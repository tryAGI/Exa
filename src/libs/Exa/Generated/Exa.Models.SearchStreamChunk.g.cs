#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// Schema for each JSON payload emitted in a `/search` server-sent event stream. Each event is emitted as `data: &lt;json&gt;` and the stream terminates with `data: [DONE]`, which is not represented by this JSON schema.
    /// </summary>
    public readonly partial struct SearchStreamChunk : global::System.IEquatable<SearchStreamChunk>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamChunkVariant1? SearchStreamChunkVariant1 { get; init; }
#else
        public global::Exa.SearchStreamChunkVariant1? SearchStreamChunkVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchStreamChunkVariant1))]
#endif
        public bool IsSearchStreamChunkVariant1 => SearchStreamChunkVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchStreamChunkVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamChunkVariant1? value)
        {
            value = SearchStreamChunkVariant1;
            return IsSearchStreamChunkVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.SearchStreamChunkVariant1 PickSearchStreamChunkVariant1() => IsSearchStreamChunkVariant1
            ? SearchStreamChunkVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchStreamChunkVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamChunkVariant2? SearchStreamChunkVariant2 { get; init; }
#else
        public global::Exa.SearchStreamChunkVariant2? SearchStreamChunkVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchStreamChunkVariant2))]
#endif
        public bool IsSearchStreamChunkVariant2 => SearchStreamChunkVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchStreamChunkVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamChunkVariant2? value)
        {
            value = SearchStreamChunkVariant2;
            return IsSearchStreamChunkVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.SearchStreamChunkVariant2 PickSearchStreamChunkVariant2() => IsSearchStreamChunkVariant2
            ? SearchStreamChunkVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchStreamChunkVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamChunkVariant3? SearchStreamChunkVariant3 { get; init; }
#else
        public global::Exa.SearchStreamChunkVariant3? SearchStreamChunkVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchStreamChunkVariant3))]
#endif
        public bool IsSearchStreamChunkVariant3 => SearchStreamChunkVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchStreamChunkVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamChunkVariant3? value)
        {
            value = SearchStreamChunkVariant3;
            return IsSearchStreamChunkVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.SearchStreamChunkVariant3 PickSearchStreamChunkVariant3() => IsSearchStreamChunkVariant3
            ? SearchStreamChunkVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchStreamChunkVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamChunkVariant4? SearchStreamChunkVariant4 { get; init; }
#else
        public global::Exa.SearchStreamChunkVariant4? SearchStreamChunkVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchStreamChunkVariant4))]
#endif
        public bool IsSearchStreamChunkVariant4 => SearchStreamChunkVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchStreamChunkVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamChunkVariant4? value)
        {
            value = SearchStreamChunkVariant4;
            return IsSearchStreamChunkVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.SearchStreamChunkVariant4 PickSearchStreamChunkVariant4() => IsSearchStreamChunkVariant4
            ? SearchStreamChunkVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchStreamChunkVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamChunkVariant5? SearchStreamChunkVariant5 { get; init; }
#else
        public global::Exa.SearchStreamChunkVariant5? SearchStreamChunkVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchStreamChunkVariant5))]
#endif
        public bool IsSearchStreamChunkVariant5 => SearchStreamChunkVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchStreamChunkVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamChunkVariant5? value)
        {
            value = SearchStreamChunkVariant5;
            return IsSearchStreamChunkVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.SearchStreamChunkVariant5 PickSearchStreamChunkVariant5() => IsSearchStreamChunkVariant5
            ? SearchStreamChunkVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchStreamChunkVariant5' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamChunkVariant6? SearchStreamChunkVariant6 { get; init; }
#else
        public global::Exa.SearchStreamChunkVariant6? SearchStreamChunkVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchStreamChunkVariant6))]
#endif
        public bool IsSearchStreamChunkVariant6 => SearchStreamChunkVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchStreamChunkVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamChunkVariant6? value)
        {
            value = SearchStreamChunkVariant6;
            return IsSearchStreamChunkVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.SearchStreamChunkVariant6 PickSearchStreamChunkVariant6() => IsSearchStreamChunkVariant6
            ? SearchStreamChunkVariant6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchStreamChunkVariant6' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamChunkVariant1 value) => new SearchStreamChunk((global::Exa.SearchStreamChunkVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.SearchStreamChunkVariant1?(SearchStreamChunk @this) => @this.SearchStreamChunkVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamChunkVariant1? value)
        {
            SearchStreamChunkVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchStreamChunk FromSearchStreamChunkVariant1(global::Exa.SearchStreamChunkVariant1? value) => new SearchStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamChunkVariant2 value) => new SearchStreamChunk((global::Exa.SearchStreamChunkVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.SearchStreamChunkVariant2?(SearchStreamChunk @this) => @this.SearchStreamChunkVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamChunkVariant2? value)
        {
            SearchStreamChunkVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchStreamChunk FromSearchStreamChunkVariant2(global::Exa.SearchStreamChunkVariant2? value) => new SearchStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamChunkVariant3 value) => new SearchStreamChunk((global::Exa.SearchStreamChunkVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.SearchStreamChunkVariant3?(SearchStreamChunk @this) => @this.SearchStreamChunkVariant3;

        /// <summary>
        /// 
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamChunkVariant3? value)
        {
            SearchStreamChunkVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchStreamChunk FromSearchStreamChunkVariant3(global::Exa.SearchStreamChunkVariant3? value) => new SearchStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamChunkVariant4 value) => new SearchStreamChunk((global::Exa.SearchStreamChunkVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.SearchStreamChunkVariant4?(SearchStreamChunk @this) => @this.SearchStreamChunkVariant4;

        /// <summary>
        /// 
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamChunkVariant4? value)
        {
            SearchStreamChunkVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchStreamChunk FromSearchStreamChunkVariant4(global::Exa.SearchStreamChunkVariant4? value) => new SearchStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamChunkVariant5 value) => new SearchStreamChunk((global::Exa.SearchStreamChunkVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.SearchStreamChunkVariant5?(SearchStreamChunk @this) => @this.SearchStreamChunkVariant5;

        /// <summary>
        /// 
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamChunkVariant5? value)
        {
            SearchStreamChunkVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchStreamChunk FromSearchStreamChunkVariant5(global::Exa.SearchStreamChunkVariant5? value) => new SearchStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamChunkVariant6 value) => new SearchStreamChunk((global::Exa.SearchStreamChunkVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.SearchStreamChunkVariant6?(SearchStreamChunk @this) => @this.SearchStreamChunkVariant6;

        /// <summary>
        /// 
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamChunkVariant6? value)
        {
            SearchStreamChunkVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchStreamChunk FromSearchStreamChunkVariant6(global::Exa.SearchStreamChunkVariant6? value) => new SearchStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchStreamChunk(
            global::Exa.SearchStreamChunkVariant1? searchStreamChunkVariant1,
            global::Exa.SearchStreamChunkVariant2? searchStreamChunkVariant2,
            global::Exa.SearchStreamChunkVariant3? searchStreamChunkVariant3,
            global::Exa.SearchStreamChunkVariant4? searchStreamChunkVariant4,
            global::Exa.SearchStreamChunkVariant5? searchStreamChunkVariant5,
            global::Exa.SearchStreamChunkVariant6? searchStreamChunkVariant6
            )
        {
            SearchStreamChunkVariant1 = searchStreamChunkVariant1;
            SearchStreamChunkVariant2 = searchStreamChunkVariant2;
            SearchStreamChunkVariant3 = searchStreamChunkVariant3;
            SearchStreamChunkVariant4 = searchStreamChunkVariant4;
            SearchStreamChunkVariant5 = searchStreamChunkVariant5;
            SearchStreamChunkVariant6 = searchStreamChunkVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchStreamChunkVariant6 as object ??
            SearchStreamChunkVariant5 as object ??
            SearchStreamChunkVariant4 as object ??
            SearchStreamChunkVariant3 as object ??
            SearchStreamChunkVariant2 as object ??
            SearchStreamChunkVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchStreamChunkVariant1?.ToString() ??
            SearchStreamChunkVariant2?.ToString() ??
            SearchStreamChunkVariant3?.ToString() ??
            SearchStreamChunkVariant4?.ToString() ??
            SearchStreamChunkVariant5?.ToString() ??
            SearchStreamChunkVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchStreamChunkVariant1 && !IsSearchStreamChunkVariant2 && !IsSearchStreamChunkVariant3 && !IsSearchStreamChunkVariant4 && !IsSearchStreamChunkVariant5 && !IsSearchStreamChunkVariant6 || !IsSearchStreamChunkVariant1 && IsSearchStreamChunkVariant2 && !IsSearchStreamChunkVariant3 && !IsSearchStreamChunkVariant4 && !IsSearchStreamChunkVariant5 && !IsSearchStreamChunkVariant6 || !IsSearchStreamChunkVariant1 && !IsSearchStreamChunkVariant2 && IsSearchStreamChunkVariant3 && !IsSearchStreamChunkVariant4 && !IsSearchStreamChunkVariant5 && !IsSearchStreamChunkVariant6 || !IsSearchStreamChunkVariant1 && !IsSearchStreamChunkVariant2 && !IsSearchStreamChunkVariant3 && IsSearchStreamChunkVariant4 && !IsSearchStreamChunkVariant5 && !IsSearchStreamChunkVariant6 || !IsSearchStreamChunkVariant1 && !IsSearchStreamChunkVariant2 && !IsSearchStreamChunkVariant3 && !IsSearchStreamChunkVariant4 && IsSearchStreamChunkVariant5 && !IsSearchStreamChunkVariant6 || !IsSearchStreamChunkVariant1 && !IsSearchStreamChunkVariant2 && !IsSearchStreamChunkVariant3 && !IsSearchStreamChunkVariant4 && !IsSearchStreamChunkVariant5 && IsSearchStreamChunkVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.SearchStreamChunkVariant1, TResult>? searchStreamChunkVariant1 = null,
            global::System.Func<global::Exa.SearchStreamChunkVariant2, TResult>? searchStreamChunkVariant2 = null,
            global::System.Func<global::Exa.SearchStreamChunkVariant3, TResult>? searchStreamChunkVariant3 = null,
            global::System.Func<global::Exa.SearchStreamChunkVariant4, TResult>? searchStreamChunkVariant4 = null,
            global::System.Func<global::Exa.SearchStreamChunkVariant5, TResult>? searchStreamChunkVariant5 = null,
            global::System.Func<global::Exa.SearchStreamChunkVariant6, TResult>? searchStreamChunkVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchStreamChunkVariant1 && searchStreamChunkVariant1 != null)
            {
                return searchStreamChunkVariant1(SearchStreamChunkVariant1!);
            }
            else if (IsSearchStreamChunkVariant2 && searchStreamChunkVariant2 != null)
            {
                return searchStreamChunkVariant2(SearchStreamChunkVariant2!);
            }
            else if (IsSearchStreamChunkVariant3 && searchStreamChunkVariant3 != null)
            {
                return searchStreamChunkVariant3(SearchStreamChunkVariant3!);
            }
            else if (IsSearchStreamChunkVariant4 && searchStreamChunkVariant4 != null)
            {
                return searchStreamChunkVariant4(SearchStreamChunkVariant4!);
            }
            else if (IsSearchStreamChunkVariant5 && searchStreamChunkVariant5 != null)
            {
                return searchStreamChunkVariant5(SearchStreamChunkVariant5!);
            }
            else if (IsSearchStreamChunkVariant6 && searchStreamChunkVariant6 != null)
            {
                return searchStreamChunkVariant6(SearchStreamChunkVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.SearchStreamChunkVariant1>? searchStreamChunkVariant1 = null,

            global::System.Action<global::Exa.SearchStreamChunkVariant2>? searchStreamChunkVariant2 = null,

            global::System.Action<global::Exa.SearchStreamChunkVariant3>? searchStreamChunkVariant3 = null,

            global::System.Action<global::Exa.SearchStreamChunkVariant4>? searchStreamChunkVariant4 = null,

            global::System.Action<global::Exa.SearchStreamChunkVariant5>? searchStreamChunkVariant5 = null,

            global::System.Action<global::Exa.SearchStreamChunkVariant6>? searchStreamChunkVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchStreamChunkVariant1)
            {
                searchStreamChunkVariant1?.Invoke(SearchStreamChunkVariant1!);
            }
            else if (IsSearchStreamChunkVariant2)
            {
                searchStreamChunkVariant2?.Invoke(SearchStreamChunkVariant2!);
            }
            else if (IsSearchStreamChunkVariant3)
            {
                searchStreamChunkVariant3?.Invoke(SearchStreamChunkVariant3!);
            }
            else if (IsSearchStreamChunkVariant4)
            {
                searchStreamChunkVariant4?.Invoke(SearchStreamChunkVariant4!);
            }
            else if (IsSearchStreamChunkVariant5)
            {
                searchStreamChunkVariant5?.Invoke(SearchStreamChunkVariant5!);
            }
            else if (IsSearchStreamChunkVariant6)
            {
                searchStreamChunkVariant6?.Invoke(SearchStreamChunkVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.SearchStreamChunkVariant1>? searchStreamChunkVariant1 = null,
            global::System.Action<global::Exa.SearchStreamChunkVariant2>? searchStreamChunkVariant2 = null,
            global::System.Action<global::Exa.SearchStreamChunkVariant3>? searchStreamChunkVariant3 = null,
            global::System.Action<global::Exa.SearchStreamChunkVariant4>? searchStreamChunkVariant4 = null,
            global::System.Action<global::Exa.SearchStreamChunkVariant5>? searchStreamChunkVariant5 = null,
            global::System.Action<global::Exa.SearchStreamChunkVariant6>? searchStreamChunkVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchStreamChunkVariant1)
            {
                searchStreamChunkVariant1?.Invoke(SearchStreamChunkVariant1!);
            }
            else if (IsSearchStreamChunkVariant2)
            {
                searchStreamChunkVariant2?.Invoke(SearchStreamChunkVariant2!);
            }
            else if (IsSearchStreamChunkVariant3)
            {
                searchStreamChunkVariant3?.Invoke(SearchStreamChunkVariant3!);
            }
            else if (IsSearchStreamChunkVariant4)
            {
                searchStreamChunkVariant4?.Invoke(SearchStreamChunkVariant4!);
            }
            else if (IsSearchStreamChunkVariant5)
            {
                searchStreamChunkVariant5?.Invoke(SearchStreamChunkVariant5!);
            }
            else if (IsSearchStreamChunkVariant6)
            {
                searchStreamChunkVariant6?.Invoke(SearchStreamChunkVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchStreamChunkVariant1,
                typeof(global::Exa.SearchStreamChunkVariant1),
                SearchStreamChunkVariant2,
                typeof(global::Exa.SearchStreamChunkVariant2),
                SearchStreamChunkVariant3,
                typeof(global::Exa.SearchStreamChunkVariant3),
                SearchStreamChunkVariant4,
                typeof(global::Exa.SearchStreamChunkVariant4),
                SearchStreamChunkVariant5,
                typeof(global::Exa.SearchStreamChunkVariant5),
                SearchStreamChunkVariant6,
                typeof(global::Exa.SearchStreamChunkVariant6),
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
        public bool Equals(SearchStreamChunk other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamChunkVariant1?>.Default.Equals(SearchStreamChunkVariant1, other.SearchStreamChunkVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamChunkVariant2?>.Default.Equals(SearchStreamChunkVariant2, other.SearchStreamChunkVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamChunkVariant3?>.Default.Equals(SearchStreamChunkVariant3, other.SearchStreamChunkVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamChunkVariant4?>.Default.Equals(SearchStreamChunkVariant4, other.SearchStreamChunkVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamChunkVariant5?>.Default.Equals(SearchStreamChunkVariant5, other.SearchStreamChunkVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamChunkVariant6?>.Default.Equals(SearchStreamChunkVariant6, other.SearchStreamChunkVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchStreamChunk obj1, SearchStreamChunk obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchStreamChunk>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchStreamChunk obj1, SearchStreamChunk obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchStreamChunk o && Equals(o);
        }
    }
}
