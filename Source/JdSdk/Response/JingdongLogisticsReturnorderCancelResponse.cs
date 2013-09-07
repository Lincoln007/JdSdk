#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:53.02460 +08:00
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
    /// 退货入库单取消 Response
    /// </summary>
    public class JingdongLogisticsReturnorderCancelResponse : JdResponse
    {
        /// <summary>
        /// 取消结果信息
        /// </summary>
        [XmlElement("process_result")]
        [JsonProperty("process_result")]
        public List<ProcessResult> ProcessResult
        {
            get;
            set;
        }

    }
}
