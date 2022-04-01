using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Yousif_Project.Utility
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session,string key,T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            // test remote repo
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value); 
        }
    }
}
