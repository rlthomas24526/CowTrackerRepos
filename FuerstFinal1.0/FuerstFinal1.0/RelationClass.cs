using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FuerstFinal1._0
{
    class RelationClass
    {
        public int parentCow;
        public int kiddyCow;

        public RelationClass()
        {

        }

        public RelationClass(int theParent, int theKiddy)
        {
            this.parentCow = theParent;
            this.kiddyCow = theKiddy;
        }

        //Creates a list of all the relationships in the save file
        public static List<RelationClass> RetrieveRelationInfo()
        {
            //INPUT AND OUTPUT FILE
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RELATIONS.txt");

            //If the path doesn't exist
            if (!File.Exists(path))
            {
                string randomText = "RELATIONS";
                string newpath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                File.WriteAllText(newpath, randomText);
            }

            List<RelationClass> Relations = new List<RelationClass>();
            using (StreamReader sr = new StreamReader(path))
            {
                string str;
                string[] strArray;

                while (sr.Peek() >= 0)
                {
                    str = sr.ReadLine();

                    strArray = str.Split(',');

                    RelationClass currentRelation = new RelationClass();
                    currentRelation.parentCow = Int32.Parse(strArray[0]);
                    currentRelation.kiddyCow = Int32.Parse(strArray[1]);

                    Relations.Add(currentRelation);
                }
            }

            return Relations;
        }

        //Adds a new relationship to the save file
        public static void AddRelation(List<RelationClass> oldRelations, RelationClass addThisRelation)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RELATIONTEST1.txt");

            //If the path doesn't exist
            if (!File.Exists(path))
            {
                string randomText = "RELATIONS";
                string newpath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                File.WriteAllText(newpath, randomText);
            }

            oldRelations.Add(addThisRelation);

            //Overwrite with first one
            using (StreamWriter sr = new StreamWriter(path, false))
            {
                sr.WriteLine(oldRelations[0].parentCow.ToString() + "," + oldRelations[0].kiddyCow.ToString());
            }

            //Append with the rest - IN REAL PROJ TEST THAT THERE IS MORE THAN ONE ITEM IN LIST FIRST THEN DO THIS probably so no breaky
            for (var i = 1; i < oldRelations.Count; i++)
            {
                using (StreamWriter sr = new StreamWriter(path, true))
                {
                    sr.WriteLine(oldRelations[i].parentCow.ToString() + "," + oldRelations[i].kiddyCow.ToString());
                }
            }
        }

        //Searches for a relationship
        public static bool SearchForRelation(List<RelationClass> oldRelations, int cow1ID, int cow2ID)
        {
            int parentCowIndex;

            for (var i = 0; i < oldRelations.Count; i++)
            {
                RelationClass currentRelation = oldRelations[i];

                if (currentRelation.parentCow == cow1ID)
                {
                    parentCowIndex = i;
                    if(oldRelations[i].kiddyCow == cow2ID)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
