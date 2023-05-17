using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class DayInfoForm : Form
    {
        public DayInfoForm()
        {
            InitializeComponent();
        }

        private void DayInfoForm_Load(object sender, EventArgs e)
        {
            txDate.Text = MainForm.static_month + "/" + UserControlDays.static_day + "/" + MainForm.static_year;
        }

        
    }
}