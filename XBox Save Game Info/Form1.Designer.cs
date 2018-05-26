namespace XBox_Save_Game_Info
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleMetaLabel = new System.Windows.Forms.Label();
            this.saveMetaLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.blockSizeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("1979", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "XBox Save Game Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title Meta: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Save Meta:";
            // 
            // titleMetaLabel
            // 
            this.titleMetaLabel.AutoSize = true;
            this.titleMetaLabel.Location = new System.Drawing.Point(79, 42);
            this.titleMetaLabel.Name = "titleMetaLabel";
            this.titleMetaLabel.Size = new System.Drawing.Size(122, 13);
            this.titleMetaLabel.TabIndex = 4;
            this.titleMetaLabel.Text = "No Save Game Loaded.";
            // 
            // saveMetaLabel
            // 
            this.saveMetaLabel.AutoSize = true;
            this.saveMetaLabel.Location = new System.Drawing.Point(79, 70);
            this.saveMetaLabel.Name = "saveMetaLabel";
            this.saveMetaLabel.Size = new System.Drawing.Size(122, 13);
            this.saveMetaLabel.TabIndex = 4;
            this.saveMetaLabel.Text = "No Save Game Loaded.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select Save Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Save to .txt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // blockSizeLabel
            // 
            this.blockSizeLabel.AutoSize = true;
            this.blockSizeLabel.Location = new System.Drawing.Point(79, 98);
            this.blockSizeLabel.Name = "blockSizeLabel";
            this.blockSizeLabel.Size = new System.Drawing.Size(122, 13);
            this.blockSizeLabel.TabIndex = 8;
            this.blockSizeLabel.Text = "No Save Game Loaded.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Block Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 151);
            this.Controls.Add(this.blockSizeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveMetaLabel);
            this.Controls.Add(this.titleMetaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XBox Save Game Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titleMetaLabel;
        private System.Windows.Forms.Label saveMetaLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label blockSizeLabel;
        private System.Windows.Forms.Label label5;
    }
}

