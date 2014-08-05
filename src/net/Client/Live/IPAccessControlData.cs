﻿// Copyright 2014 Microsoft Corporation
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    /// <summary>
    /// Specifies IP access control properties.
    /// This is the internal class for the communication to the REST and must match the REST metadata.
    /// </summary>
    internal class IPAccessControlData
    {
        /// <summary>
        /// The list of IP addresses that are allowed to connect to channel endpoint.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public IList<IPRangeData> Allow { get; set; }
    }
}
