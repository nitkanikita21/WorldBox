using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldBox
{
    public partial class Form1 : Form
    {
        public PictureBox canvas;
        public Graphics controller;
        public Form1()
        {
            InitializeComponent();
            canvas = map;
            controller = canvas.CreateGraphics();
        }

        public void Generate()
        {
            //старт генерации

            //конец генерации
            controller.Save(); // сохранение пикселей
        }

        private void btn_generateRun_Click(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
