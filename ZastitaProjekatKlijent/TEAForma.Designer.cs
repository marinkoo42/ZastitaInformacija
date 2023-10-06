namespace ZastitaProjekatKlijent
{
    partial class TEAForma
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
            this.label3 = new System.Windows.Forms.Label();
            this.keyTbx = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.decryptRadio = new System.Windows.Forms.RadioButton();
            this.encryptRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameTbx = new System.Windows.Forms.TextBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unesite kljuc:";
            // 
            // keyTbx
            // 
            this.keyTbx.Location = new System.Drawing.Point(270, 190);
            this.keyTbx.Name = "keyTbx";
            this.keyTbx.Size = new System.Drawing.Size(231, 20);
            this.keyTbx.TabIndex = 16;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(338, 284);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 15;
            this.startBtn.Text = "Pokreni";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // decryptRadio
            // 
            this.decryptRadio.AutoSize = true;
            this.decryptRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptRadio.Location = new System.Drawing.Point(417, 229);
            this.decryptRadio.Name = "decryptRadio";
            this.decryptRadio.Size = new System.Drawing.Size(82, 21);
            this.decryptRadio.TabIndex = 14;
            this.decryptRadio.TabStop = true;
            this.decryptRadio.Text = "Dekriptuj";
            this.decryptRadio.UseVisualStyleBackColor = true;
            // 
            // encryptRadio
            // 
            this.encryptRadio.AutoSize = true;
            this.encryptRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptRadio.Location = new System.Drawing.Point(270, 229);
            this.encryptRadio.Name = "encryptRadio";
            this.encryptRadio.Size = new System.Drawing.Size(81, 21);
            this.encryptRadio.TabIndex = 13;
            this.encryptRadio.TabStop = true;
            this.encryptRadio.Text = "Enkriptuj";
            this.encryptRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Izaberite fajl:";
            // 
            // fileNameTbx
            // 
            this.fileNameTbx.Location = new System.Drawing.Point(270, 153);
            this.fileNameTbx.Name = "fileNameTbx";
            this.fileNameTbx.Size = new System.Drawing.Size(231, 20);
            this.fileNameTbx.TabIndex = 11;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(543, 150);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(99, 23);
            this.selectFileBtn.TabIndex = 10;
            this.selectFileBtn.Text = "Izaberite fajl...";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "TE Algoritam";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
            // 
            // TEAForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyTbx);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.decryptRadio);
            this.Controls.Add(this.encryptRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameTbx);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.label1);
            this.Name = "TEAForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEAForma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TEAForma_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyTbx;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.RadioButton decryptRadio;
        private System.Windows.Forms.RadioButton encryptRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNameTbx;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}