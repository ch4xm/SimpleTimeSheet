using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTimeCard
{
    public partial class Form1 : Form
    {
        public enum Actions
        {
            ClockIn = 1,
            ClockOut = 0
        }

        private readonly string[] _columns = {"Time", "Action", "Total", "Note"};
        private static TimeSheet _sheet = new TimeSheet(DateTime.Today);
        public Form1()
        {
            InitializeComponent();

            foreach (var item in _columns)
            {
                
                var col = new ColumnHeader();
                {
                    col.Name = item.Replace(" ", "");
                    col.Text = item;
                    col.Width = (int)((double)timeSheetItems.Width / (double)_columns.Length);
                }

                timeSheetItems.Columns.Add(col);

            }

            

        }

        private void ResetForm()
        {
            Console.WriteLine("Resetting Form... Add code here later");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to log your hours to a file and quit for the day?", "Confirm Exit", MessageBoxButtons.OKCancel);
            if (confirmExit == DialogResult.OK)
            {
                _sheet.SaveToFile(_sheet.FileName());
                ResetForm(); 
            }
            else
            {
                ;
            }
        }

        private void clearForm_Click(object sender, EventArgs e)
        {
            DialogResult confirmReset = MessageBox.Show("Are you sure you want to reset the form? This will not log your hours!", "Confirm Reset", MessageBoxButtons.YesNo);
            if (confirmReset == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddEntry(DateTime time, Actions action, string note)
        {

        }

        private void loadForm_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFile = new OpenFileDialog();

            if (loadFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _sheet.LoadFromFile(loadFile.FileName);
                }

                catch
                {
                    MessageBox.Show("Error reading timesheet file! Please try again", "Error");
                    return;
                }

                MessageBox.Show("Successfully loaded timesheet", "Success!");
            }

        }

        private void addEntry_Click(object sender, EventArgs e)
        {
            AddEntry form = new AddEntry();
            form.Show();
        }
    }
}
