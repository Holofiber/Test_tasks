using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorMenu
{
    public class Operation : MenuItem
    {
        public string Text;

        public Operation(string name, string text) : base(name)
        {
            this.Text = text;
        }
    }
}
