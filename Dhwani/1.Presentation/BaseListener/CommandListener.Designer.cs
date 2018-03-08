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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnimatePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimatePanel
            // 
            this.AnimatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimatePanel.Image = global::Dhwani.Properties.Resources.preview;
            this.AnimatePanel.Location = new System.Drawing.Point(0, 0);
            this.AnimatePanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AnimatePanel.Name = "AnimatePanel";
            this.AnimatePanel.Size = new System.Drawing.Size(1427, 956);
            this.AnimatePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimatePanel.TabIndex = 5;
            this.AnimatePanel.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(21, 19);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(3000, 1059);
            this.webBrowser1.TabIndex = 7;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(1861, 1011);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(21, 19);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(27, 19);
            this.webBrowser2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 121);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CommandListener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1427, 956);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.AnimatePanel);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
    }
}