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
<<<<<<< HEAD
using Microsoft.Win32;
using VocabLearn.Windows;
=======
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6

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
            Vocabulary.InitVocabData(scriptPath, Variables.vocabList);
            HideResults();
        }

<<<<<<< HEAD
        //Hide Result
        public void HideResults()
=======
        public void HideResult()
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
        {
            lvVocab.Items.Clear();
            Vocabulary.DelAllMean(Variables.vocabList);
            Function.ArrayListToListView(Variables.vocabList, lvVocab);
        }
<<<<<<< HEAD

        //Show Result
        public void ShowResults()
=======
        public void ShowResult()
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
        {
            ArrayList tmp = new ArrayList();
            Function.ListViewToArrayList(lvVocab, tmp);
            Variables.vocabList.Clear();
            Vocabulary.InitVocabData(scriptPath, Variables.vocabList);
            Vocabulary.ParseAllTyped(Variables.vocabList, tmp);
            lvVocab.Items.Clear();
            Function.ArrayListToListView(Variables.vocabList, lvVocab);
        }

<<<<<<< HEAD
        //Show result by click "Show Result" button
        private void miTShowResults_Click(object sender, RoutedEventArgs e)
=======
        private void miTShowResult_Click(object sender, RoutedEventArgs e)
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
        {
            if(miTShowResults.Header != "Hide Results")
            {
                ShowResults();
                miTShowResults.Header = "Hide Results";
            }
            else
            {
                HideResults();
                miTShowResults.Header = "Show Results";
            }
        }
<<<<<<< HEAD

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

        private void miAbout_Click(object sender, RoutedEventArgs e)
        {
            About aboutWindows = new About();
            aboutWindows.Show();
        }
=======
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
    }
}
