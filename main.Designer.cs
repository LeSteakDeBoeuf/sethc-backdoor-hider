﻿namespace sethc
{
    partial class main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region main.cs Design

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.labelskcontent = new System.Windows.Forms.Label();
            this.labelturnsk = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.labeldeactivatedialog = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelskcontent
            // 
            this.labelskcontent.AutoEllipsis = true;
            this.labelskcontent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelskcontent.Location = new System.Drawing.Point(33, 39);
            this.labelskcontent.Name = "labelskcontent";
            this.labelskcontent.Size = new System.Drawing.Size(420, 39);
            this.labelskcontent.TabIndex = 1;
            this.labelskcontent.Text = "Sticky Keys lets you use the SHIFT, CTRL, ALT, or Windows Logo keys by pressing o" +
    "ne key at a time. The keyboard shortcut to turn on Sticky Keys is to press the S" +
    "HIFT key 5 times.";
            // 
            // labelturnsk
            // 
            this.labelturnsk.AutoSize = true;
            this.labelturnsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelturnsk.Location = new System.Drawing.Point(12, 17);
            this.labelturnsk.Name = "labelturnsk";
            this.labelturnsk.Size = new System.Drawing.Size(179, 13);
            this.labelturnsk.TabIndex = 0;
            this.labelturnsk.Text = "Do you want to turn on Sticky Keys?";
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(304, 137);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(70, 23);
            this.buttonYes.TabIndex = 3;
            this.buttonYes.Text = "&Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(385, 137);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 4;
            this.buttonNo.Text = "&No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // labeldeactivatedialog
            // 
            this.labeldeactivatedialog.ActiveLinkColor = System.Drawing.Color.Blue;
            this.labeldeactivatedialog.AutoEllipsis = true;
            this.labeldeactivatedialog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labeldeactivatedialog.LinkColor = System.Drawing.Color.Blue;
            this.labeldeactivatedialog.Location = new System.Drawing.Point(33, 96);
            this.labeldeactivatedialog.Name = "labeldeactivatedialog";
            this.labeldeactivatedialog.Size = new System.Drawing.Size(420, 13);
            this.labeldeactivatedialog.TabIndex = 2;
            this.labeldeactivatedialog.TabStop = true;
            this.labeldeactivatedialog.Text = "Go to the Ease of Access Center to disable the keyboard shortcut";
            this.labeldeactivatedialog.VisitedLinkColor = System.Drawing.Color.Blue;
            this.labeldeactivatedialog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labeldeactivatedialog_LinkClicked);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(500, 176);
            this.Controls.Add(this.labeldeactivatedialog);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelskcontent);
            this.Controls.Add(this.labelturnsk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sticky Keys";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelskcontent;
        private System.Windows.Forms.Label labelturnsk;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.LinkLabel labeldeactivatedialog;
    }
}

