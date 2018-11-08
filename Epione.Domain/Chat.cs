using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Domain
{
    public class Chat
    {
        [Key]
        public int IdChat { get; set; }
        public string Transmitter { get; set; }
        public string Reciever { get; set; }
        public DateTime Date_Send { get; set; }
        public string Content { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }

    }
}
