using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }


        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void lbdays_Click(object sender, EventArgs e)
        {
            
        }
    }
}