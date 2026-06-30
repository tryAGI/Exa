#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// The actual operation performed within this task
    /// </summary>
    public readonly partial struct Data2 : global::System.IEquatable<Data2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink? Think { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink? Think { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Think))]
#endif
        public bool IsThink => Think != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThink(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink? value)
        {
            value = Think;
            return IsThink;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink PickThink() => IsThink
            ? Think!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Think' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch? Search { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch? Search { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Search))]
#endif
        public bool IsSearch => Search != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch? value)
        {
            value = Search;
            return IsSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch PickSearch() => IsSearch
            ? Search!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Search' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl? Crawl { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl? Crawl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Crawl))]
#endif
        public bool IsCrawl => Crawl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCrawl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl? value)
        {
            value = Crawl;
            return IsCrawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl PickCrawl() => IsCrawl
            ? Crawl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Crawl' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data2(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink value) => new Data2((global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink?(Data2 @this) => @this.Think;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink? value)
        {
            Think = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Data2 FromThink(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink? value) => new Data2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data2(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch value) => new Data2((global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch?(Data2 @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch? value)
        {
            Search = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Data2 FromSearch(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch? value) => new Data2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data2(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl value) => new Data2((global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl?(Data2 @this) => @this.Crawl;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl? value)
        {
            Crawl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Data2 FromCrawl(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl? value) => new Data2(value);

        /// <summary>
        /// 
        /// </summary>
        public Data2(
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType? type,
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink? think,
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch? search,
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl? crawl
            )
        {
            Type = type;

            Think = think;
            Search = search;
            Crawl = crawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Crawl as object ??
            Search as object ??
            Think as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Think?.ToString() ??
            Search?.ToString() ??
            Crawl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThink && !IsSearch && !IsCrawl || !IsThink && IsSearch && !IsCrawl || !IsThink && !IsSearch && IsCrawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink, TResult>? think = null,
            global::System.Func<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch, TResult>? search = null,
            global::System.Func<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl, TResult>? crawl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThink && think != null)
            {
                return think(Think!);
            }
            else if (IsSearch && search != null)
            {
                return search(Search!);
            }
            else if (IsCrawl && crawl != null)
            {
                return crawl(Crawl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink>? think = null,

            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch>? search = null,

            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl>? crawl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThink)
            {
                think?.Invoke(Think!);
            }
            else if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsCrawl)
            {
                crawl?.Invoke(Crawl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink>? think = null,
            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch>? search = null,
            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl>? crawl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThink)
            {
                think?.Invoke(Think!);
            }
            else if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsCrawl)
            {
                crawl?.Invoke(Crawl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Think,
                typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink),
                Search,
                typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch),
                Crawl,
                typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl),
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
        public bool Equals(Data2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink?>.Default.Equals(Think, other.Think) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl?>.Default.Equals(Crawl, other.Crawl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data2 obj1, Data2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data2 obj1, Data2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data2 o && Equals(o);
        }
    }
}
