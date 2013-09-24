#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:48.77436 +08:00
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
    /// 获取标签信息 Request
    /// </summary>
    public class JingdongKuaicheZnMaterialLabelsSearchRequest : IJdRequest<JingdongKuaicheZnMaterialLabelsSearchResponse>
    {
        public String ApiName
        {
            get{ return "jingdong.kuaiche.zn.material.labels.search"; }
        }

        public String GetParamJson()
        {
            return "{}";
        }

        public void Validate()
        {
        }

    }
}