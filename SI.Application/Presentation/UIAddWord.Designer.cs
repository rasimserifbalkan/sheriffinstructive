namespace SI.App.Presentation
{
    partial class UiAddWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UiAddWord));
            this.label1 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.wordDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.lblSelectedWord = new System.Windows.Forms.Label();
            this.btnAddMeaning = new System.Windows.Forms.Button();
            this.btnEditWord = new System.Windows.Forms.Button();
            this.lblEditAlert = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddMeaningWord = new System.Windows.Forms.Button();
            this.meaningDataGridView = new System.Windows.Forms.DataGridView();
            this.btnEditMeaning = new System.Windows.Forms.Button();
            this.lblEditAlert2 = new System.Windows.Forms.Label();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnDeleteMeaning = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meaningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelime / Cümle";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(12, 60);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(438, 94);
            this.txtWord.TabIndex = 3;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(375, 160);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(75, 23);
            this.btnAddWord.TabIndex = 4;
            this.btnAddWord.Text = "Ekle";
            this.btnAddWord.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(41, 189);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(409, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // wordDataGridView
            // 
            this.wordDataGridView.AllowUserToAddRows = false;
            this.wordDataGridView.AllowUserToDeleteRows = false;
            this.wordDataGridView.AutoGenerateColumns = false;
            this.wordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.wordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.wordDataGridView.DataSource = this.wordBindingSource;
            this.wordDataGridView.Location = new System.Drawing.Point(12, 215);
            this.wordDataGridView.Name = "wordDataGridView";
            this.wordDataGridView.ReadOnly = true;
            this.wordDataGridView.Size = new System.Drawing.Size(438, 327);
            this.wordDataGridView.TabIndex = 7;
            this.wordDataGridView.SelectionChanged += new System.EventHandler(this.WordDataGridView_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kelime / Cümle Anlam";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Location = new System.Drawing.Point(456, 60);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(438, 94);
            this.txtMeaning.TabIndex = 9;
            // 
            // lblSelectedWord
            // 
            this.lblSelectedWord.AutoSize = true;
            this.lblSelectedWord.Location = new System.Drawing.Point(456, 199);
            this.lblSelectedWord.Name = "lblSelectedWord";
            this.lblSelectedWord.Size = new System.Drawing.Size(110, 13);
            this.lblSelectedWord.TabIndex = 8;
            this.lblSelectedWord.Text = "Kelime / Cümle Anlam";
            this.lblSelectedWord.Visible = false;
            // 
            // btnAddMeaning
            // 
            this.btnAddMeaning.Location = new System.Drawing.Point(819, 160);
            this.btnAddMeaning.Name = "btnAddMeaning";
            this.btnAddMeaning.Size = new System.Drawing.Size(75, 23);
            this.btnAddMeaning.TabIndex = 10;
            this.btnAddMeaning.Text = "Ekle";
            this.btnAddMeaning.UseVisualStyleBackColor = true;
            this.btnAddMeaning.Click += new System.EventHandler(this.BtnAddMeaning_Click);
            // 
            // btnEditWord
            // 
            this.btnEditWord.Location = new System.Drawing.Point(375, 548);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(75, 23);
            this.btnEditWord.TabIndex = 11;
            this.btnEditWord.Text = "Düzenle";
            this.btnEditWord.UseVisualStyleBackColor = true;
            this.btnEditWord.Click += new System.EventHandler(this.BtnEditWord_Click);
            // 
            // lblEditAlert
            // 
            this.lblEditAlert.AutoSize = true;
            this.lblEditAlert.ForeColor = System.Drawing.Color.Red;
            this.lblEditAlert.Location = new System.Drawing.Point(12, 160);
            this.lblEditAlert.Name = "lblEditAlert";
            this.lblEditAlert.Size = new System.Drawing.Size(68, 13);
            this.lblEditAlert.TabIndex = 12;
            this.lblEditAlert.Text = "Düzenleniyor";
            this.lblEditAlert.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ara";
            // 
            // btnAddMeaningWord
            // 
            this.btnAddMeaningWord.Location = new System.Drawing.Point(294, 548);
            this.btnAddMeaningWord.Name = "btnAddMeaningWord";
            this.btnAddMeaningWord.Size = new System.Drawing.Size(75, 23);
            this.btnAddMeaningWord.TabIndex = 14;
            this.btnAddMeaningWord.Text = "Anlam Ekle";
            this.btnAddMeaningWord.UseVisualStyleBackColor = true;
            this.btnAddMeaningWord.Click += new System.EventHandler(this.BtnAddMeaningWord_Click);
            // 
            // meaningDataGridView
            // 
            this.meaningDataGridView.AllowUserToAddRows = false;
            this.meaningDataGridView.AllowUserToDeleteRows = false;
            this.meaningDataGridView.AutoGenerateColumns = false;
            this.meaningDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.meaningDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meaningDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.meaningDataGridView.DataSource = this.meaningBindingSource;
            this.meaningDataGridView.Location = new System.Drawing.Point(459, 215);
            this.meaningDataGridView.Name = "meaningDataGridView";
            this.meaningDataGridView.ReadOnly = true;
            this.meaningDataGridView.Size = new System.Drawing.Size(435, 327);
            this.meaningDataGridView.TabIndex = 15;
            // 
            // btnEditMeaning
            // 
            this.btnEditMeaning.Location = new System.Drawing.Point(819, 548);
            this.btnEditMeaning.Name = "btnEditMeaning";
            this.btnEditMeaning.Size = new System.Drawing.Size(75, 23);
            this.btnEditMeaning.TabIndex = 16;
            this.btnEditMeaning.Text = "Düzenle";
            this.btnEditMeaning.UseVisualStyleBackColor = true;
            this.btnEditMeaning.Click += new System.EventHandler(this.BtnEditMeaning_Click);
            // 
            // lblEditAlert2
            // 
            this.lblEditAlert2.AutoSize = true;
            this.lblEditAlert2.ForeColor = System.Drawing.Color.Red;
            this.lblEditAlert2.Location = new System.Drawing.Point(456, 160);
            this.lblEditAlert2.Name = "lblEditAlert2";
            this.lblEditAlert2.Size = new System.Drawing.Size(68, 13);
            this.lblEditAlert2.TabIndex = 17;
            this.lblEditAlert2.Text = "Düzenleniyor";
            this.lblEditAlert2.Visible = false;
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Location = new System.Drawing.Point(12, 548);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteWord.TabIndex = 18;
            this.btnDeleteWord.Text = "Sil";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // btnDeleteMeaning
            // 
            this.btnDeleteMeaning.Location = new System.Drawing.Point(459, 548);
            this.btnDeleteMeaning.Name = "btnDeleteMeaning";
            this.btnDeleteMeaning.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMeaning.TabIndex = 19;
            this.btnDeleteMeaning.Text = "Sil";
            this.btnDeleteMeaning.UseVisualStyleBackColor = true;
            this.btnDeleteMeaning.Click += new System.EventHandler(this.BtnDeleteMeaning_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(921, 23);
            this.lblHeader.TabIndex = 20;
            this.lblHeader.Text = "KELİME VE ANLAM İŞLEMLERİ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MeaningWord";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kelime Cümle Anlamı";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // meaningBindingSource
            // 
            this.meaningBindingSource.DataSource = typeof(SI.App.Models.Meaning);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WordText";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kelime / Cümle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataSource = typeof(SI.App.Models.Word);
            // 
            // UiAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 595);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnDeleteMeaning);
            this.Controls.Add(this.btnDeleteWord);
            this.Controls.Add(this.lblEditAlert2);
            this.Controls.Add(this.btnEditMeaning);
            this.Controls.Add(this.meaningDataGridView);
            this.Controls.Add(this.btnAddMeaningWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEditAlert);
            this.Controls.Add(this.btnEditWord);
            this.Controls.Add(this.btnAddMeaning);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblSelectedWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordDataGridView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label1);
         
            this.Name = "UiAddWord";
          
            this.Text = "KELİME VE ANLAM İŞLEMLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.wordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private System.Windows.Forms.DataGridView wordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label lblSelectedWord;
        private System.Windows.Forms.Button btnAddMeaning;
        private System.Windows.Forms.Button btnEditWord;
        private System.Windows.Forms.Label lblEditAlert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddMeaningWord;
        private System.Windows.Forms.BindingSource meaningBindingSource;
        private System.Windows.Forms.DataGridView meaningDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnEditMeaning;
        private System.Windows.Forms.Label lblEditAlert2;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnDeleteMeaning;
        private System.Windows.Forms.Label lblHeader;
    }
}