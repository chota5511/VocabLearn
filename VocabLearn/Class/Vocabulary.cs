using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace VocabLearn.Class
{
    public class Vocabulary : ICloneable
    {
        private string word;
        private string mean;
        private string typed;

        //Getter and Setter Word
        public string Word
        {
            set { word = value; }
            get { return word; }
        }
        //Getter and Setter Mean
        public string Mean
        {
            set { mean = value; }
            get { return mean; }
        }
        //Getter and Setter Typed
        public string Typed
        {
            set { typed = value; }
            get { return typed; }
        }

        //Delete mean
        public void DelMean()
        {
            mean = null;
        }

        //Delete all Vocabulary meaning in ArrayList
        public static void DelAllMean(ArrayList VocabularyList)
        {
            for (int i = 0; i < VocabularyList.Count; i++)
            {
                Vocabulary tmp = (Vocabulary)VocabularyList[i];
                tmp.DelMean();
            }
        }

        //Convert text to Vocabulary
        public static Vocabulary ConvertToVocabulary(string text)
        {
            Vocabulary tmp = new Vocabulary();
            for (int i = 0, s = 0; i < text.Length || s > 2; i++)
            {
                if (text[i] == '#')
                {
                    s++;
                    i++;
                }
                if (s == 1)
                {
                    tmp.word += text[i];
                }
                if (s == 2)
                {
                    tmp.mean += text[i];
                }
            }
            return tmp;
        }

        //Writefile to path from Vocabulary variable
        public static void WriteFile(string path, Vocabulary vocab)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(" #" + vocab.Word + "#" + vocab.Mean + "#" + vocab.Typed);
            file.Close();
        }

        //Write Vocabulary object in ArrayList to file
        public static void WriteFromArrayList(string path, ArrayList arrayList)
        {
            for(int i = 0; i < arrayList.Count; i++)
            {
                WriteFile(path, (Vocabulary)arrayList[i]);
            }
        }

        //Initial a Vocabulary data of a file with file's path
        public static void InitVocabData(string path, ArrayList arrayList)
        {
            Function.ReadFile(path, arrayList);
            for (int i = 0; i < arrayList.Count; i++)
            {
                arrayList[i] = Vocabulary.ConvertToVocabulary((string)arrayList[i]);
            }
        }

        //Parse mean of Vocabulary object to other object
        public static void ParseTyped(Vocabulary vocabulary, Vocabulary _vocabulary)
        {
            vocabulary.typed = _vocabulary.typed;
        }

        //Parse mean of all object vocabulary ArrayList
        public static void ParseAllTyped(ArrayList arrayList, ArrayList _arrayList)
        {
            for(int i = 0; i < arrayList.Count; i++)
            {
                ParseTyped((Vocabulary)arrayList[i], (Vocabulary)_arrayList[i]);
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
