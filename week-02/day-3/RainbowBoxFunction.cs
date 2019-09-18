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
            double canvasWidth = canvas.Width = 600;

            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares 
            // (red, orange, yellow, green, blue, indigo, violet).
            Square(foxDraw);

        }
        public static void Square (FoxDraw foxDraw)
        {
            List<Color> colors = new List<Color> { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet };

            int x = 140;
            int y = 140;
            int j = 230;
            int k = 230;

            foreach (var color in colors)
            {
                foxDraw.SetFillColor(color);
                foxDraw.DrawRectangle(j, k, x, y);
                x -= 20;
                y -= 20;
                j += 10;
                k += 10;
            }
        }
            private void InitializeComponent() 
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}