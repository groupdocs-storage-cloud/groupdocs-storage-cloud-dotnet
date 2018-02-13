using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Storage.Cloud.Dotnet.Sdk.Test
{
    using System.Diagnostics;
    using System.IO;
    using System.Threading;
    using GroupDocs.Storage.Cloud.Sdk.Api;
    using GroupDocs.Storage.Cloud.Sdk.Model.Requests;
    using NMock;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using GroupDocs.Storage.Cloud.Sdk;


    /// <summary>
    /// Tests of OAuth2 authentification
    /// </summary>
    [TestClass]
    public class OAuthTests
    {
        private const string AppKey = "5a4e8d294b50090833f5bdbd17ad3764";
        private const string AppSid = "cdea1bc8-816a-497c-9be8-063b79b57b46";
        private const string AppUrl = "http://localhost:8081";
        private readonly string dataFolder = Path.Combine("sdktests/dotnet", "filesTests");
        private readonly string storageName = "StorageName";

        /// <summary>
        /// If token is not valid, refresh token should be successfully.
        /// Ignored because we use local server to test this feature (access token is expired in 1s)
        /// </summary>
        [TestMethod]
        [Ignore]
        public void IfTokenIsNotValidRefreshTokenShouldBeSuccessfully()
        {
            // Arrange         
            var api =
                new FileApi(
                    new Configuration
                    {
                        AppKey = AppKey,
                        AppSid = AppSid,
                        ApiBaseUrl = AppUrl,
                        AuthType = AuthType.OAuth2,
                        DebugMode = true
                    });

            using (var stream = this.ToStream("content"))
            {
                var request = new GetDownloadRequest();
                request.path = Path.Combine(dataFolder, "TestFile.pdf");
                request.storage = storageName;
                api.GetDownload(request);

                Thread.Sleep(2000);
                stream.Flush();
                stream.Position = 0;

                var mockFactory = new MockFactory();
                var traceListenerMock = mockFactory.CreateMock<TraceListener>();
                Trace.Listeners.Add(traceListenerMock.MockObject);

                traceListenerMock.Expects.One.Method(p => p.WriteLine(string.Empty)).With(Is.StringContaining("grant_type=refresh_token"));
                traceListenerMock.Expects.AtLeastOne.Method(p => p.WriteLine(string.Empty)).With(Is.Anything);

                // Act
                api.GetDownload(request);

                // Assert                    
                mockFactory.VerifyAllExpectationsHaveBeenMet();
            }
        }

        private Stream ToStream(string str)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
