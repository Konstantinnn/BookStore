using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }        //total quantity of books
        public int ItemsPerPage { get; set; }      //quantity books on page
        public int CurrentPage { get; set; }       //Number of current page
        public int TotalPages                     // total quantity pages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}