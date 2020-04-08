using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DataEntryTestApp
{


    public partial class Form1 : Form
    {
        // coordinates for window moving
        int originFormX = 0;
        int originFormY = 0;
        int originMouseX = 0;
        int originMouseY = 0;
        //is window allowed to move?
        bool mouseDown;

        List<string> postedTables = new List<string>();
        List<string> postedData = new List<string>();
        List<string> getRequest = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //records loaction of window for moving
        private void FormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            originFormX = this.Location.X;
            originFormY = this.Location.Y;
            originMouseX = MousePosition.X;
            originMouseY = MousePosition.Y;
        }
        //allows window to move
        private void FormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //moves window
        private void FormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(originFormX + (MousePosition.X - originMouseX), originFormY + (MousePosition.Y - originMouseY));
            }
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            using (var postWindow = new PostForm())
            {
                switch (postWindow.ShowDialog())
                {
                    case DialogResult.OK:
                        postedTables.Add(postWindow.returnValue1);
                        postedData.Add(postWindow.returnValue2);
                        UpdatePostBox();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        //used to display get window
        private void GetButton_Click(object sender, EventArgs e)
        {
            using (var getWindow = new GetForm())
            {
                switch (getWindow.ShowDialog())
                {
                    case DialogResult.OK:
                        getRequest.Add(getWindow.returnValue1);
                        getData(getWindow.returnValue1);
                        UpdateGetBox();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        //used to get data from mysql database
        private void getData(string targetTable)
        {
            return;
        }

        //displays all values added
        private void UpdatePostBox()
        {
            string tempText = "";
            for (int i = 0; i != postedTables.Count; i++)
            {
                tempText += "INSERT INTO " + postedTables[i] + " " + postedData[i] + "//";
            }
            TextDisplay.Text = tempText;
        }

        private void UpdateGetBox()
        {
            string tempText = "";
            for (int i = 0; i != getRequest.Count; i++)
            {
                tempText += "SELECT * FROM " + getRequest[i] + "//";
            }
            TextDisplay2.Text = tempText;
        }

        private void TextDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLabel_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FormHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void TextDisplay2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
