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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.Win32;
using VocabLearn.Windows;
=======
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
=======
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
=======
using Microsoft.Win32;
>>>>>>> parent of 7851be1... 0.1.7
=======
>>>>>>> parent of 87ed9a5... 0.1.6
=======
>>>>>>> parent of 87ed9a5... 0.1.6

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
            HideResult();
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        //Hide Result
        public void HideResults()
=======
=======
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
=======
        //Hide Result
>>>>>>> parent of 7851be1... 0.1.7
=======
>>>>>>> parent of 87ed9a5... 0.1.6
=======
>>>>>>> parent of 87ed9a5... 0.1.6
        public void HideResult()
        {
            lvVocab.Items.Clear();
            Vocabulary.DelAllMean(Variables.vocabList);
            Function.ArrayListToListView(Variables.vocabList, lvVocab);
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

        //Show Result
        public void ShowResults()
=======
=======
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
=======

        //Show Result
>>>>>>> parent of 7851be1... 0.1.7
=======
>>>>>>> parent of 87ed9a5... 0.1.6
=======
>>>>>>> parent of 87ed9a5... 0.1.6
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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        //Show result by click "Show Result" button
        private void miTShowResults_Click(object sender, RoutedEventArgs e)
=======
=======
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
=======
        //Show result by click "Show Result" button
>>>>>>> parent of 7851be1... 0.1.7
=======
>>>>>>> parent of 87ed9a5... 0.1.6
=======
>>>>>>> parent of 87ed9a5... 0.1.6
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 7851be1... 0.1.7

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
<<<<<<< HEAD

        private void miAbout_Click(object sender, RoutedEventArgs e)
        {
            About aboutWindows = new About();
            aboutWindows.Show();
        }
=======
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
=======
>>>>>>> 05ed19200e7c4eeb02b64790cddd1793b5c981e6
=======
>>>>>>> parent of 7851be1... 0.1.7
=======
>>>>>>> parent of 87ed9a5... 0.1.6
=======
>>>>>>> parent of 87ed9a5... 0.1.6
    }
}
