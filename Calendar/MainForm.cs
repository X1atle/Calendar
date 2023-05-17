using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calendar
{
    public partial class MainForm : Form
    {
        private int month, year;
        public MainForm()
        {
            InitializeComponent();
            Text = "Calendar";
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year; 
            
            lbdate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
            
           
            //frst day of the month
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //got count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            //display
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                if (i == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year)
                {
                    ucdays.IsCurrentDay = true;
                    ucdays.BorderStyle = BorderStyle.FixedSingle;
                }
                daysContainer.Controls.Add(ucdays);
            }
        }


        private void btNext_Click(object sender, EventArgs e)
        {
            //clean container
            daysContainer.Controls.Clear();
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            lbdate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //got count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            //display
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                if (i == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year)
                {
                    ucdays.IsCurrentDay = true;
                    ucdays.BorderStyle = BorderStyle.FixedSingle;
                }
                ucdays.days(i);
                daysContainer.Controls.Add(ucdays);
            }
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            //clean container
            daysContainer.Controls.Clear();
            month--;
             if (month < 1)
             { 
                 month = 12; 
                 year--;
              }
            lbdate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //got count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            //display
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                if (i == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year)
                {
                    ucdays.IsCurrentDay = true;
                    ucdays.BorderStyle = BorderStyle.FixedSingle;
                }
                ucdays.days(i);
                daysContainer.Controls.Add(ucdays);
            }
        }
    }
}