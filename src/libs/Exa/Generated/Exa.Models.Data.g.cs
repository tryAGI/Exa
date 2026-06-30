#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// The actual operation performed (think, search, or crawl)
    /// </summary>
    public readonly partial struct Data : global::System.IEquatable<Data>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink? Think { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink? Think { get; }
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
            out global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink? value)
        {
            value = Think;
            return IsThink;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink PickThink() => IsThink
            ? Think!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Think' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch? Search { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch? Search { get; }
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
            out global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch? value)
        {
            value = Search;
            return IsSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch PickSearch() => IsSearch
            ? Search!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Search' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl? Crawl { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl? Crawl { get; }
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
            out global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl? value)
        {
            value = Crawl;
            return IsCrawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl PickCrawl() => IsCrawl
            ? Crawl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Crawl' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink value) => new Data((global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink?(Data @this) => @this.Think;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink? value)
        {
            Think = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Data FromThink(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink? value) => new Data(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch value) => new Data((global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch?(Data @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch? value)
        {
            Search = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Data FromSearch(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch? value) => new Data(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl value) => new Data((global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl?(Data @this) => @this.Crawl;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl? value)
        {
            Crawl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Data FromCrawl(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl? value) => new Data(value);

        /// <summary>
        /// 
        /// </summary>
        public Data(
            global::Exa.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType? type,
            global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink? think,
            global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch? search,
            global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl? crawl
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
            global::System.Func<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink, TResult>? think = null,
            global::System.Func<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch, TResult>? search = null,
            global::System.Func<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl, TResult>? crawl = null,
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
            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink>? think = null,

            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch>? search = null,

            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl>? crawl = null,
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
            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink>? think = null,
            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch>? search = null,
            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl>? crawl = null,
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
                typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink),
                Search,
                typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch),
                Crawl,
                typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl),
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
        public bool Equals(Data other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink?>.Default.Equals(Think, other.Think) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl?>.Default.Equals(Crawl, other.Crawl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data obj1, Data obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data obj1, Data obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data o && Equals(o);
        }
    }
}
