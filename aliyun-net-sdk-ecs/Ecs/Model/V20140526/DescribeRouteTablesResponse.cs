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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeRouteTablesResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<RouteTable> routeTables;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<RouteTable> RouteTables
		{
			get
			{
				return routeTables;
			}
			set	
			{
				routeTables = value;
			}
		}

		public class RouteTable{

			private string vRouterId;

			private string routeTableId;

			private string routeTableType;

			private string creationTime;

			private List<RouteEntry> routeEntrys;

			public string VRouterId
			{
				get
				{
					return vRouterId;
				}
				set	
				{
					vRouterId = value;
				}
			}

			public string RouteTableId
			{
				get
				{
					return routeTableId;
				}
				set	
				{
					routeTableId = value;
				}
			}

			public string RouteTableType
			{
				get
				{
					return routeTableType;
				}
				set	
				{
					routeTableType = value;
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

			public List<RouteEntry> RouteEntrys
			{
				get
				{
					return routeEntrys;
				}
				set	
				{
					routeEntrys = value;
				}
			}

			public class RouteEntry{

				private string routeTableId;

				private string destinationCidrBlock;

				private string type;

				private string status;

				private string instanceId;

				private string nextHopType;

				private List<NextHop> nextHops;

				public string RouteTableId
				{
					get
					{
						return routeTableId;
					}
					set	
					{
						routeTableId = value;
					}
				}

				public string DestinationCidrBlock
				{
					get
					{
						return destinationCidrBlock;
					}
					set	
					{
						destinationCidrBlock = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string NextHopType
				{
					get
					{
						return nextHopType;
					}
					set	
					{
						nextHopType = value;
					}
				}

				public List<NextHop> NextHops
				{
					get
					{
						return nextHops;
					}
					set	
					{
						nextHops = value;
					}
				}

				public class NextHop{

					private string nextHopType;

					private string nextHopId;

					public string NextHopType
					{
						get
						{
							return nextHopType;
						}
						set	
						{
							nextHopType = value;
						}
					}

					public string NextHopId
					{
						get
						{
							return nextHopId;
						}
						set	
						{
							nextHopId = value;
						}
					}
				}
			}
		}
	}
}