using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Mapbox.Mapboxsdk.Views.Safecanvas
{
    public partial class SafeTranslatedCanvas : global::Android.Graphics.Canvas,
        global::Com.Mapbox.Mapboxsdk.Views.Safecanvas.ISafeCanvas
    {

        public void DrawColor (int p0)
        {
            return;
        }

        public void DrawColor (int p0, PorterDuff.Mode p1)
        {
            return;
        }

        public int Save (int p0)
        {
            return p0;
        }
    }
}