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

            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.

            Lines(foxDraw, 0, 0);
        }
        public static void Lines (FoxDraw foxDraw, int x, int y)
        {
            for (int i = 0; i < 30; i++)
            {
                foxDraw.DrawLine(x, y, 300, 300);
                x += 20;              
            }
            x = 0;
            for (int j = 0; j < 30; j++)
            {
                foxDraw.DrawLine(x, y, 300, 300);
                y += 20;
            }
            x = 600;
            y = 0;
            for (int k = 0; k < 30; k++)
            {
                foxDraw.DrawLine(x, y, 300, 300);
                y += 20;
            }
            x = 0;
            y = 600;
            for (int l = 0; l < 31; l++)
            {
                foxDraw.DrawLine(x, y, 300, 300);
                x += 20;
            }
        }

        private void InitializeComponent() 
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}