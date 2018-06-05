﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MS.IoT.MarketingPortal.Web.Models
{
    public class SubscriptionResponseModel
    {
        public List<SubscriptionModel> SubscriptionList { get; set; }     
    }
    public class SubscriptionModel
    {
        public string Id { get; set; }
        public string SubscriptionId { get; set; }
        public string DisplayName { get; set; }
        public SubStateModel State { get; set; }
    }

    public enum SubStateModel
    {
        Enabled = 0,
        Warned = 1,
        PastDue = 2,
        Disabled = 3,
        Deleted = 4
    }
}
