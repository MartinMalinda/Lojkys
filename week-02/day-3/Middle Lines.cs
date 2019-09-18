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
            double canvasHeight = canvas.Height = 600; // set canvas, otherwise it's infinite
            double canvasWidth = canvas.Width = 600; // set canvas, otherwise it's infinite

            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 300, canvas.Width / 2, 300);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(300, 0, 300, 300);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}