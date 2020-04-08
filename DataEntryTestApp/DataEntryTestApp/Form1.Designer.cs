namespace DataEntryTestApp
{
    partial class Form1
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
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.FormLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TextDisplay = new System.Windows.Forms.TextBox();
            this.TextDisplay2 = new System.Windows.Forms.TextBox();
            this.FormHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormHeader.Controls.Add(this.MinimizeButton);
            this.FormHeader.Controls.Add(this.FormLabel);
            this.FormHeader.Controls.Add(this.ExitButton);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(800, 50);
            this.FormHeader.TabIndex = 1;
            this.FormHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseDown);
            this.FormHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseMove);
            this.FormHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseUp);
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
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormLabel.Location = new System.Drawing.Point(12, 20);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(162, 13);
            this.FormLabel.TabIndex = 3;
            this.FormLabel.Text = "Test Form For ODBC Connection";
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
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.GetButton);
            this.panel1.Controls.Add(this.PostButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 396);
            this.panel1.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(1, 352);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 45);
            this.button10.TabIndex = 11;
            this.button10.Text = "--";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(3, 308);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 45);
            this.button6.TabIndex = 10;
            this.button6.Text = "--";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(3, 263);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 45);
            this.button7.TabIndex = 9;
            this.button7.Text = "--";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(3, 218);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "--";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(3, 176);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 45);
            this.button9.TabIndex = 7;
            this.button9.Text = "--";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "--";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "--";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // GetButton
            // 
            this.GetButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.GetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.GetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.GetButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GetButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.GetButton.Location = new System.Drawing.Point(1, 42);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(160, 45);
            this.GetButton.TabIndex = 4;
            this.GetButton.Text = "GET Data";
            this.GetButton.UseVisualStyleBackColor = false;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // PostButton
            // 
            this.PostButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PostButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PostButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PostButton.Location = new System.Drawing.Point(1, 0);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(160, 45);
            this.PostButton.TabIndex = 3;
            this.PostButton.Text = "POST Data";
            this.PostButton.UseVisualStyleBackColor = false;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // TextDisplay
            // 
            this.TextDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.TextDisplay.Location = new System.Drawing.Point(167, 62);
            this.TextDisplay.Name = "TextDisplay";
            this.TextDisplay.ReadOnly = true;
            this.TextDisplay.Size = new System.Drawing.Size(621, 20);
            this.TextDisplay.TabIndex = 3;
            // 
            // TextDisplay2
            // 
            this.TextDisplay2.Cursor = System.Windows.Forms.Cursors.No;
            this.TextDisplay2.Location = new System.Drawing.Point(166, 105);
            this.TextDisplay2.Name = "TextDisplay2";
            this.TextDisplay2.ReadOnly = true;
            this.TextDisplay2.Size = new System.Drawing.Size(621, 20);
            this.TextDisplay2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.TextDisplay2);
            this.Controls.Add(this.TextDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Label FormLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.TextBox TextDisplay;
        private System.Windows.Forms.TextBox TextDisplay2;
    }
}

