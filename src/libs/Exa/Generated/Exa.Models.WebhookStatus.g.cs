
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the webhook
    /// </summary>
    public enum WebhookStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookStatus value)
        {
            return value switch
            {
                WebhookStatus.Active => "active",
                WebhookStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => WebhookStatus.Active,
                "inactive" => WebhookStatus.Inactive,
                _ => null,
            };
        }
    }
}