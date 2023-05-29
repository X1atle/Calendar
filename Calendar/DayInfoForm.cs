using System;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;

namespace Calendar
{
    public partial class DayInfoForm : Form
    {
        public DateTime SelectedDate { get; set; }

        private JSONDatabase _jsonDatabase;
        private DatabaseEntry _existingEntry;

        public DayInfoForm()
        {
            InitializeComponent();
        }

        private void DayInfoForm_Load(object sender, EventArgs e)
        {
            txDate.Text = $"{MainForm.static_month}/{UserControlDays.static_day}/{MainForm.static_year}";

            _jsonDatabase = new JSONDatabase("database.json");
            _jsonDatabase.Load();

            SelectedDate = new DateTime(MainForm.static_year, MainForm.static_month, Int32.Parse(UserControlDays.static_day));

            // load from db
            _existingEntry = _jsonDatabase.Database.Entries.FirstOrDefault(entry => entry.Date.Date == SelectedDate.Date);

            if (_existingEntry != null)
            {
                // if found put note
                txNote.Text = _existingEntry.Note;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // get values
            string dateString = $"{MainForm.static_month}/{UserControlDays.static_day}/{MainForm.static_year}";
            string note = txNote.Text;

            // creating new entry
            DatabaseEntry newEntry = new DatabaseEntry();
            if (DateTime.TryParseExact(dateString, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                newEntry.Date = date;
                newEntry.Note = note;

                // delete if exist
                if (_existingEntry != null)
                {
                    _jsonDatabase.Database.Entries.Remove(_existingEntry);
                }

                // creating new note to db
                _jsonDatabase.Database.Entries.Add(newEntry);

                // save
                _jsonDatabase.Save();

                // saved
                MessageBox.Show("Note has been saved.");
            }
            else
            {
                MessageBox.Show("Date is not correct.");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Delete the existing entry
                if (_existingEntry != null)
                {
                    _jsonDatabase.Database.Entries.Remove(_existingEntry);
                    _jsonDatabase.Save();
                    MessageBox.Show("Note has been deleted.");
                    Close();
                }
                else
                {
                    MessageBox.Show("No note found to delete.");
                }
            }
        }

    }
}
