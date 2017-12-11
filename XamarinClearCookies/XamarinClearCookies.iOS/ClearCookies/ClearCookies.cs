[assembly: Xamarin.Forms.Dependency(typeof(XamarinClearCookies.iOS.ClearCookies.ClearCookies))]
namespace XamarinClearCookies.iOS.ClearCookies
{
    public class ClearCookies : XamarinClearCookies.IClearCookies.IClearCookies
    {
        public bool LetsClearCookies()
        {
            try
            {
                foreach (var cookie in Foundation.NSHttpCookieStorage.SharedStorage.Cookies)
                {
                    Foundation.NSHttpCookieStorage.SharedStorage.DeleteCookie(cookie);
                }

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}