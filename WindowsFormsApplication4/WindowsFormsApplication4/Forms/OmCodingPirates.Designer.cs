﻿namespace WindowsFormsApplication4
{
    partial class OmCodingPirates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OmCodingPirates));
            this.label1 = new System.Windows.Forms.Label();
            this.linkhome = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkforum = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facts om Coding Pirates";
            // 
            // linkhome
            // 
            this.linkhome.AutoSize = true;
            this.linkhome.Location = new System.Drawing.Point(85, 28);
            this.linkhome.Name = "linkhome";
            this.linkhome.Size = new System.Drawing.Size(85, 13);
            this.linkhome.TabIndex = 1;
            this.linkhome.TabStop = true;
            this.linkhome.Text = "codingpirates.dk";
            this.linkhome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkhome_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hjemmeside:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Forum";
            // 
            // linkforum
            // 
            this.linkforum.AutoSize = true;
            this.linkforum.Location = new System.Drawing.Point(85, 41);
            this.linkforum.Name = "linkforum";
            this.linkforum.Size = new System.Drawing.Size(114, 13);
            this.linkforum.TabIndex = 4;
            this.linkforum.TabStop = true;
            this.linkforum.Text = "forum.codingpirates.dk";
            this.linkforum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkforum_LinkClicked);
            // 
            // OmCodingPirates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.linkforum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkhome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OmCodingPirates";
            this.Text = "OmCodingPirates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkhome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkforum;
    }
}