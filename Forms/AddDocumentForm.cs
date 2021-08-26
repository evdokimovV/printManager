using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DocPrintManager.Services;
using DocPrintManager.ViewModels;

namespace DocPrintManager.Forms
{
    public partial class AddDocumentForm : Form
    {
        private List<DocumentTypeViewModel> CommonTypes { get; set; }
        internal DocumentItemViewModel ResultDoc { get; set; }
        private DocumentTypeViewModel CurrentType => _clbDocType.SelectedItem as DocumentTypeViewModel;
        public AddDocumentForm()
        {
            InitializeComponent();
            InitCollections();
        }

        private void InitCollections()
        {
            CommonTypes = CommonPrintService.GetTypeList();
            ((ListBox)_clbDocType).DataSource = CommonTypes;
            ((ListBox)_clbDocType).DisplayMember = nameof(DocumentTypeViewModel.Name);
            ((ListBox)_clbDocType).ValueMember = nameof(DocumentTypeViewModel.IsChecked);
        }

        private void _sbSave_Click(object sender, EventArgs e)
        {
            if (!CanSave()) return;
            ResultDoc = new DocumentItemViewModel(CurrentType, string.IsNullOrEmpty(_tbDocName.Text) ? "Без имени" : _tbDocName.Text);
            
            DialogResult = DialogResult.OK;
        }

        private bool CanSave()
        {
            if (CurrentType != null) return true;
            MessageBox.Show("Внимание", "Выберите тип документа");
            return false;
        }

        /// <summary>
        /// возможность выбрать только 1 тип документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clbDocType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < _clbDocType.Items.Count; ++ix)
                if (ix != e.Index)
                    _clbDocType.SetItemChecked(ix, false);
            _tbListSize.Text = e.NewValue == CheckState.Checked ? CurrentType.ListSize : null;
            _tbPrintTime.Text = e.NewValue == CheckState.Checked ? $"{CurrentType.PrintTime}" : null;
            _sbSave.Enabled = e.NewValue == CheckState.Checked;
        }
    }
}
