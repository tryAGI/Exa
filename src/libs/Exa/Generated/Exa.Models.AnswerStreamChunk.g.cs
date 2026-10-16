#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// Schema for each JSON payload emitted in an `/answer` server-sent event stream. Each event is emitted as `data: &lt;json&gt;`.
    /// </summary>
    public readonly partial struct AnswerStreamChunk : global::System.IEquatable<AnswerStreamChunk>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.AnswerStreamTextDeltaChunk? TextDelta { get; init; }
#else
        public global::Exa.AnswerStreamTextDeltaChunk? TextDelta { get; }
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
            out global::Exa.AnswerStreamTextDeltaChunk? value)
        {
            value = TextDelta;
            return IsTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamTextDeltaChunk PickTextDelta() => TextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.AnswerStreamCitationsChunkOutput? CitationsOutput { get; init; }
#else
        public global::Exa.AnswerStreamCitationsChunkOutput? CitationsOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CitationsOutput))]
#endif
        public bool IsCitationsOutput => CitationsOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCitationsOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.AnswerStreamCitationsChunkOutput? value)
        {
            value = CitationsOutput;
            return IsCitationsOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamCitationsChunkOutput PickCitationsOutput() => CitationsOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CitationsOutput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.AnswerStreamCostChunkOutput? CostOutput { get; init; }
#else
        public global::Exa.AnswerStreamCostChunkOutput? CostOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CostOutput))]
#endif
        public bool IsCostOutput => CostOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCostOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.AnswerStreamCostChunkOutput? value)
        {
            value = CostOutput;
            return IsCostOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamCostChunkOutput PickCostOutput() => CostOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CostOutput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.AnswerStreamErrorChunkOutput? ErrorOutput { get; init; }
#else
        public global::Exa.AnswerStreamErrorChunkOutput? ErrorOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorOutput))]
#endif
        public bool IsErrorOutput => ErrorOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickErrorOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.AnswerStreamErrorChunkOutput? value)
        {
            value = ErrorOutput;
            return IsErrorOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamErrorChunkOutput PickErrorOutput() => ErrorOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ErrorOutput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnswerStreamChunk(global::Exa.AnswerStreamTextDeltaChunk value) => new AnswerStreamChunk((global::Exa.AnswerStreamTextDeltaChunk?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.AnswerStreamTextDeltaChunk?(AnswerStreamChunk @this) => @this.TextDelta;

        /// <summary>
        ///
        /// </summary>
        public AnswerStreamChunk(global::Exa.AnswerStreamTextDeltaChunk? value)
        {
            TextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnswerStreamChunk FromTextDelta(global::Exa.AnswerStreamTextDeltaChunk? value) => new AnswerStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnswerStreamChunk(global::Exa.AnswerStreamCitationsChunkOutput value) => new AnswerStreamChunk((global::Exa.AnswerStreamCitationsChunkOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.AnswerStreamCitationsChunkOutput?(AnswerStreamChunk @this) => @this.CitationsOutput;

        /// <summary>
        ///
        /// </summary>
        public AnswerStreamChunk(global::Exa.AnswerStreamCitationsChunkOutput? value)
        {
            CitationsOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnswerStreamChunk FromCitationsOutput(global::Exa.AnswerStreamCitationsChunkOutput? value) => new AnswerStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnswerStreamChunk(global::Exa.AnswerStreamCostChunkOutput value) => new AnswerStreamChunk((global::Exa.AnswerStreamCostChunkOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.AnswerStreamCostChunkOutput?(AnswerStreamChunk @this) => @this.CostOutput;

        /// <summary>
        ///
        /// </summary>
        public AnswerStreamChunk(global::Exa.AnswerStreamCostChunkOutput? value)
        {
            CostOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnswerStreamChunk FromCostOutput(global::Exa.AnswerStreamCostChunkOutput? value) => new AnswerStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnswerStreamChunk(global::Exa.AnswerStreamErrorChunkOutput value) => new AnswerStreamChunk((global::Exa.AnswerStreamErrorChunkOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.AnswerStreamErrorChunkOutput?(AnswerStreamChunk @this) => @this.ErrorOutput;

        /// <summary>
        ///
        /// </summary>
        public AnswerStreamChunk(global::Exa.AnswerStreamErrorChunkOutput? value)
        {
            ErrorOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnswerStreamChunk FromErrorOutput(global::Exa.AnswerStreamErrorChunkOutput? value) => new AnswerStreamChunk(value);

        /// <summary>
        ///
        /// </summary>
        public AnswerStreamChunk(
            global::Exa.AnswerStreamTextDeltaChunk? textDelta,
            global::Exa.AnswerStreamCitationsChunkOutput? citationsOutput,
            global::Exa.AnswerStreamCostChunkOutput? costOutput,
            global::Exa.AnswerStreamErrorChunkOutput? errorOutput
            )
        {
            TextDelta = textDelta;
            CitationsOutput = citationsOutput;
            CostOutput = costOutput;
            ErrorOutput = errorOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ErrorOutput as object ??
            CostOutput as object ??
            CitationsOutput as object ??
            TextDelta as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TextDelta?.ToString() ??
            CitationsOutput?.ToString() ??
            CostOutput?.ToString() ??
            ErrorOutput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTextDelta && !IsCitationsOutput && !IsCostOutput && !IsErrorOutput || !IsTextDelta && IsCitationsOutput && !IsCostOutput && !IsErrorOutput || !IsTextDelta && !IsCitationsOutput && IsCostOutput && !IsErrorOutput || !IsTextDelta && !IsCitationsOutput && !IsCostOutput && IsErrorOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.AnswerStreamTextDeltaChunk, TResult>? textDelta = null,
            global::System.Func<global::Exa.AnswerStreamCitationsChunkOutput, TResult>? citationsOutput = null,
            global::System.Func<global::Exa.AnswerStreamCostChunkOutput, TResult>? costOutput = null,
            global::System.Func<global::Exa.AnswerStreamErrorChunkOutput, TResult>? errorOutput = null,
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
            else if (CitationsOutput is { } __value1 && citationsOutput != null)
            {
                return citationsOutput(__value1);
            }
            else if (CostOutput is { } __value2 && costOutput != null)
            {
                return costOutput(__value2);
            }
            else if (ErrorOutput is { } __value3 && errorOutput != null)
            {
                return errorOutput(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.AnswerStreamTextDeltaChunk>? textDelta = null,

            global::System.Action<global::Exa.AnswerStreamCitationsChunkOutput>? citationsOutput = null,

            global::System.Action<global::Exa.AnswerStreamCostChunkOutput>? costOutput = null,

            global::System.Action<global::Exa.AnswerStreamErrorChunkOutput>? errorOutput = null,
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
            else if (CitationsOutput is { } __value1)
            {
                citationsOutput?.Invoke(__value1);
            }
            else if (CostOutput is { } __value2)
            {
                costOutput?.Invoke(__value2);
            }
            else if (ErrorOutput is { } __value3)
            {
                errorOutput?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.AnswerStreamTextDeltaChunk>? textDelta = null,
            global::System.Action<global::Exa.AnswerStreamCitationsChunkOutput>? citationsOutput = null,
            global::System.Action<global::Exa.AnswerStreamCostChunkOutput>? costOutput = null,
            global::System.Action<global::Exa.AnswerStreamErrorChunkOutput>? errorOutput = null,
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
            else if (CitationsOutput is { } __value1)
            {
                citationsOutput?.Invoke(__value1);
            }
            else if (CostOutput is { } __value2)
            {
                costOutput?.Invoke(__value2);
            }
            else if (ErrorOutput is { } __value3)
            {
                errorOutput?.Invoke(__value3);
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
                typeof(global::Exa.AnswerStreamTextDeltaChunk),
                CitationsOutput,
                typeof(global::Exa.AnswerStreamCitationsChunkOutput),
                CostOutput,
                typeof(global::Exa.AnswerStreamCostChunkOutput),
                ErrorOutput,
                typeof(global::Exa.AnswerStreamErrorChunkOutput),
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
        public bool Equals(AnswerStreamChunk other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.AnswerStreamTextDeltaChunk?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.AnswerStreamCitationsChunkOutput?>.Default.Equals(CitationsOutput, other.CitationsOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.AnswerStreamCostChunkOutput?>.Default.Equals(CostOutput, other.CostOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.AnswerStreamErrorChunkOutput?>.Default.Equals(ErrorOutput, other.ErrorOutput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnswerStreamChunk obj1, AnswerStreamChunk obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnswerStreamChunk>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnswerStreamChunk obj1, AnswerStreamChunk obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnswerStreamChunk o && Equals(o);
        }
    }
}
