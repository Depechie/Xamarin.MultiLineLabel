using System;
using LabelWrappingTest.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]
namespace LabelWrappingTest.iOS
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.LineBreakMode = UIKit.UILineBreakMode.TailTruncation;
                Control.Lines = 2;
            }
        }
    }
}

