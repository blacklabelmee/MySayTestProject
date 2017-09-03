using MySayTestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MySayTestProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static List<Topic> Topics = new List<Topic>();
        public static List<feedBack> feedBacks = new List<feedBack>();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Topics.Add(new Topic()
            {
                id = 1010,
                text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent vitae dolor sit amet metus lacinia imperdiet. Sed sit amet erat eget felis varius hendrerit. Suspendisse viverra metus a orci accumsan dictum. Cras vulputate dolor non enim vestibulum, ac aliquam turpis efficitur."

            });

            Topics.Add(new Topic()
            {
                id = 1011,
                text = "Donec eget urna dapibus, efficitur mauris eget, accumsan magna. Fusce tempor libero et nisi commodo, vel suscipit metus consectetur. Nunc quis lectus in urna porta semper. Proin a enim nec felis cursus auctor nec at magna. Duis suscipit, leo imperdiet iaculis facilisis, ipsum tortor consectetur metus, et sagittis ligula tortor non velit. Morbi nec auctor ligula, vel cursus metus. Integer vitae sem turpis. Vivamus blandit, dui eu varius ullamcorper, risus metus interdum ipsum, at aliquet neque diam et libero. Sed ante nulla, suscipit vitae orci ut, vulputate pulvinar ex. In fringilla ligula viverra arcu porttitor, ac egestas elit blandit. Donec eu orci nec ipsum vehicula malesuada. Proin posuere dignissim libero vitae auctor. In porta nibh arcu, et ornare eros porttitor ac. Vestibulum fermentum neque nibh, ut interdum metus posuere ac."
            });

            Topics.Add(new Topic()
            {
                id = 1012,
                text = "Nullam vel venenatis diam, vitae molestie orci. Nulla aliquam sodales lacus consequat luctus. Phasellus non sem vel turpis euismod suscipit et nec eros. Duis ac tortor non mi malesuada suscipit facilisis eu urna. Cras lacinia faucibus magna id imperdiet. Vestibulum sed laoreet metus. Ut facilisis nulla sed molestie iaculis. Aenean vehicula, mi sit amet placerat sagittis, ex justo dapibus enim, eget convallis libero purus vitae magna. Pellentesque vitae dapibus lorem. Ut gravida nisi sed nisl vehicula luctus."
            });
            Topics.Add(new Topic()
            {
                id = 1013,
                text = "Phasellus non sem vel turpis euismod suscipit et nec eros. Duis ac tortor non mi malesuada suscipit facilisis eu urna. Cras lacinia faucibus magna id imperdiet. Vestibulum sed laoreet metus. Ut facilisis nulla sed molestie iaculis. Aenean vehicula, mi sit amet placerat sagittis, ex justo dapibus enim, eget convallis libero purus vitae magna. Pellentesque vitae dapibus lorem. Ut gravida nisi sed nisl vehicula luctus."
            });



            feedBacks.Add(new feedBack() { id = 1, addingDate = DateTime.Now.ToShortDateString(), title = "Duis ac tortor non", description = " Duis ac tortor non mi malesuada suscipit facilisis eu urna. ", userEmail = "asdw@gmail.com", topicId = 1010 });
            feedBacks.Add(new feedBack() { id = 2, addingDate = DateTime.Now.ToShortDateString(), title = "Nullam sem mauris, congue", description = "Nullam sem mauris, congue eu elit sit amet, aliquet auctor velit. Sed vitae consectetur ante. Ut eget tincidunt justo. Vestibulum non dictum elit. ", userEmail = "asdw@gmail.com", topicId = 1010 });
            feedBacks.Add(new feedBack() { id = 3, addingDate = DateTime.Now.ToShortDateString(), title = "Pellentesque vitae ", description = "Pellentesque vitae dapibus lorem. Ut gravida nisi sed nisl vehicula luctus.", userEmail = "asdw@gmail.com", topicId = 1010 });
                                                                           
            feedBacks.Add(new feedBack() { id = 4, addingDate = DateTime.Now.ToShortDateString(), title = "ut interdum", description = "ut interdum metus posuere ac.", userEmail = "asdw@gmail.com", topicId = 1011 });
            feedBacks.Add(new feedBack() { id = 5, addingDate = DateTime.Now.ToShortDateString(), title = "Donec eget urna dapibus", description = "Donec eget urna dapibus, efficitur mauris eget, accumsan magna.", userEmail = "asdw@gmail.com", topicId = 1012 });
            feedBacks.Add(new feedBack() { id = 11, addingDate = DateTime.Now.ToShortDateString(), title = "Pellentesque vitae ", description = "Pellentesque vitae dapibus lorem. Ut gravida nisi sed nisl vehicula luctus.", userEmail = "asdw@gmail.com", topicId = 1012 });

            feedBacks.Add(new feedBack() { id = 6, addingDate = DateTime.Now.ToShortDateString(), title = " mauris, congue eu elit sit amet", description = "Nullam sem mauris, congue eu elit sit amet, aliquet auctor velit. Sed vitae consectetur ante. Ut eget tincidunt justo. Vestibulum non dictum elit. ", userEmail = "asdw@gmail.com", topicId = 1013 });
            feedBacks.Add(new feedBack() { id = 7, addingDate = DateTime.Now.ToShortDateString(), title = " mauris, congue eu elit sit amet", description = "Nullam sem mauris, congue eu elit sit amet, aliquet auctor velit. Sed vitae consectetur ante. Ut eget tincidunt justo. Vestibulum non dictum elit. ", userEmail = "asdw@gmail.com", topicId = 1013 });
            feedBacks.Add(new feedBack() { id = 8, addingDate = DateTime.Now.ToShortDateString(), title = " mauris, congue eu elit sit amet", description = "Nullam sem mauris, congue eu elit sit amet, aliquet auctor velit. Sed vitae consectetur ante. Ut eget tincidunt justo. Vestibulum non dictum elit. ", userEmail = "asdw@gmail.com", topicId = 1013 });
            feedBacks.Add(new feedBack() { id = 9, addingDate = DateTime.Now.ToShortDateString(), title = " mauris, congue eu elit sit amet", description = "Nullam sem mauris, congue eu elit sit amet, aliquet auctor velit. Sed vitae consectetur ante. Ut eget tincidunt justo. Vestibulum non dictum elit. ", userEmail = "asdw@gmail.com", topicId = 1013 });
            feedBacks.Add(new feedBack() { id = 10, addingDate = DateTime.Now.ToShortDateString(), title = "Pellentesque vitae ", description = "Pellentesque vitae dapibus lorem. Ut gravida nisi sed nisl vehicula luctus.", userEmail = "asdw@gmail.com", topicId = 1013 });

        }
    }
}
