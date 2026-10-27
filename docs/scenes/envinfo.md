# Fixed: UIScene lifecycle adopted

Toolchain: unchanged since tag `crash` (see [../crash/envinfo.md](../crash/envinfo.md)).

Followed the manual steps from Gerald Versluis,
[Get Your .NET MAUI App Ready for Xcode 27](https://devblogs.microsoft.com/dotnet/migrate-dotnet-maui-apps-uikit-scene-lifecycle/).

## Changes

```
 IphoneDuo-PoC/IphoneDuo-PoC.csproj           |  1 +
 IphoneDuo-PoC/Platforms/iOS/Info.plist       | 17 +++++++++++++++++
 IphoneDuo-PoC/Platforms/iOS/SceneDelegate.cs |  8 ++++++++
 3 files changed, 26 insertions(+)
```

