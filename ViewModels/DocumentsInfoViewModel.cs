using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocPrintManager.ViewModels
{
    internal class DocumentsInfoViewModel
    {
        internal DocumentsInfoViewModel(List<DocumentGridItem> printedDocs)
        {
            PrintedDocs = printedDocs;
        }
        internal List<DocumentGridItem> PrintedDocs { get; set; }
        internal string DocsInfoString => string.Join(Environment.NewLine, PrintedDocs.Select(s => $"{s.DocName} ({s.TypeName})"));

        internal void SortDocs(Func<DocumentGridItem, string> keySelector)
        {
            PrintedDocs = PrintedDocs.OrderBy(keySelector).ToList();
        }
    }
}
