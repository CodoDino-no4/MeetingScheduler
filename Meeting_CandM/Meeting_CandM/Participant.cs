using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_CandM
{
    public class Participant
    {
        private String fullName;
        private bool important;


        public Participant()
        {
            fullName = "";
            important = false;
        }

        public Participant(String fullName, bool important)
        {
            this.fullName = fullName;
            this.important = important;
        }

        public void setFullName(String fullName)
        {
            this.fullName = fullName;
        }

        public String getFullName()
        {
            return fullName;
        }

        public void setImportance(bool important)
        {
            this.important = important;
        }

        public bool getImportance()
        {
            return important;
        }

    }
}
