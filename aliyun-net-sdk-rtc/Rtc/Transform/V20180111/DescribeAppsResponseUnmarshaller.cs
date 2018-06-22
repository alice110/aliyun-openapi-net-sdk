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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.rtc.Model.V20180111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeAppsResponseUnmarshaller
    {
        public static DescribeAppsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAppsResponse describeAppsResponse = new DescribeAppsResponse();

			describeAppsResponse.HttpResponse = context.HttpResponse;
			describeAppsResponse.RequestId = context.StringValue("DescribeApps.RequestId");
			describeAppsResponse.TotalNum = context.IntegerValue("DescribeApps.TotalNum");
			describeAppsResponse.TotalPage = context.IntegerValue("DescribeApps.TotalPage");

			List<DescribeAppsResponse.DescribeApps_App> describeAppsResponse_appList = new List<DescribeAppsResponse.DescribeApps_App>();
			for (int i = 0; i < context.Length("DescribeApps.AppList.Length"); i++) {
				DescribeAppsResponse.DescribeApps_App app = new DescribeAppsResponse.DescribeApps_App();
				app.Status = context.IntegerValue("DescribeApps.AppList["+ i +"].Status");
				app.AppId = context.StringValue("DescribeApps.AppList["+ i +"].AppId");
				app.AppName = context.StringValue("DescribeApps.AppList["+ i +"].AppName");
				app.CreateTime = context.StringValue("DescribeApps.AppList["+ i +"].CreateTime");
				app.AppType = context.StringValue("DescribeApps.AppList["+ i +"].AppType");
				app.BillType = context.StringValue("DescribeApps.AppList["+ i +"].BillType");

				List<string> app_serviceAreas = new List<string>();
				for (int j = 0; j < context.Length("DescribeApps.AppList["+ i +"].ServiceAreas.Length"); j++) {
					app_serviceAreas.Add(context.StringValue("DescribeApps.AppList["+ i +"].ServiceAreas["+ j +"]"));
				}
				app.ServiceAreas = app_serviceAreas;

				describeAppsResponse_appList.Add(app);
			}
			describeAppsResponse.AppList = describeAppsResponse_appList;
        
			return describeAppsResponse;
        }
    }
}