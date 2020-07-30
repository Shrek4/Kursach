using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace WpfShrek.some_support
{
    class Files
    {

        public static string LoadText()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = @"Word Files (.doc, .docx)|*.doc;*.docx|Text Files (.txt)|*.txt";
            string fileName="";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                fileName = dlg.FileName;
            };
            if(fileName.Split('.').Last()=="txt") return File.ReadAllText(fileName);

            Application app = new Application();
            Document doc = app.Documents.Open(fileName);

            //Get all words
            string allWords = doc.Content.Text;
            doc.Close();
            app.Quit();
            return allWords;
        }

        public static void SaveText(string text)
        {
            try
            {
                //Create an instance for word app  
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application  
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //adding text to document  
                document.Content.SetRange(0, 0);
                document.Content.Text = text;

                //Save the document  
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.Filter = @"Word Files (.doc, .docx)|*.doc;*.docx|Text Files (.txt)|*.txt";
                object fileName = "";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    fileName = dlg.FileName;
                };

                document.SaveAs2(ref fileName);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Файл успешно создан");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oh shit, I'm sorry");
            }
        }
    }
}
