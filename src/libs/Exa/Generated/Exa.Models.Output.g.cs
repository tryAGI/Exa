#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// The final research result, either successful with data or failed with error
    /// </summary>
    public readonly partial struct Output : global::System.IEquatable<Output>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType? OutputType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted? Completed { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted? Completed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted PickCompleted() => IsCompleted
            ? Completed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completed' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed? Failed { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed? Failed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed PickFailed() => IsFailed
            ? Failed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted value) => new Output((global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted?(Output @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public Output(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted? value)
        {
            Completed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Output FromCompleted(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted? value) => new Output(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed value) => new Output((global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed?(Output @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public Output(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Output FromFailed(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed? value) => new Output(value);

        /// <summary>
        /// 
        /// </summary>
        public Output(
            global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType? outputType,
            global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted? completed,
            global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed? failed
            )
        {
            OutputType = outputType;

            Completed = completed;
            Failed = failed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failed as object ??
            Completed as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Completed?.ToString() ??
            Failed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompleted && !IsFailed || !IsCompleted && IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted, TResult>? completed = null,
            global::System.Func<global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed, TResult>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted>? completed = null,

            global::System.Action<global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted>? completed = null,
            global::System.Action<global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Completed,
                typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted),
                Failed,
                typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed),
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
        public bool Equals(Output other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Output obj1, Output obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Output>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Output obj1, Output obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Output o && Equals(o);
        }
    }
}
