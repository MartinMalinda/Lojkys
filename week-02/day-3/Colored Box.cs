using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;

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

            foxDraw.SetBackgroundColor(Colors.Black);
            double canvasHeight = canvas.Height = 600;
            double canvasWidth = canvas.Width = 600;

            // Draw a box that has different colored lines on each edge.

            int x = 100;
            int y = 100;

            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(x, y, 300, 100);

            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(x, y, 100, 300);

            foxDraw.SetStrokeColor(Colors.White);
            foxDraw.DrawLine(300, 100, 300, 300);

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(300, 300, 100, 300);


        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}