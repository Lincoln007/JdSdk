#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:44.93114 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 获取预分配的运单号 Response
    /// </summary>
    public class JingdongEtmsWaybillcodeGetResponse : JdResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("resultInfo")]
        [JsonProperty("resultInfo")]
        public ResultInfoDTO ResultInfo
        {
            get;
            set;
        }

    }
}
