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
        public static void Lines (FoxDraw foxDraw)
        {
            int a = 0;
            int b = 300;
            double c = 0;
            for (int i = 0; i < 30; i++)
            {
                foxDraw.DrawLine(a, 600, b, c);
                a += 20;
                b += 10;
                c += 20;
            }
            int x = 600;
            int y = 300;
            int z = 0;
            for (int i = 0; i < 30; i++)
            {
                foxDraw.DrawLine(x, 600, y, z);
                x -= 20;
                y -= 10;
                z += 20;
            }
            int l = 0;
            int u = 600;
            int k = 600;
            int g = 600;
            for (int i = 0; i < 30; i++)
            {
                foxDraw.DrawLine(l, u, k, g);
                l += 10;
                u -= 20;
                k -= 10;
                g -= 20;
            }
        }
        private void InitializeComponent() 
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}