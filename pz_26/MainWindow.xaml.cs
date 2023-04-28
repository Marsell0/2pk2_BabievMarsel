using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace pz_26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isSaved = false;
        bool isUnderline = false;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            MessageBox.Show(menuItem.Header.ToString());
        }

        private void MenuItem_Click_showModal(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.ShowDialog();
        }

        private void openFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                FileInfo fileInfo = new FileInfo(fileStream.Name);
                TextRange range = new TextRange(richTB.Document.ContentStart, richTB.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
                dateCreation.Text = Convert.ToString(fileInfo.LastAccessTime);
                fileSize.Text = "размер: " + Convert.ToString(fileInfo.Length / 1024) + "кб";
            }
        }
        private void saveFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                FileInfo fileInfo = new FileInfo(fileStream.Name);
                TextRange range = new TextRange(richTB.Document.ContentStart, richTB.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
                isSaved = true;
                dateCreation.Text = Convert.ToString(fileInfo.LastAccessTime);
                fileSize.Text = "размер: " + Convert.ToString(fileInfo.Length / 1024) + "кб";
            }
        }

        private void UpdateCursorPosition(object sender, KeyEventArgs e)
        {
            TextPointer caretLineStart = richTB.CaretPosition.GetLineStartPosition(0);
            TextPointer p = richTB.Document.ContentStart.GetLineStartPosition(0);
            int currentLineNumber = 0;

            while (true)
            {
                if (p == null || (caretLineStart != null && caretLineStart.CompareTo(p) < 0))
                {
                    break;
                }

                p = p.GetLineStartPosition(1, out var result);

                if (result == 0)
                {
                    break;
                }

                currentLineNumber++;
            }

            position.Text = Convert.ToString(Math.Max(1, currentLineNumber));
        }

        private void makeItalic(object sender, RoutedEventArgs e)
        {
            if (richTB.Selection != null)
            {
                richTB.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
            }
            else
                richTB.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, null);
        }

        private void makeBold(object sender, RoutedEventArgs e)
        {
            if (richTB.Selection != null)
            {
                richTB.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            }
            else
                richTB.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, null);
        }

        private void makeUnderline(object sender, RoutedEventArgs e)
        {
            if (!isUnderline) 
            {
                richTB.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
                isUnderline = true;
            }
            richTB.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
            isUnderline = false;
        }
    }
}
