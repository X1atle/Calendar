using System;
using System.Windows.Forms;
using System.Linq;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public bool IsCurrentDay { get; set; }

        private JSONDatabase _jsonDatabase;
        private bool hasEntry;

        public UserControlDays()
        {
            InitializeComponent();
            _jsonDatabase = new JSONDatabase("database.json");
            _jsonDatabase.Load();
        }

        public void days(int numday)
        {
            lbdays.Text = numday.ToString();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            int day = int.Parse(lbdays.Text);
            DateTime currentDate = new DateTime(MainForm.static_year, MainForm.static_month, day);

            hasEntry = _jsonDatabase.Database.Entries.Any(entry => entry.Date.Date == currentDate.Date);

            if (hasEntry)
            {
                label1.Text = "*";
            }
        }

        private void lbdays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            DayInfoForm dayInfoForm = new DayInfoForm();
            dayInfoForm.Show();
            dayInfoForm.Text = "Day info";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            
        }
    }
}