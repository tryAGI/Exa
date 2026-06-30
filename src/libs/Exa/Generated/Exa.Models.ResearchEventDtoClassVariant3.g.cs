#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResearchEventDtoClassVariant3 : global::System.IEquatable<ResearchEventDtoClassVariant3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant3DiscriminatorEventType? EventType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant3TaskDefinition? TaskDefinition { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant3TaskDefinition? TaskDefinition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskDefinition))]
#endif
        public bool IsTaskDefinition => TaskDefinition != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTaskDefinition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant3TaskDefinition? value)
        {
            value = TaskDefinition;
            return IsTaskDefinition;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant3TaskDefinition PickTaskDefinition() => IsTaskDefinition
            ? TaskDefinition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TaskDefinition' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant3TaskOperation? TaskOperation { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant3TaskOperation? TaskOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskOperation))]
#endif
        public bool IsTaskOperation => TaskOperation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTaskOperation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant3TaskOperation? value)
        {
            value = TaskOperation;
            return IsTaskOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant3TaskOperation PickTaskOperation() => IsTaskOperation
            ? TaskOperation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TaskOperation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchEventDtoClassVariant3TaskOutput? TaskOutput { get; init; }
#else
        public global::Exa.ResearchEventDtoClassVariant3TaskOutput? TaskOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskOutput))]
#endif
        public bool IsTaskOutput => TaskOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTaskOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchEventDtoClassVariant3TaskOutput? value)
        {
            value = TaskOutput;
            return IsTaskOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchEventDtoClassVariant3TaskOutput PickTaskOutput() => IsTaskOutput
            ? TaskOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TaskOutput' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant3(global::Exa.ResearchEventDtoClassVariant3TaskDefinition value) => new ResearchEventDtoClassVariant3((global::Exa.ResearchEventDtoClassVariant3TaskDefinition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant3TaskDefinition?(ResearchEventDtoClassVariant3 @this) => @this.TaskDefinition;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant3(global::Exa.ResearchEventDtoClassVariant3TaskDefinition? value)
        {
            TaskDefinition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchEventDtoClassVariant3 FromTaskDefinition(global::Exa.ResearchEventDtoClassVariant3TaskDefinition? value) => new ResearchEventDtoClassVariant3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant3(global::Exa.ResearchEventDtoClassVariant3TaskOperation value) => new ResearchEventDtoClassVariant3((global::Exa.ResearchEventDtoClassVariant3TaskOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant3TaskOperation?(ResearchEventDtoClassVariant3 @this) => @this.TaskOperation;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant3(global::Exa.ResearchEventDtoClassVariant3TaskOperation? value)
        {
            TaskOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchEventDtoClassVariant3 FromTaskOperation(global::Exa.ResearchEventDtoClassVariant3TaskOperation? value) => new ResearchEventDtoClassVariant3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant3(global::Exa.ResearchEventDtoClassVariant3TaskOutput value) => new ResearchEventDtoClassVariant3((global::Exa.ResearchEventDtoClassVariant3TaskOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchEventDtoClassVariant3TaskOutput?(ResearchEventDtoClassVariant3 @this) => @this.TaskOutput;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant3(global::Exa.ResearchEventDtoClassVariant3TaskOutput? value)
        {
            TaskOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResearchEventDtoClassVariant3 FromTaskOutput(global::Exa.ResearchEventDtoClassVariant3TaskOutput? value) => new ResearchEventDtoClassVariant3(value);

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant3(
            global::Exa.ResearchEventDtoClassVariant3DiscriminatorEventType? eventType,
            global::Exa.ResearchEventDtoClassVariant3TaskDefinition? taskDefinition,
            global::Exa.ResearchEventDtoClassVariant3TaskOperation? taskOperation,
            global::Exa.ResearchEventDtoClassVariant3TaskOutput? taskOutput
            )
        {
            EventType = eventType;

            TaskDefinition = taskDefinition;
            TaskOperation = taskOperation;
            TaskOutput = taskOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TaskOutput as object ??
            TaskOperation as object ??
            TaskDefinition as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TaskDefinition?.ToString() ??
            TaskOperation?.ToString() ??
            TaskOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTaskDefinition && !IsTaskOperation && !IsTaskOutput || !IsTaskDefinition && IsTaskOperation && !IsTaskOutput || !IsTaskDefinition && !IsTaskOperation && IsTaskOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.ResearchEventDtoClassVariant3TaskDefinition, TResult>? taskDefinition = null,
            global::System.Func<global::Exa.ResearchEventDtoClassVariant3TaskOperation, TResult>? taskOperation = null,
            global::System.Func<global::Exa.ResearchEventDtoClassVariant3TaskOutput, TResult>? taskOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTaskDefinition && taskDefinition != null)
            {
                return taskDefinition(TaskDefinition!);
            }
            else if (IsTaskOperation && taskOperation != null)
            {
                return taskOperation(TaskOperation!);
            }
            else if (IsTaskOutput && taskOutput != null)
            {
                return taskOutput(TaskOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskDefinition>? taskDefinition = null,

            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOperation>? taskOperation = null,

            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOutput>? taskOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTaskDefinition)
            {
                taskDefinition?.Invoke(TaskDefinition!);
            }
            else if (IsTaskOperation)
            {
                taskOperation?.Invoke(TaskOperation!);
            }
            else if (IsTaskOutput)
            {
                taskOutput?.Invoke(TaskOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskDefinition>? taskDefinition = null,
            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOperation>? taskOperation = null,
            global::System.Action<global::Exa.ResearchEventDtoClassVariant3TaskOutput>? taskOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTaskDefinition)
            {
                taskDefinition?.Invoke(TaskDefinition!);
            }
            else if (IsTaskOperation)
            {
                taskOperation?.Invoke(TaskOperation!);
            }
            else if (IsTaskOutput)
            {
                taskOutput?.Invoke(TaskOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TaskDefinition,
                typeof(global::Exa.ResearchEventDtoClassVariant3TaskDefinition),
                TaskOperation,
                typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperation),
                TaskOutput,
                typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutput),
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
        public bool Equals(ResearchEventDtoClassVariant3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant3TaskDefinition?>.Default.Equals(TaskDefinition, other.TaskDefinition) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant3TaskOperation?>.Default.Equals(TaskOperation, other.TaskOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchEventDtoClassVariant3TaskOutput?>.Default.Equals(TaskOutput, other.TaskOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResearchEventDtoClassVariant3 obj1, ResearchEventDtoClassVariant3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResearchEventDtoClassVariant3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResearchEventDtoClassVariant3 obj1, ResearchEventDtoClassVariant3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResearchEventDtoClassVariant3 o && Equals(o);
        }
    }
}
