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
using Microsoft.Win32;

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

        }

        //Initial
        private void Initial()
        {
            lvVocab.Items.Clear();
            Variables.vocabList.Clear();
            Vocabulary.InitVocabData(scriptPath, Variables.vocabList);
            HideResult();
        }

        //Hide Result
        public void HideResult()
        {
            lvVocab.Items.Clear();
            Vocabulary.DelAllMean(Variables.vocabList);
            Function.ArrayListToListView(Variables.vocabList, lvVocab);
        }

        //Show Result
        public void ShowResult()
        {
            ArrayList tmp = new ArrayList();
            Function.ListViewToArrayList(lvVocab, tmp);
            Variables.vocabList.Clear();
            Vocabulary.InitVocabData(scriptPath, Variables.vocabList);
            Vocabulary.ParseAllTyped(Variables.vocabList, tmp);
            lvVocab.Items.Clear();
            Function.ArrayListToListView(Variables.vocabList, lvVocab);
        }

        //Show result by click "Show Result" button
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

        //Open file
        private void miFOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*txt|All files (*.*)|*.*";  //Set file filter
            openFileDialog.FilterIndex = 1;                                         //Set file filter default index
            openFileDialog.RestoreDirectory = true;                                 //Set default path directory to app path directory
            if(openFileDialog.ShowDialog() == true)                                 //If "Open" button is clicked get file path and reinitial
            {
                scriptPath = openFileDialog.FileName;
                Initial();
            }
        }
    }
}
