namespace WindowsFormsApplication4
{
    partial class AfdelingerIRegionSjælland
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
            this.soroe = new System.Windows.Forms.Button();
            this.glumsoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soroe
            // 
            this.soroe.Location = new System.Drawing.Point(12, 12);
            this.soroe.Name = "soroe";
            this.soroe.Size = new System.Drawing.Size(260, 38);
            this.soroe.TabIndex = 0;
            this.soroe.Text = "Sorø";
            this.soroe.UseVisualStyleBackColor = true;
            // 
            // glumsoe
            // 
            this.glumsoe.Location = new System.Drawing.Point(12, 56);
            this.glumsoe.Name = "glumsoe";
            this.glumsoe.Size = new System.Drawing.Size(260, 38);
            this.glumsoe.TabIndex = 1;
            this.glumsoe.Text = "Glumsø";
            this.glumsoe.UseVisualStyleBackColor = true;
            // 
            // AfdelingerIRegionSjælland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.glumsoe);
            this.Controls.Add(this.soroe);
            this.Name = "AfdelingerIRegionSjælland";
            this.Text = "Afdelinger I Region Sjælland";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button soroe;
        private System.Windows.Forms.Button glumsoe;
    }
}