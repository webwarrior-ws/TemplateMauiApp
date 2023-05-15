using Android.App;
using Android.Content.PM;
using Android.OS;

namespace TemplateMauiApp;

[Activity(Theme = "@style/ImprovedTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}
