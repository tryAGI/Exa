#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchResponse : global::System.IEquatable<SearchResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchResponseVariant1? SearchResponseVariant1 { get; init; }
#else
        public global::Exa.SearchResponseVariant1? SearchResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResponseVariant1))]
#endif
        public bool IsSearchResponseVariant1 => SearchResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchResponseVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchResponseVariant1? value)
        {
            value = SearchResponseVariant1;
            return IsSearchResponseVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.SearchResponseVariant1 PickSearchResponseVariant1() => IsSearchResponseVariant1
            ? SearchResponseVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResponseVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchResponseVariant2? SearchResponseVariant2 { get; init; }
#else
        public global::Exa.SearchResponseVariant2? SearchResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResponseVariant2))]
#endif
        public bool IsSearchResponseVariant2 => SearchResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchResponseVariant2? value)
        {
            value = SearchResponseVariant2;
            return IsSearchResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.SearchResponseVariant2 PickSearchResponseVariant2() => IsSearchResponseVariant2
            ? SearchResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResponse(global::Exa.SearchResponseVariant1 value) => new SearchResponse((global::Exa.SearchResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.SearchResponseVariant1?(SearchResponse @this) => @this.SearchResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SearchResponse(global::Exa.SearchResponseVariant1? value)
        {
            SearchResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchResponse FromSearchResponseVariant1(global::Exa.SearchResponseVariant1? value) => new SearchResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResponse(global::Exa.SearchResponseVariant2 value) => new SearchResponse((global::Exa.SearchResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.SearchResponseVariant2?(SearchResponse @this) => @this.SearchResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SearchResponse(global::Exa.SearchResponseVariant2? value)
        {
            SearchResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchResponse FromSearchResponseVariant2(global::Exa.SearchResponseVariant2? value) => new SearchResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchResponse(
            global::Exa.SearchResponseVariant1? searchResponseVariant1,
            global::Exa.SearchResponseVariant2? searchResponseVariant2
            )
        {
            SearchResponseVariant1 = searchResponseVariant1;
            SearchResponseVariant2 = searchResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchResponseVariant2 as object ??
            SearchResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchResponseVariant1?.ToString() ??
            SearchResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchResponseVariant1 && !IsSearchResponseVariant2 || !IsSearchResponseVariant1 && IsSearchResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.SearchResponseVariant1, TResult>? searchResponseVariant1 = null,
            global::System.Func<global::Exa.SearchResponseVariant2, TResult>? searchResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchResponseVariant1 && searchResponseVariant1 != null)
            {
                return searchResponseVariant1(SearchResponseVariant1!);
            }
            else if (IsSearchResponseVariant2 && searchResponseVariant2 != null)
            {
                return searchResponseVariant2(SearchResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.SearchResponseVariant1>? searchResponseVariant1 = null,

            global::System.Action<global::Exa.SearchResponseVariant2>? searchResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchResponseVariant1)
            {
                searchResponseVariant1?.Invoke(SearchResponseVariant1!);
            }
            else if (IsSearchResponseVariant2)
            {
                searchResponseVariant2?.Invoke(SearchResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.SearchResponseVariant1>? searchResponseVariant1 = null,
            global::System.Action<global::Exa.SearchResponseVariant2>? searchResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchResponseVariant1)
            {
                searchResponseVariant1?.Invoke(SearchResponseVariant1!);
            }
            else if (IsSearchResponseVariant2)
            {
                searchResponseVariant2?.Invoke(SearchResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchResponseVariant1,
                typeof(global::Exa.SearchResponseVariant1),
                SearchResponseVariant2,
                typeof(global::Exa.SearchResponseVariant2),
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
        public bool Equals(SearchResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchResponseVariant1?>.Default.Equals(SearchResponseVariant1, other.SearchResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchResponseVariant2?>.Default.Equals(SearchResponseVariant2, other.SearchResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchResponse obj1, SearchResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchResponse obj1, SearchResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchResponse o && Equals(o);
        }
    }
}
