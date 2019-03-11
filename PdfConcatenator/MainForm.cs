using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PdfConcatenator
{
    public partial class MainForm : Form
    {
        bool isUserSelect = true;

        public MainForm()
        {
            SetCulture();
            InitializeComponent();
            openPdfFileDialog.InitialDirectory = Directory.GetCurrentDirectory();            
        }

        static void SetCulture()
        {
            var appCulture = ConfigurationSettings.AppSettings.Get("AppCulture");
            if (!string.IsNullOrEmpty(appCulture))
            {
                CultureInfo culture = new CultureInfo(appCulture);
                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;
            }
        }

        private void upDownItemPos_ValueChanged(object sender, EventArgs e)
        {
            if (isUserSelect)
            {
                if (listBoxFiles.SelectedItem == null || listBoxFiles.SelectedIndex < 0)
                    return;
                if (upDownItemPos.Value > listBoxFiles.Items.Count)
                {
                    upDownItemPos.Value = listBoxFiles.Items.Count;
                }
                else if (upDownItemPos.Value < 1)
                {
                    upDownItemPos.Value = 1;
                }
                else if (Math.Truncate(upDownItemPos.Value) != upDownItemPos.Value)
                {
                    upDownItemPos.Value = Math.Truncate(upDownItemPos.Value);
                }
                else
                {
                    isUserSelect = false;
                    object selected = listBoxFiles.SelectedItem;
                    int newPos = (int)upDownItemPos.Value - 1;
                    // Removing removable element
                    listBoxFiles.Items.Remove(selected);
                    // Insert it in new position
                    listBoxFiles.Items.Insert(newPos, selected);
                    // Restore selection
                    listBoxFiles.SetSelected(newPos, true);
                    isUserSelect = true;
                }
            }
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            isUserSelect = false;
            upDownItemPos.Value = listBoxFiles.SelectedIndex + 1;
            isUserSelect = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {            
            if (openPdfFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBoxFiles.Items.AddRange(openPdfFileDialog.FileNames);                
            }
            openPdfFileDialog.Reset();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var index = listBoxFiles.SelectedIndex;
            if (index > -1)
            {
                listBoxFiles.Items.RemoveAt(index);
                if (listBoxFiles.Items.Count > 0)
                {
                    if (index < listBoxFiles.Items.Count)
                    {
                        listBoxFiles.SelectedIndex = index;
                    }
                    else
                    {
                        listBoxFiles.SelectedIndex = listBoxFiles.Items.Count - 1;
                    }
                }
            }
        }

        private void selectOutputButton_Click(object sender, EventArgs e)
        {
            saveOutputFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveOutputFileDialog.FileName = saveOutputTextBox.Text;
            if (saveOutputFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveOutputTextBox.Text = saveOutputFileDialog.FileName;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string outputFile = saveOutputTextBox.Text;
            if (string.IsNullOrEmpty(outputFile))
                outputFile = "output.pdf";

            IEnumerable<string> files = listBoxFiles.Items.Cast<string>();
            if (files.Count() == 0)
            {
                MessageBox.Show(Properties.Resources.PleaseSelectFile);
                return;
            }

            try
            {
                if (File.Exists(outputFile))
                {
                    File.Delete(outputFile);
                }

                Document document = new Document();
                var output = new FileStream(outputFile, FileMode.Create);
                using (PdfCopy copy = new PdfSmartCopy(document, output))
                {
                    document.Open();
                    foreach (var arg in files)
                    {
                        if (!File.Exists(arg))
                        {
                            MessageBox.Show(string.Format(Properties.Resources.ErrorFileNotFound, arg));
                        }
                        else
                        {
                            using (var reader = new PdfReader(arg))
                            {
                                copy.AddDocument(reader);
                            }
                        }
                    }
                    document.Close();
                }
                MessageBox.Show(Properties.Resources.Complete);
            }
            catch (Exception ex)
            {
                PrintError(ex);
            }
        }

        private void PrintError(Exception ex)
        {
            while (ex != null)
            {
                MessageBox.Show(string.Format(Properties.Resources.Error, ex.Message, ex.Source, ex.StackTrace));
                ex = ex.InnerException;
            }
        }

        private void listBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void listBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var pdfFiles = files.Where(x => x.EndsWith(".pdf", StringComparison.InvariantCultureIgnoreCase)).ToArray();
            listBoxFiles.Items.AddRange(pdfFiles);
        }
    }
}
