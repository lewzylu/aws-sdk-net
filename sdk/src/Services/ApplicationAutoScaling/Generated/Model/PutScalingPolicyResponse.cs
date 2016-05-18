/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// This is the response object from the PutScalingPolicy operation.
    /// </summary>
    public partial class PutScalingPolicyResponse : AmazonWebServiceResponse
    {
        private string _policyARN;

        /// <summary>
        /// Gets and sets the property PolicyARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resulting scaling policy.
        /// </para>
        /// </summary>
        public string PolicyARN
        {
            get { return this._policyARN; }
            set { this._policyARN = value; }
        }

        // Check to see if PolicyARN property is set
        internal bool IsSetPolicyARN()
        {
            return this._policyARN != null;
        }

    }
}