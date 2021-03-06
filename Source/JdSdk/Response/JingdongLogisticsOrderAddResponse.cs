#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:50.80047 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 客户订单 Response
    /// </summary>
    public class JingdongLogisticsOrderAddResponse : JdResponse
    {
        /// <summary>
        /// 处理结果code 1:为成功,其他均为错误
        /// </summary>
        [XmlElement("process_code")]
        [JsonProperty("process_code")]
        public Int64 ProcessCode
        {
            get;
            set;
        }

        /// <summary>
        /// 处理状态含义
        /// </summary>
        [XmlElement("process_status")]
        [JsonProperty("process_status")]
        public String ProcessStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 处理错误信息
        /// </summary>
        [XmlElement("error_message")]
        [JsonProperty("error_message")]
        public String ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        /// JOSL唯一出库单号.
        /// </summary>
        [XmlElement("result_no")]
        [JsonProperty("result_no")]
        public String ResultNo
        {
            get;
            set;
        }

    }
}
