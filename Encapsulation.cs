using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Encapsulation
    {
        private string data;
        public void setData(string s)
        {
            data = s;
        }
        public string getData()
        {
            return data;
        }

        public string Data1 { get; set; }
    }

}
