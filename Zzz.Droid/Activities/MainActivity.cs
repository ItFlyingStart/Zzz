using System;

using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Shared.Caching;
using MvvmCross.Droid.Support.V7.AppCompat;
using System.Collections.Generic;
using Zzz.Core.ViewModels;
using Zzz.Core.Models;
using Zzz.Droid.Adapters;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Zzz.Droid.Activities
{
    [Activity(Label = "Main Activity"
        , Theme = "@style/Theme.AppCompat"
        , LaunchMode = LaunchMode.SingleTop
        , ScreenOrientation = ScreenOrientation.Portrait
        , Name = "zzz.droid.activities.MainActivity")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        private DrawerLayout _drawerLayout;
        private MvxActionBarDrawerToggle _drawerToggle;
        private FragmentManager _fragmentManager;

        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;


        internal DrawerLayout DrawerLayout { get { return _drawerLayout;  } }

        static MainActivity instance = new MainActivity();
        
        public static MainActivity CurrentActivity => instance;

        public new MainViewModel ViewModel
        {
            get { return (MainViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _fragmentManager = FragmentManager;

            SetContentView(Resource.Layout.MainView);

            //listView = FindViewById<ListView>(Resource.Id.list);

            //tableItems.Add(new TableItem() { Heading = "Bol.com", SubHeading = "Web shop", ImageResourceId = Resource.Drawable.computer });
            //tableItems.Add(new TableItem() { Heading = "Marlink", SubHeading = "Domain login", ImageResourceId = Resource.Drawable.shopcart });

            //listView.Adapter = new OverviewListAdapter(this, tableItems);

            //listView.ItemClick += OnListItemClick;
        }

        //protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
        //{
        //    var listView = sender as ListView;
        //    var t = tableItems[e.Position];
        //    Android.Widget.Toast.MakeText(this, t.Heading, Android.Widget.ToastLength.Short).Show();
        //    Console.WriteLine("Clicked on " + t.Heading);
        //}
    }
}

