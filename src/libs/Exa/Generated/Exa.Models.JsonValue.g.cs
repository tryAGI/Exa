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
        public object? JsonValueVariant1 { get; init; }
#else
        public object? JsonValueVariant1 { get; }
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
            out object? value)
        {
            value = JsonValueVariant1;
            return IsJsonValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickJsonValueVariant1() => IsJsonValueVariant1
            ? JsonValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? JsonValueVariant2 { get; init; }
#else
        public bool? JsonValueVariant2 { get; }
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
            out bool? value)
        {
            value = JsonValueVariant2;
            return IsJsonValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool PickJsonValueVariant2() => IsJsonValueVariant2
            ? JsonValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? JsonValueVariant3 { get; init; }
#else
        public double? JsonValueVariant3 { get; }
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
            out double? value)
        {
            value = JsonValueVariant3;
            return IsJsonValueVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickJsonValueVariant3() => IsJsonValueVariant3
            ? JsonValueVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? JsonValueVariant4 { get; init; }
#else
        public string? JsonValueVariant4 { get; }
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
            out string? value)
        {
            value = JsonValueVariant4;
            return IsJsonValueVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickJsonValueVariant4() => IsJsonValueVariant4
            ? JsonValueVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Exa.JsonValue>? JsonValueVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Exa.JsonValue>? JsonValueVariant5 { get; }
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
            out global::System.Collections.Generic.IList<global::Exa.JsonValue>? value)
        {
            value = JsonValueVariant5;
            return IsJsonValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.JsonValue> PickJsonValueVariant5() => IsJsonValueVariant5
            ? JsonValueVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant5' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? JsonValueVariant6 { get; init; }
#else
        public object? JsonValueVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonValueVariant6))]
#endif
        public bool IsJsonValueVariant6 => JsonValueVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickJsonValueVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = JsonValueVariant6;
            return IsJsonValueVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickJsonValueVariant6() => IsJsonValueVariant6
            ? JsonValueVariant6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueVariant6' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonValue(bool value) => new JsonValue((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(JsonValue @this) => @this.JsonValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public JsonValue(bool? value)
        {
            JsonValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonValue FromJsonValueVariant2(bool? value) => new JsonValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonValue(double value) => new JsonValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(JsonValue @this) => @this.JsonValueVariant3;

        /// <summary>
        /// 
        /// </summary>
        public JsonValue(double? value)
        {
            JsonValueVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonValue FromJsonValueVariant3(double? value) => new JsonValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonValue(string value) => new JsonValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(JsonValue @this) => @this.JsonValueVariant4;

        /// <summary>
        /// 
        /// </summary>
        public JsonValue(string? value)
        {
            JsonValueVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonValue FromJsonValueVariant4(string? value) => new JsonValue(value);

        /// <summary>
        /// 
        /// </summary>
        public JsonValue(
            object? jsonValueVariant1,
            bool? jsonValueVariant2,
            double? jsonValueVariant3,
            string? jsonValueVariant4,
            global::System.Collections.Generic.IList<global::Exa.JsonValue>? jsonValueVariant5,
            object? jsonValueVariant6
            )
        {
            JsonValueVariant1 = jsonValueVariant1;
            JsonValueVariant2 = jsonValueVariant2;
            JsonValueVariant3 = jsonValueVariant3;
            JsonValueVariant4 = jsonValueVariant4;
            JsonValueVariant5 = jsonValueVariant5;
            JsonValueVariant6 = jsonValueVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonValueVariant6 as object ??
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
            JsonValueVariant1?.ToString() ??
            JsonValueVariant2?.ToString().ToLowerInvariant() ??
            JsonValueVariant3?.ToString() ??
            JsonValueVariant4?.ToString() ??
            JsonValueVariant5?.ToString() ??
            JsonValueVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJsonValueVariant1 && !IsJsonValueVariant2 && !IsJsonValueVariant3 && !IsJsonValueVariant4 && !IsJsonValueVariant5 && !IsJsonValueVariant6 || !IsJsonValueVariant1 && IsJsonValueVariant2 && !IsJsonValueVariant3 && !IsJsonValueVariant4 && !IsJsonValueVariant5 && !IsJsonValueVariant6 || !IsJsonValueVariant1 && !IsJsonValueVariant2 && IsJsonValueVariant3 && !IsJsonValueVariant4 && !IsJsonValueVariant5 && !IsJsonValueVariant6 || !IsJsonValueVariant1 && !IsJsonValueVariant2 && !IsJsonValueVariant3 && IsJsonValueVariant4 && !IsJsonValueVariant5 && !IsJsonValueVariant6 || !IsJsonValueVariant1 && !IsJsonValueVariant2 && !IsJsonValueVariant3 && !IsJsonValueVariant4 && IsJsonValueVariant5 && !IsJsonValueVariant6 || !IsJsonValueVariant1 && !IsJsonValueVariant2 && !IsJsonValueVariant3 && !IsJsonValueVariant4 && !IsJsonValueVariant5 && IsJsonValueVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object, TResult>? jsonValueVariant1 = null,
            global::System.Func<bool?, TResult>? jsonValueVariant2 = null,
            global::System.Func<double?, TResult>? jsonValueVariant3 = null,
            global::System.Func<string, TResult>? jsonValueVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Exa.JsonValue>, TResult>? jsonValueVariant5 = null,
            global::System.Func<object, TResult>? jsonValueVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonValueVariant1 && jsonValueVariant1 != null)
            {
                return jsonValueVariant1(JsonValueVariant1!);
            }
            else if (IsJsonValueVariant2 && jsonValueVariant2 != null)
            {
                return jsonValueVariant2(JsonValueVariant2!);
            }
            else if (IsJsonValueVariant3 && jsonValueVariant3 != null)
            {
                return jsonValueVariant3(JsonValueVariant3!);
            }
            else if (IsJsonValueVariant4 && jsonValueVariant4 != null)
            {
                return jsonValueVariant4(JsonValueVariant4!);
            }
            else if (IsJsonValueVariant5 && jsonValueVariant5 != null)
            {
                return jsonValueVariant5(JsonValueVariant5!);
            }
            else if (IsJsonValueVariant6 && jsonValueVariant6 != null)
            {
                return jsonValueVariant6(JsonValueVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object>? jsonValueVariant1 = null,

            global::System.Action<bool?>? jsonValueVariant2 = null,

            global::System.Action<double?>? jsonValueVariant3 = null,

            global::System.Action<string>? jsonValueVariant4 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Exa.JsonValue>>? jsonValueVariant5 = null,

            global::System.Action<object>? jsonValueVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonValueVariant1)
            {
                jsonValueVariant1?.Invoke(JsonValueVariant1!);
            }
            else if (IsJsonValueVariant2)
            {
                jsonValueVariant2?.Invoke(JsonValueVariant2!);
            }
            else if (IsJsonValueVariant3)
            {
                jsonValueVariant3?.Invoke(JsonValueVariant3!);
            }
            else if (IsJsonValueVariant4)
            {
                jsonValueVariant4?.Invoke(JsonValueVariant4!);
            }
            else if (IsJsonValueVariant5)
            {
                jsonValueVariant5?.Invoke(JsonValueVariant5!);
            }
            else if (IsJsonValueVariant6)
            {
                jsonValueVariant6?.Invoke(JsonValueVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<object>? jsonValueVariant1 = null,
            global::System.Action<bool?>? jsonValueVariant2 = null,
            global::System.Action<double?>? jsonValueVariant3 = null,
            global::System.Action<string>? jsonValueVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Exa.JsonValue>>? jsonValueVariant5 = null,
            global::System.Action<object>? jsonValueVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonValueVariant1)
            {
                jsonValueVariant1?.Invoke(JsonValueVariant1!);
            }
            else if (IsJsonValueVariant2)
            {
                jsonValueVariant2?.Invoke(JsonValueVariant2!);
            }
            else if (IsJsonValueVariant3)
            {
                jsonValueVariant3?.Invoke(JsonValueVariant3!);
            }
            else if (IsJsonValueVariant4)
            {
                jsonValueVariant4?.Invoke(JsonValueVariant4!);
            }
            else if (IsJsonValueVariant5)
            {
                jsonValueVariant5?.Invoke(JsonValueVariant5!);
            }
            else if (IsJsonValueVariant6)
            {
                jsonValueVariant6?.Invoke(JsonValueVariant6!);
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
                typeof(object),
                JsonValueVariant2,
                typeof(bool),
                JsonValueVariant3,
                typeof(double),
                JsonValueVariant4,
                typeof(string),
                JsonValueVariant5,
                typeof(global::System.Collections.Generic.IList<global::Exa.JsonValue>),
                JsonValueVariant6,
                typeof(object),
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
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(JsonValueVariant1, other.JsonValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(JsonValueVariant2, other.JsonValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(JsonValueVariant3, other.JsonValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(JsonValueVariant4, other.JsonValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Exa.JsonValue>?>.Default.Equals(JsonValueVariant5, other.JsonValueVariant5) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(JsonValueVariant6, other.JsonValueVariant6) 
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
