using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fake_Dashboard
{
    public partial class Dean : Form
    {
        string UPI;
        public Dean(string LoginUPI)
        {
            UPI = LoginUPI;
            InitializeComponent();
            DatabaseQuery.SetCourseNumComboBox(CourseNumComboBox);
            //DatabaseQuery.showDataTable(this.DataTable1, "CS101");
        }

        private void Dean_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CourseNumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseNum = CourseNumComboBox.Items[CourseNumComboBox.SelectedIndex].ToString();
            //MessageBox.Show(CourseNumComboBox.Items[CourseNumComboBox.SelectedIndex].ToString());
            DatabaseQuery.ShowStudentDataTable(this.StudentDataTable, courseNum);
            DatabaseQuery.ShowLecturerDataTable(this.LecturerDataTable, courseNum);
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(UPI);
            profile.Show();
        }
    }
}
