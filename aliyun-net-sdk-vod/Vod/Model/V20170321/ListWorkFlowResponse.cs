/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class ListWorkFlowResponse : AcsResponse
	{

		private string requestId;

		private List<ListWorkFlow_WorkFlowInfo> workFlowInfoList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<ListWorkFlow_WorkFlowInfo> WorkFlowInfoList
		{
			get
			{
				return workFlowInfoList;
			}
			set	
			{
				workFlowInfoList = value;
			}
		}

		public class ListWorkFlow_WorkFlowInfo
		{

			private string workFlowId;

			private string name;

			private string actionList;

			private string creationTime;

			private string modifyTime;

			public string WorkFlowId
			{
				get
				{
					return workFlowId;
				}
				set	
				{
					workFlowId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string ActionList
			{
				get
				{
					return actionList;
				}
				set	
				{
					actionList = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}
		}
	}
}