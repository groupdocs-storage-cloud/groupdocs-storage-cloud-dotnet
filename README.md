# GroupDocs.Storage Cloud SDK for .NET
This repository contains GroupDocs.Storage Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Storage Cloud REST APIs in your .NET applications quickly and easily.

See [API Reference](https://apireference.groupdocs.cloud/storage/) for full API specification.
## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/display/gdstoragecloud/Home).

### Prerequisites

To use GroupDocs Storage for Cloud .NET SDK you need to register an account with [GroupDocs Cloud](https://www.groupdocs.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.groupdocs.cloud/#/apps). There is free quota available. For more details, see [GroupDocs Cloud Pricing](https://purchase.groupdocs.cloud/pricing).

### Installation

#### Install GroupDocs.Storage-Cloud via NuGet

From the command line:

	nuget install GroupDocs.Storage-Cloud

From Package Manager:

	PM> Install-Package GroupDocs.Storage-Cloud

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "GroupDocs.Storage-Cloud".
5. Click on the GroupDocs.Storage-Cloud package, select the appropriate version in the right-tab and click *Install*.

### Sample usage
The example below shows how your application has to initiate and download a file using GroupDocs.Storage-Cloud library:
```csharp
var configuration = new Configuration { AppSid = appSid, AppKey = appKey };
StorageApi file = new StorageApi(configuration);
FileGetDownloadRequest request = new FileGetDownloadRequest();
request.path = "TestFile.pdf";
request.storage = "StorageName";
var response = StorageApi.FileGetDownload(request);

```

[Tests](/groupdocs-storage-cloud/groupdocs-storage-cloud-dotnet/tree/master/GroupDocs.Storage.Cloud.Sdk.Tests) contain various examples of using the SDK.

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)



## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.groupdocs.cloud/c/total).
