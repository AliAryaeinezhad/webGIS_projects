namespace Media_Counter
{
    partial class MediaCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaCounter));
            this.ChoosButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.HintLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChoosButton
            // 
            this.ChoosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChoosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChoosButton.Location = new System.Drawing.Point(484, 49);
            this.ChoosButton.Name = "ChoosButton";
            this.ChoosButton.Size = new System.Drawing.Size(257, 133);
            this.ChoosButton.TabIndex = 1;
            this.ChoosButton.Text = "Choose File";
            this.ChoosButton.UseVisualStyleBackColor = false;
            this.ChoosButton.Click += new System.EventHandler(this.btn_resualt_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PathLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PathLabel.Location = new System.Drawing.Point(40, 198);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(701, 214);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Text = "Directory:";
            this.PathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.Lime;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(484, 431);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(257, 133);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // HintLabel
            // 
            this.HintLabel.BackColor = System.Drawing.Color.Silver;
            this.HintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HintLabel.Location = new System.Drawing.Point(39, 49);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(422, 133);
            this.HintLabel.TabIndex = 0;
            this.HintLabel.Text = "Please Choose a XML File:";
            this.HintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImageLabel
            // 
            this.ImageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ImageLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLabel.Location = new System.Drawing.Point(37, 431);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(424, 133);
            this.ImageLabel.TabIndex = 3;
            this.ImageLabel.Text = "Image Tag <img>:";
            this.ImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MediaCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(781, 625);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ChoosButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaCounter";
            this.Text = "Media Counter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChoosButton;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Label ImageLabel;
    }
}

