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

            // draw four different size and color rectangles.
            // avoid code duplication.

            List<Color> colors = new List<Color> { Colors.Blue, Colors.Pink, Colors.Red, Colors.Green, Colors.Yellow };

            int i = 0;
            int j = 0;

            foreach (var color in colors)
            {
                i += 30;
                j += 30;
                foxDraw.SetFillColor(color);
                foxDraw.DrawRectangle(i, 30, 20, 20);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}