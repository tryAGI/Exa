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
        public global::Exa.AnswerStreamChunkVariant1? AnswerStreamChunkVariant1 { get; init; }
#else
        public global::Exa.AnswerStreamChunkVariant1? AnswerStreamChunkVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnswerStreamChunkVariant1))]
#endif
        public bool IsAnswerStreamChunkVariant1 => AnswerStreamChunkVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnswerStreamChunkVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.AnswerStreamChunkVariant1? value)
        {
            value = AnswerStreamChunkVariant1;
            return IsAnswerStreamChunkVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.AnswerStreamChunkVariant1 PickAnswerStreamChunkVariant1() => IsAnswerStreamChunkVariant1
            ? AnswerStreamChunkVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnswerStreamChunkVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.AnswerStreamChunkVariant2? AnswerStreamChunkVariant2 { get; init; }
#else
        public global::Exa.AnswerStreamChunkVariant2? AnswerStreamChunkVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnswerStreamChunkVariant2))]
#endif
        public bool IsAnswerStreamChunkVariant2 => AnswerStreamChunkVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnswerStreamChunkVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.AnswerStreamChunkVariant2? value)
        {
            value = AnswerStreamChunkVariant2;
            return IsAnswerStreamChunkVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.AnswerStreamChunkVariant2 PickAnswerStreamChunkVariant2() => IsAnswerStreamChunkVariant2
            ? AnswerStreamChunkVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnswerStreamChunkVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.AnswerStreamChunkVariant3? AnswerStreamChunkVariant3 { get; init; }
#else
        public global::Exa.AnswerStreamChunkVariant3? AnswerStreamChunkVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnswerStreamChunkVariant3))]
#endif
        public bool IsAnswerStreamChunkVariant3 => AnswerStreamChunkVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnswerStreamChunkVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.AnswerStreamChunkVariant3? value)
        {
            value = AnswerStreamChunkVariant3;
            return IsAnswerStreamChunkVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.AnswerStreamChunkVariant3 PickAnswerStreamChunkVariant3() => IsAnswerStreamChunkVariant3
            ? AnswerStreamChunkVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnswerStreamChunkVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.AnswerStreamChunkVariant4? AnswerStreamChunkVariant4 { get; init; }
#else
        public global::Exa.AnswerStreamChunkVariant4? AnswerStreamChunkVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnswerStreamChunkVariant4))]
#endif
        public bool IsAnswerStreamChunkVariant4 => AnswerStreamChunkVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnswerStreamChunkVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.AnswerStreamChunkVariant4? value)
        {
            value = AnswerStreamChunkVariant4;
            return IsAnswerStreamChunkVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.AnswerStreamChunkVariant4 PickAnswerStreamChunkVariant4() => IsAnswerStreamChunkVariant4
            ? AnswerStreamChunkVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnswerStreamChunkVariant4' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnswerStreamChunk(global::Exa.AnswerStreamChunkVariant1 value) => new AnswerStreamChunk((global::Exa.AnswerStreamChunkVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.AnswerStreamChunkVariant1?(AnswerStreamChunk @this) => @this.AnswerStreamChunkVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnswerStreamChunk(global::Exa.AnswerStreamChunkVariant1? value)
        {
            AnswerStreamChunkVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnswerStreamChunk FromAnswerStreamChunkVariant1(global::Exa.AnswerStreamChunkVariant1? value) => new AnswerStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnswerStreamChunk(global::Exa.AnswerStreamChunkVariant2 value) => new AnswerStreamChunk((global::Exa.AnswerStreamChunkVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.AnswerStreamChunkVariant2?(AnswerStreamChunk @this) => @this.AnswerStreamChunkVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AnswerStreamChunk(global::Exa.AnswerStreamChunkVariant2? value)
        {
            AnswerStreamChunkVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnswerStreamChunk FromAnswerStreamChunkVariant2(global::Exa.AnswerStreamChunkVariant2? value) => new AnswerStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnswerStreamChunk(global::Exa.AnswerStreamChunkVariant3 value) => new AnswerStreamChunk((global::Exa.AnswerStreamChunkVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.AnswerStreamChunkVariant3?(AnswerStreamChunk @this) => @this.AnswerStreamChunkVariant3;

        /// <summary>
        /// 
        /// </summary>
        public AnswerStreamChunk(global::Exa.AnswerStreamChunkVariant3? value)
        {
            AnswerStreamChunkVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnswerStreamChunk FromAnswerStreamChunkVariant3(global::Exa.AnswerStreamChunkVariant3? value) => new AnswerStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnswerStreamChunk(global::Exa.AnswerStreamChunkVariant4 value) => new AnswerStreamChunk((global::Exa.AnswerStreamChunkVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.AnswerStreamChunkVariant4?(AnswerStreamChunk @this) => @this.AnswerStreamChunkVariant4;

        /// <summary>
        /// 
        /// </summary>
        public AnswerStreamChunk(global::Exa.AnswerStreamChunkVariant4? value)
        {
            AnswerStreamChunkVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnswerStreamChunk FromAnswerStreamChunkVariant4(global::Exa.AnswerStreamChunkVariant4? value) => new AnswerStreamChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public AnswerStreamChunk(
            global::Exa.AnswerStreamChunkVariant1? answerStreamChunkVariant1,
            global::Exa.AnswerStreamChunkVariant2? answerStreamChunkVariant2,
            global::Exa.AnswerStreamChunkVariant3? answerStreamChunkVariant3,
            global::Exa.AnswerStreamChunkVariant4? answerStreamChunkVariant4
            )
        {
            AnswerStreamChunkVariant1 = answerStreamChunkVariant1;
            AnswerStreamChunkVariant2 = answerStreamChunkVariant2;
            AnswerStreamChunkVariant3 = answerStreamChunkVariant3;
            AnswerStreamChunkVariant4 = answerStreamChunkVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnswerStreamChunkVariant4 as object ??
            AnswerStreamChunkVariant3 as object ??
            AnswerStreamChunkVariant2 as object ??
            AnswerStreamChunkVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnswerStreamChunkVariant1?.ToString() ??
            AnswerStreamChunkVariant2?.ToString() ??
            AnswerStreamChunkVariant3?.ToString() ??
            AnswerStreamChunkVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnswerStreamChunkVariant1 && !IsAnswerStreamChunkVariant2 && !IsAnswerStreamChunkVariant3 && !IsAnswerStreamChunkVariant4 || !IsAnswerStreamChunkVariant1 && IsAnswerStreamChunkVariant2 && !IsAnswerStreamChunkVariant3 && !IsAnswerStreamChunkVariant4 || !IsAnswerStreamChunkVariant1 && !IsAnswerStreamChunkVariant2 && IsAnswerStreamChunkVariant3 && !IsAnswerStreamChunkVariant4 || !IsAnswerStreamChunkVariant1 && !IsAnswerStreamChunkVariant2 && !IsAnswerStreamChunkVariant3 && IsAnswerStreamChunkVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.AnswerStreamChunkVariant1, TResult>? answerStreamChunkVariant1 = null,
            global::System.Func<global::Exa.AnswerStreamChunkVariant2, TResult>? answerStreamChunkVariant2 = null,
            global::System.Func<global::Exa.AnswerStreamChunkVariant3, TResult>? answerStreamChunkVariant3 = null,
            global::System.Func<global::Exa.AnswerStreamChunkVariant4, TResult>? answerStreamChunkVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnswerStreamChunkVariant1 && answerStreamChunkVariant1 != null)
            {
                return answerStreamChunkVariant1(AnswerStreamChunkVariant1!);
            }
            else if (IsAnswerStreamChunkVariant2 && answerStreamChunkVariant2 != null)
            {
                return answerStreamChunkVariant2(AnswerStreamChunkVariant2!);
            }
            else if (IsAnswerStreamChunkVariant3 && answerStreamChunkVariant3 != null)
            {
                return answerStreamChunkVariant3(AnswerStreamChunkVariant3!);
            }
            else if (IsAnswerStreamChunkVariant4 && answerStreamChunkVariant4 != null)
            {
                return answerStreamChunkVariant4(AnswerStreamChunkVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.AnswerStreamChunkVariant1>? answerStreamChunkVariant1 = null,

            global::System.Action<global::Exa.AnswerStreamChunkVariant2>? answerStreamChunkVariant2 = null,

            global::System.Action<global::Exa.AnswerStreamChunkVariant3>? answerStreamChunkVariant3 = null,

            global::System.Action<global::Exa.AnswerStreamChunkVariant4>? answerStreamChunkVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnswerStreamChunkVariant1)
            {
                answerStreamChunkVariant1?.Invoke(AnswerStreamChunkVariant1!);
            }
            else if (IsAnswerStreamChunkVariant2)
            {
                answerStreamChunkVariant2?.Invoke(AnswerStreamChunkVariant2!);
            }
            else if (IsAnswerStreamChunkVariant3)
            {
                answerStreamChunkVariant3?.Invoke(AnswerStreamChunkVariant3!);
            }
            else if (IsAnswerStreamChunkVariant4)
            {
                answerStreamChunkVariant4?.Invoke(AnswerStreamChunkVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.AnswerStreamChunkVariant1>? answerStreamChunkVariant1 = null,
            global::System.Action<global::Exa.AnswerStreamChunkVariant2>? answerStreamChunkVariant2 = null,
            global::System.Action<global::Exa.AnswerStreamChunkVariant3>? answerStreamChunkVariant3 = null,
            global::System.Action<global::Exa.AnswerStreamChunkVariant4>? answerStreamChunkVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnswerStreamChunkVariant1)
            {
                answerStreamChunkVariant1?.Invoke(AnswerStreamChunkVariant1!);
            }
            else if (IsAnswerStreamChunkVariant2)
            {
                answerStreamChunkVariant2?.Invoke(AnswerStreamChunkVariant2!);
            }
            else if (IsAnswerStreamChunkVariant3)
            {
                answerStreamChunkVariant3?.Invoke(AnswerStreamChunkVariant3!);
            }
            else if (IsAnswerStreamChunkVariant4)
            {
                answerStreamChunkVariant4?.Invoke(AnswerStreamChunkVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnswerStreamChunkVariant1,
                typeof(global::Exa.AnswerStreamChunkVariant1),
                AnswerStreamChunkVariant2,
                typeof(global::Exa.AnswerStreamChunkVariant2),
                AnswerStreamChunkVariant3,
                typeof(global::Exa.AnswerStreamChunkVariant3),
                AnswerStreamChunkVariant4,
                typeof(global::Exa.AnswerStreamChunkVariant4),
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
                global::System.Collections.Generic.EqualityComparer<global::Exa.AnswerStreamChunkVariant1?>.Default.Equals(AnswerStreamChunkVariant1, other.AnswerStreamChunkVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.AnswerStreamChunkVariant2?>.Default.Equals(AnswerStreamChunkVariant2, other.AnswerStreamChunkVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.AnswerStreamChunkVariant3?>.Default.Equals(AnswerStreamChunkVariant3, other.AnswerStreamChunkVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.AnswerStreamChunkVariant4?>.Default.Equals(AnswerStreamChunkVariant4, other.AnswerStreamChunkVariant4) 
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
