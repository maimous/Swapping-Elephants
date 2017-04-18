using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swapping_Elephants
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LloydsButton_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void LucindasButton_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }
    }
}
