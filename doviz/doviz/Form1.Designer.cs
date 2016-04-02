namespace doviz
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBoxUsd = new System.Windows.Forms.PictureBox();
            this.lblUsd = new System.Windows.Forms.Label();
            this.lblUsdValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsd)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(393, 274);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(205, 153);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.tcmb.gov.tr/kurlar/today.xml", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // pictureBoxUsd
            // 
            this.pictureBoxUsd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsd.Image")));
            this.pictureBoxUsd.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxUsd.Name = "pictureBoxUsd";
            this.pictureBoxUsd.Size = new System.Drawing.Size(66, 37);
            this.pictureBoxUsd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsd.TabIndex = 1;
            this.pictureBoxUsd.TabStop = false;
            // 
            // lblUsd
            // 
            this.lblUsd.AutoSize = true;
            this.lblUsd.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblUsd.Location = new System.Drawing.Point(84, 19);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(50, 24);
            this.lblUsd.TabIndex = 2;
            this.lblUsd.Text = "USD:";
            // 
            // lblUsdValue
            // 
            this.lblUsdValue.AutoSize = true;
            this.lblUsdValue.Font = new System.Drawing.Font("Roboto Cn", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblUsdValue.Location = new System.Drawing.Point(128, 14);
            this.lblUsdValue.Name = "lblUsdValue";
            this.lblUsdValue.Size = new System.Drawing.Size(0, 33);
            this.lblUsdValue.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(290, 63);
            this.Controls.Add(this.lblUsdValue);
            this.Controls.Add(this.lblUsd);
            this.Controls.Add(this.pictureBoxUsd);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 63);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Currency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBoxUsd;
        private System.Windows.Forms.Label lblUsd;
        private System.Windows.Forms.Label lblUsdValue;
    }
}

