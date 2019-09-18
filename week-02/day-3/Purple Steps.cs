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

            Rectangle(foxDraw, 20);

            
        }
        public static void Rectangle (FoxDraw foxDraw, int howMany)
        {
            int x = 10;
            int y = 10;

            for (int i = 0; i < howMany; i++)
            {
                foxDraw.SetFillColor(Colors.Purple);
                foxDraw.DrawRectangle(x, y, 15, 15);
                x += 15;
                y += 15;
            }
        }
            private void InitializeComponent() 
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}