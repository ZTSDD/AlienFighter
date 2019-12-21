using Android.Widget;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlienFighter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private void CanvasPaint(object sender, SKPaintSurfaceEventArgs e)
        //{
        //    var assembly = this.GetType().GetTypeInfo().Assembly;
        //    SKBitmap sKBitmap;
        //    SKBitmap ressKBitmap;
        //    using (var stream = assembly.GetManifestResourceStream("AlienFighter.icon.png"))
        //    {
        //        sKBitmap = SKBitmap.Decode(stream);
        //        ressKBitmap = sKBitmap.Resize(new SKImageInfo(300, 300), SKFilterQuality.High);
        //    }
        //    //var emptyImage = new SKImageInfo(300, 500);
        //    //var skSurface = SKSurface.Create(emptyImage);
        //    //var canvas = skSurface.Canvas;
        //    //canvas.Clear(SKColors.Red);
        //    //canvas.DrawBitmap(sKBitmap, 30, 30);
        //    // we get the current surface from the event args
        //    var surface = e.Surface;
        //    // then we get the canvas that we can draw on
        //    var canvas = surface.Canvas;
        //    // clear the canvas / view
        //    canvas.Clear(SKColors.Cyan);


        //    // create the paint for the filled circle
        //    var circleFill = new SKPaint
        //    {
        //        IsAntialias = true,
        //        Style = SKPaintStyle.Fill,
        //        Color = SKColors.Blue
        //    };

        //    // draw the circle fill
        //    canvas.DrawCircle(100, 100, 40, circleFill);
        //    canvas.DrawBitmap(ressKBitmap, 300, 300);
        //    // create the paint for the circle border
        //    var circleBorder = new SKPaint
        //    {
        //        IsAntialias = true,
        //        Style = SKPaintStyle.Stroke,
        //        Color = SKColors.Red,
        //        StrokeWidth = 5
        //    };

        //    // draw the circle border
        //    canvas.DrawCircle(100, 100, 40, circleBorder);
        // }
    }
}
