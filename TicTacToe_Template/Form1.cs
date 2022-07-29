using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Template
{
    public partial class Form1 : Form
    {
        public Button[,] grid;

        public Form1()
        {
            InitializeComponent();
            CreateGrid();
        }

        private void CreateGrid()
        {
            grid = new Button[,]
                { { button1, button2, button3 }, { button4, button5, button6 }, { button7, button8, button9 } };
        }

        private void Cell_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            Point point = (Point) button.Tag;

            if (e.Button == MouseButtons.Left) // regular click
            {
                button_Clicked(point);
            }
        }

        private void button_Clicked(Point p)
        {
            // TODO
        }
    }
}
