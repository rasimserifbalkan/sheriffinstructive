namespace SI.App.Presentation
{
    partial class UiListSet
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
            this.setDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnListWord = new System.Windows.Forms.Button();
            this.btnStartLearn = new System.Windows.Forms.Button();
            this.timerStartLearn = new System.Windows.Forms.Timer(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMemorization = new System.Windows.Forms.Button();
            this.brnSetImport = new System.Windows.Forms.Button();
            this.brnSetExport = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.setDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // setDataGridView
            // 
            this.setDataGridView.AllowUserToAddRows = false;
            this.setDataGridView.AllowUserToDeleteRows = false;
            this.setDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setDataGridView.AutoGenerateColumns = false;
            this.setDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.setDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.setDataGridView.DataSource = this.setBindingSource;
            this.setDataGridView.Location = new System.Drawing.Point(12, 26);
            this.setDataGridView.Name = "setDataGridView";
            this.setDataGridView.ReadOnly = true;
            this.setDataGridView.Size = new System.Drawing.Size(776, 347);
            this.setDataGridView.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(662, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(728, 379);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnListWord
            // 
            this.btnListWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnListWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListWord.Location = new System.Drawing.Point(144, 408);
            this.btnListWord.Name = "btnListWord";
            this.btnListWord.Size = new System.Drawing.Size(165, 23);
            this.btnListWord.TabIndex = 6;
            this.btnListWord.Text = "Kelime İşlemleri";
            this.btnListWord.UseVisualStyleBackColor = true;
            this.btnListWord.Click += new System.EventHandler(this.btnListWord_Click);
            // 
            // btnStartLearn
            // 
            this.btnStartLearn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartLearn.Location = new System.Drawing.Point(12, 379);
            this.btnStartLearn.Name = "btnStartLearn";
            this.btnStartLearn.Size = new System.Drawing.Size(126, 52);
            this.btnStartLearn.TabIndex = 7;
            this.btnStartLearn.Text = "Seti Başlat";
            this.btnStartLearn.UseVisualStyleBackColor = true;
            this.btnStartLearn.Click += new System.EventHandler(this.BtnStartLearn_Click);
            // 
            // timerStartLearn
            // 
            this.timerStartLearn.Tick += new System.EventHandler(this.TimerStartLearn_Tick);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(800, 23);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "KELİME VE ANLAM İŞLEMLERİ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMemorization
            // 
            this.btnMemorization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMemorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMemorization.Location = new System.Drawing.Point(144, 379);
            this.btnMemorization.Name = "btnMemorization";
            this.btnMemorization.Size = new System.Drawing.Size(165, 23);
            this.btnMemorization.TabIndex = 22;
            this.btnMemorization.Text = "Bu Sette Ezberlediklerim";
            this.btnMemorization.UseVisualStyleBackColor = true;
            this.btnMemorization.Click += new System.EventHandler(this.BtnMemorization_Click);
            // 
            // brnSetImport
            // 
            this.brnSetImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brnSetImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brnSetImport.Location = new System.Drawing.Point(315, 379);
            this.brnSetImport.Name = "brnSetImport";
            this.brnSetImport.Size = new System.Drawing.Size(124, 23);
            this.brnSetImport.TabIndex = 22;
            this.brnSetImport.Text = "İçeri Set Aktar";
            this.brnSetImport.UseVisualStyleBackColor = true;
            this.brnSetImport.Click += new System.EventHandler(this.BrnSetImport_Click);
            // 
            // brnSetExport
            // 
            this.brnSetExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brnSetExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brnSetExport.Location = new System.Drawing.Point(315, 408);
            this.brnSetExport.Name = "brnSetExport";
            this.brnSetExport.Size = new System.Drawing.Size(124, 23);
            this.brnSetExport.TabIndex = 23;
            this.brnSetExport.Text = "Dışarı Set Aktar";
            this.brnSetExport.UseVisualStyleBackColor = true;
            this.brnSetExport.Click += new System.EventHandler(this.BrnSetExport_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "SET";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // setBindingSource
            // 
            this.setBindingSource.DataSource = typeof(SI.App.Models.Set);
            // 
            // UiListSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.brnSetExport);
            this.Controls.Add(this.brnSetImport);
            this.Controls.Add(this.btnMemorization);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnStartLearn);
            this.Controls.Add(this.btnListWord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.setDataGridView);
            this.Name = "UiListSet";
            this.Size = new System.Drawing.Size(800, 452);
            ((System.ComponentModel.ISupportInitialize)(this.setDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource setBindingSource;
        private System.Windows.Forms.DataGridView setDataGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnListWord;
        private System.Windows.Forms.Button btnStartLearn;
        private System.Windows.Forms.Timer timerStartLearn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMemorization;
        private System.Windows.Forms.Button brnSetImport;
        private System.Windows.Forms.Button brnSetExport;
    }
}