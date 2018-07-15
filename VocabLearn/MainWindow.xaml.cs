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
using VocabLearn.Windows;
using Microsoft.Win32;


namespace VocabLearn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        //Initial
        private void Initial()
        {
            lvVocab.Items.Clear();
            Variables.vocabList.Clear();
            Vocabulary.InitVocabData(Variables.scriptPath, Variables.vocabList);
            HideResults();
        }

        //Hide Result
        public void HideResults()
        {
            lvVocab.Items.Clear();
            Vocabulary.DelAllMean(Variables.vocabList);
            Function.ArrayListToListView(Variables.vocabList, lvVocab);
        }

        //Show Result
        public void ShowResults()
        {
            ArrayList tmp = new ArrayList();
            Function.ListViewToArrayList(lvVocab, tmp);
            Variables.vocabList.Clear();
            Vocabulary.InitVocabData(Variables.scriptPath, Variables.vocabList);
            Vocabulary.ParseAllTyped(Variables.vocabList, tmp);
            lvVocab.Items.Clear();
            Function.ArrayListToListView(Variables.vocabList, lvVocab);
        }

        //Show result by click "Show Result" button
        private void miTShowResults_Click(object sender, RoutedEventArgs e)
        {
            if(miTShowResults.Header != "Hide Result")
            {
                ShowResults();
                miTShowResults.Header = "Hide Result";
            }
            else
            {
                HideResults();
                miTShowResults.Header = "Show Result";
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
                Variables.scriptPath = openFileDialog.FileName;
                Initial();
            }
        }

        private void miAbout_Click(object sender, RoutedEventArgs e)
        {
            About aboutWindows = new About();
            aboutWindows.Show();
        }
    }
}
