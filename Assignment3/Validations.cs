using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Validations
    {
        private string fileName = @"..\note.txt";
        public Validations()
        {
            if (!File.Exists(fileName))
            {
                using (File.Create(fileName));
            }
        }
        public int GetNewId()
        {
            string[] lines = File.ReadAllLines(fileName);
            int maxId = 0;
            foreach (string line in lines)
            {
                int id = Convert.ToInt32(line.Split('|')[0]);
                if (id > maxId)
                {
                    maxId = id;
                }
            }
            return maxId + 1;
        }

        

        public void AddNewPatient(Prop newUser)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(newUser.ToString());
            }
        }

        public void AlreadyUser(Prop newUser, int id)
        {

            {
                String UserInfo = newUser.ToString();
                string[] arrLine = File.ReadAllLines(fileName);
                arrLine[id - 1] = UserInfo;
                File.WriteAllLines(fileName, arrLine);
            }

        }
    }
}

