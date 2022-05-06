using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Location = new Point(116, 47);
            button2.Location = new Point(116, 180);
            button1.Size = new Size(180, 72);
            button2.Size = new Size(180, 72);
            Size = new Size(460, 380);
            MaximumSize = new Size(460, 380);
            MinimumSize = new Size(460, 380);
            button1.BackColor = Color.DarkOrchid;//by Данечка
            button2.BackColor = Color.DarkOrchid;
            button1.Font  = new Font(FontFamily.GenericSansSerif ,32);
            button2.Font = new Font(FontFamily.GenericSansSerif, 32);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Location = new Point(button2.Location.X + 4, button2.Location.Y + 2);
            if (button2.Location.X == Size.Width-button2.Size.Width-12|
                button2.Location.Y == Size.Height-button2.Size.Height-34) button2.Location = new Point(116, 170);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(button1.Size.Width-2, button1.Size.Height);
            if (button1.Size.Width < 11) button1.Size = new Size(180, 72);
        }
    }
}
