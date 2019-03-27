using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWBook
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
