This project illustrates what I believe to be a bug in Xamarin Forms.

# Expected behavior

All platforms should show the same picture twice, at full size in both cases. (Maybe smaller if the image doesn't fit in its parent, but at least both images should have the same size.)

# Actual behavior

* UWP exhibits the expected behavior.
* iOS shows the image loaded with `ImageSource.FromFile` at full size, and the image loaded with `ImageSource.FromResource` at half size.
* Android shows the image loaded with `ImageSource.FromFile` at full size, and the image loaded with `ImageSource.FromResource` at one-third the size.

Using `ImageSource.FromStream` instead of `ImageSource.FromResource` gives the same results, regardless of whether the stream is created from an embedded resource or from a file on the file system.

# Test environment

* Xamarin Forms v2.0.0.6482 and v2.3.1.114
* Android 5.0 (API 21)
* iOS 9.3
* Windows 10, Build 1056 with UWP v5.0.0 and v5.2.2

Developed with Visual Studio Enterprise 2015 with all updates installed.