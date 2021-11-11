using System;
using System.Collections.Generic;

namespace WebApi_Task.Models
{
    [Serializable]
    public class WebsiteModel
    {
        public Header Header { get; set; }
        public IEnumerable<Carousel> Carousels { get; set; }
        public string IntroHeading { get; set; }
        public string IntroText { get; set; }
    }
}
