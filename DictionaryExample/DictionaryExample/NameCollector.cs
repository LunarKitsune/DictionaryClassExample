using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class NameCollector
    {
        Dictionary<string, StudentRecord> StudentCollection = new Dictionary<string, StudentRecord>();

        public Dictionary<string, StudentRecord>.ValueCollection StudentValueCollection
        { get { return StudentCollection.Values; } }


        public NameCollector()
        { }

        public string FindGrade(string name)
        {
            StudentRecord foundRecord = new StudentRecord();
            string output = string.Empty;

            if(StudentCollection.ContainsKey(name))
            {
                foundRecord = StudentCollection[name];
                output = "Record found:\r\n";
                output += $"{foundRecord.Name}: {foundRecord.grade}";
            }
            else
            {
                output = "Record Not Found";
            }

            return output;
        }

        public string Displayrecords()
        {
            string output = "Name\tGrade\r\n";
            foreach(StudentRecord gradeRecord in StudentValueCollection)
            {
                output += $"{gradeRecord.Name}\t{gradeRecord.grade}\n";
            }

            return output;
        }

        public void AddRecords(StudentRecord record)
        {
            StudentCollection.Add(record.Name, record);
        }

        public void RemoveRecords(string name)
        {

            StudentCollection.Remove(name);
        }
    }
}
