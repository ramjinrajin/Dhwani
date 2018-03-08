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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.AnimatePanel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnimatePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(8, 8);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1125, 444);
            this.webBrowser1.TabIndex = 7;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(698, 424);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(8, 8);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(10, 8);
            this.webBrowser2.TabIndex = 8;
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
            this.AnimatePanel.DoubleClick += new System.EventHandler(this.AnimatePanel_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dhwani";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(370, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Double click to add commands";
            // 
            // SearchKey
            // 
            this.SearchKey.AutoSize = true;
            this.SearchKey.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchKey.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchKey.ForeColor = System.Drawing.Color.White;
            this.SearchKey.Location = new System.Drawing.Point(208, 113);
            this.SearchKey.Name = "SearchKey";
            this.SearchKey.Size = new System.Drawing.Size(133, 31);
            this.SearchKey.TabIndex = 11;
            this.SearchKey.Text = ".................";
            // 
            // CommandListener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 401);
            this.Controls.Add(this.SearchKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.AnimatePanel);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "CommandListener";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommandListener";
            this.Load += new System.EventHandler(this.CommandListener_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnimatePanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.PictureBox AnimatePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SearchKey;
    }
}