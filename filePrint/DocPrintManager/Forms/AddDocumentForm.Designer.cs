namespace DocPrintManager.Forms
{
    partial class AddDocumentForm
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
            this._lblPaperSize = new System.Windows.Forms.Label();
            this._lblPrintTime = new System.Windows.Forms.Label();
            this._lblDocType = new System.Windows.Forms.Label();
            this._lblSecUnit = new System.Windows.Forms.Label();
            this._clbDocType = new System.Windows.Forms.CheckedListBox();
            this._sbSave = new System.Windows.Forms.Button();
            this._sbCancel = new System.Windows.Forms.Button();
            this._tbListSize = new System.Windows.Forms.TextBox();
            this._tbPrintTime = new System.Windows.Forms.TextBox();
            this._tbDocName = new System.Windows.Forms.TextBox();
            this._lblDocName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblPaperSize
            // 
            this._lblPaperSize.AutoSize = true;
            this._lblPaperSize.Location = new System.Drawing.Point(182, 11);
            this._lblPaperSize.Name = "_lblPaperSize";
            this._lblPaperSize.Size = new System.Drawing.Size(78, 13);
            this._lblPaperSize.TabIndex = 2;
            this._lblPaperSize.Text = "Размер листа";
            // 
            // _lblPrintTime
            // 
            this._lblPrintTime.AutoSize = true;
            this._lblPrintTime.Location = new System.Drawing.Point(266, 11);
            this._lblPrintTime.Name = "_lblPrintTime";
            this._lblPrintTime.Size = new System.Drawing.Size(148, 13);
            this._lblPrintTime.TabIndex = 3;
            this._lblPrintTime.Text = "Продолжительность печати";
            // 
            // _lblDocType
            // 
            this._lblDocType.AutoSize = true;
            this._lblDocType.Location = new System.Drawing.Point(9, 11);
            this._lblDocType.Name = "_lblDocType";
            this._lblDocType.Size = new System.Drawing.Size(83, 13);
            this._lblDocType.TabIndex = 4;
            this._lblDocType.Text = "Тип документа";
            // 
            // _lblSecUnit
            // 
            this._lblSecUnit.AutoSize = true;
            this._lblSecUnit.Location = new System.Drawing.Point(303, 37);
            this._lblSecUnit.Name = "_lblSecUnit";
            this._lblSecUnit.Size = new System.Drawing.Size(28, 13);
            this._lblSecUnit.TabIndex = 7;
            this._lblSecUnit.Text = "сек.";
            // 
            // _clbDocType
            // 
            this._clbDocType.FormattingEnabled = true;
            this._clbDocType.Items.AddRange(new object[] {
            ""});
            this._clbDocType.Location = new System.Drawing.Point(12, 34);
            this._clbDocType.Name = "_clbDocType";
            this._clbDocType.Size = new System.Drawing.Size(80, 79);
            this._clbDocType.TabIndex = 9;
            this._clbDocType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this._clbDocType_ItemCheck);
            // 
            // _sbSave
            // 
            this._sbSave.Enabled = false;
            this._sbSave.Location = new System.Drawing.Point(256, 90);
            this._sbSave.Name = "_sbSave";
            this._sbSave.Size = new System.Drawing.Size(75, 23);
            this._sbSave.TabIndex = 10;
            this._sbSave.Text = "Добавить";
            this._sbSave.UseVisualStyleBackColor = true;
            this._sbSave.Click += new System.EventHandler(this._sbSave_Click);
            // 
            // _sbCancel
            // 
            this._sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._sbCancel.Location = new System.Drawing.Point(339, 90);
            this._sbCancel.Name = "_sbCancel";
            this._sbCancel.Size = new System.Drawing.Size(75, 23);
            this._sbCancel.TabIndex = 11;
            this._sbCancel.Text = "Отмена";
            this._sbCancel.UseVisualStyleBackColor = true;
            // 
            // _tbListSize
            // 
            this._tbListSize.Location = new System.Drawing.Point(185, 34);
            this._tbListSize.Name = "_tbListSize";
            this._tbListSize.ReadOnly = true;
            this._tbListSize.Size = new System.Drawing.Size(34, 20);
            this._tbListSize.TabIndex = 12;
            // 
            // _tbPrintTime
            // 
            this._tbPrintTime.Location = new System.Drawing.Point(269, 34);
            this._tbPrintTime.Name = "_tbPrintTime";
            this._tbPrintTime.ReadOnly = true;
            this._tbPrintTime.Size = new System.Drawing.Size(28, 20);
            this._tbPrintTime.TabIndex = 13;
            // 
            // _tbDocName
            // 
            this._tbDocName.Location = new System.Drawing.Point(98, 34);
            this._tbDocName.Name = "_tbDocName";
            this._tbDocName.Size = new System.Drawing.Size(78, 20);
            this._tbDocName.TabIndex = 14;
            // 
            // _lblDocName
            // 
            this._lblDocName.AutoSize = true;
            this._lblDocName.Location = new System.Drawing.Point(98, 13);
            this._lblDocName.Name = "_lblDocName";
            this._lblDocName.Size = new System.Drawing.Size(29, 13);
            this._lblDocName.TabIndex = 15;
            this._lblDocName.Text = "Имя";
            // 
            // AddDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 135);
            this.Controls.Add(this._lblDocName);
            this.Controls.Add(this._tbDocName);
            this.Controls.Add(this._tbPrintTime);
            this.Controls.Add(this._tbListSize);
            this.Controls.Add(this._sbCancel);
            this.Controls.Add(this._sbSave);
            this.Controls.Add(this._clbDocType);
            this.Controls.Add(this._lblSecUnit);
            this.Controls.Add(this._lblDocType);
            this.Controls.Add(this._lblPrintTime);
            this.Controls.Add(this._lblPaperSize);
            this.Name = "AddDocumentForm";
            this.Text = "Добавление документа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lblPaperSize;
        private System.Windows.Forms.Label _lblPrintTime;
        private System.Windows.Forms.Label _lblDocType;
        private System.Windows.Forms.Label _lblSecUnit;
        private System.Windows.Forms.CheckedListBox _clbDocType;
        private System.Windows.Forms.Button _sbSave;
        private System.Windows.Forms.Button _sbCancel;
        private System.Windows.Forms.TextBox _tbListSize;
        private System.Windows.Forms.TextBox _tbPrintTime;
        private System.Windows.Forms.TextBox _tbDocName;
        private System.Windows.Forms.Label _lblDocName;
    }
}