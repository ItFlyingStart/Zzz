using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Views;
using MvvmCross.Droid.Shared.Caching;
using MvvmCross.Droid.Support.V7.AppCompat;
using Zzz.Core.ViewModels;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Zzz.Droid.Activities
{
    [Activity(Label = "Main Activity"
        , Theme = "@style/AppTheme"
        , LaunchMode = LaunchMode.SingleTop
        , ScreenOrientation = ScreenOrientation.Portrait
        , Name = "zzz.droid.activities.MainActivity")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        private DrawerLayout _drawerLayout;
        private MvxActionBarDrawerToggle _drawerToggle;
        private FragmentManager _fragmentManager;

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
        }
    }
}

