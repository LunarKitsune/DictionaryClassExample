using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryExample
{
    public partial class Form1 : Form
    {
        NameCollector RecordCollector = new NameCollector();
        public Form1()
        {
            InitializeComponent();
        }

        #region formButtons

        private void btn_AddName(object sender, EventArgs e)
        {
            string studentName = txtLastName.Text;
            double studentGrade = double.Parse(txtGrade.Text);
            StudentRecord recordedStudent = new StudentRecord()
            { Name = studentName, grade = studentGrade };

            try
            {
                RecordCollector.AddRecords(recordedStudent);
            }
            catch(Exception indexAddError)
            {
                MessageBox.Show(indexAddError.Message, "Error");
            }
        }

        private void btn_DeleteName(object sender, EventArgs e)
        {
            string studentName = txtLastName.Text;
            MessageBoxButtons resultButtons = MessageBoxButtons.YesNo;
            DialogResult RemoveStudentResult = MessageBox.Show($"Would you like to delete {studentName} from the records?","Delete Record", resultButtons);

            if (RemoveStudentResult == DialogResult.Yes)
            {
                try
                {
                    RecordCollector.RemoveRecords(studentName);
                }
                catch (Exception indexDeleteError)
                {
                    MessageBox.Show(indexDeleteError.Message, "Error");
                }
            }
        }

        private void btn_DisplayNames(object sender, EventArgs e)
        {
            rtbNameDisplay.Text = RecordCollector.Displayrecords();
        }

        private void Btn_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            string name = txtLastName.Text;
            rtbNameDisplay.Text = RecordCollector.FindGrade(name);
        }

        #endregion formButtons
    }
}
