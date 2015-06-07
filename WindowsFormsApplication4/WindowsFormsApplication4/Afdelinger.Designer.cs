namespace WindowsFormsApplication4
{
    partial class Afdelinger
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
            this.afdelingersjælland = new System.Windows.Forms.Button();
            this.afdelingerfyn = new System.Windows.Forms.Button();
            this.afdelingerjylland = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // afdelingersjælland
            // 
            this.afdelingersjælland.Location = new System.Drawing.Point(12, 12);
            this.afdelingersjælland.Name = "afdelingersjælland";
            this.afdelingersjælland.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.afdelingersjælland.Size = new System.Drawing.Size(260, 38);
            this.afdelingersjælland.TabIndex = 0;
            this.afdelingersjælland.Text = "Afdelinger i Sjælland";
            this.afdelingersjælland.UseVisualStyleBackColor = true;
            this.afdelingersjælland.Click += new System.EventHandler(this.button1_Click);
            // 
            // afdelingerfyn
            // 
            this.afdelingerfyn.Location = new System.Drawing.Point(12, 56);
            this.afdelingerfyn.Name = "afdelingerfyn";
            this.afdelingerfyn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.afdelingerfyn.Size = new System.Drawing.Size(260, 38);
            this.afdelingerfyn.TabIndex = 1;
            this.afdelingerfyn.Text = "Afdelinger i Fyn";
            this.afdelingerfyn.UseVisualStyleBackColor = true;
            this.afdelingerfyn.Click += new System.EventHandler(this.button2_Click);
            // 
            // afdelingerjylland
            // 
            this.afdelingerjylland.Location = new System.Drawing.Point(12, 100);
            this.afdelingerjylland.Name = "afdelingerjylland";
            this.afdelingerjylland.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.afdelingerjylland.Size = new System.Drawing.Size(260, 38);
            this.afdelingerjylland.TabIndex = 2;
            this.afdelingerjylland.Text = "Afdelinger i Jylland";
            this.afdelingerjylland.UseVisualStyleBackColor = true;
            this.afdelingerjylland.Click += new System.EventHandler(this.button3_Click);
            // 
            // Afdelinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.afdelingerjylland);
            this.Controls.Add(this.afdelingerfyn);
            this.Controls.Add(this.afdelingersjælland);
            this.Name = "Afdelinger";
            this.Text = "Afdelinger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button afdelingersjælland;
        private System.Windows.Forms.Button afdelingerfyn;
        private System.Windows.Forms.Button afdelingerjylland;
    }
}