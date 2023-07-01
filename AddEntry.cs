using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTimeCard
{
    public partial class AddEntry : Form
    {
        public AddEntry()
        {
            InitializeComponent();
        }

        private void noteLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timePicker.Value =  DateTime.Now;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            DateTime time = timePicker.Value;
            string action = (clockIn.Checked) ? "Clock In" : "Clock Out";
            string note = noteTextBox.Text;




        }
    }
}
