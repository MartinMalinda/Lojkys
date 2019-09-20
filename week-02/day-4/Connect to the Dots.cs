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

            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}

            Lines(foxDraw);

        }
        public static void Lines(FoxDraw foxDraw)
        {
            List<Point> StartPoints = new List<Point>();
            StartPoints.Add(new Point(10, 10));
            StartPoints.Add(new Point(290, 290));

            List<Point> EndPoints = new List<Point>();
            EndPoints.Add(new Point(10, 290));
            EndPoints.Add(new Point(290, 10));


            List<Point> StartPoints2 = new List<Point>();
            StartPoints2.Add(new Point(50, 100));
            StartPoints2.Add(new Point(70, 70));
            StartPoints2.Add(new Point(80, 90));
            StartPoints2.Add(new Point(90, 90));
            StartPoints2.Add(new Point(100, 70));
            StartPoints2.Add(new Point(120, 100));
            StartPoints2.Add(new Point(85, 130));
            StartPoints2.Add(new Point(50, 100)); // 7 
            

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.SetStrokeThicknes(2);
            for (int i = 0; i < StartPoints2.Count; i++)
            {
                foxDraw.DrawLine(StartPoints2[i], StartPoints2[i + 1]);
                if (i == 6)
                {
                    break;
                }
            }

            foreach (var start in StartPoints)
            {
                foreach (var end in EndPoints)
                {
                    foxDraw.DrawLine(start, end);
                }
            }

            //int x = 0;
           // foreach (var start in StartPoints)
            //{
              // foreach (var end in EndPoints)
                //{
                    //x++;
                    //foxDraw.DrawLine(start, end);
                    //if (x == 2)
                    //{
                       // return;
                    //}
                //}
            //}
        }
        private void InitializeComponent() 
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}