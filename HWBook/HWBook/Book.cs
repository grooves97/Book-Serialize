using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWBook
{
    [Serializable]
    public class Book
    {
        [MyAttribute(Name = "Книгу \"")]
        public string Name { get; set; }

        [MyAttribute(Name = "\" написал ")]
        public string Author { get; set; }

        [MyAttribute(Name = " в ")]
        public int Year { get; set; }

        [MyAttribute(Name = " году. Продам за ")]
        public int Price { get; set; }
    }
}
