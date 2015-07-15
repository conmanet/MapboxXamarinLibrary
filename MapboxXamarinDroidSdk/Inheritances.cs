using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace Com.Mapbox.Mapboxsdk.Overlay
{
    public partial class OverlayManager : global::Java.Util.AbstractList
    {
        public override Object Get(int location)
        {
            return null;
        }
    }
}

namespace Com.Almeros.Android.Multitouch
{
    public partial class RotateGestureDetector : global::Com.Almeros.Android.Multitouch.TwoFingerGestureDetector
    {
        protected void HandleInProgressEvent(int p0, MotionEvent p1)
        {
            throw new NotImplementedException();
        }

        protected void HandleStartProgressEvent(int p0, MotionEvent p1)
        {
            throw new NotImplementedException();
        }
    }
    

    public partial class ShoveGestureDetector : global::Com.Almeros.Android.Multitouch.TwoFingerGestureDetector
    {
        protected void HandleInProgressEvent(int p0, MotionEvent p1)
        {
            throw new NotImplementedException();
        }

        protected void HandleStartProgressEvent(int p0, MotionEvent p1)
        {
            throw new NotImplementedException();
        }
    }
}

namespace Com.Mapbox.Mapboxsdk.Tileprovider
{
    public abstract partial class MapTileLayerBase : global::Java.Lang.Object,
        global::Com.Mapbox.Mapboxsdk.Tileprovider.IMapTileProviderCallback
    {
        public partial class CacheTask : global::Android.OS.AsyncTask
        {
            protected override Object DoInBackground(params Object[] @params)
            {
                return null;
            }

        }
    }
}

namespace Com.Almeros.Android.Multitouch
{
    internal partial class TwoFingerGestureDetectorInvoker : TwoFingerGestureDetector
    {
        protected void HandleInProgressEvent(int p0, MotionEvent p1)
        {
            return;
        }

        protected void HandleStartProgressEvent(int p0, MotionEvent p1)
        {
            return;
        }
    }
}