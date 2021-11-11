using System;
using System.Collections.Generic;

namespace WebApi_Task.Models
{
    [Serializable]
    public class Header
    {
        public IEnumerable<NavigationLink> NavigationLinks { get; set; }
    }
}
