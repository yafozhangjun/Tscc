using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Xlinktscc.Models;

namespace Xlinktscc.Models
{
    public class Article
    {
        public Article()
        {

        }

        public Article(string title , DateTime datetime)
        {
            this.Title = title;
            this.Datetime = datetime;
        }

        public string Title { get; set; }
        public DateTime Datetime { get; private set; }
        public string context { get; set; }

        //public string[] label
    }


    

}