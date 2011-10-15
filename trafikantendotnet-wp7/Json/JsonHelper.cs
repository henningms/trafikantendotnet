using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Trafikanten.Json
{
    public class JsonHelper
    {
        public static string Serialize<T>(T obj)
        {
            var ser = new DataContractJsonSerializer(typeof (T));
            
        }

        public static T Deserialize<T>(string json)
        {
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                //parse into jsonser
                var ser =
                    new DataContractJsonSerializer(typeof(T));
                var obj = (T)ser.ReadObject(ms);

                return obj;
            }

        }
    }
}
