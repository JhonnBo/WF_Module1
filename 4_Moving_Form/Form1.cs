using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Moving_Form
{
    public partial class Form1 : Form
    {
        int left;
        int top;
        public Form1()
        {
            InitializeComponent();
            Width = 300;
            Height = 300;
            StartPosition = FormStartPosition.Manual;
            left = (Screen.PrimaryScreen.Bounds.Width - 300) / 2;
            top = (Screen.PrimaryScreen.Bounds.Height - 300) / 2;
            Location = new Point(left, top);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Form frm = (Form)sender;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    --left;
                    break;
                case Keys.Right:
                    ++left;
                    break;
                case Keys.Up:
                    --top;
                    break;
                case Keys.Down:
                    ++top;
                    break;
            }
            frm.Location = new Point(left, top);
        }
    }
}
