#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResearchEventDtoClassVariant1 : global::System.IEquatable<ResearchEventDtoClassVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant1DiscriminatorEventType? EventType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant1ResearchDefinition? ResearchDefinition { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant1ResearchDefinition? ResearchDefinition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResearchDefinition))]
#endif
        public bool IsResearchDefinition => ResearchDefinition != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResearchDefinition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant1ResearchDefinition? value)
        {
            value = ResearchDefinition;
            return IsResearchDefinition;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant1ResearchDefinition PickResearchDefinition() => IsResearchDefinition
            ? ResearchDefinition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResearchDefinition' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutput? ResearchOutput { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutput? ResearchOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResearchOutput))]
#endif
        public bool IsResearchOutput => ResearchOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResearchOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant1ResearchOutput? value)
        {
            value = ResearchOutput;
            return IsResearchOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutput PickResearchOutput() => IsResearchOutput
            ? ResearchOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResearchOutput' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant1(global::Exa.ResearchEventDtoClassVariant1ResearchDefinition value) => new ResearchEventDtoClassVariant1((global::Exa.ResearchEventDtoClassVariant1ResearchDefinition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant1ResearchDefinition?(ResearchEventDtoClassVariant1 @this) => @this.ResearchDefinition;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant1(global::Exa.ResearchEventDtoClassVariant1ResearchDefinition? value)
        {
            ResearchDefinition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchEventDtoClassVariant1 FromResearchDefinition(global::Exa.ResearchEventDtoClassVariant1ResearchDefinition? value) => new ResearchEventDtoClassVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant1(global::Exa.ResearchEventDtoClassVariant1ResearchOutput value) => new ResearchEventDtoClassVariant1((global::Exa.ResearchEventDtoClassVariant1ResearchOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant1ResearchOutput?(ResearchEventDtoClassVariant1 @this) => @this.ResearchOutput;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant1(global::Exa.ResearchEventDtoClassVariant1ResearchOutput? value)
        {
            ResearchOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchEventDtoClassVariant1 FromResearchOutput(global::Exa.ResearchEventDtoClassVariant1ResearchOutput? value) => new ResearchEventDtoClassVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant1(
            global::Exa.ResearchEventDtoClassVariant1DiscriminatorEventType? eventType,
            global::Exa.ResearchEventDtoClassVariant1ResearchDefinition? researchDefinition,
            global::Exa.ResearchEventDtoClassVariant1ResearchOutput? researchOutput
            )
        {
            EventType = eventType;

            ResearchDefinition = researchDefinition;
            ResearchOutput = researchOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResearchOutput as object ??
            ResearchDefinition as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResearchDefinition?.ToString() ??
            ResearchOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResearchDefinition && !IsResearchOutput || !IsResearchDefinition && IsResearchOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.ResearchEventDtoClassVariant1ResearchDefinition, TResult>? researchDefinition = null,
            global::System.Func<global::Exa.ResearchEventDtoClassVariant1ResearchOutput, TResult>? researchOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResearchDefinition && researchDefinition != null)
            {
                return researchDefinition(ResearchDefinition!);
            }
            else if (IsResearchOutput && researchOutput != null)
            {
                return researchOutput(ResearchOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant1ResearchDefinition>? researchDefinition = null,

            global::System.Action<global::Exa.ResearchEventDtoClassVariant1ResearchOutput>? researchOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResearchDefinition)
            {
                researchDefinition?.Invoke(ResearchDefinition!);
            }
            else if (IsResearchOutput)
            {
                researchOutput?.Invoke(ResearchOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant1ResearchDefinition>? researchDefinition = null,
            global::System.Action<global::Exa.ResearchEventDtoClassVariant1ResearchOutput>? researchOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResearchDefinition)
            {
                researchDefinition?.Invoke(ResearchDefinition!);
            }
            else if (IsResearchOutput)
            {
                researchOutput?.Invoke(ResearchOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResearchDefinition,
                typeof(global::Exa.ResearchEventDtoClassVariant1ResearchDefinition),
                ResearchOutput,
                typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutput),
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
        public bool Equals(ResearchEventDtoClassVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant1ResearchDefinition?>.Default.Equals(ResearchDefinition, other.ResearchDefinition) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant1ResearchOutput?>.Default.Equals(ResearchOutput, other.ResearchOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResearchEventDtoClassVariant1 obj1, ResearchEventDtoClassVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResearchEventDtoClassVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResearchEventDtoClassVariant1 obj1, ResearchEventDtoClassVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResearchEventDtoClassVariant1 o && Equals(o);
        }
    }
}
