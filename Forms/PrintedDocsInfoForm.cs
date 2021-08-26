using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DocPrintManager.ViewModels;

namespace DocPrintManager.Forms
{
    public partial class PrintedDocsInfoForm : Form
    {
        private DocumentsInfoViewModel DocsInfo { get; }
        internal PrintedDocsInfoForm(DocumentsInfoViewModel docsInfo)
        {
            InitializeComponent();
            DocsInfo = docsInfo;
            InitCollections();
            SortDocs(s => $"{s.Id}");
        }

        private void InitCollections()
        {
            _bsPrintedDocs.DataSource = DocsInfo.PrintedDocs;
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
            DocsInfo.SortDocs(keySelector);
            _bsPrintedDocs.DataSource = DocsInfo.PrintedDocs;
            _tbInfo.Text = DocsInfo.DocsInfoString;
        }
    }
}
