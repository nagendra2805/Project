using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Contact
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DateofBirth { get; set; }
        public List<string> PhNumbers { get; set; }
        public List<string> EmailIds { get; set; }
    }
}
