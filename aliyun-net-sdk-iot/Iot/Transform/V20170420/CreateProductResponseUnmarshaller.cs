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
using Aliyun.Acs.Iot.Model.V20170420;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20170420
{
    public class CreateProductResponseUnmarshaller
    {
        public static CreateProductResponse Unmarshall(UnmarshallerContext context)
        {
			CreateProductResponse createProductResponse = new CreateProductResponse();

			createProductResponse.HttpResponse = context.HttpResponse;
			createProductResponse.RequestId = context.StringValue("CreateProduct.RequestId");
			createProductResponse.Success = context.BooleanValue("CreateProduct.Success");
			createProductResponse.Code = context.StringValue("CreateProduct.Code");
			createProductResponse.ErrorMessage = context.StringValue("CreateProduct.ErrorMessage");

			CreateProductResponse.CreateProduct_ProductInfo productInfo = new CreateProductResponse.CreateProduct_ProductInfo();
			productInfo.ProductKey = context.StringValue("CreateProduct.ProductInfo.ProductKey");
			productInfo.ProductName = context.StringValue("CreateProduct.ProductInfo.ProductName");
			productInfo.NodeType = context.IntegerValue("CreateProduct.ProductInfo.NodeType");
			productInfo.CatId = context.LongValue("CreateProduct.ProductInfo.CatId");
			productInfo.CreateUserId = context.LongValue("CreateProduct.ProductInfo.CreateUserId");
			productInfo.ProductDesc = context.StringValue("CreateProduct.ProductInfo.ProductDesc");
			productInfo.FromSource = context.StringValue("CreateProduct.ProductInfo.FromSource");
			productInfo.ExtProps = context.StringValue("CreateProduct.ProductInfo.ExtProps");
			productInfo.GmtCreate = context.StringValue("CreateProduct.ProductInfo.GmtCreate");
			productInfo.GmtModified = context.StringValue("CreateProduct.ProductInfo.GmtModified");
			productInfo.ProductSecret = context.StringValue("CreateProduct.ProductInfo.ProductSecret");
			productInfo.Id2 = context.BooleanValue("CreateProduct.ProductInfo.Id2");
			createProductResponse.ProductInfo = productInfo;
        
			return createProductResponse;
        }
    }
}