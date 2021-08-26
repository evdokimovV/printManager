using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocPrintManager.Basics;
using DocPrintManager.Forms;
using DocPrintManager.ViewModels;

namespace DocPrintManager
{
    internal partial class MainForm : Form
    {
        private bool StopPrint { get; set; }
        private BindingList<DocumentItemViewModel> Documents { get; set; }
        private BindingList<DocumentGridItem> GridData { get; set; }
        private CancellationTokenSource CancellationTokenSource { get; set; }
        internal MainForm()
        {
            InitializeComponent();
            InitCollections();
        }

        private void InitCollections()
        {
            Documents = new BindingList<DocumentItemViewModel>();
            GridData = new BindingList<DocumentGridItem>();
            _bsDocs.DataSource = GridData;
        }

        private void StartPrint()
        {
            var doc = Documents.FirstOrDefault(s => s.Printed.HasValue && !s.Printed.Value);
            if (doc == null)
                return;
            PrintDoc(doc);
        }

        private async void PrintDoc(DocumentItemViewModel doc)
        {
            CancellationTokenSource = new CancellationTokenSource();
            var gridItem = GridData.First(s => s.Printed.HasValue && !s.Printed.Value && s.Type == doc.Type);
            var task = Task.Run(async () =>
            {
                try
                {
                    await Task.Delay(doc.Type.PrintTime * 1000, CancellationTokenSource.Token);
                    doc.Printed = gridItem.Printed = true;
                    BeginInvoke((Action) (() => _dgvDocs.Refresh()));
                    StartPrint();
                }
                catch (OperationCanceledException)
                {
                    if (StopPrint)
                    {
                        var notPrintedDocs = Documents.Where(s => !s.Printed.HasValue || !s.Printed.Value);
                        MessageBox.Show(string.Join(", ",
                                notPrintedDocs.Select(s =>
                                    $"{s.DocName} ({s.Type.Name})")),
                            PrintManagerConstants.PrintedDocsCaption);
                        StopPrint = false;
                    }
                    else
                    {
                        doc.Printed = gridItem.Printed = null;
                        BeginInvoke((Action)(() => _dgvDocs.Refresh()));
                        StartPrint();
                    }
                }
            }, CancellationTokenSource.Token);
            await task;
        }

        private void CancelTokenSource()
        {
            CancellationTokenSource?.Cancel();
        }

        private void _sbStart_Click(object sender, EventArgs e)
        {
            StartPrint();
        }

        private void _btnStopPrint_Click(object sender, EventArgs e)
        {
            if (!GridData.Any()) return;
            StopPrint = true;
            CancelTokenSource();
        }

        private void _btnAddDoc_Click(object sender, EventArgs e)
        {
            var addingForm = new AddDocumentForm();
            if (addingForm.ShowDialog() != DialogResult.OK) return;
            Documents.Add(addingForm.ResultDoc);
            var docIter = GridData.Any() ? GridData.Last().Id : 1;
            GridData.Add(new DocumentGridItem(addingForm.ResultDoc, docIter));
        }

        private void _btnCancelPrint_Click(object sender, EventArgs e)
        {
            CancelTokenSource();
        }

        private void _btnGetPrintedDocs_Click(object sender, EventArgs e)
        {
            var printedDocs = new List<DocumentGridItem>(GridData.Where(s => s.Printed.HasValue && s.Printed.Value).ToList());
            if (!printedDocs.Any()) return;
            var form = new PrintedDocsInfoForm(new DocumentsInfoViewModel(printedDocs));
            form.ShowDialog();
        }

        private void _btnGetAvgPrintTime_Click(object sender, EventArgs e)
        {
            var printedDocs = Documents.Where(s => s.Printed.HasValue && s.Printed.Value).ToList();
            var avgPrintTime = printedDocs.Any() ? printedDocs.Select(s => s.Type.PrintTime).Average() : (double?)null;
            if (avgPrintTime.HasValue) MessageBox.Show($"{avgPrintTime:0.##} {PrintManagerConstants.UnitOfTimeSecond}", PrintManagerConstants.AvgPrintTimeCaption);
        }
    }
}
