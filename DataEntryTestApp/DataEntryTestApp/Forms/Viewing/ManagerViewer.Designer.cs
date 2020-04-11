namespace DataEntryTestApp
{
    partial class ManagerViewer
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ManagersViewerButton = new System.Windows.Forms.Button();
            this.ItemViewerButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.EmployeeViewerButton = new System.Windows.Forms.Button();
            this.StoresViewerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.StoreViewerButton = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ViewerBackButton = new System.Windows.Forms.Button();
            this.FormHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormHeader.Controls.Add(this.MinimizeButton);
            this.FormHeader.Controls.Add(this.label1);
            this.FormHeader.Controls.Add(this.ExitButton);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(800, 50);
            this.FormHeader.TabIndex = 69;
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
            // ManagersViewerButton
            // 
            this.ManagersViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ManagersViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagersViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManagersViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagersViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ManagersViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ManagersViewerButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ManagersViewerButton.Location = new System.Drawing.Point(2, 184);
            this.ManagersViewerButton.Name = "ManagersViewerButton";
            this.ManagersViewerButton.Size = new System.Drawing.Size(160, 45);
            this.ManagersViewerButton.TabIndex = 71;
            this.ManagersViewerButton.Text = "Managers";
            this.ManagersViewerButton.UseVisualStyleBackColor = false;
            // 
            // ItemViewerButton
            // 
            this.ItemViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ItemViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ItemViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ItemViewerButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ItemViewerButton.Location = new System.Drawing.Point(2, 139);
            this.ItemViewerButton.Name = "ItemViewerButton";
            this.ItemViewerButton.Size = new System.Drawing.Size(160, 45);
            this.ItemViewerButton.TabIndex = 70;
            this.ItemViewerButton.Text = "Items";
            this.ItemViewerButton.UseVisualStyleBackColor = false;
            this.ItemViewerButton.Click += new System.EventHandler(this.ItemViewerButton_Click);
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
            // EmployeeViewerButton
            // 
            this.EmployeeViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EmployeeViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.EmployeeViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmployeeViewerButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.EmployeeViewerButton.Location = new System.Drawing.Point(2, 95);
            this.EmployeeViewerButton.Name = "EmployeeViewerButton";
            this.EmployeeViewerButton.Size = new System.Drawing.Size(160, 45);
            this.EmployeeViewerButton.TabIndex = 63;
            this.EmployeeViewerButton.Text = "Employees";
            this.EmployeeViewerButton.UseVisualStyleBackColor = false;
            this.EmployeeViewerButton.Click += new System.EventHandler(this.EmployeeViewerButton_Click);
            // 
            // StoresViewerButton
            // 
            this.StoresViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StoresViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StoresViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.StoresViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoresViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoresViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StoresViewerButton.Location = new System.Drawing.Point(2, 53);
            this.StoresViewerButton.Name = "StoresViewerButton";
            this.StoresViewerButton.Size = new System.Drawing.Size(160, 45);
            this.StoresViewerButton.TabIndex = 62;
            this.StoresViewerButton.Text = "Stores";
            this.StoresViewerButton.UseVisualStyleBackColor = false;
            this.StoresViewerButton.Click += new System.EventHandler(this.StoresViewerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Information:";
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
            this.panel1.Location = new System.Drawing.Point(313, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 156);
            this.panel1.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Store:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salary:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Staff ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Manager:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Location = new System.Drawing.Point(169, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 376);
            this.panel4.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Staff Managed:";
            // 
            // StoreViewerButton
            // 
            this.StoreViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StoreViewerButton.Location = new System.Drawing.Point(587, 63);
            this.StoreViewerButton.Name = "StoreViewerButton";
            this.StoreViewerButton.Size = new System.Drawing.Size(201, 376);
            this.StoreViewerButton.TabIndex = 81;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Location = new System.Drawing.Point(313, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 198);
            this.panel3.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Store Profit:";
            // 
            // ViewerBackButton
            // 
            this.ViewerBackButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ViewerBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewerBackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewerBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewerBackButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ViewerBackButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ViewerBackButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ViewerBackButton.Location = new System.Drawing.Point(3, 403);
            this.ViewerBackButton.Name = "ViewerBackButton";
            this.ViewerBackButton.Size = new System.Drawing.Size(160, 45);
            this.ViewerBackButton.TabIndex = 83;
            this.ViewerBackButton.Text = "Back";
            this.ViewerBackButton.UseVisualStyleBackColor = false;
            this.ViewerBackButton.Click += new System.EventHandler(this.ViewerBackButton_Click);
            // 
            // ManagerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewerBackButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StoreViewerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.FormHeader);
            this.Controls.Add(this.ManagersViewerButton);
            this.Controls.Add(this.ItemViewerButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.EmployeeViewerButton);
            this.Controls.Add(this.StoresViewerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerViewer";
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ManagersViewerButton;
        private System.Windows.Forms.Button ItemViewerButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button EmployeeViewerButton;
        private System.Windows.Forms.Button StoresViewerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel StoreViewerButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ViewerBackButton;
    }
}