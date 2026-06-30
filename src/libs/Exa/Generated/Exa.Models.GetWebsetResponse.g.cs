#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetWebsetResponse : global::System.IEquatable<GetWebsetResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.Webset? Webset { get; init; }
#else
        public global::Exa.Webset? Webset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webset))]
#endif
        public bool IsWebset => Webset != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.Webset? value)
        {
            value = Webset;
            return IsWebset;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.Webset PickWebset() => IsWebset
            ? Webset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webset' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.GetWebsetResponseVariant2? GetWebsetResponseVariant2 { get; init; }
#else
        public global::Exa.GetWebsetResponseVariant2? GetWebsetResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetWebsetResponseVariant2))]
#endif
        public bool IsGetWebsetResponseVariant2 => GetWebsetResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGetWebsetResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.GetWebsetResponseVariant2? value)
        {
            value = GetWebsetResponseVariant2;
            return IsGetWebsetResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.GetWebsetResponseVariant2 PickGetWebsetResponseVariant2() => IsGetWebsetResponseVariant2
            ? GetWebsetResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetWebsetResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetWebsetResponse(global::Exa.Webset value) => new GetWebsetResponse((global::Exa.Webset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.Webset?(GetWebsetResponse @this) => @this.Webset;

        /// <summary>
        /// 
        /// </summary>
        public GetWebsetResponse(global::Exa.Webset? value)
        {
            Webset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetWebsetResponse FromWebset(global::Exa.Webset? value) => new GetWebsetResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetWebsetResponse(global::Exa.GetWebsetResponseVariant2 value) => new GetWebsetResponse((global::Exa.GetWebsetResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.GetWebsetResponseVariant2?(GetWebsetResponse @this) => @this.GetWebsetResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GetWebsetResponse(global::Exa.GetWebsetResponseVariant2? value)
        {
            GetWebsetResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetWebsetResponse FromGetWebsetResponseVariant2(global::Exa.GetWebsetResponseVariant2? value) => new GetWebsetResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public GetWebsetResponse(
            global::Exa.Webset? webset,
            global::Exa.GetWebsetResponseVariant2? getWebsetResponseVariant2
            )
        {
            Webset = webset;
            GetWebsetResponseVariant2 = getWebsetResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetWebsetResponseVariant2 as object ??
            Webset as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Webset?.ToString() ??
            GetWebsetResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebset && IsGetWebsetResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.Webset, TResult>? webset = null,
            global::System.Func<global::Exa.GetWebsetResponseVariant2, TResult>? getWebsetResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebset && webset != null)
            {
                return webset(Webset!);
            }
            else if (IsGetWebsetResponseVariant2 && getWebsetResponseVariant2 != null)
            {
                return getWebsetResponseVariant2(GetWebsetResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.Webset>? webset = null,

            global::System.Action<global::Exa.GetWebsetResponseVariant2>? getWebsetResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebset)
            {
                webset?.Invoke(Webset!);
            }
            else if (IsGetWebsetResponseVariant2)
            {
                getWebsetResponseVariant2?.Invoke(GetWebsetResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.Webset>? webset = null,
            global::System.Action<global::Exa.GetWebsetResponseVariant2>? getWebsetResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebset)
            {
                webset?.Invoke(Webset!);
            }
            else if (IsGetWebsetResponseVariant2)
            {
                getWebsetResponseVariant2?.Invoke(GetWebsetResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Webset,
                typeof(global::Exa.Webset),
                GetWebsetResponseVariant2,
                typeof(global::Exa.GetWebsetResponseVariant2),
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
        public bool Equals(GetWebsetResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.Webset?>.Default.Equals(Webset, other.Webset) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.GetWebsetResponseVariant2?>.Default.Equals(GetWebsetResponseVariant2, other.GetWebsetResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetWebsetResponse obj1, GetWebsetResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetWebsetResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetWebsetResponse obj1, GetWebsetResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetWebsetResponse o && Equals(o);
        }
    }
}
