# MarkdownWiki 1.0

Have you ever found yourself working on a wiki that was intended for code documentation for development teams, while using another wiki or documentation format which made copy-and-paste code snippets difficult? (For instance, I've seen documentation in which quotes which were meant to be code were converted to smart quotes.)

With Markdown, all you have to do to identify something as code is to indent it. So citing code is just like writing code!

I love GitHub's Markdwon-based wikis, and use them regularly. But sometimes you might find yourself working on a project that's not hosted on GitHub, wishing you had the same Markdown-based wiki editing functionality. With this project, you can have it.

MarkdownWiki is a free, lightweight alternative to Github Wikis (which are awesome). It is offered under GPLv3, and you are invited to participate in its improvement and customization!

This project uses

* [MarkdownSharp](https://code.google.com/p/markdownsharp/), the open-source Markdown library created by [Jeff Atwood](https://twitter.com/codinghorror) for [Stack Overflow](http://stackoverflow.com).
* [ASP.NET MVC 4](http://aspnetwebstack.codeplex.com/)
* [Twitter Bootstrap](http://twitter.github.io/bootstrap/)

### Roadmap

* Customize markdown directory via web.config
* Fix Markdown bugs in sidebar which prevent lists, anchors, and Twitter Bootstrap nav-list from playing nicely together.
* Something else that I can't remember right now...