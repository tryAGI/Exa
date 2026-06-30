#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// The plan's decision: either generate tasks or stop researching
    /// </summary>
    public readonly partial struct Output2 : global::System.IEquatable<Output2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType? OutputType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks? Tasks { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks? Tasks { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tasks))]
#endif
        public bool IsTasks => Tasks != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTasks(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks? value)
        {
            value = Tasks;
            return IsTasks;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks PickTasks() => IsTasks
            ? Tasks!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tasks' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop? Stop { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop? Stop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stop))]
#endif
        public bool IsStop => Stop != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop? value)
        {
            value = Stop;
            return IsStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop PickStop() => IsStop
            ? Stop!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stop' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output2(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks value) => new Output2((global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks?(Output2 @this) => @this.Tasks;

        /// <summary>
        /// 
        /// </summary>
        public Output2(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks? value)
        {
            Tasks = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Output2 FromTasks(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks? value) => new Output2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output2(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop value) => new Output2((global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop?(Output2 @this) => @this.Stop;

        /// <summary>
        /// 
        /// </summary>
        public Output2(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop? value)
        {
            Stop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Output2 FromStop(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop? value) => new Output2(value);

        /// <summary>
        /// 
        /// </summary>
        public Output2(
            global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType? outputType,
            global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks? tasks,
            global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop? stop
            )
        {
            OutputType = outputType;

            Tasks = tasks;
            Stop = stop;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Stop as object ??
            Tasks as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Tasks?.ToString() ??
            Stop?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTasks && !IsStop || !IsTasks && IsStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks, TResult>? tasks = null,
            global::System.Func<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop, TResult>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTasks && tasks != null)
            {
                return tasks(Tasks!);
            }
            else if (IsStop && stop != null)
            {
                return stop(Stop!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks>? tasks = null,

            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTasks)
            {
                tasks?.Invoke(Tasks!);
            }
            else if (IsStop)
            {
                stop?.Invoke(Stop!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks>? tasks = null,
            global::System.Action<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTasks)
            {
                tasks?.Invoke(Tasks!);
            }
            else if (IsStop)
            {
                stop?.Invoke(Stop!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Tasks,
                typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks),
                Stop,
                typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop),
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
        public bool Equals(Output2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks?>.Default.Equals(Tasks, other.Tasks) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop?>.Default.Equals(Stop, other.Stop) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Output2 obj1, Output2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Output2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Output2 obj1, Output2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Output2 o && Equals(o);
        }
    }
}
