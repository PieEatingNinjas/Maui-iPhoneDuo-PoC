# Baseline on iPhone Duo

This is what your app looks like on the iPhone Duo, without rebuilding it.

Build: tag baseline, not rebuilt (see ../baseline/envinfo.md).
Run with:

```
Xcode 27.1
Build version 27A9275

iOS 27.1 (27.1 - 24A94425) - com.apple.CoreSimulator.SimRuntime.iOS-27-1
```

Took the previously built app and installed it on the iPhone Duo simulator:
```
xcrun simctl install [device-identifier] path/to/your/app.app
```

To get the device identifier for the iPhone Duo simulator, run:
```
xcrun simctl list devices | grep -i "iPhone Duo"
```
