using System;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;

namespace Calendar
{
    public partial class DayInfoForm : Form
    {
        public DateTime SelectedDate { get; set; }
        
        private XMLDatabase xmlDatabase;
        public DayInfoForm()
        {
            InitializeComponent();
        }

        private void DayInfoForm_Load(object sender, EventArgs e)
        {
            txDate.Text = MainForm.static_month + "/" + UserControlDays.static_day + "/" + MainForm.static_year;
            xmlDatabase = new XMLDatabase("database.xml");
            xmlDatabase.Load();
            SelectedDate = new DateTime(MainForm.static_year, MainForm.static_month, Int32.Parse(UserControlDays.static_day));
            // load from db
            DatabaseEntry entry = xmlDatabase.Database.Entries.Find(a => a.Date.Date == SelectedDate.Date);

            if (entry != null)
            {
                // if found put note
                txNote.Text = entry.Note;
            }

        }


        private void btSave_Click(object sender, EventArgs e)
        {
            // get values
            string dateString = MainForm.static_month + "/" + UserControlDays.static_day + "/" + MainForm.static_year;
            string note = txNote.Text;

            // creating new entry
            DatabaseEntry newEntry = new DatabaseEntry();
            if (DateTime.TryParseExact(dateString, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                newEntry.Date = date;
                newEntry.Note = note;

                // delete if exist
                var existingEntry = xmlDatabase.Database.Entries.FirstOrDefault(entry => entry.Date == date);
                if (existingEntry != null)
                {
                    xmlDatabase.Database.Entries.Remove(existingEntry);
                }
                // creating new note to db
                xmlDatabase.Database.Entries.Add(newEntry);

                // save
                xmlDatabase.Save();

                // saved
                MessageBox.Show("Note has been saved.");
            }
            else
            {
                MessageBox.Show("Date is not correct.");
            }
        }
    }
}