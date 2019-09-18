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
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.
            

            DrawLines(foxDraw, 0, 0);

        }
        public static void DrawLines(FoxDraw foxDraw, int sirka, int vyska)
        {
            sirka = 0;
            vyska = 20;

            foxDraw.SetStrokeThicknes(3);
            int horizontal = 50;
            int vertical = 20;
            Console.Write("How many lines do you want? : ");
            int lines = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                
                foxDraw.DrawLine(sirka, vyska, horizontal, vertical);
                vyska += 20;
                horizontal += 50;
                vertical += 20;

                if (i % 2 == 0)
                {
                    foxDraw.SetStrokeColor(Colors.Blue);
                }
                else
                {
                    foxDraw.SetStrokeColor(Colors.Black);
                }
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}