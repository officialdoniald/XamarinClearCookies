[assembly: Xamarin.Forms.Dependency(typeof(XamarinClearCookies.Droid.ClearCookies.ClearCookies))]
namespace XamarinClearCookies.Droid.ClearCookies
{
    public class ClearCookies : XamarinClearCookies.IClearCookies.IClearCookies
    {
        public bool LetsClearCookies()
        {
            try
            {
                Android.Webkit.CookieManager.Instance.RemoveAllCookie();

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}