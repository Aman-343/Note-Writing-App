using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Prop
    {
        public int ID { get;}
        public string Patientname { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }

        public string Problems { get; set; }

        public Prop(int id, string patientname, DateTime dateofbirth, string problems, string notes)
        {
            ID = id;
            if (!String.IsNullOrEmpty(patientname))
            {
                Patientname = patientname;
            }
            else
            {
                throw new Exception("Patientname is required and cannot be empty or null.");
            }

            if (!String.IsNullOrEmpty(notes))
            {
                Notes = notes;
            }
            else
            {
                throw new Exception("Please Enter Clinical Note!");
            }

            if (dateofbirth <= DateTime.Now)
            {
                DateCreated = dateofbirth;
            }
            else
            {
                throw new Exception("Date Of Birth cannot be in the future.");
            }

            Problems = problems;

        }
        public string ToString()
        {
            return ID.ToString() + "|" + Patientname + "|" + DateCreated.ToString() + "|" + Problems + "|" + Notes ;
        }
    }
}
