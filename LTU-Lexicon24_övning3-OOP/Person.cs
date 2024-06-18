using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person()
    {
            private int age;
            private string fName;
            private string lName;
            private double height;
            private double weight;

            public int Age
            {
                get => age;
                set
                {
                if (value <= 0) throw new ArgumentException("Age must be greater than 0.");
                    age = value;
                }
            }
    }
}
