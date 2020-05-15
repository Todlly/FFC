namespace FFCwinforms
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
            this.loadImage = new System.Windows.Forms.Button();
            this.rawPanel = new System.Windows.Forms.Panel();
            this.darkPanel = new System.Windows.Forms.Panel();
            this.loadDarkButton = new System.Windows.Forms.Button();
            this.loadFlatButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flatPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.correctedPanel = new System.Windows.Forms.Panel();
            this.correctButton = new System.Windows.Forms.Button();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.updateSizeButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.updateIntervalButton = new System.Windows.Forms.Button();
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.updatePixelSizeButton = new System.Windows.Forms.Button();
            this.pixelSizeBox = new System.Windows.Forms.TextBox();
            this.pixelSizeLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadImage
            // 
            this.loadImage.Location = new System.Drawing.Point(21, 622);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(75, 23);
            this.loadImage.TabIndex = 0;
            this.loadImage.Text = "Load raw";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // rawPanel
            // 
            this.rawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rawPanel.Location = new System.Drawing.Point(12, 28);
            this.rawPanel.Name = "rawPanel";
            this.rawPanel.Size = new System.Drawing.Size(260, 260);
            this.rawPanel.TabIndex = 1;
            // 
            // darkPanel
            // 
            this.darkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkPanel.Location = new System.Drawing.Point(13, 310);
            this.darkPanel.Name = "darkPanel";
            this.darkPanel.Size = new System.Drawing.Size(259, 260);
            this.darkPanel.TabIndex = 2;
            // 
            // loadDarkButton
            // 
            this.loadDarkButton.Location = new System.Drawing.Point(102, 622);
            this.loadDarkButton.Name = "loadDarkButton";
            this.loadDarkButton.Size = new System.Drawing.Size(75, 23);
            this.loadDarkButton.TabIndex = 3;
            this.loadDarkButton.Text = "Load dark";
            this.loadDarkButton.UseVisualStyleBackColor = true;
            this.loadDarkButton.Click += new System.EventHandler(this.loadDarkButton_Click);
            // 
            // loadFlatButton
            // 
            this.loadFlatButton.Location = new System.Drawing.Point(183, 622);
            this.loadFlatButton.Name = "loadFlatButton";
            this.loadFlatButton.Size = new System.Drawing.Size(75, 23);
            this.loadFlatButton.TabIndex = 4;
            this.loadFlatButton.Text = "Load flat";
            this.loadFlatButton.UseVisualStyleBackColor = true;
            this.loadFlatButton.Click += new System.EventHandler(this.loadFlatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dark frame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Flat frame";
            // 
            // flatPanel
            // 
            this.flatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flatPanel.Location = new System.Drawing.Point(282, 310);
            this.flatPanel.Name = "flatPanel";
            this.flatPanel.Size = new System.Drawing.Size(260, 260);
            this.flatPanel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Corrected image";
            // 
            // correctedPanel
            // 
            this.correctedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correctedPanel.Location = new System.Drawing.Point(282, 28);
            this.correctedPanel.Name = "correctedPanel";
            this.correctedPanel.Size = new System.Drawing.Size(260, 260);
            this.correctedPanel.TabIndex = 9;
            // 
            // correctButton
            // 
            this.correctButton.Location = new System.Drawing.Point(264, 622);
            this.correctButton.Name = "correctButton";
            this.correctButton.Size = new System.Drawing.Size(75, 23);
            this.correctButton.TabIndex = 10;
            this.correctButton.Text = "Correct";
            this.correctButton.UseVisualStyleBackColor = true;
            this.correctButton.Click += new System.EventHandler(this.correctButton_Click);
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(345, 596);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(75, 20);
            this.sizeBox.TabIndex = 11;
            // 
            // updateSizeButton
            // 
            this.updateSizeButton.Location = new System.Drawing.Point(345, 622);
            this.updateSizeButton.Name = "updateSizeButton";
            this.updateSizeButton.Size = new System.Drawing.Size(75, 23);
            this.updateSizeButton.TabIndex = 12;
            this.updateSizeButton.Text = "Update size";
            this.updateSizeButton.UseVisualStyleBackColor = true;
            this.updateSizeButton.Click += new System.EventHandler(this.updateSizeButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(342, 580);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(42, 13);
            this.sizeLabel.TabIndex = 13;
            this.sizeLabel.Text = "Size 30";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(423, 580);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(51, 13);
            this.intervalLabel.TabIndex = 14;
            this.intervalLabel.Text = "Interval 1";
            // 
            // updateIntervalButton
            // 
            this.updateIntervalButton.Location = new System.Drawing.Point(426, 622);
            this.updateIntervalButton.Name = "updateIntervalButton";
            this.updateIntervalButton.Size = new System.Drawing.Size(88, 23);
            this.updateIntervalButton.TabIndex = 16;
            this.updateIntervalButton.Text = "Update interval";
            this.updateIntervalButton.UseVisualStyleBackColor = true;
            this.updateIntervalButton.Click += new System.EventHandler(this.updateIntervalButton_Click);
            // 
            // intervalBox
            // 
            this.intervalBox.Location = new System.Drawing.Point(426, 596);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(88, 20);
            this.intervalBox.TabIndex = 15;
            // 
            // updatePixelSizeButton
            // 
            this.updatePixelSizeButton.Location = new System.Drawing.Point(520, 622);
            this.updatePixelSizeButton.Name = "updatePixelSizeButton";
            this.updatePixelSizeButton.Size = new System.Drawing.Size(96, 23);
            this.updatePixelSizeButton.TabIndex = 19;
            this.updatePixelSizeButton.Text = "Update pixel size";
            this.updatePixelSizeButton.UseVisualStyleBackColor = true;
            this.updatePixelSizeButton.Click += new System.EventHandler(this.updatePixelSizeButton_Click);
            // 
            // pixelSizeBox
            // 
            this.pixelSizeBox.Location = new System.Drawing.Point(520, 596);
            this.pixelSizeBox.Name = "pixelSizeBox";
            this.pixelSizeBox.Size = new System.Drawing.Size(96, 20);
            this.pixelSizeBox.TabIndex = 18;
            // 
            // pixelSizeLabel
            // 
            this.pixelSizeLabel.AutoSize = true;
            this.pixelSizeLabel.Location = new System.Drawing.Point(517, 580);
            this.pixelSizeLabel.Name = "pixelSizeLabel";
            this.pixelSizeLabel.Size = new System.Drawing.Size(59, 13);
            this.pixelSizeLabel.TabIndex = 17;
            this.pixelSizeLabel.Text = "Pixel size 8";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(622, 622);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 20;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 674);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.updatePixelSizeButton);
            this.Controls.Add(this.pixelSizeBox);
            this.Controls.Add(this.pixelSizeLabel);
            this.Controls.Add(this.updateIntervalButton);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.updateSizeButton);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.correctButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.correctedPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flatPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadFlatButton);
            this.Controls.Add(this.loadDarkButton);
            this.Controls.Add(this.darkPanel);
            this.Controls.Add(this.rawPanel);
            this.Controls.Add(this.loadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Panel rawPanel;
        private System.Windows.Forms.Panel darkPanel;
        private System.Windows.Forms.Button loadDarkButton;
        private System.Windows.Forms.Button loadFlatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel flatPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel correctedPanel;
        private System.Windows.Forms.Button correctButton;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.Button updateSizeButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Button updateIntervalButton;
        private System.Windows.Forms.TextBox intervalBox;
        private System.Windows.Forms.Button updatePixelSizeButton;
        private System.Windows.Forms.TextBox pixelSizeBox;
        private System.Windows.Forms.Label pixelSizeLabel;
        private System.Windows.Forms.Button exportButton;
    }
}

