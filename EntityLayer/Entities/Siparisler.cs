using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Siparisler
    {
      public int Siparis_Id { get; set; }
      [ForeignKey("Masalar")]
      public int Masa_Id { get; set; }
      public virtual Masalar? Masalar { get; set; }
      public DateTime Acilis { get; set; }
      public DateTime Kapanis { get; set; }
     

    }
}
