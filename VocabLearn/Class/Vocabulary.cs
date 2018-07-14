using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
