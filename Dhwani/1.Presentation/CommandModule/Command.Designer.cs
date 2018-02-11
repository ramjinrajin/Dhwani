namespace Dhwani._1.Presentation.CommandModule
{
    partial class Command
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtManglish = new System.Windows.Forms.TextBox();
            this.txtMalayalam = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manglish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Malayalam";
            // 
            // txtManglish
            // 
            this.txtManglish.Location = new System.Drawing.Point(381, 79);
            this.txtManglish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManglish.Name = "txtManglish";
            this.txtManglish.Size = new System.Drawing.Size(468, 38);
            this.txtManglish.TabIndex = 2;
            // 
            // txtMalayalam
            // 
            this.txtMalayalam.Location = new System.Drawing.Point(381, 196);
            this.txtMalayalam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMalayalam.Name = "txtMalayalam";
            this.txtMalayalam.Size = new System.Drawing.Size(468, 38);
            this.txtMalayalam.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(381, 308);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(165, 74);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Command
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 484);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtMalayalam);
            this.Controls.Add(this.txtManglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Command";
            this.Text = "Command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManglish;
        private System.Windows.Forms.TextBox txtMalayalam;
        private System.Windows.Forms.Button btnInsert;
    }
}