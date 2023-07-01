using System;
using System.Windows.Forms;


namespace SimpleTimeCard
{
    public class Entry
    {
        private DateTime _time;
        private bool _action;
        private string _note;

        public Entry(DateTime time, bool action, string note)
        {
            _time = time;
            _action = action;
            _note = note;
        }

        public void AddToPanel(TableLayoutPanel panel)
        {
            ListViewGroup item = new ListViewGroup();
            panel.Controls.Add(ColumnStyle);
            panel.Update();
        }


    }
}