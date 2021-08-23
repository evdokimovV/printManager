using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DocPrintManager.ViewModels;

namespace DocPrintManager.Forms
{
    public partial class PrintedDocsInfoForm : Form
    {
        private BindingList<DocumentGridItem> PrintedDocs { get; }
        public PrintedDocsInfoForm(BindingList<DocumentGridItem> documentItemViewModels)
        {
            InitializeComponent();
            PrintedDocs = documentItemViewModels;
            InitCollections();
            SortDocs(s => $"{s.Id}");
        }

        private void InitCollections()
        {
            _bsPrintedDocs.DataSource = PrintedDocs;
        }

        private void _rbSortByOrder_CheckedChanged(object sender, EventArgs e)
        {
            SortDocs(s => $"{s.Id}");
        }

        private void _rbSortByType_CheckedChanged(object sender, EventArgs e)
        {
            SortDocs(s => s.TypeName);
        }

        private void _rbSortByPrintTime_CheckedChanged(object sender, EventArgs e)
        {
            SortDocs(s => $"{s.PrintTime}");
        }

        private void _rbSortByPaperSize_CheckedChanged(object sender, EventArgs e)
        {
            SortDocs(s => s.ListSize);
        }

        private void SortDocs(Func<DocumentGridItem, string> keySelector)
        {
            var sortedList = PrintedDocs.OrderBy(keySelector);
            _bsPrintedDocs.DataSource = sortedList;
            _tbInfo.Text = string.Join(Environment.NewLine, sortedList.Select(s => $"{s.DocName} ({s.TypeName})"));
        }
    }
}
