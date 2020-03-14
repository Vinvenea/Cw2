using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
    public class Studies
    {
        public String name { get;set;}
        public String mode { get; set; }
        public Studies(String name, String mode)
        {
            this.name = name;
            this.mode = mode;
        }
        public Studies()
        {

        }
    }
}
