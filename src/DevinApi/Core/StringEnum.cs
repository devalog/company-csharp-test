using System.Text.Json.Serialization;

namespace DevinApi.Core;

public interface IStringEnum : IEquatable<string>
{
    public string Value { get; }
}
