#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AgentStopReason : global::System.IEquatable<AgentStopReason>
    {
        /// <summary>
        /// The agent finished the task before reaching any limit.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentStopReasonVariant1 { get; init; }
#else
        public string? AgentStopReasonVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStopReasonVariant1))]
#endif
        public bool IsAgentStopReasonVariant1 => AgentStopReasonVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentStopReasonVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentStopReasonVariant1;
            return IsAgentStopReasonVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAgentStopReasonVariant1() => AgentStopReasonVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStopReasonVariant1' but the value was {ToString()}.");

        /// <summary>
        /// The run reached `budget.maxCostDollars`.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentStopReasonVariant2 { get; init; }
#else
        public string? AgentStopReasonVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStopReasonVariant2))]
#endif
        public bool IsAgentStopReasonVariant2 => AgentStopReasonVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentStopReasonVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentStopReasonVariant2;
            return IsAgentStopReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAgentStopReasonVariant2() => AgentStopReasonVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStopReasonVariant2' but the value was {ToString()}.");

        /// <summary>
        /// The run reached `budget.maxDurationSeconds`.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentStopReasonVariant3 { get; init; }
#else
        public string? AgentStopReasonVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStopReasonVariant3))]
#endif
        public bool IsAgentStopReasonVariant3 => AgentStopReasonVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentStopReasonVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentStopReasonVariant3;
            return IsAgentStopReasonVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAgentStopReasonVariant3() => AgentStopReasonVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStopReasonVariant3' but the value was {ToString()}.");

        /// <summary>
        /// The run reached its maximum number of agent steps.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentStopReasonVariant4 { get; init; }
#else
        public string? AgentStopReasonVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStopReasonVariant4))]
#endif
        public bool IsAgentStopReasonVariant4 => AgentStopReasonVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentStopReasonVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentStopReasonVariant4;
            return IsAgentStopReasonVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAgentStopReasonVariant4() => AgentStopReasonVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStopReasonVariant4' but the value was {ToString()}.");

        /// <summary>
        /// The run reached its limit on model tokens.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentStopReasonVariant5 { get; init; }
#else
        public string? AgentStopReasonVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStopReasonVariant5))]
#endif
        public bool IsAgentStopReasonVariant5 => AgentStopReasonVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentStopReasonVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentStopReasonVariant5;
            return IsAgentStopReasonVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAgentStopReasonVariant5() => AgentStopReasonVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStopReasonVariant5' but the value was {ToString()}.");

        /// <summary>
        /// You stopped the run.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentStopReasonVariant6 { get; init; }
#else
        public string? AgentStopReasonVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStopReasonVariant6))]
#endif
        public bool IsAgentStopReasonVariant6 => AgentStopReasonVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentStopReasonVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentStopReasonVariant6;
            return IsAgentStopReasonVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAgentStopReasonVariant6() => AgentStopReasonVariant6 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStopReasonVariant6' but the value was {ToString()}.");

        /// <summary>
        /// The run failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentStopReasonVariant7 { get; init; }
#else
        public string? AgentStopReasonVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStopReasonVariant7))]
#endif
        public bool IsAgentStopReasonVariant7 => AgentStopReasonVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentStopReasonVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentStopReasonVariant7;
            return IsAgentStopReasonVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAgentStopReasonVariant7() => AgentStopReasonVariant7 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStopReasonVariant7' but the value was {ToString()}.");

        /// <summary>
        /// The run was cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentStopReasonVariant8 { get; init; }
#else
        public string? AgentStopReasonVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStopReasonVariant8))]
#endif
        public bool IsAgentStopReasonVariant8 => AgentStopReasonVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentStopReasonVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentStopReasonVariant8;
            return IsAgentStopReasonVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAgentStopReasonVariant8() => AgentStopReasonVariant8 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStopReasonVariant8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentStopReasonVariant9 { get; init; }
#else
        public string? AgentStopReasonVariant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStopReasonVariant9))]
#endif
        public bool IsAgentStopReasonVariant9 => AgentStopReasonVariant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentStopReasonVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AgentStopReasonVariant9;
            return IsAgentStopReasonVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAgentStopReasonVariant9() => AgentStopReasonVariant9 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStopReasonVariant9' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentStopReason(string value) => new AgentStopReason((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(AgentStopReason @this) => @this.AgentStopReasonVariant1;

        /// <summary>
        ///
        /// </summary>
        public AgentStopReason(string? value)
        {
            AgentStopReasonVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentStopReason FromAgentStopReasonVariant1(string? value) => new AgentStopReason(value);

        /// <summary>
        ///
        /// </summary>
        public AgentStopReason(
            string? agentStopReasonVariant1,
            string? agentStopReasonVariant2,
            string? agentStopReasonVariant3,
            string? agentStopReasonVariant4,
            string? agentStopReasonVariant5,
            string? agentStopReasonVariant6,
            string? agentStopReasonVariant7,
            string? agentStopReasonVariant8,
            string? agentStopReasonVariant9
            )
        {
            AgentStopReasonVariant1 = agentStopReasonVariant1;
            AgentStopReasonVariant2 = agentStopReasonVariant2;
            AgentStopReasonVariant3 = agentStopReasonVariant3;
            AgentStopReasonVariant4 = agentStopReasonVariant4;
            AgentStopReasonVariant5 = agentStopReasonVariant5;
            AgentStopReasonVariant6 = agentStopReasonVariant6;
            AgentStopReasonVariant7 = agentStopReasonVariant7;
            AgentStopReasonVariant8 = agentStopReasonVariant8;
            AgentStopReasonVariant9 = agentStopReasonVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AgentStopReasonVariant9 as object ??
            AgentStopReasonVariant8 as object ??
            AgentStopReasonVariant7 as object ??
            AgentStopReasonVariant6 as object ??
            AgentStopReasonVariant5 as object ??
            AgentStopReasonVariant4 as object ??
            AgentStopReasonVariant3 as object ??
            AgentStopReasonVariant2 as object ??
            AgentStopReasonVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AgentStopReasonVariant1?.ToString() ??
            AgentStopReasonVariant2?.ToString() ??
            AgentStopReasonVariant3?.ToString() ??
            AgentStopReasonVariant4?.ToString() ??
            AgentStopReasonVariant5?.ToString() ??
            AgentStopReasonVariant6?.ToString() ??
            AgentStopReasonVariant7?.ToString() ??
            AgentStopReasonVariant8?.ToString() ??
            AgentStopReasonVariant9?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAgentStopReasonVariant1 || IsAgentStopReasonVariant2 || IsAgentStopReasonVariant3 || IsAgentStopReasonVariant4 || IsAgentStopReasonVariant5 || IsAgentStopReasonVariant6 || IsAgentStopReasonVariant7 || IsAgentStopReasonVariant8 || IsAgentStopReasonVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? agentStopReasonVariant1 = null,
            global::System.Func<string, TResult>? agentStopReasonVariant2 = null,
            global::System.Func<string, TResult>? agentStopReasonVariant3 = null,
            global::System.Func<string, TResult>? agentStopReasonVariant4 = null,
            global::System.Func<string, TResult>? agentStopReasonVariant5 = null,
            global::System.Func<string, TResult>? agentStopReasonVariant6 = null,
            global::System.Func<string, TResult>? agentStopReasonVariant7 = null,
            global::System.Func<string, TResult>? agentStopReasonVariant8 = null,
            global::System.Func<string, TResult>? agentStopReasonVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AgentStopReasonVariant1 is { } __value0 && agentStopReasonVariant1 != null)
            {
                return agentStopReasonVariant1(__value0);
            }
            else if (AgentStopReasonVariant2 is { } __value1 && agentStopReasonVariant2 != null)
            {
                return agentStopReasonVariant2(__value1);
            }
            else if (AgentStopReasonVariant3 is { } __value2 && agentStopReasonVariant3 != null)
            {
                return agentStopReasonVariant3(__value2);
            }
            else if (AgentStopReasonVariant4 is { } __value3 && agentStopReasonVariant4 != null)
            {
                return agentStopReasonVariant4(__value3);
            }
            else if (AgentStopReasonVariant5 is { } __value4 && agentStopReasonVariant5 != null)
            {
                return agentStopReasonVariant5(__value4);
            }
            else if (AgentStopReasonVariant6 is { } __value5 && agentStopReasonVariant6 != null)
            {
                return agentStopReasonVariant6(__value5);
            }
            else if (AgentStopReasonVariant7 is { } __value6 && agentStopReasonVariant7 != null)
            {
                return agentStopReasonVariant7(__value6);
            }
            else if (AgentStopReasonVariant8 is { } __value7 && agentStopReasonVariant8 != null)
            {
                return agentStopReasonVariant8(__value7);
            }
            else if (AgentStopReasonVariant9 is { } __value8 && agentStopReasonVariant9 != null)
            {
                return agentStopReasonVariant9(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? agentStopReasonVariant1 = null,

            global::System.Action<string>? agentStopReasonVariant2 = null,

            global::System.Action<string>? agentStopReasonVariant3 = null,

            global::System.Action<string>? agentStopReasonVariant4 = null,

            global::System.Action<string>? agentStopReasonVariant5 = null,

            global::System.Action<string>? agentStopReasonVariant6 = null,

            global::System.Action<string>? agentStopReasonVariant7 = null,

            global::System.Action<string>? agentStopReasonVariant8 = null,

            global::System.Action<string>? agentStopReasonVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AgentStopReasonVariant1 is { } __value0)
            {
                agentStopReasonVariant1?.Invoke(__value0);
            }
            else if (AgentStopReasonVariant2 is { } __value1)
            {
                agentStopReasonVariant2?.Invoke(__value1);
            }
            else if (AgentStopReasonVariant3 is { } __value2)
            {
                agentStopReasonVariant3?.Invoke(__value2);
            }
            else if (AgentStopReasonVariant4 is { } __value3)
            {
                agentStopReasonVariant4?.Invoke(__value3);
            }
            else if (AgentStopReasonVariant5 is { } __value4)
            {
                agentStopReasonVariant5?.Invoke(__value4);
            }
            else if (AgentStopReasonVariant6 is { } __value5)
            {
                agentStopReasonVariant6?.Invoke(__value5);
            }
            else if (AgentStopReasonVariant7 is { } __value6)
            {
                agentStopReasonVariant7?.Invoke(__value6);
            }
            else if (AgentStopReasonVariant8 is { } __value7)
            {
                agentStopReasonVariant8?.Invoke(__value7);
            }
            else if (AgentStopReasonVariant9 is { } __value8)
            {
                agentStopReasonVariant9?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? agentStopReasonVariant1 = null,
            global::System.Action<string>? agentStopReasonVariant2 = null,
            global::System.Action<string>? agentStopReasonVariant3 = null,
            global::System.Action<string>? agentStopReasonVariant4 = null,
            global::System.Action<string>? agentStopReasonVariant5 = null,
            global::System.Action<string>? agentStopReasonVariant6 = null,
            global::System.Action<string>? agentStopReasonVariant7 = null,
            global::System.Action<string>? agentStopReasonVariant8 = null,
            global::System.Action<string>? agentStopReasonVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AgentStopReasonVariant1 is { } __value0)
            {
                agentStopReasonVariant1?.Invoke(__value0);
            }
            else if (AgentStopReasonVariant2 is { } __value1)
            {
                agentStopReasonVariant2?.Invoke(__value1);
            }
            else if (AgentStopReasonVariant3 is { } __value2)
            {
                agentStopReasonVariant3?.Invoke(__value2);
            }
            else if (AgentStopReasonVariant4 is { } __value3)
            {
                agentStopReasonVariant4?.Invoke(__value3);
            }
            else if (AgentStopReasonVariant5 is { } __value4)
            {
                agentStopReasonVariant5?.Invoke(__value4);
            }
            else if (AgentStopReasonVariant6 is { } __value5)
            {
                agentStopReasonVariant6?.Invoke(__value5);
            }
            else if (AgentStopReasonVariant7 is { } __value6)
            {
                agentStopReasonVariant7?.Invoke(__value6);
            }
            else if (AgentStopReasonVariant8 is { } __value7)
            {
                agentStopReasonVariant8?.Invoke(__value7);
            }
            else if (AgentStopReasonVariant9 is { } __value8)
            {
                agentStopReasonVariant9?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentStopReasonVariant1,
                typeof(string),
                AgentStopReasonVariant2,
                typeof(string),
                AgentStopReasonVariant3,
                typeof(string),
                AgentStopReasonVariant4,
                typeof(string),
                AgentStopReasonVariant5,
                typeof(string),
                AgentStopReasonVariant6,
                typeof(string),
                AgentStopReasonVariant7,
                typeof(string),
                AgentStopReasonVariant8,
                typeof(string),
                AgentStopReasonVariant9,
                typeof(string),
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
        public bool Equals(AgentStopReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentStopReasonVariant1, other.AgentStopReasonVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentStopReasonVariant2, other.AgentStopReasonVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentStopReasonVariant3, other.AgentStopReasonVariant3) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentStopReasonVariant4, other.AgentStopReasonVariant4) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentStopReasonVariant5, other.AgentStopReasonVariant5) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentStopReasonVariant6, other.AgentStopReasonVariant6) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentStopReasonVariant7, other.AgentStopReasonVariant7) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentStopReasonVariant8, other.AgentStopReasonVariant8) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentStopReasonVariant9, other.AgentStopReasonVariant9)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentStopReason obj1, AgentStopReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentStopReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentStopReason obj1, AgentStopReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentStopReason o && Equals(o);
        }
    }
}
