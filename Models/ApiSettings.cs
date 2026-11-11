namespace Discr.Models
{
    public sealed class ApiSettings
    {
        public const string SectionName = "ApiSettings";

        public string ApiKey { get; init; } = string.Empty;
    }
}
