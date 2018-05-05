using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FuerstFinal1._0
{
    class CowClass
    {
        public int ID;
        public char gender;
        public char herd;
        public DateTime birthday;
        public int birthweight;
        public string notes;

        //Default values for optional variables
        public DateTime defaultBirthday = new DateTime(1900, 1, 1);
        public const int defaultBirthweight = 9987899;
        public const string defaultNotes = "N/A";

        public CowClass()
        {

        }

        public CowClass(int theID, char theGender, char theHerd)
        {

        }

        public CowClass(int theID, char theGender, char theHerd, DateTime theBirthday, int theBirthweight, string theNotes)
        {

        }

        //Creates a list of all the cows in the save file
        public List<CowClass> retrieveCowInfo()
        {
            //INPUT AND OUTPUT FILE
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "COWTEST1.txt");

            List<CowClass> Cows = new List<CowClass>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();

                    strArray = str.Split(',');

                    CowClass currentCow = new CowClass();
                    currentCow.ID = Int32.Parse(strArray[0]);
                    currentCow.gender = Convert.ToChar(strArray[1]);
                    currentCow.herd = Convert.ToChar(strArray[2]);
                    currentCow.birthday = new DateTime(Int32.Parse(strArray[3]), Int32.Parse(strArray[4]), Int32.Parse(strArray[5]));
                    currentCow.birthweight = Int32.Parse(strArray[6]);
                    currentCow.notes = strArray[7];

                    Cows.Add(currentCow);
                }
            }

            return Cows;
        }
    }
}
