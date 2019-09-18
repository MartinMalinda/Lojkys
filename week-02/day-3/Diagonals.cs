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

            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, 600, 600);

            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.SetStrokeThicknes(10);
            foxDraw.DrawLine(0, 600, 600, 0);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}