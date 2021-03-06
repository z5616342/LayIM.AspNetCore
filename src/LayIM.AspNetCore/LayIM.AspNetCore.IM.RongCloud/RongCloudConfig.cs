﻿using LayIM.AspNetCore.Core.IM;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayIM.AspNetCore.IM.RongCloud
{
    public class RongCloudConfig : ILayIMAppInfo
    {
        private string appKey;
        private string appSecret;
        public string AppKey
        {
            get
            {
                return appKey;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("rongcloud appkey must not be null or empty");
                }
                appKey = value;
            }
        }
        public string AppSecret
        {
            get
            {
                return appSecret;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("rongcloud appsecret must not be null or empty");
                }
                appSecret = value;
            }
        }
    }
}
