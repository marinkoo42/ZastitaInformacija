namespace ZastitaProjekatKlijent
{
    partial class CRCTestForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.fileName1Tbx = new System.Windows.Forms.TextBox();
            this.fileName2Tbx = new System.Windows.Forms.TextBox();
            this.file1Btn = new System.Windows.Forms.Button();
            this.file2Btn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.file1Dialog = new System.Windows.Forms.OpenFileDialog();
            this.file2Dialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberi prvi fajl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izaberi drugi fajl:";
            // 
            // fileName1Tbx
            // 
            this.fileName1Tbx.Location = new System.Drawing.Point(306, 64);
            this.fileName1Tbx.Name = "fileName1Tbx";
            this.fileName1Tbx.Size = new System.Drawing.Size(212, 20);
            this.fileName1Tbx.TabIndex = 2;
            // 
            // fileName2Tbx
            // 
            this.fileName2Tbx.Location = new System.Drawing.Point(306, 128);
            this.fileName2Tbx.Name = "fileName2Tbx";
            this.fileName2Tbx.Size = new System.Drawing.Size(212, 20);
            this.fileName2Tbx.TabIndex = 3;
            // 
            // file1Btn
            // 
            this.file1Btn.Location = new System.Drawing.Point(553, 62);
            this.file1Btn.Name = "file1Btn";
            this.file1Btn.Size = new System.Drawing.Size(95, 23);
            this.file1Btn.TabIndex = 4;
            this.file1Btn.Text = "Izaberite fajl...";
            this.file1Btn.UseVisualStyleBackColor = true;
            this.file1Btn.Click += new System.EventHandler(this.file1Btn_Click);
            // 
            // file2Btn
            // 
            this.file2Btn.Location = new System.Drawing.Point(553, 126);
            this.file2Btn.Name = "file2Btn";
            this.file2Btn.Size = new System.Drawing.Size(95, 23);
            this.file2Btn.TabIndex = 5;
            this.file2Btn.Text = "Izaberite fajl...";
            this.file2Btn.UseVisualStyleBackColor = true;
            this.file2Btn.Click += new System.EventHandler(this.file2Btn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(353, 208);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(95, 23);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "Proveri";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultLbl);
            this.groupBox1.Location = new System.Drawing.Point(259, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(21, 41);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(66, 24);
            this.resultLbl.TabIndex = 8;
            this.resultLbl.Text = "label3";
            // 
            // file1Dialog
            // 
            this.file1Dialog.FileName = "openFileDialog1";
            this.file1Dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.file1Dialog_FileOk);
            // 
            // file2Dialog
            // 
            this.file2Dialog.FileName = "openFileDialog1";
            this.file2Dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.file2Dialog_FileOk);
            // 
            // CRCTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.file2Btn);
            this.Controls.Add(this.file1Btn);
            this.Controls.Add(this.fileName2Tbx);
            this.Controls.Add(this.fileName1Tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRCTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRCTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRCTestForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileName1Tbx;
        private System.Windows.Forms.TextBox fileName2Tbx;
        private System.Windows.Forms.Button file1Btn;
        private System.Windows.Forms.Button file2Btn;
        private System.Windows.Forms.Button checkBtn;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.OpenFileDialog file1Dialog;
        private System.Windows.Forms.OpenFileDialog file2Dialog;
    }
}