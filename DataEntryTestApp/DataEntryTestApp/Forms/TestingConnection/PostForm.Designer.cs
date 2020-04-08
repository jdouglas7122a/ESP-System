namespace DataEntryTestApp
{
    partial class PostForm
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
            this.FormHeader = new System.Windows.Forms.Panel();
            this.TargetTableBox = new System.Windows.Forms.TextBox();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(304, 46);
            this.FormHeader.TabIndex = 0;
            this.FormHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseDown);
            this.FormHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseMove);
            this.FormHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseUp);
            // 
            // TargetTableBox
            // 
            this.TargetTableBox.Location = new System.Drawing.Point(95, 73);
            this.TargetTableBox.Name = "TargetTableBox";
            this.TargetTableBox.Size = new System.Drawing.Size(151, 20);
            this.TargetTableBox.TabIndex = 8;
            // 
            // DataBox
            // 
            this.DataBox.Location = new System.Drawing.Point(95, 128);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(151, 20);
            this.DataBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(41, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Table #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(41, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SubmitButton.Location = new System.Drawing.Point(3, 173);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(148, 45);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.Location = new System.Drawing.Point(152, 173);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(148, 45);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(304, 223);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.TargetTableBox);
            this.Controls.Add(this.FormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.TextBox TargetTableBox;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
    }
}