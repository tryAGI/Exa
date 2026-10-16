#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// Any JSON value.
    /// </summary>
    public readonly partial struct JsonValue : global::System.IEquatable<JsonValue>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? JsonValueVariant1 { get; init; }
#else
        public bool? JsonValueVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonValueVariant1))]
#endif
        public bool IsJsonValueVariant1 => JsonValueVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = JsonValueVariant1;
            return IsJsonValueVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickJsonValueVariant1() => JsonValueVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? JsonValueVariant2 { get; init; }
#else
        public double? JsonValueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonValueVariant2))]
#endif
        public bool IsJsonValueVariant2 => JsonValueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = JsonValueVariant2;
            return IsJsonValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickJsonValueVariant2() => JsonValueVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? JsonValueVariant3 { get; init; }
#else
        public string? JsonValueVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonValueVariant3))]
#endif
        public bool IsJsonValueVariant3 => JsonValueVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = JsonValueVariant3;
            return IsJsonValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickJsonValueVariant3() => JsonValueVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Exa.JsonValue?>? JsonValueVariant4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Exa.JsonValue?>? JsonValueVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonValueVariant4))]
#endif
        public bool IsJsonValueVariant4 => JsonValueVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonValueVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Exa.JsonValue?>? value)
        {
            value = JsonValueVariant4;
            return IsJsonValueVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.JsonValue?> PickJsonValueVariant4() => JsonValueVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? JsonValueVariant5 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? JsonValueVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonValueVariant5))]
#endif
        public bool IsJsonValueVariant5 => JsonValueVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonValueVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? value)
        {
            value = JsonValueVariant5;
            return IsJsonValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?> PickJsonValueVariant5() => JsonValueVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator JsonValue(bool value) => new JsonValue((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(JsonValue @this) => @this.JsonValueVariant1;

        /// <summary>
        ///
        /// </summary>
        public JsonValue(bool? value)
        {
            JsonValueVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JsonValue FromJsonValueVariant1(bool? value) => new JsonValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator JsonValue(double value) => new JsonValue((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(JsonValue @this) => @this.JsonValueVariant2;

        /// <summary>
        ///
        /// </summary>
        public JsonValue(double? value)
        {
            JsonValueVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JsonValue FromJsonValueVariant2(double? value) => new JsonValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator JsonValue(string value) => new JsonValue((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(JsonValue @this) => @this.JsonValueVariant3;

        /// <summary>
        ///
        /// </summary>
        public JsonValue(string? value)
        {
            JsonValueVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JsonValue FromJsonValueVariant3(string? value) => new JsonValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator JsonValue(global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?> value) => new JsonValue((global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>?(JsonValue @this) => @this.JsonValueVariant5;

        /// <summary>
        ///
        /// </summary>
        public JsonValue(global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? value)
        {
            JsonValueVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JsonValue FromJsonValueVariant5(global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? value) => new JsonValue(value);

        /// <summary>
        ///
        /// </summary>
        public JsonValue(
            bool? jsonValueVariant1,
            double? jsonValueVariant2,
            string? jsonValueVariant3,
            global::System.Collections.Generic.IList<global::Exa.JsonValue?>? jsonValueVariant4,
            global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? jsonValueVariant5
            )
        {
            JsonValueVariant1 = jsonValueVariant1;
            JsonValueVariant2 = jsonValueVariant2;
            JsonValueVariant3 = jsonValueVariant3;
            JsonValueVariant4 = jsonValueVariant4;
            JsonValueVariant5 = jsonValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JsonValueVariant5 as object ??
            JsonValueVariant4 as object ??
            JsonValueVariant3 as object ??
            JsonValueVariant2 as object ??
            JsonValueVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            JsonValueVariant1?.ToString().ToLowerInvariant() ??
            JsonValueVariant2?.ToString() ??
            JsonValueVariant3?.ToString() ??
            JsonValueVariant4?.ToString() ??
            JsonValueVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsJsonValueVariant1 && !IsJsonValueVariant2 && !IsJsonValueVariant3 && !IsJsonValueVariant4 && !IsJsonValueVariant5 || !IsJsonValueVariant1 && IsJsonValueVariant2 && !IsJsonValueVariant3 && !IsJsonValueVariant4 && !IsJsonValueVariant5 || !IsJsonValueVariant1 && !IsJsonValueVariant2 && IsJsonValueVariant3 && !IsJsonValueVariant4 && !IsJsonValueVariant5 || !IsJsonValueVariant1 && !IsJsonValueVariant2 && !IsJsonValueVariant3 && IsJsonValueVariant4 && !IsJsonValueVariant5 || !IsJsonValueVariant1 && !IsJsonValueVariant2 && !IsJsonValueVariant3 && !IsJsonValueVariant4 && IsJsonValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? jsonValueVariant1 = null,
            global::System.Func<double?, TResult>? jsonValueVariant2 = null,
            global::System.Func<string, TResult>? jsonValueVariant3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Exa.JsonValue?>, TResult>? jsonValueVariant4 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>, TResult>? jsonValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JsonValueVariant1 is { } __value0 && jsonValueVariant1 != null)
            {
                return jsonValueVariant1(__value0);
            }
            else if (JsonValueVariant2 is { } __value1 && jsonValueVariant2 != null)
            {
                return jsonValueVariant2(__value1);
            }
            else if (JsonValueVariant3 is { } __value2 && jsonValueVariant3 != null)
            {
                return jsonValueVariant3(__value2);
            }
            else if (JsonValueVariant4 is { } __value3 && jsonValueVariant4 != null)
            {
                return jsonValueVariant4(__value3);
            }
            else if (JsonValueVariant5 is { } __value4 && jsonValueVariant5 != null)
            {
                return jsonValueVariant5(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<bool?>? jsonValueVariant1 = null,

            global::System.Action<double?>? jsonValueVariant2 = null,

            global::System.Action<string>? jsonValueVariant3 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Exa.JsonValue?>>? jsonValueVariant4 = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? jsonValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JsonValueVariant1 is { } __value0)
            {
                jsonValueVariant1?.Invoke(__value0);
            }
            else if (JsonValueVariant2 is { } __value1)
            {
                jsonValueVariant2?.Invoke(__value1);
            }
            else if (JsonValueVariant3 is { } __value2)
            {
                jsonValueVariant3?.Invoke(__value2);
            }
            else if (JsonValueVariant4 is { } __value3)
            {
                jsonValueVariant4?.Invoke(__value3);
            }
            else if (JsonValueVariant5 is { } __value4)
            {
                jsonValueVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<bool?>? jsonValueVariant1 = null,
            global::System.Action<double?>? jsonValueVariant2 = null,
            global::System.Action<string>? jsonValueVariant3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Exa.JsonValue?>>? jsonValueVariant4 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? jsonValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JsonValueVariant1 is { } __value0)
            {
                jsonValueVariant1?.Invoke(__value0);
            }
            else if (JsonValueVariant2 is { } __value1)
            {
                jsonValueVariant2?.Invoke(__value1);
            }
            else if (JsonValueVariant3 is { } __value2)
            {
                jsonValueVariant3?.Invoke(__value2);
            }
            else if (JsonValueVariant4 is { } __value3)
            {
                jsonValueVariant4?.Invoke(__value3);
            }
            else if (JsonValueVariant5 is { } __value4)
            {
                jsonValueVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonValueVariant1,
                typeof(bool),
                JsonValueVariant2,
                typeof(double),
                JsonValueVariant3,
                typeof(string),
                JsonValueVariant4,
                typeof(global::System.Collections.Generic.IList<global::Exa.JsonValue?>),
                JsonValueVariant5,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(JsonValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(JsonValueVariant1, other.JsonValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(JsonValueVariant2, other.JsonValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(JsonValueVariant3, other.JsonValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Exa.JsonValue?>?>.Default.Equals(JsonValueVariant4, other.JsonValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>?>.Default.Equals(JsonValueVariant5, other.JsonValueVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(JsonValue obj1, JsonValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(JsonValue obj1, JsonValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonValue o && Equals(o);
        }
    }
}
