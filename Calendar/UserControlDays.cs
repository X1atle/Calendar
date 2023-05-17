using System;
using System.Globalization;
using System.Windows.Forms;


namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
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
            static_day = lbdays.Text;
            DayInfoForm dayInfoForm = new DayInfoForm();
            dayInfoForm.Show();
            dayInfoForm.Text = "Day info";
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            
        }
    }
}