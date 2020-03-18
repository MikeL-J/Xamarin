# Xamarin Spike Details

## Environment Setup

https://docs.microsoft.com/en-us/xamarin/get-started/installation/windows
Install xamarin

Make sure the box to install Andriod SDK is checked

you can see the default paths to the jdk and SDK
Tools > Options > Xamarin > Android Settings:

Xamarin.Android uses JDK 8
Xamarin.Android does not support JDK 9

Understanding Android API levels
https://docs.microsoft.com/en-us/xamarin/android/app-fundamentals/android-api-levels?tabs=windows

You can use the Google Android SDK Manager to install versions of the Android SDK Tools package 
up to version 25.2.3. However, if you need to use a later version of the Android SDK Tools package, 
you must install the Xamarin Android SDK Manager plugin for Visual Studio (available from the Visual 
Studio Marketplace). This is necessary because Google's standalone SDK Manager was deprecated in 
version 25.2.3 of the Android SDK Tools package.
https://docs.microsoft.com/en-us/xamarin/android/get-started/installation/android-sdk

Andriod SDK for Xamarin
https://docs.microsoft.com/en-us/xamarin/android/get-started/installation/android-sdk?tabs=windows

Tools > Android > Android SDK Manager
Install desired API levels (24 and Up for newer devices)

SetUp Device for Development
https://docs.microsoft.com/en-us/xamarin/android/get-started/installation/set-up-device-for-development

Settings -> System -> Advanced -> Developer -> Options -> USB Debugging

## Project Setup

Use the `Mobile App (Xamarin.Forms)` project template when creating a new project.

Should create

- NetStandard library with Xaml views, view models, and models
  - The AppShell.xaml is where the pages for the app's content are defined
- Droid project for Android development
= iOS project for iPhone development
- If selected, a WebApi project

Modifying the Xaml views should allow the Android app to seamlessly update without being touched.
