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
        public static void  ArrayListToListView(ArrayList arrayList, ListView listView)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                listView.Items.Add((Vocabulary)arrayList[i]);
            }
        }

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
