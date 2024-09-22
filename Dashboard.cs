using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BookMonitoring
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }
        public void loadform(object Form)
        {
            if (Form != null && Form is Form form)
            {
                // Remove any existing controls from panel1
                if (this.panel1.Controls.Count > 0)
                    this.panel1.Controls.RemoveAt(0);

                // Set up the new form
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;

                // Add the form to panel1
                this.panel1.Controls.Add(form);
                this.panel1.Tag = form;
                form.Show();
            }
            else
            {
                // Handle the case where Form is null or not of expected type
                MessageBox.Show("Invalid form object provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //{
        //    if (this.panel1.Controls.Count > 0)
        //        this.panel1.Controls.RemoveAt(0);
        //    Dashboard f = Form as Dashboard;
        //    f.TopLevel = false;
        //    f.Dock = DockStyle.Fill;
        //    this.panel1.Controls.Add(f);
        //    this.panel1.Tag = f;
        //    f.Show();
        //}
        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadform(new dashboardform());
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new AddNewBook());
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new ReturnBooks());
            //ReturnBooks returnbooks = new ReturnBooks();
            //returnbooks.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Attendance());
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new ViewBooks());
            //ViewBooks viewbooks = new ViewBooks();
            //viewbooks.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new IssueBooks());
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            loadform(new CompleteBookDetails());



        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure You want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new AddStudent());

        }

        private void viewStudentsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new ViewStudentsInfo());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
