using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi_Task.Models.Interfaces
{
    public interface IWebRepository
    {
        WebsiteModel GetWebsiteData();
    }
}
