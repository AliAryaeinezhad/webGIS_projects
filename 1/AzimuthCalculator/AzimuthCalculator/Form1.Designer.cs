namespace AzimuthCalculator
{
    partial class azimuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(azimuth));
            this.first = new System.Windows.Forms.Label();
            this.lat1label = new System.Windows.Forms.Label();
            this.long1label = new System.Windows.Forms.Label();
            this.coor = new System.Windows.Forms.Label();
            this.lat1 = new System.Windows.Forms.TextBox();
            this.long1 = new System.Windows.Forms.TextBox();
            this.deg1 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.deg2 = new System.Windows.Forms.Label();
            this.deg4 = new System.Windows.Forms.Label();
            this.deg3 = new System.Windows.Forms.Label();
            this.long2 = new System.Windows.Forms.TextBox();
            this.lat2 = new System.Windows.Forms.TextBox();
            this.long2label = new System.Windows.Forms.Label();
            this.lat2label = new System.Windows.Forms.Label();
            this.scond = new System.Windows.Forms.Label();
            this.deg5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.Location = new System.Drawing.Point(19, 76);
            this.first.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(450, 254);
            this.first.TabIndex = 0;
            this.first.Text = "\r\nFirst Point";
            this.first.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lat1label
            // 
            this.lat1label.BackColor = System.Drawing.Color.DarkGray;
            this.lat1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat1label.ForeColor = System.Drawing.Color.Lime;
            this.lat1label.Location = new System.Drawing.Point(35, 175);
            this.lat1label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lat1label.Name = "lat1label";
            this.lat1label.Size = new System.Drawing.Size(163, 57);
            this.lat1label.TabIndex = 1;
            this.lat1label.Text = "Latitude";
            this.lat1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // long1label
            // 
            this.long1label.BackColor = System.Drawing.Color.DarkGray;
            this.long1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long1label.ForeColor = System.Drawing.Color.Lime;
            this.long1label.Location = new System.Drawing.Point(35, 248);
            this.long1label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.long1label.Name = "long1label";
            this.long1label.Size = new System.Drawing.Size(163, 57);
            this.long1label.TabIndex = 2;
            this.long1label.Text = "Longitude";
            this.long1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coor
            // 
            this.coor.BackColor = System.Drawing.Color.Transparent;
            this.coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coor.ForeColor = System.Drawing.Color.White;
            this.coor.Location = new System.Drawing.Point(2, 14);
            this.coor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coor.Name = "coor";
            this.coor.Size = new System.Drawing.Size(865, 62);
            this.coor.TabIndex = 3;
            this.coor.Text = "Import the Values in Latitude and Longitude Form:";
            // 
            // lat1
            // 
            this.lat1.Location = new System.Drawing.Point(215, 188);
            this.lat1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lat1.Name = "lat1";
            this.lat1.Size = new System.Drawing.Size(160, 35);
            this.lat1.TabIndex = 1;
            // 
            // long1
            // 
            this.long1.Location = new System.Drawing.Point(215, 262);
            this.long1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.long1.Name = "long1";
            this.long1.Size = new System.Drawing.Size(160, 35);
            this.long1.TabIndex = 2;
            // 
            // deg1
            // 
            this.deg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deg1.ForeColor = System.Drawing.Color.Black;
            this.deg1.Location = new System.Drawing.Point(379, 190);
            this.deg1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deg1.Name = "deg1";
            this.deg1.Size = new System.Drawing.Size(64, 34);
            this.deg1.TabIndex = 4;
            this.deg1.Text = "deg";
            this.deg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.LimeGreen;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(351, 349);
            this.calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(252, 68);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate!";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(276, 430);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(406, 84);
            this.result.TabIndex = 13;
            this.result.Text = "Azimuth = ";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deg2
            // 
            this.deg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deg2.ForeColor = System.Drawing.Color.Black;
            this.deg2.Location = new System.Drawing.Point(379, 263);
            this.deg2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deg2.Name = "deg2";
            this.deg2.Size = new System.Drawing.Size(64, 34);
            this.deg2.TabIndex = 14;
            this.deg2.Text = "deg";
            this.deg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deg4
            // 
            this.deg4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deg4.ForeColor = System.Drawing.Color.Black;
            this.deg4.Location = new System.Drawing.Point(842, 263);
            this.deg4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deg4.Name = "deg4";
            this.deg4.Size = new System.Drawing.Size(64, 34);
            this.deg4.TabIndex = 21;
            this.deg4.Text = "deg";
            this.deg4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deg3
            // 
            this.deg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deg3.ForeColor = System.Drawing.Color.Black;
            this.deg3.Location = new System.Drawing.Point(842, 190);
            this.deg3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deg3.Name = "deg3";
            this.deg3.Size = new System.Drawing.Size(64, 34);
            this.deg3.TabIndex = 20;
            this.deg3.Text = "deg";
            this.deg3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // long2
            // 
            this.long2.Location = new System.Drawing.Point(678, 262);
            this.long2.Margin = new System.Windows.Forms.Padding(2);
            this.long2.Name = "long2";
            this.long2.Size = new System.Drawing.Size(160, 35);
            this.long2.TabIndex = 4;
            // 
            // lat2
            // 
            this.lat2.Location = new System.Drawing.Point(678, 188);
            this.lat2.Margin = new System.Windows.Forms.Padding(2);
            this.lat2.Name = "lat2";
            this.lat2.Size = new System.Drawing.Size(160, 35);
            this.lat2.TabIndex = 3;
            // 
            // long2label
            // 
            this.long2label.BackColor = System.Drawing.Color.DarkGray;
            this.long2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long2label.ForeColor = System.Drawing.Color.LawnGreen;
            this.long2label.Location = new System.Drawing.Point(498, 248);
            this.long2label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.long2label.Name = "long2label";
            this.long2label.Size = new System.Drawing.Size(163, 57);
            this.long2label.TabIndex = 19;
            this.long2label.Text = "Longitude";
            this.long2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lat2label
            // 
            this.lat2label.BackColor = System.Drawing.Color.DarkGray;
            this.lat2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat2label.ForeColor = System.Drawing.Color.LawnGreen;
            this.lat2label.Location = new System.Drawing.Point(498, 175);
            this.lat2label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lat2label.Name = "lat2label";
            this.lat2label.Size = new System.Drawing.Size(163, 57);
            this.lat2label.TabIndex = 17;
            this.lat2label.Text = "Latitude";
            this.lat2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scond
            // 
            this.scond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scond.Location = new System.Drawing.Point(482, 76);
            this.scond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scond.Name = "scond";
            this.scond.Size = new System.Drawing.Size(450, 254);
            this.scond.TabIndex = 15;
            this.scond.Text = "\r\nSecond Point";
            this.scond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deg5
            // 
            this.deg5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deg5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deg5.ForeColor = System.Drawing.Color.Black;
            this.deg5.Location = new System.Drawing.Point(444, 524);
            this.deg5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deg5.Name = "deg5";
            this.deg5.Size = new System.Drawing.Size(64, 34);
            this.deg5.TabIndex = 22;
            this.deg5.Text = "deg";
            this.deg5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // azimuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 580);
            this.Controls.Add(this.deg5);
            this.Controls.Add(this.deg4);
            this.Controls.Add(this.deg3);
            this.Controls.Add(this.long2);
            this.Controls.Add(this.lat2);
            this.Controls.Add(this.long2label);
            this.Controls.Add(this.lat2label);
            this.Controls.Add(this.scond);
            this.Controls.Add(this.deg2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.deg1);
            this.Controls.Add(this.long1);
            this.Controls.Add(this.lat1);
            this.Controls.Add(this.coor);
            this.Controls.Add(this.long1label);
            this.Controls.Add(this.lat1label);
            this.Controls.Add(this.first);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "azimuth";
            this.Text = "Azimuth Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label lat1label;
        private System.Windows.Forms.Label long1label;
        private System.Windows.Forms.Label coor;
        private System.Windows.Forms.TextBox lat1;
        private System.Windows.Forms.TextBox long1;
        private System.Windows.Forms.Label deg1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label deg2;
        private System.Windows.Forms.Label deg4;
        private System.Windows.Forms.Label deg3;
        private System.Windows.Forms.TextBox long2;
        private System.Windows.Forms.TextBox lat2;
        private System.Windows.Forms.Label long2label;
        private System.Windows.Forms.Label lat2label;
        private System.Windows.Forms.Label scond;
        private System.Windows.Forms.Label deg5;
    }
}

