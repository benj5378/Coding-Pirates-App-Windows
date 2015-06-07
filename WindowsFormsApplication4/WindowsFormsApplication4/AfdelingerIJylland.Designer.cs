namespace WindowsFormsApplication4
{
    partial class AfdelingerIJylland
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
            this.regionsyddanmark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regionsyddanmark
            // 
            this.regionsyddanmark.Location = new System.Drawing.Point(12, 12);
            this.regionsyddanmark.Name = "regionsyddanmark";
            this.regionsyddanmark.Size = new System.Drawing.Size(260, 38);
            this.regionsyddanmark.TabIndex = 0;
            this.regionsyddanmark.Text = "Afdelinger i Region Syd Danmark";
            this.regionsyddanmark.UseVisualStyleBackColor = true;
            // 
            // AfdelingerIJylland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.regionsyddanmark);
            this.Name = "AfdelingerIJylland";
            this.Text = "Afdelinger I Jylland";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regionsyddanmark;
    }
}