﻿//============================================================
//http://codelover.link author:李国宝
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace HouseCrawler.Web.DataContent
{
    [Serializable()]

    /// <summary>
    /// 
    /// </summary>
    public class DBHouseInfo
    {
        /// <summary>
        /// 
        /// </summary>
		public long Id
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string HouseTitle
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string HouseOnlineURL
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string HouseLocation
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string DisPlayPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? PubTime
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? HousePrice
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string LocationCityName
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public DateTime? DataCreateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public string HouseText
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public DateTime? DataChange_LastTime
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public bool? IsAnalyzed
        {
            get;
            set;
        }

    }
}