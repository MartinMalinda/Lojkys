using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;
using System;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);


            double canvasHeight = canvas.Height = 600;
            double canvasWidth = canvas.Width = 800;

            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            foxDraw.SetBackgroundColor(Colors.Black);
            DrawMoon(foxDraw);
            Stars(foxDraw);
        }
        public int RandomNumber(int min, int max)
        {
            
            Random random = new Random();
            return random.Next(min, max);
        }   
        public void Stars (FoxDraw foxDraw)
        {
            List<Color> colors = new List<Color> { Colors.DarkGray, Colors.DarkSlateGray, Colors.DimGray, Colors.Gray, Colors.LightGray, Colors.LightSlateGray, Colors.SlateGray, Colors.LightYellow };
            int ran1; int ran2;
            foreach (var color in colors)
            {
                for (int i = 0; i < 100; i++)
                {
                    foxDraw.SetFillColor(color);
                    do
                    {
                        ran1 = RandomNumber(0, 790);
                        ran2 = RandomNumber(0, 590);
                    } while ((ran1 > 710) && (ran2 < 80));
                    foxDraw.DrawRectangle(ran1, ran2, 10,10);
                }
            }
        }
        public static void DrawMoon (FoxDraw foxDraw)
        {
            foxDraw.SetFillColor(Colors.WhiteSmoke);
            foxDraw.DrawEllipse(720, 0, 80, 80);
        }
        private void InitializeComponent() 
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}