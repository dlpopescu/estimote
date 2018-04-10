using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Estimotes.Droid
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]            
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var items = new string []{ "Scan for Estimotes", "Scan for other nearables", "Scan for Eddystones" };

            ListAdapter = new ArrayAdapter<string>(this, 
                Android.Resource.Layout.SimpleListItem1, 
                Android.Resource.Id.Text1,
                items);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            switch (position)
            {
                case 0:
                    StartActivity(typeof(DiscoverEstimotesActivity));
                    break;
                case 1:
                    StartActivity(typeof(DiscoveryOtherNearablesActivity));
                    break;
                case 2:
                    StartActivity(typeof(DiscoverEddystonesActivity));
                    break;
            }
        }
    }
}

