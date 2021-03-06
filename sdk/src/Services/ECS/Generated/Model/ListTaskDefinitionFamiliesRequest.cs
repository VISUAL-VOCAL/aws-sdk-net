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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListTaskDefinitionFamilies operation.
    /// Returns a list of task definition families that are registered to your account (which
    /// may include task definition families that no longer have any <code>ACTIVE</code> task
    /// definition revisions).
    /// 
    ///  
    /// <para>
    /// You can filter out task definition families that do not contain any <code>ACTIVE</code>
    /// task definition revisions by setting the <code>status</code> parameter to <code>ACTIVE</code>.
    /// You can also filter the results with the <code>familyPrefix</code> parameter.
    /// </para>
    /// </summary>
    public partial class ListTaskDefinitionFamiliesRequest : AmazonECSRequest
    {
        private string _familyPrefix;
        private int? _maxResults;
        private string _nextToken;
        private TaskDefinitionFamilyStatus _status;

        /// <summary>
        /// Gets and sets the property FamilyPrefix. 
        /// <para>
        /// The <code>familyPrefix</code> is a string that is used to filter the results of <code>ListTaskDefinitionFamilies</code>.
        /// If you specify a <code>familyPrefix</code>, only task definition family names that
        /// begin with the <code>familyPrefix</code> string are returned.
        /// </para>
        /// </summary>
        public string FamilyPrefix
        {
            get { return this._familyPrefix; }
            set { this._familyPrefix = value; }
        }

        // Check to see if FamilyPrefix property is set
        internal bool IsSetFamilyPrefix()
        {
            return this._familyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of task definition family results returned by <code>ListTaskDefinitionFamilies</code>
        /// in paginated output. When this parameter is used, <code>ListTaskDefinitions</code>
        /// only returns <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>ListTaskDefinitionFamilies</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 100. If this parameter is not used, then <code>ListTaskDefinitionFamilies</code>
        /// returns up to 100 results and a <code>nextToken</code> value if applicable.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListTaskDefinitionFamilies</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The task definition family status with which to filter the <code>ListTaskDefinitionFamilies</code>
        /// results. By default, both <code>ACTIVE</code> and <code>INACTIVE</code> task definition
        /// families are listed. If this parameter is set to <code>ACTIVE</code>, only task definition
        /// families that have an <code>ACTIVE</code> task definition revision are returned. If
        /// this parameter is set to <code>INACTIVE</code>, only task definition families that
        /// do not have any <code>ACTIVE</code> task definition revisions are returned. If you
        /// paginate the resulting output, be sure to keep the <code>status</code> value constant
        /// in each subsequent request.
        /// </para>
        /// </summary>
        public TaskDefinitionFamilyStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}