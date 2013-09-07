#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:59.29296 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据商家计划编号查询商家计划基本信息 Request
    /// </summary>
    public class JingdongUnionPlanbaseinfoGetRequest : IJdRequest<JingdongUnionPlanbaseinfoGetResponse>
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        [XmlElement("planId")]
        [JsonProperty("planId")]
        public String PlanId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.planbaseinfo.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("planid" ,this.PlanId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("planId", this.PlanId);
        }

    }
}
