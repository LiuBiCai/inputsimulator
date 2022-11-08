using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Tests;

namespace Test
{
    public partial class Form1 : Form
    {
        InputSimulator sim = new InputSimulator();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            var pos = tbAimPos.Text.Split(',');

            sim.Mouse
               .MoveMouseTo(0, 0)
               .Sleep(1000)
               .MoveMouseTo(int.Parse(pos[0])*65535/2015, int.Parse(pos[1]) * 65535 / 1343);
               //.Sleep(1000)
               //.MoveMouseTo(65535 / 2, 65535 / 2);

        }
       
        

        //线程间安全调用windows空间
        delegate void SetTextCallback(string text);//后加的，好好想一想,参数是SetText带的参数。

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbPos.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //this.tbPos.AppendText(text);
                tbPos.Text = text;
                this.tbPos.Refresh();
            }
        }
        // We need to use unmanaged code
        [DllImport("user32.dll")]
        // GetCursorPos() makes everything possible
        static extern bool GetCursorPos(ref Point lpPoint);
        // Variable we will need to count the traveled pixels
        static protected long totalPixels = 0;
        static protected int currX;
        static protected int currY;
        static protected int diffX;
        static protected int diffY;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // New point that will be updated by the function with the current coordinates
            Point defPnt = new Point();
            // Call the function and pass the Point, defPnt
            GetCursorPos(ref defPnt);
            // Now after calling the function, defPnt contains the coordinates which we can read
            tbPos.Text= defPnt.X+","+defPnt.Y;
            
            // If the cursor has moved at all
            if (diffX != defPnt.X | diffY != defPnt.Y)
            {
                // Calculate the distance of movement (in both vertical and horizontal movement)
                diffX = (defPnt.X - currX);
                diffY = (defPnt.Y - currY);
                // The difference will be negative if the cursor was moved left or up
                // and if it is so, make the number positive
                if (diffX < 0)
                {
                    diffX *= -1;
                }
                if (diffY < 0)
                {
                    diffY *= -1;
                }
                // Add to the "pixels traveled" counter
                totalPixels += diffX + diffY;
                // And display inside a label
                //lblTravel.Text = "You have traveled " + totalPixels + " pixels";
            }
            // We need this to see the difference of pixels between two mouse movements
            currX = defPnt.X;
            currY = defPnt.Y;
        }

        private void btnPSNTest_Click(object sender, EventArgs e)
        {
            sim.Mouse.MoveMouseTo
        }
    }
}
