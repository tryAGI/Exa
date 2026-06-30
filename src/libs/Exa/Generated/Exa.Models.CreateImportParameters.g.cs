#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateImportParameters : global::System.IEquatable<CreateImportParameters>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.CreateImportParametersDiscriminatorFormat? Format { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.CreateImportParametersVariant1? Csv { get; init; }
#else
        public global::Exa.CreateImportParametersVariant1? Csv { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Csv))]
#endif
        public bool IsCsv => Csv != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCsv(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.CreateImportParametersVariant1? value)
        {
            value = Csv;
            return IsCsv;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.CreateImportParametersVariant1 PickCsv() => IsCsv
            ? Csv!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Csv' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateImportParameters(global::Exa.CreateImportParametersVariant1 value) => new CreateImportParameters((global::Exa.CreateImportParametersVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.CreateImportParametersVariant1?(CreateImportParameters @this) => @this.Csv;

        /// <summary>
        /// 
        /// </summary>
        public CreateImportParameters(global::Exa.CreateImportParametersVariant1? value)
        {
            Csv = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateImportParameters FromCsv(global::Exa.CreateImportParametersVariant1? value) => new CreateImportParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateImportParameters(
            global::Exa.CreateImportParametersDiscriminatorFormat? format,
            global::Exa.CreateImportParametersVariant1? csv
            )
        {
            Format = format;

            Csv = csv;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Csv as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Csv?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCsv;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.CreateImportParametersVariant1, TResult>? csv = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCsv && csv != null)
            {
                return csv(Csv!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.CreateImportParametersVariant1>? csv = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCsv)
            {
                csv?.Invoke(Csv!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.CreateImportParametersVariant1>? csv = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCsv)
            {
                csv?.Invoke(Csv!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Csv,
                typeof(global::Exa.CreateImportParametersVariant1),
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
        public bool Equals(CreateImportParameters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.CreateImportParametersVariant1?>.Default.Equals(Csv, other.Csv) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateImportParameters obj1, CreateImportParameters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateImportParameters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateImportParameters obj1, CreateImportParameters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateImportParameters o && Equals(o);
        }
    }
}
