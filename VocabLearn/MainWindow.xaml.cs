using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VocabLearn.Class;
using System.Collections;

namespace VocabLearn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string scriptPath = "script.txt";
        string resultPath = "result.txt";

        public MainWindow()
        {
            InitializeComponent();
            Function.InitVocabData(scriptPath, Variables.vocabList);
            HideResult();
        }

        public void HideResult()
        {
            lvVocab.Items.Clear();
            Vocabulary.DelAllMean(Variables.vocabList);
            Function.ArrayListToListView(Variables.vocabList, lvVocab);
        }
        public void ShowResult()
        {
            Variables.vocabList.Clear();
            Function.InitVocabData(scriptPath, Variables.vocabList);
            Function.ArrayListToListView(Variables.vocabList, lvVocab);
        }

        private void miTShowResult_Click(object sender, RoutedEventArgs e)
        {
            if(miTShowResult.Header != "Hide Result")
            {
                ShowResult();
                miTShowResult.Header = "Hide Result";
            }
            else
            {
                HideResult();
                miTShowResult.Header = "Show Result";
            }
        }
    }
}
