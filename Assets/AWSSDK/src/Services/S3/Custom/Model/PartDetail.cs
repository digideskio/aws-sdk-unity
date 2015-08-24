//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A container for elements related to a particular part in a multipart operation. 
    /// A response can contain zero or more Part elements.
    /// </summary>
    public class PartDetail : PartETag
    {
        private DateTime? lastModified;
        private long? size;


        /// <summary>
        /// The date and time at which the part was uploaded.
        /// </summary>
        public DateTime LastModified
        {
            get { return this.lastModified.GetValueOrDefault(); }
            set { this.lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsLastModified()
        {
            return this.lastModified.HasValue;
        }

        /// <summary>
        /// The size of the uploaded part data.
        /// </summary>
        public long Size
        {
            get { return this.size.GetValueOrDefault(); }
            set { this.size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSize()
        {
            return this.size.HasValue;
        }
    }
}
