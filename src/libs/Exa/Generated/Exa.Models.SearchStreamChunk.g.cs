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
        public global::Exa.SearchStreamChunkDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamTextDeltaChunkOutput? TextDelta { get; init; }
#else
        public global::Exa.SearchStreamTextDeltaChunkOutput? TextDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDelta))]
#endif
        public bool IsTextDelta => TextDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamTextDeltaChunkOutput? value)
        {
            value = TextDelta;
            return IsTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutput PickTextDelta() => TextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamGroundingChunkOutput? Grounding { get; init; }
#else
        public global::Exa.SearchStreamGroundingChunkOutput? Grounding { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Grounding))]
#endif
        public bool IsGrounding => Grounding != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGrounding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamGroundingChunkOutput? value)
        {
            value = Grounding;
            return IsGrounding;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutput PickGrounding() => Grounding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grounding' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamResultsChunkOutput? Results { get; init; }
#else
        public global::Exa.SearchStreamResultsChunkOutput? Results { get; }
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
            out global::Exa.SearchStreamResultsChunkOutput? value)
        {
            value = Results;
            return IsResults;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamResultsChunkOutput PickResults() => Results is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Results' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamResetChunkOutput? StreamReset { get; init; }
#else
        public global::Exa.SearchStreamResetChunkOutput? StreamReset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamReset))]
#endif
        public bool IsStreamReset => StreamReset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamReset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamResetChunkOutput? value)
        {
            value = StreamReset;
            return IsStreamReset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamResetChunkOutput PickStreamReset() => StreamReset is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamReset' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamDoneChunkOutput? Done { get; init; }
#else
        public global::Exa.SearchStreamDoneChunkOutput? Done { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Done))]
#endif
        public bool IsDone => Done != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamDoneChunkOutput? value)
        {
            value = Done;
            return IsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutput PickDone() => Done is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Done' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchStreamErrorChunkOutput? Error { get; init; }
#else
        public global::Exa.SearchStreamErrorChunkOutput? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchStreamErrorChunkOutput? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamErrorChunkOutput PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamTextDeltaChunkOutput value) => new SearchStreamChunk((global::Exa.SearchStreamTextDeltaChunkOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchStreamTextDeltaChunkOutput?(SearchStreamChunk @this) => @this.TextDelta;

        /// <summary>
        ///
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamTextDeltaChunkOutput? value)
        {
            TextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchStreamChunk FromTextDelta(global::Exa.SearchStreamTextDeltaChunkOutput? value) => new SearchStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamGroundingChunkOutput value) => new SearchStreamChunk((global::Exa.SearchStreamGroundingChunkOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchStreamGroundingChunkOutput?(SearchStreamChunk @this) => @this.Grounding;

        /// <summary>
        ///
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamGroundingChunkOutput? value)
        {
            Grounding = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchStreamChunk FromGrounding(global::Exa.SearchStreamGroundingChunkOutput? value) => new SearchStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamResultsChunkOutput value) => new SearchStreamChunk((global::Exa.SearchStreamResultsChunkOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchStreamResultsChunkOutput?(SearchStreamChunk @this) => @this.Results;

        /// <summary>
        ///
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamResultsChunkOutput? value)
        {
            Results = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchStreamChunk FromResults(global::Exa.SearchStreamResultsChunkOutput? value) => new SearchStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamResetChunkOutput value) => new SearchStreamChunk((global::Exa.SearchStreamResetChunkOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchStreamResetChunkOutput?(SearchStreamChunk @this) => @this.StreamReset;

        /// <summary>
        ///
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamResetChunkOutput? value)
        {
            StreamReset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchStreamChunk FromStreamReset(global::Exa.SearchStreamResetChunkOutput? value) => new SearchStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamDoneChunkOutput value) => new SearchStreamChunk((global::Exa.SearchStreamDoneChunkOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchStreamDoneChunkOutput?(SearchStreamChunk @this) => @this.Done;

        /// <summary>
        ///
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamDoneChunkOutput? value)
        {
            Done = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchStreamChunk FromDone(global::Exa.SearchStreamDoneChunkOutput? value) => new SearchStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchStreamChunk(global::Exa.SearchStreamErrorChunkOutput value) => new SearchStreamChunk((global::Exa.SearchStreamErrorChunkOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchStreamErrorChunkOutput?(SearchStreamChunk @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public SearchStreamChunk(global::Exa.SearchStreamErrorChunkOutput? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchStreamChunk FromError(global::Exa.SearchStreamErrorChunkOutput? value) => new SearchStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public SearchStreamChunk(
            global::Exa.SearchStreamChunkDiscriminatorType? type,
            global::Exa.SearchStreamTextDeltaChunkOutput? textDelta,
            global::Exa.SearchStreamGroundingChunkOutput? grounding,
            global::Exa.SearchStreamResultsChunkOutput? results,
            global::Exa.SearchStreamResetChunkOutput? streamReset,
            global::Exa.SearchStreamDoneChunkOutput? done,
            global::Exa.SearchStreamErrorChunkOutput? error
            )
        {
            Type = type;

            TextDelta = textDelta;
            Grounding = grounding;
            Results = results;
            StreamReset = streamReset;
            Done = done;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            Done as object ??
            StreamReset as object ??
            Results as object ??
            Grounding as object ??
            TextDelta as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TextDelta?.ToString() ??
            Grounding?.ToString() ??
            Results?.ToString() ??
            StreamReset?.ToString() ??
            Done?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTextDelta && !IsGrounding && !IsResults && !IsStreamReset && !IsDone && !IsError || !IsTextDelta && IsGrounding && !IsResults && !IsStreamReset && !IsDone && !IsError || !IsTextDelta && !IsGrounding && IsResults && !IsStreamReset && !IsDone && !IsError || !IsTextDelta && !IsGrounding && !IsResults && IsStreamReset && !IsDone && !IsError || !IsTextDelta && !IsGrounding && !IsResults && !IsStreamReset && IsDone && !IsError || !IsTextDelta && !IsGrounding && !IsResults && !IsStreamReset && !IsDone && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.SearchStreamTextDeltaChunkOutput, TResult>? textDelta = null,
            global::System.Func<global::Exa.SearchStreamGroundingChunkOutput, TResult>? grounding = null,
            global::System.Func<global::Exa.SearchStreamResultsChunkOutput, TResult>? results = null,
            global::System.Func<global::Exa.SearchStreamResetChunkOutput, TResult>? streamReset = null,
            global::System.Func<global::Exa.SearchStreamDoneChunkOutput, TResult>? done = null,
            global::System.Func<global::Exa.SearchStreamErrorChunkOutput, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextDelta is { } __value0 && textDelta != null)
            {
                return textDelta(__value0);
            }
            else if (Grounding is { } __value1 && grounding != null)
            {
                return grounding(__value1);
            }
            else if (Results is { } __value2 && results != null)
            {
                return results(__value2);
            }
            else if (StreamReset is { } __value3 && streamReset != null)
            {
                return streamReset(__value3);
            }
            else if (Done is { } __value4 && done != null)
            {
                return done(__value4);
            }
            else if (Error is { } __value5 && error != null)
            {
                return error(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.SearchStreamTextDeltaChunkOutput>? textDelta = null,

            global::System.Action<global::Exa.SearchStreamGroundingChunkOutput>? grounding = null,

            global::System.Action<global::Exa.SearchStreamResultsChunkOutput>? results = null,

            global::System.Action<global::Exa.SearchStreamResetChunkOutput>? streamReset = null,

            global::System.Action<global::Exa.SearchStreamDoneChunkOutput>? done = null,

            global::System.Action<global::Exa.SearchStreamErrorChunkOutput>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextDelta is { } __value0)
            {
                textDelta?.Invoke(__value0);
            }
            else if (Grounding is { } __value1)
            {
                grounding?.Invoke(__value1);
            }
            else if (Results is { } __value2)
            {
                results?.Invoke(__value2);
            }
            else if (StreamReset is { } __value3)
            {
                streamReset?.Invoke(__value3);
            }
            else if (Done is { } __value4)
            {
                done?.Invoke(__value4);
            }
            else if (Error is { } __value5)
            {
                error?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.SearchStreamTextDeltaChunkOutput>? textDelta = null,
            global::System.Action<global::Exa.SearchStreamGroundingChunkOutput>? grounding = null,
            global::System.Action<global::Exa.SearchStreamResultsChunkOutput>? results = null,
            global::System.Action<global::Exa.SearchStreamResetChunkOutput>? streamReset = null,
            global::System.Action<global::Exa.SearchStreamDoneChunkOutput>? done = null,
            global::System.Action<global::Exa.SearchStreamErrorChunkOutput>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextDelta is { } __value0)
            {
                textDelta?.Invoke(__value0);
            }
            else if (Grounding is { } __value1)
            {
                grounding?.Invoke(__value1);
            }
            else if (Results is { } __value2)
            {
                results?.Invoke(__value2);
            }
            else if (StreamReset is { } __value3)
            {
                streamReset?.Invoke(__value3);
            }
            else if (Done is { } __value4)
            {
                done?.Invoke(__value4);
            }
            else if (Error is { } __value5)
            {
                error?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextDelta,
                typeof(global::Exa.SearchStreamTextDeltaChunkOutput),
                Grounding,
                typeof(global::Exa.SearchStreamGroundingChunkOutput),
                Results,
                typeof(global::Exa.SearchStreamResultsChunkOutput),
                StreamReset,
                typeof(global::Exa.SearchStreamResetChunkOutput),
                Done,
                typeof(global::Exa.SearchStreamDoneChunkOutput),
                Error,
                typeof(global::Exa.SearchStreamErrorChunkOutput),
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
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamTextDeltaChunkOutput?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamGroundingChunkOutput?>.Default.Equals(Grounding, other.Grounding) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamResultsChunkOutput?>.Default.Equals(Results, other.Results) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamResetChunkOutput?>.Default.Equals(StreamReset, other.StreamReset) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamDoneChunkOutput?>.Default.Equals(Done, other.Done) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchStreamErrorChunkOutput?>.Default.Equals(Error, other.Error)
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
