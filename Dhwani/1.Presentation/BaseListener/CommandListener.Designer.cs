namespace Dhwani._1.Presentation.BaseListener
{
    partial class CommandListener
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandListener));
            this.AnimatePanel = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.AnimatePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimatePanel
            // 
            this.AnimatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimatePanel.Image = global::Dhwani.Properties.Resources.preview;
            this.AnimatePanel.Location = new System.Drawing.Point(0, 0);
            this.AnimatePanel.Name = "AnimatePanel";
            this.AnimatePanel.Size = new System.Drawing.Size(535, 401);
            this.AnimatePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimatePanel.TabIndex = 5;
            this.AnimatePanel.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(8, 8);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1125, 444);
            this.webBrowser1.TabIndex = 7;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(698, 424);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(1);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(8, 8);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(10, 8);
            this.webBrowser2.TabIndex = 8;
            // 
            // CommandListener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 401);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.AnimatePanel);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CommandListener";
            this.Text = "CommandListener";
            this.Load += new System.EventHandler(this.CommandListener_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnimatePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AnimatePanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}