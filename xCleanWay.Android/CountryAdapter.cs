using System.Collections;
using System.Collections.Generic;
using Android.App;
using Android.Content.Res;
using Android.Views;
using Android.Widget;
using xCleanWay.Ui.Models;

namespace xCleanWay.Android
{
    public class CountryAdapter : BaseAdapter<CountryModel>
    {
        private IList<CountryModel> countries;
        private Activity context;

        public CountryAdapter(Activity context, IList<CountryModel> countries)
        {
            this.context = context;
            this.countries = countries;
        }
        
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var country = countries[position];
            var view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.CountryLayout, null);

            view.FindViewById<TextView>(Resource.Id.CountryNameTextView).Text = country.Name;
            view.FindViewById<TextView>(Resource.Id.CountryIsoTextView).Text = country.IsoCode;

            return view;
        }

        public override int Count => countries.Count;

        public override CountryModel this[int position] => countries[position];
    }
}