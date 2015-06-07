namespace WindowsFormsApplication4
{
    partial class Main
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
            this.Frivilligeb = new System.Windows.Forms.Button();
            this.Afdelingerb = new System.Windows.Forms.Button();
            this.Om_Coding_Piratesb = new System.Windows.Forms.Button();
            this.Creditsb = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAProplemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frivilligeb
            // 
            this.Frivilligeb.Location = new System.Drawing.Point(12, 56);
            this.Frivilligeb.Name = "Frivilligeb";
            this.Frivilligeb.Size = new System.Drawing.Size(260, 23);
            this.Frivilligeb.TabIndex = 0;
            this.Frivilligeb.Text = "Frivillige";
            this.Frivilligeb.UseVisualStyleBackColor = true;
            this.Frivilligeb.Click += new System.EventHandler(this.Frivilligeb_Click);
            // 
            // Afdelingerb
            // 
            this.Afdelingerb.Location = new System.Drawing.Point(12, 27);
            this.Afdelingerb.Name = "Afdelingerb";
            this.Afdelingerb.Size = new System.Drawing.Size(260, 23);
            this.Afdelingerb.TabIndex = 1;
            this.Afdelingerb.Text = "Afdelinger";
            this.Afdelingerb.UseVisualStyleBackColor = true;
            this.Afdelingerb.Click += new System.EventHandler(this.Afdelingerb_Click);
            // 
            // Om_Coding_Piratesb
            // 
            this.Om_Coding_Piratesb.Location = new System.Drawing.Point(12, 85);
            this.Om_Coding_Piratesb.Name = "Om_Coding_Piratesb";
            this.Om_Coding_Piratesb.Size = new System.Drawing.Size(260, 23);
            this.Om_Coding_Piratesb.TabIndex = 2;
            this.Om_Coding_Piratesb.Text = "Om Coding Pirates";
            this.Om_Coding_Piratesb.UseVisualStyleBackColor = true;
            this.Om_Coding_Piratesb.Click += new System.EventHandler(this.Om_Coding_Piratesb_Click);
            // 
            // Creditsb
            // 
            this.Creditsb.Location = new System.Drawing.Point(12, 114);
            this.Creditsb.Name = "Creditsb";
            this.Creditsb.Size = new System.Drawing.Size(260, 23);
            this.Creditsb.TabIndex = 3;
            this.Creditsb.Text = "Credits";
            this.Creditsb.UseVisualStyleBackColor = true;
            this.Creditsb.Click += new System.EventHandler(this.Creditsb_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAProplemToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportAProplemToolStripMenuItem
            // 
            this.reportAProplemToolStripMenuItem.Name = "reportAProplemToolStripMenuItem";
            this.reportAProplemToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.reportAProplemToolStripMenuItem.Text = "Report a proplem";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Creditsb);
            this.Controls.Add(this.Om_Coding_Piratesb);
            this.Controls.Add(this.Afdelingerb);
            this.Controls.Add(this.Frivilligeb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Start";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Frivilligeb;
        private System.Windows.Forms.Button Afdelingerb;
        private System.Windows.Forms.Button Om_Coding_Piratesb;
        private System.Windows.Forms.Button Creditsb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAProplemToolStripMenuItem;
    }
}

