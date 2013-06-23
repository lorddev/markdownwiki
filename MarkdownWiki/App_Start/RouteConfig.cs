// -----------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Lord Design">
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
using System.Web.Mvc;
using System.Web.Routing;

namespace LordDesign.MarkdownWiki
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Wiki",
                url: "wiki/{id}",
                defaults: new { controller = "Wiki", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}