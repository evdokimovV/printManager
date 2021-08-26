namespace DocPrintManager.Forms
{
    partial class PrintedDocsInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._dgvPrintedDocs = new System.Windows.Forms.DataGridView();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bsPrintedDocs = new System.Windows.Forms.BindingSource(this.components);
            this._lblSortBy = new System.Windows.Forms.Label();
            this._rbSortByPaperSize = new System.Windows.Forms.RadioButton();
            this._rbSortByPrintTime = new System.Windows.Forms.RadioButton();
            this._rbSortByType = new System.Windows.Forms.RadioButton();
            this._rbSortByOrder = new System.Windows.Forms.RadioButton();
            this._tbInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dgvPrintedDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsPrintedDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgvPrintedDocs
            // 
            this._dgvPrintedDocs.AutoGenerateColumns = false;
            this._dgvPrintedDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvPrintedDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeNameDataGridViewTextBoxColumn,
            this.printTimeDataGridViewTextBoxColumn,
            this.listSizeDataGridViewTextBoxColumn,
            this.docNameDataGridViewTextBoxColumn});
            this._dgvPrintedDocs.DataSource = this._bsPrintedDocs;
            this._dgvPrintedDocs.Location = new System.Drawing.Point(212, 12);
            this._dgvPrintedDocs.Name = "_dgvPrintedDocs";
            this._dgvPrintedDocs.ReadOnly = true;
            this._dgvPrintedDocs.Size = new System.Drawing.Size(446, 307);
            this._dgvPrintedDocs.TabIndex = 0;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printTimeDataGridViewTextBoxColumn
            // 
            this.printTimeDataGridViewTextBoxColumn.DataPropertyName = "PrintTime";
            this.printTimeDataGridViewTextBoxColumn.HeaderText = "Время печати";
            this.printTimeDataGridViewTextBoxColumn.Name = "printTimeDataGridViewTextBoxColumn";
            this.printTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listSizeDataGridViewTextBoxColumn
            // 
            this.listSizeDataGridViewTextBoxColumn.DataPropertyName = "ListSize";
            this.listSizeDataGridViewTextBoxColumn.HeaderText = "Размер";
            this.listSizeDataGridViewTextBoxColumn.Name = "listSizeDataGridViewTextBoxColumn";
            this.listSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docNameDataGridViewTextBoxColumn
            // 
            this.docNameDataGridViewTextBoxColumn.DataPropertyName = "DocName";
            this.docNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.docNameDataGridViewTextBoxColumn.Name = "docNameDataGridViewTextBoxColumn";
            this.docNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _bsPrintedDocs
            // 
            this._bsPrintedDocs.DataSource = typeof(DocPrintManager.ViewModels.DocumentGridItem);
            // 
            // _lblSortBy
            // 
            this._lblSortBy.AutoSize = true;
            this._lblSortBy.Location = new System.Drawing.Point(9, 10);
            this._lblSortBy.Name = "_lblSortBy";
            this._lblSortBy.Size = new System.Drawing.Size(90, 13);
            this._lblSortBy.TabIndex = 16;
            this._lblSortBy.Text = "Сортировать по:";
            // 
            // _rbSortByPaperSize
            // 
            this._rbSortByPaperSize.AutoSize = true;
            this._rbSortByPaperSize.Location = new System.Drawing.Point(12, 95);
            this._rbSortByPaperSize.Name = "_rbSortByPaperSize";
            this._rbSortByPaperSize.Size = new System.Drawing.Size(103, 17);
            this._rbSortByPaperSize.TabIndex = 15;
            this._rbSortByPaperSize.Text = "Размер бумаги";
            this._rbSortByPaperSize.UseVisualStyleBackColor = true;
            this._rbSortByPaperSize.CheckedChanged += new System.EventHandler(this._rbSortByPaperSize_CheckedChanged);
            // 
            // _rbSortByPrintTime
            // 
            this._rbSortByPrintTime.AutoSize = true;
            this._rbSortByPrintTime.Location = new System.Drawing.Point(12, 72);
            this._rbSortByPrintTime.Name = "_rbSortByPrintTime";
            this._rbSortByPrintTime.Size = new System.Drawing.Size(166, 17);
            this._rbSortByPrintTime.TabIndex = 14;
            this._rbSortByPrintTime.Text = "Продолжительность печати";
            this._rbSortByPrintTime.UseVisualStyleBackColor = true;
            this._rbSortByPrintTime.CheckedChanged += new System.EventHandler(this._rbSortByPrintTime_CheckedChanged);
            // 
            // _rbSortByType
            // 
            this._rbSortByType.AutoSize = true;
            this._rbSortByType.Location = new System.Drawing.Point(12, 49);
            this._rbSortByType.Name = "_rbSortByType";
            this._rbSortByType.Size = new System.Drawing.Size(101, 17);
            this._rbSortByType.TabIndex = 13;
            this._rbSortByType.Text = "Тип документа";
            this._rbSortByType.UseVisualStyleBackColor = true;
            this._rbSortByType.CheckedChanged += new System.EventHandler(this._rbSortByType_CheckedChanged);
            // 
            // _rbSortByOrder
            // 
            this._rbSortByOrder.AutoSize = true;
            this._rbSortByOrder.Checked = true;
            this._rbSortByOrder.Location = new System.Drawing.Point(12, 26);
            this._rbSortByOrder.Name = "_rbSortByOrder";
            this._rbSortByOrder.Size = new System.Drawing.Size(106, 17);
            this._rbSortByOrder.TabIndex = 12;
            this._rbSortByOrder.TabStop = true;
            this._rbSortByOrder.Text = "Порядок печати";
            this._rbSortByOrder.UseVisualStyleBackColor = true;
            this._rbSortByOrder.CheckedChanged += new System.EventHandler(this._rbSortByOrder_CheckedChanged);
            // 
            // _tbInfo
            // 
            this._tbInfo.Location = new System.Drawing.Point(12, 118);
            this._tbInfo.Multiline = true;
            this._tbInfo.Name = "_tbInfo";
            this._tbInfo.ReadOnly = true;
            this._tbInfo.Size = new System.Drawing.Size(166, 201);
            this._tbInfo.TabIndex = 17;
            // 
            // PrintedDocsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 332);
            this.Controls.Add(this._tbInfo);
            this.Controls.Add(this._lblSortBy);
            this.Controls.Add(this._rbSortByPaperSize);
            this.Controls.Add(this._rbSortByPrintTime);
            this.Controls.Add(this._rbSortByType);
            this.Controls.Add(this._rbSortByOrder);
            this.Controls.Add(this._dgvPrintedDocs);
            this.Name = "PrintedDocsInfoForm";
            this.Text = "Напечатанные документы";
            ((System.ComponentModel.ISupportInitialize)(this._dgvPrintedDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsPrintedDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvPrintedDocs;
        private System.Windows.Forms.BindingSource _bsPrintedDocs;
        private System.Windows.Forms.Label _lblSortBy;
        private System.Windows.Forms.RadioButton _rbSortByPaperSize;
        private System.Windows.Forms.RadioButton _rbSortByPrintTime;
        private System.Windows.Forms.RadioButton _rbSortByType;
        private System.Windows.Forms.RadioButton _rbSortByOrder;
        private System.Windows.Forms.TextBox _tbInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNameDataGridViewTextBoxColumn;
    }
}