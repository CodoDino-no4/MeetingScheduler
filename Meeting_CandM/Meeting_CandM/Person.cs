using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_CandM
{
    public class Person
    {
        private String fullName;

        public Person(String fullName)
        {
            this.fullName = fullName;
        }

        public void setFullName(String fullName)
        {
            this.fullName = fullName;
        }

        public String getFullName()
        {
            return fullName;
        }

    }
}
