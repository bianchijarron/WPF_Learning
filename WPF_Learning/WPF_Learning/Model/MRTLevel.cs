using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Learning.Model
{
    public class MRTLevel
    {
        public MRTLevel(string _name, int _index)
        {
            name = _name;
            index = _index;
        }

        public string name { get; set; }
        public double height { get; set; }
        public int index { get; set; }
    }
}
