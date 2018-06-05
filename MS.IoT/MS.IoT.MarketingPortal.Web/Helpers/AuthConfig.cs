﻿using Microsoft.Azure.ActiveDirectory.GraphClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MS.IoT.MarketingPortal.Web.Helpers
{
    public static class AuthConfig
    {
        public static class ConfigurationItems
        {
            public static string ClientId
            {
                get
                {
                    return ConfigurationManager.AppSettings["ida:ClientId"];
                }
            }

            public static string AADInstance
            {
                get
                {
                    return ConfigurationManager.AppSettings["ida:AADInstance"];
                }
            }

            public static string Authority
            {
                get
                {
                    return ConfigurationManager.AppSettings["ida:AADInstance"] + "common";
                }
            }

            public static string AppKey
            {
                get
                {
                    return ConfigurationManager.AppSettings["ida:AppKey"];
                }
            }

            public static string GraphAppUri
            {
                get
                {
                    return ConfigurationManager.AppSettings["ida:GraphAppUri"];
                }
            }

            public static string ManagementAppUri
            {
                get
                {
                    return ConfigurationManager.AppSettings["ida:ManagementAppUri"];
                }
            }
                       

            public static string RedirectUri
            {
                get
                {
                    return ConfigurationManager.AppSettings["ida:PostLogoutRedirectUri"];
                }
            }
        }

        public static class SessionItems
        {         
            public static string AuthCode { get; set; }
            public static Uri AuthCodeLastTokenRequestUrl { get; set; }
            public static string UserDomainName { get; set; }
            public static string UserObjectId { get; set; }
            public static string GraphAuthToken { get; set; }
            public static string GraphTargetTenant { get; set; }
            public static string ManagementAuthToken { get; set; }     
        }
    }
}