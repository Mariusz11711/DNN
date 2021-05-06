﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.Components
{
    using DotNetNuke.Services.Localization;

    public class LocalizationHelper
    {
        private const string ResourceFile = "admin/ControlPanel/App_LocalResources/ControlBar";

        public static string GetControlBarString(string key)
        {
            return Localization.GetString(key, ResourceFile);
        }
    }
}
