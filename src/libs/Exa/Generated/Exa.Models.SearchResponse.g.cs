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
        public global::Exa.SearchSynthesisResponse? Synthesis { get; init; }
#else
        public global::Exa.SearchSynthesisResponse? Synthesis { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Synthesis))]
#endif
        public bool IsSynthesis => Synthesis != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSynthesis(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchSynthesisResponse? value)
        {
            value = Synthesis;
            return IsSynthesis;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisResponse PickSynthesis() => Synthesis is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Synthesis' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchResultsResponse? Results { get; init; }
#else
        public global::Exa.SearchResultsResponse? Results { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Results))]
#endif
        public bool IsResults => Results != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResults(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchResultsResponse? value)
        {
            value = Results;
            return IsResults;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultsResponse PickResults() => Results is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Results' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchResponse(global::Exa.SearchSynthesisResponse value) => new SearchResponse((global::Exa.SearchSynthesisResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchSynthesisResponse?(SearchResponse @this) => @this.Synthesis;

        /// <summary>
        ///
        /// </summary>
        public SearchResponse(global::Exa.SearchSynthesisResponse? value)
        {
            Synthesis = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchResponse FromSynthesis(global::Exa.SearchSynthesisResponse? value) => new SearchResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchResponse(global::Exa.SearchResultsResponse value) => new SearchResponse((global::Exa.SearchResultsResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchResultsResponse?(SearchResponse @this) => @this.Results;

        /// <summary>
        ///
        /// </summary>
        public SearchResponse(global::Exa.SearchResultsResponse? value)
        {
            Results = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchResponse FromResults(global::Exa.SearchResultsResponse? value) => new SearchResponse(value);

        /// <summary>
        ///
        /// </summary>
        public SearchResponse(
            global::Exa.SearchSynthesisResponse? synthesis,
            global::Exa.SearchResultsResponse? results
            )
        {
            Synthesis = synthesis;
            Results = results;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Results as object ??
            Synthesis as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Synthesis?.ToString() ??
            Results?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSynthesis && !IsResults || !IsSynthesis && IsResults;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.SearchSynthesisResponse, TResult>? synthesis = null,
            global::System.Func<global::Exa.SearchResultsResponse, TResult>? results = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Synthesis is { } __value0 && synthesis != null)
            {
                return synthesis(__value0);
            }
            else if (Results is { } __value1 && results != null)
            {
                return results(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.SearchSynthesisResponse>? synthesis = null,

            global::System.Action<global::Exa.SearchResultsResponse>? results = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Synthesis is { } __value0)
            {
                synthesis?.Invoke(__value0);
            }
            else if (Results is { } __value1)
            {
                results?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.SearchSynthesisResponse>? synthesis = null,
            global::System.Action<global::Exa.SearchResultsResponse>? results = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Synthesis is { } __value0)
            {
                synthesis?.Invoke(__value0);
            }
            else if (Results is { } __value1)
            {
                results?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Synthesis,
                typeof(global::Exa.SearchSynthesisResponse),
                Results,
                typeof(global::Exa.SearchResultsResponse),
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
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchSynthesisResponse?>.Default.Equals(Synthesis, other.Synthesis) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchResultsResponse?>.Default.Equals(Results, other.Results)
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
