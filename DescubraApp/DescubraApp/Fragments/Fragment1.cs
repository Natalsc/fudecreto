using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;

namespace DescubraApp.Fragments
{
    public class Fragment1 : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);
                Activity.SetContentView(Resource.Layout.main);
                var listView = Activity.FindViewById<ListView>(Resource.Id.lvDados);

                var times = new List<string>
            {
                "Santos",
                "Grêmio",
                "Coritiba",
                "Flamengo",
                "São Paulo",
                "Palmeiras",
                "Vasco",
                "Bahia",
                "Corinthians",
                "Sport",
                "Internacional",
                "Cruzeiro",
                "Atletico",
                "Vitoria"
            };
                var adapter = new ArrayAdapter<string>(Activity, Android.Resource.Layout.SimpleListItem1, times);
                listView.Adapter = adapter;
                listView.ItemClick += (sender, e) =>
                {
                    using (var dialog = new AlertDialog.Builder(Activity))
                    {
                        var posicao = e.Position;
                        var valor = times[posicao];
                        dialog.SetTitle("Time Selecionado");
                        dialog.SetMessage(valor);
                        dialog.Show();
                    }
                };
                // Create your fragment here
            }
            catch (Exception ex)
            {

            }
        }

        public static Fragment1 NewInstance()
        {
            var frag1 = new Fragment1 { Arguments = new Bundle() };
            return frag1;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.fragment1, null);
        }
    }
}