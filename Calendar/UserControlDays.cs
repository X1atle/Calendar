using System;
using System.Windows.Forms;
using System.Linq;


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
            // load db
            var xmlDatabase = new XMLDatabase("database.xml");
            xmlDatabase.Load();

            // get date
            int day = int.Parse(lbdays.Text);
            DateTime currentDate = new DateTime(MainForm.static_year, MainForm.static_month, day);

            // check some notes
            bool hasEntry = xmlDatabase.Database.Entries.Any(entry => entry.Date.Date == currentDate.Date);

            if (hasEntry)
            {
                // adding "*"
                label1.Text = "*";
            }
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            
        }
    }
}