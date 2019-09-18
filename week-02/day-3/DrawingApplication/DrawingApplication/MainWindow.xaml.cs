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

            Rectangle(foxDraw, 6);

            
        }
        public static void Rectangle (FoxDraw foxDraw, int howMany)
        {
            double x = 30;
            double y = 0;
            for (int i = 0; i < 6; i++)
            {
                foxDraw.SetFillColor(Colors.Purple);
                foxDraw.DrawRectangle(y, y, x, x);
                y += x;
                x += x / 4;
            }

        }
            private void InitializeComponent() 
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}