using System.IO;
using Newtonsoft.Json;

namespace GuildfordBoroughCouncil.Linq.Json
{
    public static partial class ObjectExtensions
    {
        public static string ToJson(this object obj)
        {
            JsonSerializer js = JsonSerializer.Create(new JsonSerializerSettings());
            var jw = new StringWriter();
            js.Serialize(jw, obj);
            return jw.ToString();
        }
    }
}
