using System.Collections.Generic;
using WebApi_Task.Models;

namespace WebApi_Task.Mocks
{
    public static class Mocks
    {
        public static WebsiteModel GetWebApiMockData()
        {
            return new WebsiteModel()
            {
                IntroText = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H.Rackham.",
                IntroHeading = "Welcome",
                Carousels = new List<Carousel>()
                {
                    new Carousel () { Text = "Carousel A", ImageURL ="https://mdbootstrap.com/img/new/slides/041.jpg"},
                    new Carousel () { Text = "Carousel B", ImageURL ="https://mdbootstrap.com/img/new/slides/042.jpg"},
                    new Carousel () { Text = "Carousel C", ImageURL ="https://mdbootstrap.com/img/new/slides/043.jpg"},
                    new Carousel () { Text = "Carousel D", ImageURL ="https://mdbootstrap.com/img/new/slides/044.jpg"},
                    new Carousel () { Text = "Carousel E", ImageURL ="https://mdbootstrap.com/img/new/slides/045.jpg"},
                    new Carousel () { Text = "Carousel F", ImageURL ="https://mdbootstrap.com/img/new/slides/046.jpg"},
                },
                Header = new Header()
                {
                    NavigationLinks = new List<NavigationLink>(3)
                    {
                        new NavigationLink () { LinkText = "About us", LinkURL ="/aboutus"},
                        new NavigationLink () { LinkText = "Careers", LinkURL ="/careers"},
                        new NavigationLink () { LinkText = "Contact", LinkURL ="/contact"},
                        new NavigationLink () { LinkText = "Services", LinkURL ="/services"}
                    }
                }
            };
        }
    }
}
