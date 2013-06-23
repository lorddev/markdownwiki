using MarkdownSharp;
// -----------------------------------------------------------------------
// <copyright file="WikiController.cs" company="Lord Design">
// This file is part of MarkdownWiki.
// 
// MarkdownWiki is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// MarkdownWiki is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MarkdownWiki.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
using System.IO;
using System.Net;
using System.Web.Mvc;
using Ffile = System.IO.File;

namespace LordDesign.MarkdownWiki.Controllers
{
    public class WikiController : Controller
    {
        //
        // GET: /Wiki/

        public ActionResult Index(string id = "")
        {
            if (id == string.Empty)
            {
                return View(new WikiDto { Title = "Hello", Content = "World" });
            }

            if (id.Contains("../") || id.Contains("..\\"))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            string fileName = id + ".md";

            string content = GetMarkdownContent(Server.MapPath("~/markdown/" + fileName));
            var md = new Markdown();

            string sidebar = GetMarkdownContent(Server.MapPath("~/markdown/_sidebar.md"));

            return View(new WikiDto { Title = id, Content = md.Transform(content), Sidebar = md.Transform(sidebar) } );
        }

        private static string GetMarkdownContent(string path)
        {
            if (Ffile.Exists(path))
            {
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }

            return string.Empty;
        }
    }
}