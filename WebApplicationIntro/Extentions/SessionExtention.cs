using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApplicationIntro.Extentions
{
    public static class SessionExtention
    {
        public static void SetObject(this ISession session,string key,object entity)
        {
            string entityString = JsonSerializer.Serialize(entity);
            session.SetString(key,entityString);
        }

        public static T GetObject<T>(this ISession session,string key) where T:class
        {
            var entityString = session.GetString(key);
            if (string.IsNullOrEmpty(entityString))
            {
                return null;
            }
            else
            {
                return JsonSerializer.Deserialize<T>(entityString);
            }
        }
    }
}
