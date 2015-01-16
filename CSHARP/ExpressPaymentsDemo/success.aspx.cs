﻿/*
*-*-**-***-*****-********-*************
Pay with Amazon Express Payments Demo
Copyright 2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
Licensed under the Apache License, Version 2.0 (the "License"); 
*-*-**-***-*****-********-*************

You may not use this file except in compliance with the License. You may obtain 
a copy of the License at: 

http://aws.amazon.com/apache2.0/

or in the "license" file accompanying this file. This file is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or 
implied. See the License for the specific language governing permissions and 
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("The Transaction was Successful! Following are the parameters returned" + "<br/><br/>");
        foreach (string key in Request.QueryString)
        {
            Response.Write(key + " =      " + Request.QueryString[key] + "<br/>");
        }

    }
}