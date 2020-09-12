using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimplexNoise;

namespace WorldBox
{
    public partial class Form1 : Form
    {
        public PictureBox canvas;
        //контроллер 
        public Graphics controller;
        public Random rnd = new Random();

        public void GenerateLandshaftMap()
        {
            //сид для шума
            Noise.Seed = rnd.Next();

            //двухмерный массив с шумом 
            float[,] noise = Noise.Calc2D(700,700,0.05f);

            //перебор массива
            for(int y = 0; y < 500;y++)
            {
                for(int x = 0; x < 500; x++)
                {
                    //получаем точку с шума
                    float pixelNoise = noise[y, x];

                    Color currentPixelColor = GetPixel(x, y);

                    //добавляем яркости взависимости от значения точки из шума
                    currentPixelColor = Color.FromArgb(currentPixelColor.R+(int)pixelNoise, currentPixelColor.G + (int)pixelNoise, currentPixelColor.B + (int)pixelNoise);

                    DrawPixel(currentPixelColor, x, y);
                }
            }
        }
        //получение цвета пикселя (всеровно что ((Bitmap)canvas.Image).GetPixel(x, y);)
        public Color GetPixel(int x,int y)
        {
            return Color.Black;
        }
        //рисование пикселя
        public void DrawPixel(Color color,int x,int y)
        {
            controller.FillRectangle(new SolidBrush(color), x, y, 1, 1);
        }


        public Form1()
        {
            InitializeComponent();
            canvas = map;
            controller = canvas.CreateGraphics();
            controller.FillRectangle(new SolidBrush(Color.Black), 0, 0, canvas.Width, canvas.Height);
        }

        public void Generate()
        {
            //старт генерации

            //сюда добавляются методы-генераторы
            GenerateLandshaftMap();
            

            //конец генерации
            controller.Save(); // сохранение пикселей
        }
        

        private void btn_generateRun_Click(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
