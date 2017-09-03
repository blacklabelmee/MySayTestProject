# MySayTestProject
Documentations

I have created the demo with asp.net MVC template, and to keep things simple and as you mentioned there was no need of data persisting in database there is no layers’ separation in the project, because usually in my real projects I will choose multi-layer structure for separation concerns. (UI - business logic-data access and etc.) and other complicated stuff that makes the projects more manageable.

There are two simple classes for topics and feedbacks in the MySayTestProject.Models namespace.
In the global.aspx.cs, Application_Start event I have created simple topics and feedbacks for simulating the database.

The main page of this web application contains a list of sample topics with their feedbacks count.
By choosing one of the topics you will be redirected to a page with the selected topic feedbacks and a form to add new feedbacks.
I have added a simple required validation for the form due to simplicity.
The form will submit an ajax request to the server and after simulated adding of the feedback in its related controller the result will be sent back to the client side. On the ajax success event the added feedback will be add to the list of feedbacks with jQuery append method. The custom scripts are located in this path:
"~/Scripts/usersFeedBackScripts.js"
And also at the bottom of the page you can see the topics summery.

Again due to simplicity the stylings are uncomplicated and plain and they will be found on this path:
"~/Content/MySayyStyles.css"



 










