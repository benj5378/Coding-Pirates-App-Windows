namespace WindowsFormsApplication4
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.lavetaf = new System.Windows.Forms.Label();
            this.lavetafbenjamin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lavetaf
            // 
            this.lavetaf.AutoSize = true;
            this.lavetaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavetaf.Location = new System.Drawing.Point(84, 9);
            this.lavetaf.Name = "lavetaf";
            this.lavetaf.Size = new System.Drawing.Size(132, 25);
            this.lavetaf.TabIndex = 0;
            this.lavetaf.Text = "App lavet af:";
            // 
            // lavetafbenjamin
            // 
            this.lavetafbenjamin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lavetafbenjamin.AutoSize = true;
            this.lavetafbenjamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavetafbenjamin.Location = new System.Drawing.Point(53, 50);
            this.lavetafbenjamin.Name = "lavetafbenjamin";
            this.lavetafbenjamin.Size = new System.Drawing.Size(194, 20);
            this.lavetafbenjamin.TabIndex = 1;
            this.lavetafbenjamin.Text = "Benjamin Bræstrup Sayoc";
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lavetafbenjamin);
            this.Controls.Add(this.lavetaf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Credits";
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.Credits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lavetaf;
        private System.Windows.Forms.Label lavetafbenjamin;
    }
}