
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PutCopyFolderRequest.cs">
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
  /// Request model for <see cref="GroupDocs.Storage.Cloud.Sdk.PutCopyFolder" /> operation.
  /// </summary>  
  public class PutCopyFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutCopyFolderRequest"/> class.
        /// </summary>        
        public PutCopyFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutCopyFolderRequest"/> class.
        /// </summary>
        /// <param name="path">Source folder path e.g. /Folder1</param>
        /// <param name="newdest">Destination folder path e.g. /Folder2</param>
        /// <param name="storage">User&#39;s source storage name</param>
        /// <param name="destStorage">User&#39;s destination storage name</param>
        public PutCopyFolderRequest(string path, string newdest, string storage = null, string destStorage = null)             
        {
            this.path = path;
            this.newdest = newdest;
            this.storage = storage;
            this.destStorage = destStorage;
        }

        /// <summary>
        /// Source folder path e.g. /Folder1
        /// </summary>  
        public string path { get; set; }

        /// <summary>
        /// Destination folder path e.g. /Folder2
        /// </summary>  
        public string newdest { get; set; }

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
