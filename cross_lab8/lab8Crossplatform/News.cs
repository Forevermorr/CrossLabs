using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8Crossplatform
{
    class News
    {
        public string link, title, information, date;

        public News(string title, string info, string link, string date)
        {
            this.link = link;
            this.title = title;
            this.information = info;
            this.date = date;
        }
    }
}
