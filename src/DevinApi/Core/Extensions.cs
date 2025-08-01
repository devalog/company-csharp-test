using System.Runtime.Serialization;

namespace DevinApi.Core;

internal static class Extensions
{
    public static string Stringify(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = (EnumMemberAttribute)
            Attribute.GetCustomAttribute(field, typeof(EnumMemberAttribute));
        return attribute?.Value ?? value.ToString();
    }
}
