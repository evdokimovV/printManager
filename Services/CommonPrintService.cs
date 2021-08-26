using System.Collections.Generic;
using System.Linq;
using DocPrintManager.ViewModels;

namespace DocPrintManager.Services
{
    internal static class CommonPrintService
    {
        internal static List<DocumentTypeViewModel> CommonTypes { get; set; }
        internal static List<DocumentTypeViewModel> GetTypeList()
        {
            if (!CommonTypes?.Any() ?? true)
                InitTypes();
            return CommonTypes;
        }

        private static void InitTypes()
        {
            CommonTypes = new List<DocumentTypeViewModel>
            {
                new DocumentTypeViewModel(1, "DocType1", 1, "A1"),
                new DocumentTypeViewModel(1, "DocType2", 2, "A2"),
                new DocumentTypeViewModel(1, "DocType3", 3, "A3"),
                new DocumentTypeViewModel(1, "DocType4", 5, "A4"),
                new DocumentTypeViewModel(1, "DocType5", 10, "A5")
            };
        }
    }
}
