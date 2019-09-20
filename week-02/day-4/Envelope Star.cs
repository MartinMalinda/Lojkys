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

            foxDraw.SetBackgroundColor(Colors.Black);
            foxDraw.SetStrokeColor(Colors.Pink);
            Lines(foxDraw);

        }
        public void Lines(FoxDraw foxDraw)
        {
            int y = 0;
            int x = 300;
            int a = 300;
            int b = 600;
            int c = 300;
            int d = 600;
            int e = 20;
            int f = 280;
            for (int i = 0; i < 15; i++)
            {
                foxDraw.DrawLine(300, y, x, 300);
                y += 20;
                x += 20;
            
                foxDraw.DrawLine(300, b, a, 300);
                a += 20;
                b -= 20;
            
                foxDraw.DrawLine(300, d, c, 300)
                d -= 20;
                c -= 20;
           
                foxDraw.DrawLine(e, 300, 300, f);
                e += 20;
                f -= 20;
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}