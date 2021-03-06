﻿namespace DataEntryTestApp
{
    partial class SalesCompleteMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesCompleteMessage));
            this.ProceedButton = new System.Windows.Forms.Button();
            this.FormHeader = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmationMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProceedButton
            // 
            this.ProceedButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ProceedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProceedButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedButton.Location = new System.Drawing.Point(131, 152);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(184, 45);
            this.ProceedButton.TabIndex = 35;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.UseVisualStyleBackColor = false;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormHeader.Controls.Add(this.pictureBox1);
            this.FormHeader.Controls.Add(this.MinimizeButton);
            this.FormHeader.Controls.Add(this.ExitButton);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(443, 50);
            this.FormHeader.TabIndex = 34;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinimizeButton.Location = new System.Drawing.Point(701, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 42);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitButton.Location = new System.Drawing.Point(752, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(45, 42);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Returning To Mode Select";
            // 
            // ConfirmationMessage
            // 
            this.ConfirmationMessage.AutoSize = true;
            this.ConfirmationMessage.Location = new System.Drawing.Point(134, 74);
            this.ConfirmationMessage.Name = "ConfirmationMessage";
            this.ConfirmationMessage.Size = new System.Drawing.Size(175, 13);
            this.ConfirmationMessage.TabIndex = 36;
            this.ConfirmationMessage.Text = "You\'ve Completed Sales Data Input";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // SalesCompleteMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmationMessage);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.FormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesCompleteMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesCompleteMessage";
            this.FormHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConfirmationMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}