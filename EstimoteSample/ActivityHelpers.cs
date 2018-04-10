using System;
using Android.App;
using Android.Content;
using EstimoteSdk;
using JavaInteger = Java.Lang.Integer;

namespace Estimotes.Droid
{
    public static class ActivityHelpers
    {
        public static void StartActivityForBeacon<TActivity>(this Activity activity, Beacon beacon) where TActivity : Activity
        {
            Type type = typeof(TActivity);
            Intent intent = new Intent(activity, type);
            intent.PutExtra("beacon", beacon);
            activity.StartActivity(intent);
        }

        public static Tuple<Beacon, Region> GetBeaconAndRegion(this Activity activity)
        {
            Beacon beacon = activity.Intent.GetParcelableExtra("beacon") as Beacon;
            Region region = new Region("region_id", beacon.ProximityUUID, new JavaInteger(beacon.Major), new JavaInteger(beacon.Minor));

            return new Tuple<Beacon, Region>(beacon, region);
        }
    }
}
