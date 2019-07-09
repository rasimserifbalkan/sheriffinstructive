namespace SI.App.Presentation
{
    partial class UISettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.numQuestionSecondLimit = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.numScreenSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.chkPlayQuestion = new System.Windows.Forms.CheckBox();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPlayAnswer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionSecondLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru Sorma Aralığı (Saniye)";
            // 
            // numQuestionSecondLimit
            // 
            this.numQuestionSecondLimit.Location = new System.Drawing.Point(152, 35);
            this.numQuestionSecondLimit.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numQuestionSecondLimit.Name = "numQuestionSecondLimit";
            this.numQuestionSecondLimit.Size = new System.Drawing.Size(120, 20);
            this.numQuestionSecondLimit.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // numScreenSize
            // 
            this.numScreenSize.Location = new System.Drawing.Point(152, 61);
            this.numScreenSize.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numScreenSize.Name = "numScreenSize";
            this.numScreenSize.Size = new System.Drawing.Size(120, 20);
            this.numScreenSize.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soru Ekran Genişliği";
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(399, 23);
            this.lblHeader.TabIndex = 23;
            this.lblHeader.Text = "AYARLAR";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkPlayQuestion
            // 
            this.chkPlayQuestion.AutoSize = true;
            this.chkPlayQuestion.Checked = true;
            this.chkPlayQuestion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlayQuestion.Location = new System.Drawing.Point(152, 113);
            this.chkPlayQuestion.Name = "chkPlayQuestion";
            this.chkPlayQuestion.Size = new System.Drawing.Size(234, 17);
            this.chkPlayQuestion.TabIndex = 24;
            this.chkPlayQuestion.Text = "Soru Ekranı Geldiğinde Soruyu İngilizce Oku";
            this.chkPlayQuestion.UseVisualStyleBackColor = true;
            // 
            // numOpacity
            // 
            this.numOpacity.Location = new System.Drawing.Point(152, 87);
            this.numOpacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.Size = new System.Drawing.Size(120, 20);
            this.numOpacity.TabIndex = 26;
            this.numOpacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Soru Ekranının Saydanlığı";
            // 
            // chkPlayAnswer
            // 
            this.chkPlayAnswer.AutoSize = true;
            this.chkPlayAnswer.Location = new System.Drawing.Point(152, 136);
            this.chkPlayAnswer.Name = "chkPlayAnswer";
            this.chkPlayAnswer.Size = new System.Drawing.Size(188, 17);
            this.chkPlayAnswer.TabIndex = 27;
            this.chkPlayAnswer.Text = "Cevaplara Tıklandığında Sesli Oku";
            this.chkPlayAnswer.UseVisualStyleBackColor = true;
            // 
            // UISettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkPlayAnswer);
            this.Controls.Add(this.numOpacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPlayQuestion);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.numScreenSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numQuestionSecondLimit);
            this.Controls.Add(this.label1);
            this.Name = "UISettings";
            this.Size = new System.Drawing.Size(399, 195);
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionSecondLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numQuestionSecondLimit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numScreenSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.CheckBox chkPlayQuestion;
        private System.Windows.Forms.NumericUpDown numOpacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPlayAnswer;
    }
}