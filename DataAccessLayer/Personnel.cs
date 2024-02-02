using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Personnel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Mission { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int StatuID { get; set; }
        public string PersonnelStatu { get; set; }
        public bool Statu { get; set; }
        public string StatuStr { get; set; }
    }
}
