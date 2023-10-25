namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.patientList = new System.Windows.Forms.ListBox();
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.listBp = new System.Windows.Forms.ListBox();
            this.listProblem = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddnote = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.gB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(33, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = " Start new note";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientList
            // 
            this.patientList.FormattingEnabled = true;
            this.patientList.ItemHeight = 20;
            this.patientList.Location = new System.Drawing.Point(33, 88);
            this.patientList.Name = "patientList";
            this.patientList.Size = new System.Drawing.Size(150, 384);
            this.patientList.TabIndex = 1;
            this.patientList.SelectedIndexChanged += new System.EventHandler(this.patientList_SelectedIndexChanged);
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.listBp);
            this.gB1.Controls.Add(this.listProblem);
            this.gB1.Controls.Add(this.btnAdd);
            this.gB1.Controls.Add(this.label7);
            this.gB1.Controls.Add(this.label6);
            this.gB1.Controls.Add(this.txtDate);
            this.gB1.Controls.Add(this.txtNew);
            this.gB1.Controls.Add(this.txtName);
            this.gB1.Controls.Add(this.txtId);
            this.gB1.Controls.Add(this.btnDelete);
            this.gB1.Controls.Add(this.btnUpdate);
            this.gB1.Controls.Add(this.btnAddnote);
            this.gB1.Controls.Add(this.txtNotes);
            this.gB1.Controls.Add(this.label5);
            this.gB1.Controls.Add(this.label4);
            this.gB1.Controls.Add(this.label3);
            this.gB1.Controls.Add(this.label2);
            this.gB1.Controls.Add(this.label1);
            this.gB1.Location = new System.Drawing.Point(250, 45);
            this.gB1.Name = "gB1";
            this.gB1.Size = new System.Drawing.Size(829, 446);
            this.gB1.TabIndex = 2;
            this.gB1.TabStop = false;
            this.gB1.Text = "Add/Edit/Delete Encounter Note:";
            this.gB1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBp
            // 
            this.listBp.FormattingEnabled = true;
            this.listBp.ItemHeight = 20;
            this.listBp.Location = new System.Drawing.Point(663, 60);
            this.listBp.Name = "listBp";
            this.listBp.Size = new System.Drawing.Size(141, 124);
            this.listBp.TabIndex = 20;
            // 
            // listProblem
            // 
            this.listProblem.FormattingEnabled = true;
            this.listProblem.ItemHeight = 20;
            this.listProblem.Location = new System.Drawing.Point(516, 62);
            this.listProblem.Name = "listProblem";
            this.listProblem.Size = new System.Drawing.Size(132, 124);
            this.listProblem.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(361, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "BP Measurements:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Problems:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(150, 120);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(250, 27);
            this.txtDate.TabIndex = 13;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(150, 161);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(205, 27);
            this.txtNew.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 27);
            this.txtName.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 44);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(87, 27);
            this.txtId.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(240, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete note";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(132, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update note";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddnote
            // 
            this.btnAddnote.AutoSize = true;
            this.btnAddnote.Location = new System.Drawing.Point(32, 408);
            this.btnAddnote.Name = "btnAddnote";
            this.btnAddnote.Size = new System.Drawing.Size(94, 30);
            this.btnAddnote.TabIndex = 6;
            this.btnAddnote.Text = "Add note";
            this.btnAddnote.UseVisualStyleBackColor = true;
            this.btnAddnote.Click += new System.EventHandler(this.btnAddnote_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(31, 226);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(691, 169);
            this.txtNotes.TabIndex = 5;
            this.txtNotes.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Notes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "New problem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note ID:";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(33, 496);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 20);
            this.Output.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 525);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.gB1);
            this.Controls.Add(this.patientList);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Encounter Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gB1.ResumeLayout(false);
            this.gB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ListBox patientList;
        private GroupBox gB1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnUpdate;
        private Button btnAddnote;
        private RichTextBox txtNotes;
        private Label label5;
        private Button btnAdd;
        private Label label7;
        private Label label6;
        private DateTimePicker txtDate;
        private TextBox txtNew;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnDelete;
        private Label Output;
        private ListBox listProblem;
        private ListBox listBp;
    }
}