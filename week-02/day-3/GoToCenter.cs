using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;
using System;

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
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.
            DrawLines(foxDraw, 0,0);

        }
        public static void DrawLines(FoxDraw foxDraw, int x, int y)
        {
            int j = 0;
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                k += 40;
                j += 20;
                foxDraw.DrawLine(300, 300, k, j);
                
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}