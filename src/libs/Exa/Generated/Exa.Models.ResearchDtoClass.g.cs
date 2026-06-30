#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResearchDtoClass : global::System.IEquatable<ResearchDtoClass>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassDiscriminatorStatus? Status { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchDtoClassPending? Pending { get; init; }
#else
        public global::Exa.ResearchDtoClassPending? Pending { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pending))]
#endif
        public bool IsPending => Pending != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPending(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchDtoClassPending? value)
        {
            value = Pending;
            return IsPending;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassPending PickPending() => IsPending
            ? Pending!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pending' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchDtoClassRunning? Running { get; init; }
#else
        public global::Exa.ResearchDtoClassRunning? Running { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Running))]
#endif
        public bool IsRunning => Running != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchDtoClassRunning? value)
        {
            value = Running;
            return IsRunning;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassRunning PickRunning() => IsRunning
            ? Running!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Running' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchDtoClassCompleted? Completed { get; init; }
#else
        public global::Exa.ResearchDtoClassCompleted? Completed { get; }
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
            out global::Exa.ResearchDtoClassCompleted? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassCompleted PickCompleted() => IsCompleted
            ? Completed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completed' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchDtoClassCanceled? Canceled { get; init; }
#else
        public global::Exa.ResearchDtoClassCanceled? Canceled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Canceled))]
#endif
        public bool IsCanceled => Canceled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCanceled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchDtoClassCanceled? value)
        {
            value = Canceled;
            return IsCanceled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassCanceled PickCanceled() => IsCanceled
            ? Canceled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Canceled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchDtoClassFailed? Failed { get; init; }
#else
        public global::Exa.ResearchDtoClassFailed? Failed { get; }
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
            out global::Exa.ResearchDtoClassFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassFailed PickFailed() => IsFailed
            ? Failed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchDtoClass(global::Exa.ResearchDtoClassPending value) => new ResearchDtoClass((global::Exa.ResearchDtoClassPending?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchDtoClassPending?(ResearchDtoClass @this) => @this.Pending;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::Exa.ResearchDtoClassPending? value)
        {
            Pending = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchDtoClass FromPending(global::Exa.ResearchDtoClassPending? value) => new ResearchDtoClass(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchDtoClass(global::Exa.ResearchDtoClassRunning value) => new ResearchDtoClass((global::Exa.ResearchDtoClassRunning?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchDtoClassRunning?(ResearchDtoClass @this) => @this.Running;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::Exa.ResearchDtoClassRunning? value)
        {
            Running = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchDtoClass FromRunning(global::Exa.ResearchDtoClassRunning? value) => new ResearchDtoClass(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchDtoClass(global::Exa.ResearchDtoClassCompleted value) => new ResearchDtoClass((global::Exa.ResearchDtoClassCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchDtoClassCompleted?(ResearchDtoClass @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::Exa.ResearchDtoClassCompleted? value)
        {
            Completed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchDtoClass FromCompleted(global::Exa.ResearchDtoClassCompleted? value) => new ResearchDtoClass(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchDtoClass(global::Exa.ResearchDtoClassCanceled value) => new ResearchDtoClass((global::Exa.ResearchDtoClassCanceled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchDtoClassCanceled?(ResearchDtoClass @this) => @this.Canceled;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::Exa.ResearchDtoClassCanceled? value)
        {
            Canceled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchDtoClass FromCanceled(global::Exa.ResearchDtoClassCanceled? value) => new ResearchDtoClass(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchDtoClass(global::Exa.ResearchDtoClassFailed value) => new ResearchDtoClass((global::Exa.ResearchDtoClassFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchDtoClassFailed?(ResearchDtoClass @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::Exa.ResearchDtoClassFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchDtoClass FromFailed(global::Exa.ResearchDtoClassFailed? value) => new ResearchDtoClass(value);

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(
            global::Exa.ResearchDtoClassDiscriminatorStatus? status,
            global::Exa.ResearchDtoClassPending? pending,
            global::Exa.ResearchDtoClassRunning? running,
            global::Exa.ResearchDtoClassCompleted? completed,
            global::Exa.ResearchDtoClassCanceled? canceled,
            global::Exa.ResearchDtoClassFailed? failed
            )
        {
            Status = status;

            Pending = pending;
            Running = running;
            Completed = completed;
            Canceled = canceled;
            Failed = failed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failed as object ??
            Canceled as object ??
            Completed as object ??
            Running as object ??
            Pending as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Pending?.ToString() ??
            Running?.ToString() ??
            Completed?.ToString() ??
            Canceled?.ToString() ??
            Failed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPending && !IsRunning && !IsCompleted && !IsCanceled && !IsFailed || !IsPending && IsRunning && !IsCompleted && !IsCanceled && !IsFailed || !IsPending && !IsRunning && IsCompleted && !IsCanceled && !IsFailed || !IsPending && !IsRunning && !IsCompleted && IsCanceled && !IsFailed || !IsPending && !IsRunning && !IsCompleted && !IsCanceled && IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.ResearchDtoClassPending, TResult>? pending = null,
            global::System.Func<global::Exa.ResearchDtoClassRunning, TResult>? running = null,
            global::System.Func<global::Exa.ResearchDtoClassCompleted, TResult>? completed = null,
            global::System.Func<global::Exa.ResearchDtoClassCanceled, TResult>? canceled = null,
            global::System.Func<global::Exa.ResearchDtoClassFailed, TResult>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPending && pending != null)
            {
                return pending(Pending!);
            }
            else if (IsRunning && running != null)
            {
                return running(Running!);
            }
            else if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }
            else if (IsCanceled && canceled != null)
            {
                return canceled(Canceled!);
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
            global::System.Action<global::Exa.ResearchDtoClassPending>? pending = null,

            global::System.Action<global::Exa.ResearchDtoClassRunning>? running = null,

            global::System.Action<global::Exa.ResearchDtoClassCompleted>? completed = null,

            global::System.Action<global::Exa.ResearchDtoClassCanceled>? canceled = null,

            global::System.Action<global::Exa.ResearchDtoClassFailed>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPending)
            {
                pending?.Invoke(Pending!);
            }
            else if (IsRunning)
            {
                running?.Invoke(Running!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsCanceled)
            {
                canceled?.Invoke(Canceled!);
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
            global::System.Action<global::Exa.ResearchDtoClassPending>? pending = null,
            global::System.Action<global::Exa.ResearchDtoClassRunning>? running = null,
            global::System.Action<global::Exa.ResearchDtoClassCompleted>? completed = null,
            global::System.Action<global::Exa.ResearchDtoClassCanceled>? canceled = null,
            global::System.Action<global::Exa.ResearchDtoClassFailed>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPending)
            {
                pending?.Invoke(Pending!);
            }
            else if (IsRunning)
            {
                running?.Invoke(Running!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsCanceled)
            {
                canceled?.Invoke(Canceled!);
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
                Pending,
                typeof(global::Exa.ResearchDtoClassPending),
                Running,
                typeof(global::Exa.ResearchDtoClassRunning),
                Completed,
                typeof(global::Exa.ResearchDtoClassCompleted),
                Canceled,
                typeof(global::Exa.ResearchDtoClassCanceled),
                Failed,
                typeof(global::Exa.ResearchDtoClassFailed),
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
        public bool Equals(ResearchDtoClass other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchDtoClassPending?>.Default.Equals(Pending, other.Pending) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchDtoClassRunning?>.Default.Equals(Running, other.Running) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchDtoClassCompleted?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchDtoClassCanceled?>.Default.Equals(Canceled, other.Canceled) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchDtoClassFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResearchDtoClass obj1, ResearchDtoClass obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResearchDtoClass>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResearchDtoClass obj1, ResearchDtoClass obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResearchDtoClass o && Equals(o);
        }
    }
}
