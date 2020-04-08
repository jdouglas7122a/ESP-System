namespace DataEntryTestApp
{
    partial class EmployeeViewer
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FormHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormHeader.Controls.Add(this.button1);
            this.FormHeader.Controls.Add(this.label1);
            this.FormHeader.Controls.Add(this.button2);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(800, 50);
            this.FormHeader.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(701, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test Form For ODBC Connection";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(752, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.Location = new System.Drawing.Point(2, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 45);
            this.button4.TabIndex = 71;
            this.button4.Text = "Managers";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(2, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 45);
            this.button3.TabIndex = 70;
            this.button3.Text = "Items";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(2, 405);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 45);
            this.button10.TabIndex = 68;
            this.button10.Text = "--";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(2, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 45);
            this.button6.TabIndex = 67;
            this.button6.Text = "--";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(2, 316);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 45);
            this.button7.TabIndex = 66;
            this.button7.Text = "--";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(2, 271);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 45);
            this.button8.TabIndex = 65;
            this.button8.Text = "--";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(2, 229);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 45);
            this.button9.TabIndex = 64;
            this.button9.Text = "--";
            this.button9.UseVisualStyleBackColor = false;
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
            this.GetButton.Location = new System.Drawing.Point(2, 95);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(160, 45);
            this.GetButton.TabIndex = 63;
            this.GetButton.Text = "Employees";
            this.GetButton.UseVisualStyleBackColor = false;
            // 
            // PostButton
            // 
            this.PostButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PostButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PostButton.Location = new System.Drawing.Point(2, 53);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(160, 45);
            this.PostButton.TabIndex = 62;
            this.PostButton.Text = "Stores";
            this.PostButton.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Staff:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Location = new System.Drawing.Point(168, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 376);
            this.panel4.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(415, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 191);
            this.panel1.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Information:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Staff ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salary:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Store:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 6;
            // 
            // EmployeeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.FormHeader);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.PostButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeViewer";
            this.Text = "EmployeeViewer";
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}