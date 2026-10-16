#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SearchResultOutputEntitie : global::System.IEquatable<SearchResultOutputEntitie>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitieDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchCompanyEntityOutput? Company { get; init; }
#else
        public global::Exa.SearchCompanyEntityOutput? Company { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Company))]
#endif
        public bool IsCompany => Company != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCompany(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchCompanyEntityOutput? value)
        {
            value = Company;
            return IsCompany;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutput PickCompany() => Company is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Company' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchPersonEntityOutput? Person { get; init; }
#else
        public global::Exa.SearchPersonEntityOutput? Person { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Person))]
#endif
        public bool IsPerson => Person != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPerson(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchPersonEntityOutput? value)
        {
            value = Person;
            return IsPerson;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutput PickPerson() => Person is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Person' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.SearchPublicationEntityOutput? Publication { get; init; }
#else
        public global::Exa.SearchPublicationEntityOutput? Publication { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Publication))]
#endif
        public bool IsPublication => Publication != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPublication(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.SearchPublicationEntityOutput? value)
        {
            value = Publication;
            return IsPublication;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutput PickPublication() => Publication is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Publication' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchResultOutputEntitie(global::Exa.SearchCompanyEntityOutput value) => new SearchResultOutputEntitie((global::Exa.SearchCompanyEntityOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchCompanyEntityOutput?(SearchResultOutputEntitie @this) => @this.Company;

        /// <summary>
        ///
        /// </summary>
        public SearchResultOutputEntitie(global::Exa.SearchCompanyEntityOutput? value)
        {
            Company = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchResultOutputEntitie FromCompany(global::Exa.SearchCompanyEntityOutput? value) => new SearchResultOutputEntitie(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchResultOutputEntitie(global::Exa.SearchPersonEntityOutput value) => new SearchResultOutputEntitie((global::Exa.SearchPersonEntityOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchPersonEntityOutput?(SearchResultOutputEntitie @this) => @this.Person;

        /// <summary>
        ///
        /// </summary>
        public SearchResultOutputEntitie(global::Exa.SearchPersonEntityOutput? value)
        {
            Person = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchResultOutputEntitie FromPerson(global::Exa.SearchPersonEntityOutput? value) => new SearchResultOutputEntitie(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchResultOutputEntitie(global::Exa.SearchPublicationEntityOutput value) => new SearchResultOutputEntitie((global::Exa.SearchPublicationEntityOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Exa.SearchPublicationEntityOutput?(SearchResultOutputEntitie @this) => @this.Publication;

        /// <summary>
        ///
        /// </summary>
        public SearchResultOutputEntitie(global::Exa.SearchPublicationEntityOutput? value)
        {
            Publication = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchResultOutputEntitie FromPublication(global::Exa.SearchPublicationEntityOutput? value) => new SearchResultOutputEntitie(value);

        /// <summary>
        ///
        /// </summary>
        public SearchResultOutputEntitie(
            global::Exa.SearchResultOutputEntitieDiscriminatorType? type,
            global::Exa.SearchCompanyEntityOutput? company,
            global::Exa.SearchPersonEntityOutput? person,
            global::Exa.SearchPublicationEntityOutput? publication
            )
        {
            Type = type;

            Company = company;
            Person = person;
            Publication = publication;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Publication as object ??
            Person as object ??
            Company as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Company?.ToString() ??
            Person?.ToString() ??
            Publication?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCompany && !IsPerson && !IsPublication || !IsCompany && IsPerson && !IsPublication || !IsCompany && !IsPerson && IsPublication;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.SearchCompanyEntityOutput, TResult>? company = null,
            global::System.Func<global::Exa.SearchPersonEntityOutput, TResult>? person = null,
            global::System.Func<global::Exa.SearchPublicationEntityOutput, TResult>? publication = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Company is { } __value0 && company != null)
            {
                return company(__value0);
            }
            else if (Person is { } __value1 && person != null)
            {
                return person(__value1);
            }
            else if (Publication is { } __value2 && publication != null)
            {
                return publication(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.SearchCompanyEntityOutput>? company = null,

            global::System.Action<global::Exa.SearchPersonEntityOutput>? person = null,

            global::System.Action<global::Exa.SearchPublicationEntityOutput>? publication = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Company is { } __value0)
            {
                company?.Invoke(__value0);
            }
            else if (Person is { } __value1)
            {
                person?.Invoke(__value1);
            }
            else if (Publication is { } __value2)
            {
                publication?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.SearchCompanyEntityOutput>? company = null,
            global::System.Action<global::Exa.SearchPersonEntityOutput>? person = null,
            global::System.Action<global::Exa.SearchPublicationEntityOutput>? publication = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Company is { } __value0)
            {
                company?.Invoke(__value0);
            }
            else if (Person is { } __value1)
            {
                person?.Invoke(__value1);
            }
            else if (Publication is { } __value2)
            {
                publication?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Company,
                typeof(global::Exa.SearchCompanyEntityOutput),
                Person,
                typeof(global::Exa.SearchPersonEntityOutput),
                Publication,
                typeof(global::Exa.SearchPublicationEntityOutput),
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
        public bool Equals(SearchResultOutputEntitie other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchCompanyEntityOutput?>.Default.Equals(Company, other.Company) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchPersonEntityOutput?>.Default.Equals(Person, other.Person) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.SearchPublicationEntityOutput?>.Default.Equals(Publication, other.Publication)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SearchResultOutputEntitie obj1, SearchResultOutputEntitie obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchResultOutputEntitie>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SearchResultOutputEntitie obj1, SearchResultOutputEntitie obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchResultOutputEntitie o && Equals(o);
        }
    }
}
