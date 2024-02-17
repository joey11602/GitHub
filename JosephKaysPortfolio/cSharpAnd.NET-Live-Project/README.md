# C# and .NET Live Project Summary
## Introduction:
#### Presenting my C# and .NET Live Project undertaken at The Tech Academy, this two-week sprint followed an Azure DevOps style project structure. The primary goal was to complete a minimum of four boards, and I successfully completed four within the specified timeframe.
## Project Overview:
#### This project, developed using ASP .NET MVC and Entity Framework, serves as an interactive website for managing content and productions for a theater/acting company. It functions as a user-friendly Content Management Service (CMS) for non-tech-savvy users and facilitates easy management of website content. Additionally, it provides a robust system for subscriber logins and maintains a comprehensive wiki of past performances and performers.
## Key Stories:
### Story One: Enhancing Sign In Page with JavaScript
- Tasked with using JavaScript on the Sign In page to count developers.
- Added custom IDs to HTML elements and utilized JavaScript to count and display developer numbers on the badge.
- [Sign In Page](images/SignIn.jpg)
- [Code Snippets](images/SignInCountCode.jpg)
### Story Two: Improving Blog Author Create and Edit Pages
- Created the [Blog Authors Model](TheatreCMS3/Areas/Blog/Models/BlogAuthor.cs) and connected it to my database using the Entity Framework.
- Modified [Create](TheatreCMS3/Areas/Blog/Views/BlogAuthors/Create.cshtml) and [Edit](TheatreCMS3/Areas/Blog/Views/BlogAuthors/Edit.cshtml) pages for Blog Author, incorporating color variables from Site.css.
- Centered and aligned Name and Bio fields, applied CSS from [Blog.css](TheatreCMS3/Content/Areas/Blog.css) for styling.
- Included date and time pickers, and created buttons for Create and Back to List links.
- [Create Page](images/CreatePage.jpg)
### Story Three: Designing Details and Delete Page
- Styled [Details](TheatreCMS3/Areas/Blog/Views/BlogAuthors/Details.cshtml) and [Delete](TheatreCMS3/Areas/Blog/Views/BlogAuthors/Delete.cshtml) pages resembling the storyboard card example.
- Added tabs for Author Details and Latest Blog Posts, with placeholders for unfinished sections.
- Integrated social media links using Awesome icons and implemented an [Under Contruction page](TheatreCMS3/Areas/Blog/Views/BlogAuthors/UnderConstruction.cshtml).
- Included navigation buttons at the bottom - Back to List, Edit, and Delete.
- [Details and Delete Page](images/DetailsDeletePage.jpg)
- [Under Construction Page](images/UnderConstructionPage.jpg)
- [Delete Confirmation Page](images/DeleteConfirmPage.jpg)
### Story Four: Implementing Partial View for Blog Author Index Page
- Replaced the table on the index page with a partial view [_BlogAuthor.cshtml](TheatreCMS3/Areas/Blog/Views/Shared/_BlogAuthor.cshtml).                           
- On the [Index Page](TheatreCMS3/Areas/Blog/Views/BlogAuthors/Index.cshtml) I rendered a partial views for each BlogAuthor using a for loop, mimicking Details/Delete page layout.
-	Moved Edit and Delete buttons inside the BlogAuthor container.
-	[Index view using the partial view](images/IndexPartialViewPage.jpg)
### Story Five: Modal Confirmation for Author Deletion
- Created a [Modal](TheatreCMS3/Scripts/Areas/Blog.js) using JavaScript for confirmation on delete button click.
-	Developed JavaScript for database access, removal, and save confirmation.
-	Pending completion for removing author details from the page without reloading. I was still debugging my code when the project ended.
## My Take Away
### This project marked significant growth in my development skills, evident in my increased confidence and knowledge. Working with C# and the .NET framework was a more enjoyable experience compared to previous projects with Python. The project reinforced my preference for C# as my programming language of choice, largely due to the ease and efficiency of the .NET framework.
## Thank you for exploring my C# and .NET Live Project.
