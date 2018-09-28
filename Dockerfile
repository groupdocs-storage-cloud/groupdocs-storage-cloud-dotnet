# escape=`

FROM microsoft/dotnet-framework:4.7.2-sdk-windowsservercore-ltsc2016 AS build

WORKDIR /app
COPY . .
RUN nuget restore GroupDocs.Storage.Cloud.Sdk.sln

WORKDIR /app
RUN dotnet build GroupDocs.Storage.Cloud.Sdk.sln `
            "/p:TargetFrameworkVersion=v4.7.2" `
            "/p:Configuration=Release" `
            "/p:OutDir=../publish"

FROM build AS testrunner
WORKDIR /app/GroupDocs.Storage.Cloud.Sdk.Tests
ENTRYPOINT ["dotnet", "test", "GroupDocs.Storage.Cloud.Sdk.Tests.csproj", `
            "--no-build", `
            "/p:TargetFrameworkVersion=v4.7.2", `
            "/p:Configuration=Release", `
            "/p:OutDir=../publish", `
			"--logger:trx;LogFileName=GroupDocs.Storage.Cloud.Sdk.Tests.trx", `
			"--results-directory:../publish/TestResults"]

FROM build AS publish
WORKDIR /app
RUN dotnet publish GroupDocs.Storage.Cloud.Sdk.sln `
            "/p:TargetFrameworkVersion=v4.7.2" `
            "/p:Configuration=Release" `
            "/p:OutDir=../publish"