# Rebuilt with the new toolchain

Same code as tag `baseline`, rebuilt with Xcode 27.1 and workload set 10.0.402.1.
Result: the app shows the splash screen and is terminated (see [crash-log.txt](crash-log.txt)).

```
ProductName:		macOS
ProductVersion:		26.7.2
BuildVersion:		25G332

Xcode 27.1
Build version 27A9275

10.0.403

 Workload version: 10.0.402.1
 Configured to use workload sets when installing new manifests.

 [maui-ios]
   Installation Source: SDK 10.0.400
   Manifest Version:    10.0.110/10.0.100
   Manifest Path:       /usr/local/share/dotnet/sdk-manifests/10.0.100/microsoft.net.sdk.maui/10.0.110/WorkloadManifest.json
   Install Type:        FileBased

 [ios]
   Installation Source: SDK 10.0.400
   Manifest Version:    27.1.10018/10.0.100
   Manifest Path:       /usr/local/share/dotnet/sdk-manifests/10.0.100/microsoft.net.sdk.ios/27.1.10018/WorkloadManifest.json
   Install Type:        FileBased

 [maccatalyst]
   Installation Source: SDK 10.0.400
   Manifest Version:    27.0.10742/10.0.100
   Manifest Path:       /usr/local/share/dotnet/sdk-manifests/10.0.100/microsoft.net.sdk.maccatalyst/27.0.10742/WorkloadManifest.json
   Install Type:        FileBased

 [maui]
   Installation Source: SDK 10.0.400
   Manifest Version:    10.0.110/10.0.100
   Manifest Path:       /usr/local/share/dotnet/sdk-manifests/10.0.100/microsoft.net.sdk.maui/10.0.110/WorkloadManifest.json
   Install Type:        FileBased


```
