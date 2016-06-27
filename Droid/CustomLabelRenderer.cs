using Android.Text;
using LabelWrappingTest.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]
namespace LabelWrappingTest.Droid
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.Ellipsize = TextUtils.TruncateAt.End;
                Control.SetMaxLines(2);
            }
        }
    }
}