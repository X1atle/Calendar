using System;
using System.Globalization;
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
            // Загружаем базу данных
            var xmlDatabase = new XMLDatabase("database.xml");
            xmlDatabase.Load();

            // Получаем дату для текущего UserControlDays
            int day = int.Parse(lbdays.Text);
            DateTime currentDate = new DateTime(MainForm.static_year, MainForm.static_month, day);

            // Проверяем наличие записи на данную дату в базе данных
            bool hasEntry = xmlDatabase.Database.Entries.Any(entry => entry.Date.Date == currentDate.Date);

            if (hasEntry)
            {
                // Добавляем символ "*" к тексту дня
                label1.Text = "*";
            }
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            
        }
    }
}