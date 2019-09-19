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

            Lines(foxDraw);

        }
        public void Lines(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Red);
            int x = 50;
            int y = 10;
            for (int i = 0; i < 28; i++)
            {
                foxDraw.DrawLine(x, 0, 600, y);
                x += 20;
                y += 20;
            }
            foxDraw.SetStrokeColor(Colors.Blue);
            int a = 50;
            int b = 10;
            for (int i = 0; i < 28; i++)
            {
                foxDraw.DrawLine(0, a, b, 600);
                a += 20;
                b += 20;
            }
        }
        private void InitializeComponent() 
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}