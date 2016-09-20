using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioAPI.Utils
{
    internal class JSONSerializer
    {
        private static JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public static string Serilaize(object entity)
        {
            return JsonConvert.SerializeObject(entity, JsonSerializerSettings);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}