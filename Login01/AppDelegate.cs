﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Login01
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;

        // Register our storyboard with the app delegate by name
        public static UIStoryboard Storyboard = UIStoryboard.FromName("MainStoryboard", null);
        public static UIViewController initialViewController;

        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // create a new window instance based on the screen size
            window = new UIWindow(UIScreen.MainScreen.Bounds);

            // instantiate an initial ViewController, and set as root ViewController
            initialViewController = Storyboard.InstantiateInitialViewController() as UIViewController;
            window.RootViewController = initialViewController;
            window.MakeKeyAndVisible();

            return true;
        }
    }
}