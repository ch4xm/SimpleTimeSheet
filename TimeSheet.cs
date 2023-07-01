using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;


namespace SimpleTimeCard
{
    internal class TimeSheet
    {
        private static string _baseName = "TimeSheet.csv";
        private string _fileName;
        private DateTime[] _clockIns;
        private int _totalHours;
        private string[] _entries;
        public TimeSheet(DateTime date) // Stores array of clock ins, array of clock outs
        {
            _fileName = _baseName + date.ToString();
            Console.WriteLine(_fileName);

        }


        public string FileName()
        {
            return _fileName;
        }

        public void LoadFromFile(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("File Name is invalid!");
            }

            _entries = File.ReadAllLines(fileName);
            if (_entries == null)
            {
                throw new Exception("Error reading data from file!");
            }

            foreach (var entry in _entries)
            {
                Console.WriteLine(entry);
            }

        }

        public void SaveToFile(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException();
            }
        }            
    }
}
