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
            float[,] noise = Noise.Calc2D(700,700,0.01f);

            Noise.Seed = rnd.Next();
            float[,] noise2 = Noise.Calc2D(700, 700, 0.01f);

            //перебор массива
            for (int y = 0; y < 500;y++)
            {
                for(int x = 0; x < 500; x++)
                {
                    //получаем точку с шума
                    float pixelNoise = (noise[y, x] + noise2[y, x])/4;
                    pixelNoise /= 2.5f;

                    Color currentPixelColor = GetPixel(x, y);

                    //каналы цвета
                    //добавляем яркости взависимости от значения точки из шума
                    int R = currentPixelColor.R + (int)pixelNoise > 255 ? 255 : currentPixelColor.R + (int)pixelNoise;
                    int G = currentPixelColor.G + (int)pixelNoise > 255 ? 255 : currentPixelColor.G + (int)pixelNoise;
                    int B = currentPixelColor.B + (int)pixelNoise > 255 ? 255 : currentPixelColor.B + (int)pixelNoise;
                    
                    currentPixelColor = Color.FromArgb(R,G,B);

                    DrawPixel(currentPixelColor, x, y);
                }
            }
        }
        //получение цвета пикселя (всеровно что ((Bitmap)canvas.Image).GetPixel(x, y);)
        public Color GetPixel(int x,int y)
        {
            return Color.DarkGreen;
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
