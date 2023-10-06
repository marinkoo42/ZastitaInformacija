namespace ZastitaProjekatKlijent
{
    partial class PocetnaForma
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
            this.rc4Button = new System.Windows.Forms.Button();
            this.enigmaButton = new System.Windows.Forms.Button();
            this.teaButton = new System.Windows.Forms.Button();
            this.cbcButton = new System.Windows.Forms.Button();
            this.crcBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite algoritam";
            // 
            // rc4Button
            // 
            this.rc4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rc4Button.Location = new System.Drawing.Point(128, 130);
            this.rc4Button.Name = "rc4Button";
            this.rc4Button.Size = new System.Drawing.Size(152, 88);
            this.rc4Button.TabIndex = 1;
            this.rc4Button.Text = "RC4";
            this.rc4Button.UseVisualStyleBackColor = true;
            this.rc4Button.Click += new System.EventHandler(this.rc4Button_Click);
            // 
            // enigmaButton
            // 
            this.enigmaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enigmaButton.Location = new System.Drawing.Point(491, 130);
            this.enigmaButton.Name = "enigmaButton";
            this.enigmaButton.Size = new System.Drawing.Size(152, 88);
            this.enigmaButton.TabIndex = 2;
            this.enigmaButton.Text = "Enigma";
            this.enigmaButton.UseVisualStyleBackColor = true;
            this.enigmaButton.Click += new System.EventHandler(this.enigmaButton_Click);
            // 
            // teaButton
            // 
            this.teaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teaButton.Location = new System.Drawing.Point(128, 248);
            this.teaButton.Name = "teaButton";
            this.teaButton.Size = new System.Drawing.Size(152, 88);
            this.teaButton.TabIndex = 3;
            this.teaButton.Text = "TEA";
            this.teaButton.UseVisualStyleBackColor = true;
            this.teaButton.Click += new System.EventHandler(this.teaButton_Click);
            // 
            // cbcButton
            // 
            this.cbcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcButton.Location = new System.Drawing.Point(491, 248);
            this.cbcButton.Name = "cbcButton";
            this.cbcButton.Size = new System.Drawing.Size(152, 88);
            this.cbcButton.TabIndex = 4;
            this.cbcButton.Text = "TEA CBC";
            this.cbcButton.UseVisualStyleBackColor = true;
            this.cbcButton.Click += new System.EventHandler(this.cbcButton_Click);
            // 
            // crcBtn
            // 
            this.crcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crcBtn.Location = new System.Drawing.Point(313, 162);
            this.crcBtn.Name = "crcBtn";
            this.crcBtn.Size = new System.Drawing.Size(152, 88);
            this.crcBtn.TabIndex = 5;
            this.crcBtn.Text = "CRC Test";
            this.crcBtn.UseVisualStyleBackColor = true;
            this.crcBtn.Click += new System.EventHandler(this.crcBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 88);
            this.button1.TabIndex = 6;
            this.button1.Text = "RC4 Parallel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crcBtn);
            this.Controls.Add(this.cbcButton);
            this.Controls.Add(this.teaButton);
            this.Controls.Add(this.enigmaButton);
            this.Controls.Add(this.rc4Button);
            this.Controls.Add(this.label1);
            this.Name = "PocetnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rc4Button;
        private System.Windows.Forms.Button enigmaButton;
        private System.Windows.Forms.Button teaButton;
        private System.Windows.Forms.Button cbcButton;
        private System.Windows.Forms.Button crcBtn;
        private System.Windows.Forms.Button button1;
    }
}

