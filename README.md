# XamarinClearCookies
With this Package you can clear all applicaion's cookies. So if you are already logged in with your social media account you can simply log out with this.

NOTE: This NuGetPackage will create 2 other folders:  iOS and Droid. These two folders you have to move to the each Platform's project like this: Droid/ClearCookies folder -> <your_project_name>.Droid iOS/ClearCookies folder -> <your_project_name>.iOS

Usage:

bool success = DependencyService.Get<IClearCookies.IClearCookies>().LetsClearCookies();
