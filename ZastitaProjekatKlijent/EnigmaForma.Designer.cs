namespace ZastitaProjekatKlijent
{
    partial class EnigmaForma
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
            this.startBtn = new System.Windows.Forms.Button();
            this.decryptRadio = new System.Windows.Forms.RadioButton();
            this.encryptRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameTbx = new System.Windows.Forms.TextBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rotor1Cbx = new System.Windows.Forms.ComboBox();
            this.rotor2Cbx = new System.Windows.Forms.ComboBox();
            this.rotor3Cbx = new System.Windows.Forms.ComboBox();
            this.ringVal1 = new System.Windows.Forms.NumericUpDown();
            this.ringVal2 = new System.Windows.Forms.NumericUpDown();
            this.ringVal3 = new System.Windows.Forms.NumericUpDown();
            this.enigmaKeyTbx = new System.Windows.Forms.TextBox();
            this.plugboardLbx = new System.Windows.Forms.ListBox();
            this.plugboardTbx = new System.Windows.Forms.TextBox();
            this.plugboardAddBtn = new System.Windows.Forms.Button();
            this.plugboardRemoveBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.reflectorCbx = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ringVal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringVal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringVal3)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(332, 336);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 24;
            this.startBtn.Text = "Pokreni";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // decryptRadio
            // 
            this.decryptRadio.AutoSize = true;
            this.decryptRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptRadio.Location = new System.Drawing.Point(411, 281);
            this.decryptRadio.Name = "decryptRadio";
            this.decryptRadio.Size = new System.Drawing.Size(82, 21);
            this.decryptRadio.TabIndex = 23;
            this.decryptRadio.TabStop = true;
            this.decryptRadio.Text = "Dekriptuj";
            this.decryptRadio.UseVisualStyleBackColor = true;
            // 
            // encryptRadio
            // 
            this.encryptRadio.AutoSize = true;
            this.encryptRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptRadio.Location = new System.Drawing.Point(264, 281);
            this.encryptRadio.Name = "encryptRadio";
            this.encryptRadio.Size = new System.Drawing.Size(81, 21);
            this.encryptRadio.TabIndex = 22;
            this.encryptRadio.TabStop = true;
            this.encryptRadio.Text = "Enkriptuj";
            this.encryptRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Izaberite fajl:";
            // 
            // fileNameTbx
            // 
            this.fileNameTbx.Location = new System.Drawing.Point(264, 232);
            this.fileNameTbx.Name = "fileNameTbx";
            this.fileNameTbx.Size = new System.Drawing.Size(231, 20);
            this.fileNameTbx.TabIndex = 20;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(537, 229);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(99, 23);
            this.selectFileBtn.TabIndex = 19;
            this.selectFileBtn.Text = "Izaberite fajl...";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "ENIGMA MACHINE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Rotor 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rotor 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Rotor 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kljuc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ringovi:";
            // 
            // rotor1Cbx
            // 
            this.rotor1Cbx.FormattingEnabled = true;
            this.rotor1Cbx.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.rotor1Cbx.Location = new System.Drawing.Point(114, 80);
            this.rotor1Cbx.Name = "rotor1Cbx";
            this.rotor1Cbx.Size = new System.Drawing.Size(68, 21);
            this.rotor1Cbx.TabIndex = 35;
            // 
            // rotor2Cbx
            // 
            this.rotor2Cbx.FormattingEnabled = true;
            this.rotor2Cbx.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.rotor2Cbx.Location = new System.Drawing.Point(114, 115);
            this.rotor2Cbx.Name = "rotor2Cbx";
            this.rotor2Cbx.Size = new System.Drawing.Size(68, 21);
            this.rotor2Cbx.TabIndex = 36;
            // 
            // rotor3Cbx
            // 
            this.rotor3Cbx.FormattingEnabled = true;
            this.rotor3Cbx.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.rotor3Cbx.Location = new System.Drawing.Point(114, 149);
            this.rotor3Cbx.Name = "rotor3Cbx";
            this.rotor3Cbx.Size = new System.Drawing.Size(68, 21);
            this.rotor3Cbx.TabIndex = 37;
            // 
            // ringVal1
            // 
            this.ringVal1.Location = new System.Drawing.Point(310, 116);
            this.ringVal1.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.ringVal1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ringVal1.Name = "ringVal1";
            this.ringVal1.Size = new System.Drawing.Size(35, 20);
            this.ringVal1.TabIndex = 38;
            this.ringVal1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ringVal2
            // 
            this.ringVal2.Location = new System.Drawing.Point(351, 116);
            this.ringVal2.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.ringVal2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ringVal2.Name = "ringVal2";
            this.ringVal2.Size = new System.Drawing.Size(35, 20);
            this.ringVal2.TabIndex = 39;
            this.ringVal2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ringVal3
            // 
            this.ringVal3.Location = new System.Drawing.Point(392, 116);
            this.ringVal3.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.ringVal3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ringVal3.Name = "ringVal3";
            this.ringVal3.Size = new System.Drawing.Size(35, 20);
            this.ringVal3.TabIndex = 40;
            this.ringVal3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // enigmaKeyTbx
            // 
            this.enigmaKeyTbx.Location = new System.Drawing.Point(310, 81);
            this.enigmaKeyTbx.Name = "enigmaKeyTbx";
            this.enigmaKeyTbx.Size = new System.Drawing.Size(117, 20);
            this.enigmaKeyTbx.TabIndex = 41;
            // 
            // plugboardLbx
            // 
            this.plugboardLbx.FormattingEnabled = true;
            this.plugboardLbx.Location = new System.Drawing.Point(668, 75);
            this.plugboardLbx.Name = "plugboardLbx";
            this.plugboardLbx.Size = new System.Drawing.Size(120, 95);
            this.plugboardLbx.TabIndex = 42;
            // 
            // plugboardTbx
            // 
            this.plugboardTbx.Location = new System.Drawing.Point(537, 80);
            this.plugboardTbx.Name = "plugboardTbx";
            this.plugboardTbx.Size = new System.Drawing.Size(65, 20);
            this.plugboardTbx.TabIndex = 43;
            // 
            // plugboardAddBtn
            // 
            this.plugboardAddBtn.Location = new System.Drawing.Point(616, 79);
            this.plugboardAddBtn.Name = "plugboardAddBtn";
            this.plugboardAddBtn.Size = new System.Drawing.Size(46, 23);
            this.plugboardAddBtn.TabIndex = 44;
            this.plugboardAddBtn.Text = ">";
            this.plugboardAddBtn.UseVisualStyleBackColor = true;
            this.plugboardAddBtn.Click += new System.EventHandler(this.plugboardAddBtn_Click);
            // 
            // plugboardRemoveBtn
            // 
            this.plugboardRemoveBtn.Location = new System.Drawing.Point(616, 118);
            this.plugboardRemoveBtn.Name = "plugboardRemoveBtn";
            this.plugboardRemoveBtn.Size = new System.Drawing.Size(46, 23);
            this.plugboardRemoveBtn.TabIndex = 45;
            this.plugboardRemoveBtn.Text = "<";
            this.plugboardRemoveBtn.UseVisualStyleBackColor = true;
            this.plugboardRemoveBtn.Click += new System.EventHandler(this.plugboardRemoveBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Plugboard:";
            // 
            // reflectorCbx
            // 
            this.reflectorCbx.FormattingEnabled = true;
            this.reflectorCbx.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.reflectorCbx.Location = new System.Drawing.Point(310, 152);
            this.reflectorCbx.Name = "reflectorCbx";
            this.reflectorCbx.Size = new System.Drawing.Size(68, 21);
            this.reflectorCbx.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Reflektor:";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialogName";
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // EnigmaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reflectorCbx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.plugboardRemoveBtn);
            this.Controls.Add(this.plugboardAddBtn);
            this.Controls.Add(this.plugboardTbx);
            this.Controls.Add(this.plugboardLbx);
            this.Controls.Add(this.enigmaKeyTbx);
            this.Controls.Add(this.ringVal3);
            this.Controls.Add(this.ringVal2);
            this.Controls.Add(this.ringVal1);
            this.Controls.Add(this.rotor3Cbx);
            this.Controls.Add(this.rotor2Cbx);
            this.Controls.Add(this.rotor1Cbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.decryptRadio);
            this.Controls.Add(this.encryptRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameTbx);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.label1);
            this.Name = "EnigmaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnigmaForma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnigmaForma_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ringVal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringVal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringVal3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.RadioButton decryptRadio;
        private System.Windows.Forms.RadioButton encryptRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNameTbx;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox rotor1Cbx;
        private System.Windows.Forms.ComboBox rotor2Cbx;
        private System.Windows.Forms.ComboBox rotor3Cbx;
        private System.Windows.Forms.NumericUpDown ringVal1;
        private System.Windows.Forms.NumericUpDown ringVal2;
        private System.Windows.Forms.NumericUpDown ringVal3;
        private System.Windows.Forms.TextBox enigmaKeyTbx;
        private System.Windows.Forms.ListBox plugboardLbx;
        private System.Windows.Forms.TextBox plugboardTbx;
        private System.Windows.Forms.Button plugboardAddBtn;
        private System.Windows.Forms.Button plugboardRemoveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox reflectorCbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}