
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public enum RotateApiKeyResponseCode
    {
        /// <summary>
        ///
        /// </summary>
        PreviousSecretActive,
        /// <summary>
        ///
        /// </summary>
        RotationConflict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RotateApiKeyResponseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateApiKeyResponseCode value)
        {
            return value switch
            {
                RotateApiKeyResponseCode.PreviousSecretActive => "previous_secret_active",
                RotateApiKeyResponseCode.RotationConflict => "rotation_conflict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateApiKeyResponseCode? ToEnum(string value)
        {
            return value switch
            {
                "previous_secret_active" => RotateApiKeyResponseCode.PreviousSecretActive,
                "rotation_conflict" => RotateApiKeyResponseCode.RotationConflict,
                _ => null,
            };
        }
    }
}