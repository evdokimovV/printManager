namespace DocPrintManager
{
    partial class MainForm
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
            this._btnStopPrint = new System.Windows.Forms.Button();
            this._btnAddDoc = new System.Windows.Forms.Button();
            this._btnCancelPrint = new System.Windows.Forms.Button();
            this._btnGetPrintedDocs = new System.Windows.Forms.Button();
            this._btnGetAvgPrintTime = new System.Windows.Forms.Button();
            this._dgvDocs = new System.Windows.Forms.DataGridView();
            this.printTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bsDocs = new System.Windows.Forms.BindingSource(this.components);
            this._sbStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnStopPrint
            // 
            this._btnStopPrint.Location = new System.Drawing.Point(12, 41);
            this._btnStopPrint.Name = "_btnStopPrint";
            this._btnStopPrint.Size = new System.Drawing.Size(185, 23);
            this._btnStopPrint.TabIndex = 0;
            this._btnStopPrint.Text = "Стоп";
            this._btnStopPrint.UseVisualStyleBackColor = false;
            this._btnStopPrint.Click += new System.EventHandler(this._btnStopPrint_Click);
            // 
            // _btnAddDoc
            // 
            this._btnAddDoc.Location = new System.Drawing.Point(12, 70);
            this._btnAddDoc.Name = "_btnAddDoc";
            this._btnAddDoc.Size = new System.Drawing.Size(185, 23);
            this._btnAddDoc.TabIndex = 1;
            this._btnAddDoc.Text = "Добавить документ";
            this._btnAddDoc.UseVisualStyleBackColor = true;
            this._btnAddDoc.Click += new System.EventHandler(this._btnAddDoc_Click);
            // 
            // _btnCancelPrint
            // 
            this._btnCancelPrint.Location = new System.Drawing.Point(12, 99);
            this._btnCancelPrint.Name = "_btnCancelPrint";
            this._btnCancelPrint.Size = new System.Drawing.Size(185, 23);
            this._btnCancelPrint.TabIndex = 2;
            this._btnCancelPrint.Text = "Отменить печать";
            this._btnCancelPrint.UseVisualStyleBackColor = true;
            this._btnCancelPrint.Click += new System.EventHandler(this._btnCancelPrint_Click);
            // 
            // _btnGetPrintedDocs
            // 
            this._btnGetPrintedDocs.Location = new System.Drawing.Point(12, 157);
            this._btnGetPrintedDocs.Name = "_btnGetPrintedDocs";
            this._btnGetPrintedDocs.Size = new System.Drawing.Size(185, 23);
            this._btnGetPrintedDocs.TabIndex = 3;
            this._btnGetPrintedDocs.Text = "Напечатанные документы";
            this._btnGetPrintedDocs.UseVisualStyleBackColor = true;
            this._btnGetPrintedDocs.Click += new System.EventHandler(this._btnGetPrintedDocs_Click);
            // 
            // _btnGetAvgPrintTime
            // 
            this._btnGetAvgPrintTime.Location = new System.Drawing.Point(12, 128);
            this._btnGetAvgPrintTime.Name = "_btnGetAvgPrintTime";
            this._btnGetAvgPrintTime.Size = new System.Drawing.Size(185, 23);
            this._btnGetAvgPrintTime.TabIndex = 4;
            this._btnGetAvgPrintTime.Text = "Среднее время печати";
            this._btnGetAvgPrintTime.UseVisualStyleBackColor = true;
            this._btnGetAvgPrintTime.Click += new System.EventHandler(this._btnGetAvgPrintTime_Click);
            // 
            // _dgvDocs
            // 
            this._dgvDocs.AutoGenerateColumns = false;
            this._dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.printTimeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.listSizeDataGridViewTextBoxColumn,
            this.docNameDataGridViewTextBoxColumn});
            this._dgvDocs.DataSource = this._bsDocs;
            this._dgvDocs.Location = new System.Drawing.Point(203, 12);
            this._dgvDocs.Name = "_dgvDocs";
            this._dgvDocs.ReadOnly = true;
            this._dgvDocs.Size = new System.Drawing.Size(545, 426);
            this._dgvDocs.TabIndex = 5;
            // 
            // printTimeDataGridViewTextBoxColumn
            // 
            this.printTimeDataGridViewTextBoxColumn.DataPropertyName = "PrintTime";
            this.printTimeDataGridViewTextBoxColumn.HeaderText = "Время печати";
            this.printTimeDataGridViewTextBoxColumn.Name = "printTimeDataGridViewTextBoxColumn";
            this.printTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listSizeDataGridViewTextBoxColumn
            // 
            this.listSizeDataGridViewTextBoxColumn.DataPropertyName = "ListSize";
            this.listSizeDataGridViewTextBoxColumn.HeaderText = "Размер листа";
            this.listSizeDataGridViewTextBoxColumn.Name = "listSizeDataGridViewTextBoxColumn";
            this.listSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docNameDataGridViewTextBoxColumn
            // 
            this.docNameDataGridViewTextBoxColumn.DataPropertyName = "DocName";
            this.docNameDataGridViewTextBoxColumn.HeaderText = "Имя документа";
            this.docNameDataGridViewTextBoxColumn.Name = "docNameDataGridViewTextBoxColumn";
            this.docNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _bsDocs
            // 
            this._bsDocs.DataSource = typeof(DocPrintManager.ViewModels.DocumentGridItem);
            // 
            // _sbStart
            // 
            this._sbStart.Location = new System.Drawing.Point(12, 12);
            this._sbStart.Name = "_sbStart";
            this._sbStart.Size = new System.Drawing.Size(185, 23);
            this._sbStart.TabIndex = 6;
            this._sbStart.Text = "Старт";
            this._sbStart.UseVisualStyleBackColor = false;
            this._sbStart.Click += new System.EventHandler(this._sbStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this._sbStart);
            this.Controls.Add(this._dgvDocs);
            this.Controls.Add(this._btnGetAvgPrintTime);
            this.Controls.Add(this._btnGetPrintedDocs);
            this.Controls.Add(this._btnCancelPrint);
            this.Controls.Add(this._btnAddDoc);
            this.Controls.Add(this._btnStopPrint);
            this.Name = "MainForm";
            this.Text = "Диспетчер печати документов";
            ((System.ComponentModel.ISupportInitialize)(this._dgvDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsDocs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnStopPrint;
        private System.Windows.Forms.Button _btnAddDoc;
        private System.Windows.Forms.Button _btnCancelPrint;
        private System.Windows.Forms.Button _btnGetPrintedDocs;
        private System.Windows.Forms.Button _btnGetAvgPrintTime;
        private System.Windows.Forms.DataGridView _dgvDocs;
        private System.Windows.Forms.BindingSource _bsDocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn printTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button _sbStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNameDataGridViewTextBoxColumn;
    }
}

