// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.UI.Modules.Html5
{
    using System.Globalization;
    using System.Web;

    using DotNetNuke.Entities.Users;
    using DotNetNuke.Services.Tokens;

    public class RequestPropertyAccess : IPropertyAccess
    {
        private readonly HttpRequest _request;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPropertyAccess"/> class.
        /// </summary>
        /// <param name="request"></param>
        public RequestPropertyAccess(HttpRequest request)
        {
            this._request = request;
        }

        /// <inheritdoc/>
        public virtual CacheLevel Cacheability
        {
            get { return CacheLevel.notCacheable; }
        }

        /// <inheritdoc/>
        public string GetProperty(string propertyName, string format, CultureInfo formatProvider, UserInfo accessingUser, Scope accessLevel, ref bool propertyNotFound)
        {
            switch (propertyName.ToLowerInvariant())
            {
                case "querystring":
                    return this._request.QueryString.ToString();
            }

            propertyNotFound = true;
            return string.Empty;
        }
    }
}
