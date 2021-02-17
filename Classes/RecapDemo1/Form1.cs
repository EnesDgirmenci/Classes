using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }



        public void GenerateButtons()
        {//Dama tahtası yapımı
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {//sütun
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {//satır //her yeni sütun +50 pixel daha solda
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    //sırası gelen i+j'nin mod 2 si sıfıra eşitse butonu siyah yap değilse beyaz yap
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;

                    }
                    this.Controls.Add(buttons[i, j]);
                }
                //her yeni satıra geçtiği zaman en soldan 0 piksel ve üstten her seferinde +50 pixel daha altta
                top += 50;
                left = 0;
            }


        }
    }
}
