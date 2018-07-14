using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VocabLearn.Class
{
    public static class Function
    {
        //Parse all ArrayList objects to ListView
        public static void  ArrayListToListView(ArrayList arrayList, ListView listView)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                listView.Items.Add((object)arrayList[i]);
            }
        }

        //Parse all ListView object to ArrayList (Only add new object to ArrayList)
        public static void ListViewToArrayList(ListView listView, ArrayList arrayList)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                arrayList.Add(listView.Items[i]);
            }
        }

        //Writefile to path from Vocabulary variable
        public static void WriteFile(string path, Vocabulary vocab)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(" #" + vocab.Word + "#" + vocab.Mean);
            file.Close();
        }

        //Readfile from path to ArrayList
        public static void ReadFile(string path, ArrayList arrayList)
        {
            StreamReader file = new StreamReader(path);
            while (true)
            {
                string line = file.ReadLine();
                if(line == null)
                {
                    return;
                }
                arrayList.Add(line);
            }
        }

        //Initial a Vocabulary data of a file with file's path
        public static void InitVocabData(string path, ArrayList arrayList)
        {
            ReadFile(path, arrayList);
            for(int i = 0; i < arrayList.Count; i++)
            {
                arrayList[i] = Vocabulary.ConvertToVocabulary((string)arrayList[i]);
            }
        }


    }
}
