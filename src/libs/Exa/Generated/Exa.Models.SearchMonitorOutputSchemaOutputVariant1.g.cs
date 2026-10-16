#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// JSON schema for synthesized output. Supported root types are "text" and "object". When provided, the response includes an output object whose content matches this schema. Works with every search type and adds about 2 seconds of synthesis latency on top of the selected search type. Object schemas are limited to 10 properties in total (nested and array items properties count toward the limit) and 2 levels of nesting, and every array must define items.
    /// </summary>
    public readonly partial struct SearchMonitorOutputSchemaOutputVariant1 : global::System.IEquatable<SearchMonitorOutputSchemaOutputVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.OutputSchemaTextOutput? Text { get; init; }
#else
        public global::Exa.OutputSchemaTextOutput? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.OutputSchemaTextOutput? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.OutputSchemaTextOutput PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.OutputSchemaObject? ObjectValue { get; init; }
#else
        public global::Exa.OutputSchemaObject? ObjectValue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectValue))]
#endif
        public bool IsObjectValue => ObjectValue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickObjectValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.OutputSchemaObject? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.OutputSchemaObject PickObjectValue() => ObjectValue is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchMonitorOutputSchemaOutputVariant1(global::Exa.OutputSchemaTextOutput value) => new SearchMonitorOutputSchemaOutputVariant1((global::Exa.OutputSchemaTextOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.OutputSchemaTextOutput?(SearchMonitorOutputSchemaOutputVariant1 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public SearchMonitorOutputSchemaOutputVariant1(global::Exa.OutputSchemaTextOutput? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchMonitorOutputSchemaOutputVariant1 FromText(global::Exa.OutputSchemaTextOutput? value) => new SearchMonitorOutputSchemaOutputVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchMonitorOutputSchemaOutputVariant1(global::Exa.OutputSchemaObject value) => new SearchMonitorOutputSchemaOutputVariant1((global::Exa.OutputSchemaObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.OutputSchemaObject?(SearchMonitorOutputSchemaOutputVariant1 @this) => @this.ObjectValue;

        /// <summary>
        ///
        /// </summary>
        public SearchMonitorOutputSchemaOutputVariant1(global::Exa.OutputSchemaObject? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchMonitorOutputSchemaOutputVariant1 FromObjectValue(global::Exa.OutputSchemaObject? value) => new SearchMonitorOutputSchemaOutputVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public SearchMonitorOutputSchemaOutputVariant1(
            global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType? type,
            global::Exa.OutputSchemaTextOutput? text,
            global::Exa.OutputSchemaObject? objectValue
            )
        {
            Type = type;

            Text = text;
            ObjectValue = objectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ObjectValue as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ObjectValue?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsObjectValue || !IsText && IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.OutputSchemaTextOutput, TResult>? text = null,
            global::System.Func<global::Exa.OutputSchemaObject, TResult>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (ObjectValue is { } __value1 && objectValue != null)
            {
                return objectValue(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.OutputSchemaTextOutput>? text = null,

            global::System.Action<global::Exa.OutputSchemaObject>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ObjectValue is { } __value1)
            {
                objectValue?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.OutputSchemaTextOutput>? text = null,
            global::System.Action<global::Exa.OutputSchemaObject>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ObjectValue is { } __value1)
            {
                objectValue?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Exa.OutputSchemaTextOutput),
                ObjectValue,
                typeof(global::Exa.OutputSchemaObject),
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
        public bool Equals(SearchMonitorOutputSchemaOutputVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.OutputSchemaTextOutput?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.OutputSchemaObject?>.Default.Equals(ObjectValue, other.ObjectValue)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SearchMonitorOutputSchemaOutputVariant1 obj1, SearchMonitorOutputSchemaOutputVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchMonitorOutputSchemaOutputVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SearchMonitorOutputSchemaOutputVariant1 obj1, SearchMonitorOutputSchemaOutputVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchMonitorOutputSchemaOutputVariant1 o && Equals(o);
        }
    }
}
