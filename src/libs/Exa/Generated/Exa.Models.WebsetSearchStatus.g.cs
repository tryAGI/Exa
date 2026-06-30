
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the search
    /// </summary>
    public enum WebsetSearchStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebsetSearchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetSearchStatus value)
        {
            return value switch
            {
                WebsetSearchStatus.Canceled => "canceled",
                WebsetSearchStatus.Completed => "completed",
                WebsetSearchStatus.Created => "created",
                WebsetSearchStatus.Pending => "pending",
                WebsetSearchStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetSearchStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => WebsetSearchStatus.Canceled,
                "completed" => WebsetSearchStatus.Completed,
                "created" => WebsetSearchStatus.Created,
                "pending" => WebsetSearchStatus.Pending,
                "running" => WebsetSearchStatus.Running,
                _ => null,
            };
        }
    }
}