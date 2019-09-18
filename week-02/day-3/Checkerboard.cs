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


            double canvasHeight = canvas.Height = 640;
            double canvasWidth = canvas.Width = 640;

            // Fill the canvas with a checkerboard pattern.
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                CheckerBoardOdd(foxDraw, 0, j);
                j += 40;
                CheckerBoardEven(foxDraw, 0, j);
                j += 40;
            }
        }
        public static void CheckerBoardOdd(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetFillColor(Colors.White);
            for (int i = 0; i < 16; i++)
            {
                foxDraw.DrawRectangle(x, y, 40, 40);
                x += 40;
                if (i % 2 == 0)
                {
                    foxDraw.SetFillColor(Colors.Black);
                }
                else
                {
                    foxDraw.SetFillColor(Colors.White);
                }
            }
        }
        public static void CheckerBoardEven(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetFillColor(Colors.Black);
            for (int i = 0; i < 16; i++)
            {
                foxDraw.DrawRectangle(x, y, 40, 40);
                x += 40;
                if (i % 2 == 1)
                {
                    foxDraw.SetFillColor(Colors.Black);
                }
                else
                {
                    foxDraw.SetFillColor(Colors.White);
                }
            }
        }
        private void InitializeComponent() 
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}