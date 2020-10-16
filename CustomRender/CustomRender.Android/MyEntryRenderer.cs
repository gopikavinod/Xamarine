using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomRender;
using CustomRenderer.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace CustomRenderer.Android
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var gradientDarawable = new GradientDrawable();
                gradientDarawable.SetCornerRadius(8f);
                gradientDarawable.SetStroke(6, global::Android.Graphics.Color.Black);
                gradientDarawable.SetColor(global::Android.Graphics.Color.White);
                gradientDarawable.SetGradientRadius(8f);
                Control.SetBackground(gradientDarawable);
                Control.SetPadding(10, Control.PaddingTop, Control.PaddingRight,50);
               /* Control.SetBackgroundColor(global::Android.Graphics.Color.White);
                Control.SetTextColor(global::Android.Graphics.Color.Black);*/
               

            }
        }
    }
}