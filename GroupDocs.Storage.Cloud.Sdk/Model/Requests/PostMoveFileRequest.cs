
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostMoveFileRequest.cs">
//   Copyright (c) 2018 GroupDocs.Storage for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GroupDocs.Storage.Cloud.Sdk.Model.Requests 
{
  using GroupDocs.Storage.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Storage.Cloud.Sdk.PostMoveFile" /> operation.
  /// </summary>  
  public class PostMoveFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostMoveFileRequest"/> class.
        /// </summary>        
        public PostMoveFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePostMoveFileRequest"/> class.
        /// </summary>
        /// <param name="src">Source file path e.g. /fileSource.ext</param>
        /// <param name="dest">Destination file path e.g. /fileDestination.ext</param>
        /// <param name="versionId">Source file&#39;s version,</param>
        /// <param name="storage">User&#39;s source storage name</param>
        /// <param name="destStorage">User&#39;s destination storage name</param>
        public PostMoveFileRequest(string src, string dest, string versionId = null, string storage = null, string destStorage = null)             
        {
            this.src = src;
            this.dest = dest;
            this.versionId = versionId;
            this.storage = storage;
            this.destStorage = destStorage;
        }

        /// <summary>
        /// Source file path e.g. /fileSource.ext
        /// </summary>  
        public string src { get; set; }

        /// <summary>
        /// Destination file path e.g. /fileDestination.ext
        /// </summary>  
        public string dest { get; set; }

        /// <summary>
        /// Source file's version,
        /// </summary>  
        public string versionId { get; set; }

        /// <summary>
        /// User's source storage name
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// User's destination storage name
        /// </summary>  
        public string destStorage { get; set; }
  }
}