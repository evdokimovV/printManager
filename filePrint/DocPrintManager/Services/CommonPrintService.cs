using System.Collections.Generic;
using DocPrintManager.ViewModels;

namespace DocPrintManager.Services
{
    public static class CommonPrintService
    {
        public static List<DocumentTypeViewModel> GetTypeList()
        {
            var result = new List<DocumentTypeViewModel>();
            result.Add(new DocumentTypeViewModel(1, "DocType1", 1, "A1"));
            result.Add(new DocumentTypeViewModel(1, "DocType2", 2, "A2"));
            result.Add(new DocumentTypeViewModel(1, "DocType3", 3, "A3"));
            result.Add(new DocumentTypeViewModel(1, "DocType4", 5, "A4"));
            result.Add(new DocumentTypeViewModel(1, "DocType5", 10, "A5"));
            return result;
        }
    }
}
