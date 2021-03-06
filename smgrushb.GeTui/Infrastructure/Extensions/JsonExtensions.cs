﻿using System.Web.Script.Serialization;

namespace smgrushb.GeTui.Infrastructure.Extensions
{
    internal static class JsonExtensions
    {
        /// <summary>
        /// 将Json反序列化为对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字段</param>
        public static T ToObject<T>(this string json) where T : class
        {
            return new JavaScriptSerializer().Deserialize<T>(json);
        }
    }
}