using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostegreSQL.API.Request
{
    //article request model ile controllerı dolduracağız.
    public class ArticleRequestModel
    {
        //database ile aynı ismi vermek zorunlu değil.
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
