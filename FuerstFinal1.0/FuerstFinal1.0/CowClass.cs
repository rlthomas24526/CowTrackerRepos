using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FuerstFinal1._0
{
    public class CowClass
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

        public CowClass(int theID, char theGender, char theHerd, DateTime theBirthday, int theBirthweight, string theNotes)
        {
            this.ID = theID;
            this.gender = theGender;
            this.herd = theHerd;
            this.birthday = theBirthday;
            this.birthweight = theBirthweight;
            this.notes = theNotes;
        }

        //Creates a list of all the cows in the save file
        public static List<CowClass> RetrieveCowInfo()
        {
            //INPUT AND OUTPUT FILE
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "COWTEST1.txt");

            List<CowClass> Cows = new List<CowClass>();
            using (StreamReader sr = new StreamReader(path))
            {
                string str;
                string[] strArray;

                while (sr.Peek() >= 0)
                {
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

        //Adds a cow to the end of the list of cows
        public static List<CowClass> AddCow(List<CowClass> oldCows, CowClass addThisCow)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "COWTEST1.txt");

            oldCows.Add(addThisCow);

            //Overwrite with first one
            using (StreamWriter sr = new StreamWriter(path, false))
            {
                sr.WriteLine(oldCows[0].ID.ToString() + "," + oldCows[0].gender.ToString() + "," + oldCows[0].herd + "," +
                    oldCows[0].birthday.Year.ToString() + "," + oldCows[0].birthday.Month.ToString() + "," + oldCows[0].birthday.Day.ToString() +
                    "," + oldCows[0].birthweight.ToString() + oldCows[0].notes);
            }

            //Append with the rest - IN REAL PROJ TEST THAT THERE IS MORE THAN ONE ITEM IN LIST FIRST THEN DO THIS probably so no breaky
            for (var i = 1; i < oldCows.Count; i++)
            {
                using (StreamWriter sr = new StreamWriter(path, true))
                {
                    sr.WriteLine(oldCows[i].ID.ToString() + "," + oldCows[i].gender.ToString() + "," + oldCows[i].herd + "," +
                    oldCows[i].birthday.Year.ToString() + "," + oldCows[i].birthday.Month.ToString() + "," + oldCows[i].birthday.Day.ToString() +
                    "," + oldCows[i].birthweight.ToString() + oldCows[i].notes);
                }
            }

            return oldCows;
        }

        //Deletes a cow from the list of cows
        public static List<CowClass> DeleteCow(List<CowClass> oldCows, int indexToDelete)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "COWTEST1.txt");

            oldCows.RemoveAt(indexToDelete);

            //Overwrite with first one
            using (StreamWriter sr = new StreamWriter(path, false))
            {
                sr.WriteLine(oldCows[0].ID.ToString() + "," + oldCows[0].gender.ToString() + "," + oldCows[0].herd + "," +
                    oldCows[0].birthday.Year.ToString() + "," + oldCows[0].birthday.Month.ToString() + "," + oldCows[0].birthday.Day.ToString() +
                    "," + oldCows[0].birthweight.ToString() + oldCows[0].notes);
            }

            //Append with the rest - IN REAL PROG TEST THAT THERE IS MORE THAN ONE ITEM IN LIST FIRST THEN DO THIS
            for (var i = 1; i < oldCows.Count; i++)
            {
                using (StreamWriter sr = new StreamWriter(path, true))
                {
                    sr.WriteLine(oldCows[i].ID.ToString() + "," + oldCows[i].gender.ToString() + "," + oldCows[i].herd + "," +
                    oldCows[i].birthday.Year.ToString() + "," + oldCows[i].birthday.Month.ToString() + "," + oldCows[i].birthday.Day.ToString() +
                    "," + oldCows[i].birthweight.ToString() + oldCows[i].notes);
                }
            }

            return oldCows;
        }

        //Searches for a particular cow
        public static int SearchForCow(List<CowClass> oldCows, int searchForThisID)
        {
            int returnthisnumber = 666;

            for (var i = 0; i < oldCows.Count; i++)
            {
                CowClass currentCow = oldCows[i];

                if (currentCow.ID == searchForThisID)
                {
                    returnthisnumber = currentCow.ID;
                }
            }

            return returnthisnumber;
        }
    }
}
