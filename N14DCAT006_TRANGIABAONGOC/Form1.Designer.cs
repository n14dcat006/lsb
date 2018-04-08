namespace N14DCAT006_TRANGIABAONGOC
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.encodeSaveFile = new System.Windows.Forms.Button();
            this.buttonEmbed = new System.Windows.Forms.Button();
            this.textEncode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encodeOpenFile = new System.Windows.Forms.Button();
            this.afterImage = new System.Windows.Forms.PictureBox();
            this.beforeImage = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textExtract = new System.Windows.Forms.TextBox();
            this.imageDecode = new System.Windows.Forms.PictureBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.decodeOpenFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDecode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 399);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.encodeSaveFile);
            this.tabPage1.Controls.Add(this.buttonEmbed);
            this.tabPage1.Controls.Add(this.textEncode);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.encodeOpenFile);
            this.tabPage1.Controls.Add(this.afterImage);
            this.tabPage1.Controls.Add(this.beforeImage);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encode";
            // 
            // encodeSaveFile
            // 
            this.encodeSaveFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeSaveFile.Location = new System.Drawing.Point(352, 232);
            this.encodeSaveFile.Name = "encodeSaveFile";
            this.encodeSaveFile.Size = new System.Drawing.Size(68, 26);
            this.encodeSaveFile.TabIndex = 11;
            this.encodeSaveFile.Text = "Save";
            this.encodeSaveFile.UseVisualStyleBackColor = true;
            this.encodeSaveFile.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEmbed
            // 
            this.buttonEmbed.Location = new System.Drawing.Point(414, 295);
            this.buttonEmbed.Name = "buttonEmbed";
            this.buttonEmbed.Size = new System.Drawing.Size(94, 26);
            this.buttonEmbed.TabIndex = 9;
            this.buttonEmbed.Text = "Embed";
            this.buttonEmbed.UseVisualStyleBackColor = true;
            this.buttonEmbed.Click += new System.EventHandler(this.hiddenSecret_Click);
            // 
            // textEncode
            // 
            this.textEncode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEncode.Location = new System.Drawing.Point(18, 296);
            this.textEncode.Name = "textEncode";
            this.textEncode.Size = new System.Drawing.Size(390, 26);
            this.textEncode.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(14, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message";
            // 
            // encodeOpenFile
            // 
            this.encodeOpenFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeOpenFile.Location = new System.Drawing.Point(81, 232);
            this.encodeOpenFile.Name = "encodeOpenFile";
            this.encodeOpenFile.Size = new System.Drawing.Size(95, 29);
            this.encodeOpenFile.TabIndex = 6;
            this.encodeOpenFile.Text = "Open Image";
            this.encodeOpenFile.UseVisualStyleBackColor = true;
            this.encodeOpenFile.Click += new System.EventHandler(this.encodeOpenFile_Click);
            // 
            // afterImage
            // 
            this.afterImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.afterImage.Location = new System.Drawing.Point(274, 25);
            this.afterImage.Name = "afterImage";
            this.afterImage.Size = new System.Drawing.Size(234, 201);
            this.afterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.afterImage.TabIndex = 2;
            this.afterImage.TabStop = false;
            // 
            // beforeImage
            // 
            this.beforeImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.beforeImage.Location = new System.Drawing.Point(18, 25);
            this.beforeImage.Name = "beforeImage";
            this.beforeImage.Size = new System.Drawing.Size(234, 201);
            this.beforeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.beforeImage.TabIndex = 0;
            this.beforeImage.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textExtract);
            this.tabPage2.Controls.Add(this.imageDecode);
            this.tabPage2.Controls.Add(this.buttonExtract);
            this.tabPage2.Controls.Add(this.decodeOpenFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Message";
            // 
            // textExtract
            // 
            this.textExtract.Location = new System.Drawing.Point(9, 313);
            this.textExtract.Name = "textExtract";
            this.textExtract.Size = new System.Drawing.Size(350, 26);
            this.textExtract.TabIndex = 6;
            // 
            // imageDecode
            // 
            this.imageDecode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imageDecode.Location = new System.Drawing.Point(9, 30);
            this.imageDecode.Name = "imageDecode";
            this.imageDecode.Size = new System.Drawing.Size(234, 201);
            this.imageDecode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDecode.TabIndex = 5;
            this.imageDecode.TabStop = false;
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(365, 313);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(115, 26);
            this.buttonExtract.TabIndex = 3;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.giaiMa_Click);
            // 
            // decodeOpenFile
            // 
            this.decodeOpenFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeOpenFile.Location = new System.Drawing.Point(65, 237);
            this.decodeOpenFile.Name = "decodeOpenFile";
            this.decodeOpenFile.Size = new System.Drawing.Size(113, 28);
            this.decodeOpenFile.TabIndex = 2;
            this.decodeOpenFile.Text = "Open Image";
            this.decodeOpenFile.UseVisualStyleBackColor = true;
            this.decodeOpenFile.Click += new System.EventHandler(this.decodeOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(544, 391);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Image Steganography - LSB";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDecode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox afterImage;
        private System.Windows.Forms.PictureBox beforeImage;
        private System.Windows.Forms.Button encodeOpenFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEncode;
        private System.Windows.Forms.Button buttonEmbed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textExtract;
        private System.Windows.Forms.PictureBox imageDecode;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Button decodeOpenFile;
        private System.Windows.Forms.Button encodeSaveFile;
    }
}

