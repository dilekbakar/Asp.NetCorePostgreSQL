using System;
using System.Collections.Generic;
using System.Text;

namespace PostegreSQL.Data.Entities
{
    public class Article : BaseEntity
    {

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
