using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public bool IsCurrentDay { get; set; }
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void lbdays_Click(object sender, EventArgs e)
        {
            DayInfoForm dayInfoForm = new DayInfoForm();
            dayInfoForm.Show();
            dayInfoForm.Text = "Day info";
        }
    }
}