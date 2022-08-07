using System;
using System.Collections.Generic;
using System.Text;


//Tüm entity olayları bu classtan türeyecek.

namespace PostegreSQL.Data.Entities
{
    //abstract class kullanmamızın nedeni kalıtımla kullanılmak istenmesi.
    public abstract class BaseEntity
    {
        //ortak olarak istenen bilgiler.
        public int ID { get; set; }

        public bool isActive { get; set; } = true;

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public DateTime? UpdatedTime { get; set; } //nullable olduğu için ?.

    }
}
