using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
         displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            //frst day of the month
            DateTime startOfTheMonth = new DateTime(now.Year, now.Month, 1);
            //got count of days of the month
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"))+ 1;
            //display
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }
        }

        
    }
}