namespace WindowsFormsApplication4
{
    partial class AfdelingerISjælland
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
            this.afdelingerhovedstaden = new System.Windows.Forms.Button();
            this.afdelingersjælland = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // afdelingerhovedstaden
            // 
            this.afdelingerhovedstaden.Location = new System.Drawing.Point(12, 12);
            this.afdelingerhovedstaden.Name = "afdelingerhovedstaden";
            this.afdelingerhovedstaden.Size = new System.Drawing.Size(260, 38);
            this.afdelingerhovedstaden.TabIndex = 0;
            this.afdelingerhovedstaden.Text = "Afdelinger i Region Hovedstaden";
            this.afdelingerhovedstaden.UseVisualStyleBackColor = true;
            this.afdelingerhovedstaden.Click += new System.EventHandler(this.button1_Click);
            // 
            // afdelingersjælland
            // 
            this.afdelingersjælland.Location = new System.Drawing.Point(12, 56);
            this.afdelingersjælland.Name = "afdelingersjælland";
            this.afdelingersjælland.Size = new System.Drawing.Size(260, 38);
            this.afdelingersjælland.TabIndex = 1;
            this.afdelingersjælland.Text = "Afdelinger i Region Sjælland";
            this.afdelingersjælland.UseVisualStyleBackColor = true;
            // 
            // AfdelingerISjælland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.afdelingersjælland);
            this.Controls.Add(this.afdelingerhovedstaden);
            this.Name = "AfdelingerISjælland";
            this.Text = "Afdelinger i Sjælland";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button afdelingerhovedstaden;
        private System.Windows.Forms.Button afdelingersjælland;
    }
}