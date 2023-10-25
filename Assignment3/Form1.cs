using NPOI.SS.Formula.Functions;
using System.Text.RegularExpressions;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Validations patient = new Validations();
        private List<string> list = new List<string>();
        private string Problem;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtNew.Enabled = false;
            txtDate.Enabled = false;
            listProblem.Enabled = false;
            listBp.Enabled = false;
            txtNotes.Enabled = false;
            btnAddnote.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            var filename = @"..\note.txt";
            string[] lines = File.ReadAllLines(filename);
       
            foreach (string line in lines)
            {
                string name = line.Split('|')[1];
                patientList.Items.Add(name + "(Note : " + line.Split('|')[0].ToString() + ")");
            }

        }
        public static void BpObatin(out String note, out List<string> BP, String Bp, String Ap)
        {
            string[] items = Bp.Split(Ap);
            String Gp = "";
            foreach (string bp in items)
            {
                if (Gp == null)
                {
                    Gp = bp;
                }
                else
                {
                    Gp = Gp + ";" + bp;
                }
            }

            note = Gp;
            List<string> BPP = new List<string>();
            Boolean check = false;
            Regex rx = new Regex(@"[B][P][:]\s[1-9][0-9]{1,2}[/][0-9][0-9]{1,2}");

            foreach (string bp in items)
            {
                if (rx.IsMatch(bp))
                {
                    BPP.Add(bp);
                    check = true;
                }
            }

            if (check == false)
            {
                throw new Exception("Correct format as BP: 120/80");
            }
            else
            {
                BP = BPP;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtNew.Enabled = true;
            txtDate.Enabled = true;
            listProblem.Enabled = true;
            listBp.Enabled = true;
            txtNotes.Enabled = true;
            btnAddnote.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            Validations obj = new Validations();
            txtId.Text = obj.GetNewId().ToString();
        }

        private void btnAddnote_Click(object sender, EventArgs e)
        { 

            foreach (String prob in listProblem.Items)
            {
                if (Problem == null)
                {
                    Problem = prob;
                }
                else
                {
                    Problem = Problem + ";" + prob;
                }

            }

            try
            {
                BpObatin(out String note, out List<string> BP, txtNotes.Text, "\n");
                Prop user = new Prop(Convert.ToInt32(txtId.Text), txtName.Text, txtDate.Value, Problem, note);
                Validations obj = new Validations();
                obj.AddNewPatient(user);
                Output.Text = "New Note of " + user.Patientname + " is added successfully";
                txtId.Text = "";
                txtName.Text = "";
                txtNew.Text = "";
                txtDate.Value = DateTime.Now;
                txtNotes.Text = "";
                listProblem.Text = "";
                listBp.Text = "";
                txtNotes.Text = "";


                foreach (string bp in BP)
                {
                    listBp.Items.Add(bp);
                }

                String path = @"..\note.txt";
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();
                patientList.Items.Clear();
                foreach (string line in lines)
                {
                    string[] items = line.Split("|");
                    patientList.Items.Add(items[1] + " (Note" + items[0] + ")");
                }
                listProblem.Items.Clear();
                listBp.Items.Clear();
                txtName.Text = "";
                txtNotes.Text = "";
                txtNew.Text = "";
                txtId.Text = "";


            }
            catch (Exception ex)
            {
                Output.Text += ex.Message + "\n";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNew.Text) && !String.IsNullOrWhiteSpace(txtNew.Text))
            {
                listProblem.Items.Add(txtNew.Text);
            }
            else
            {
                Output.Text = "Please enter atleast one problem";
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txtId.Text);
                String name = txtName.Text;
                BpObatin(out String note, out List<string> BP, txtNotes.Text, "\n");
                Prop user = new Prop(Convert.ToInt32(txtId.Text), txtName.Text, txtDate.Value, Problem, note);
                foreach (String prob in listProblem.Items)
                {
                    if (Problem == null)
                    {
                        Problem = prob;
                    }
                    else
                    {
                        Problem = Problem + "|" + prob;
                    }

                }

                Validations obj = new Validations();    
                obj.AlreadyUser(user, ID);
                listProblem.Items.Clear();
                foreach (string bp in BP)
                {
                    listBp.Items.Add(bp.Substring(3));
                }

                String path = @"..\note.txt";
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();
                patientList.Items.Clear();
                foreach (string line in lines)
                {
                    string[] items = line.Split("|");
                    patientList.Items.Add(items[1] + " (Note" + items[0] + ")");
                }
                Output.Text = "";
                Output.Text = "Patient " + user.Patientname + " updated successfully";
                listProblem.Items.Clear();
                listBp.Items.Clear();
                txtName.Text = "";
                txtNotes.Text = "";
                txtNew.Text = "";
                txtId.Text = "";

            }
            catch (Exception ex)
            {
                Output.Text = ex.Message;
            }
            
        }

        private void patientList_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtId.Enabled = true;
            txtName.Enabled = true;
            txtNew.Enabled = true;
            txtDate.Enabled = true;
            listProblem.Enabled = true;
            listBp.Enabled = true;
            txtNotes.Enabled = true;
            btnAddnote.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            listProblem.Items.Clear();
            listBp.Items.Clear();
            


            String path = @"..\note.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split("|");
                if (patientList.SelectedIndex == int.Parse(items[0]) - 1)
                {
                    txtId.Text = items[0];
                    txtName.Text = items[1];
                    txtDate.Value = DateTime.Parse(items[2]);
                    BpObatin(out String note, out List<string> BP, items[4], ";");
                    foreach (string bp in BP)
                    {
                        listBp.Items.Add(bp.Substring(3));
                    }
                    string[] prob = items[3].Split(";");
                    foreach (string pb in prob)
                    {
                        listProblem.Items.Add(pb);
                    }

                    string[] Note = note.Split(";");
                    foreach (string pb in Note)
                    {
                        txtNotes.Text = txtNotes.Text + pb + "\n";
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            String path = @"..\note.txt";
            string[] arrLine = File.ReadAllLines(path);
            Boolean check = true;
            if (arrLine.Length == 1)
            {
                check = false;
            }
            arrLine = arrLine.Where((source, index) => index != id-1).ToArray();


            if (arrLine.Length >= 1 && check == true)
            {
                int k = 0;
                for (int j = 0; j < arrLine.Length; j++)
                {
                    string idd = (k + 1).ToString();
                    k++;
                    arrLine[j] = idd + arrLine[j].Remove(0, 1);
                }
                var FileName = File.Create(path);
                FileName.Close();
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    foreach (String line in arrLine)
                    {
                        sw.WriteLine(line);
                    }
                }
                txtDate.Value = DateTime.Now;
                txtId.Text = "";
                txtName.Text = "";
                txtNew.Text = "";
                txtNotes.Text = "";
                listProblem.Items.Clear();
                listBp.Items.Clear();
                patientList.Items.Clear();
                List<string> Para = new List<string>();
                Para = File.ReadAllLines(path).ToList();
                patientList.Items.Clear();
                foreach (string line in Para)
                {
                    string[] items = line.Split("|");
                    patientList.Items.Add(items[1] + " (Note" + items[0] + ")");
                }
            }
            else
            {
                var myFile = File.Create(path);
                myFile.Close();
                txtDate.Value = DateTime.Now;
                txtId.Text = "";
                txtName.Text = "";
                txtNotes.Text = "";
                txtNew.Text = "";
                listProblem.Items.Clear();
                listBp.Items.Clear();
                patientList.Items.Clear();
                List<string> Para = new List<string>();
                Para = File.ReadAllLines(path).ToList();
                patientList.Items.Clear();
                foreach (string line in Para)
                {
                    string[] items = line.Split("|");
                    patientList.Items.Add(items[1] + " (Note" + items[0] + ")");
                }
            }

            

        }
    }
}