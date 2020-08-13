using İcarePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace İcarePlatform.ViewModels
{
    public class HomeVM
    {
        public AboutU AboutUs { get; set; }
        public ContactMe ContactMe { get; set; }
        public AspNetUser User { get; set; }
        public Order Orders { get; set; }
    }
}