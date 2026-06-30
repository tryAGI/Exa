#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// The profile related to the search result
    /// </summary>
    public readonly partial struct Profile : global::System.IEquatable<Profile>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant1? LinkedinCompany { get; init; }
#else
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant1? LinkedinCompany { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LinkedinCompany))]
#endif
        public bool IsLinkedinCompany => LinkedinCompany != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLinkedinCompany(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchDtoClassCompletedCitationProfileVariant1? value)
        {
            value = LinkedinCompany;
            return IsLinkedinCompany;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant1 PickLinkedinCompany() => IsLinkedinCompany
            ? LinkedinCompany!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LinkedinCompany' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2? Company { get; init; }
#else
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2? Company { get; }
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
            out global::Exa.ResearchDtoClassCompletedCitationProfileVariant2? value)
        {
            value = Company;
            return IsCompany;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2 PickCompany() => IsCompany
            ? Company!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Company' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant3? LinkedinPerson { get; init; }
#else
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant3? LinkedinPerson { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LinkedinPerson))]
#endif
        public bool IsLinkedinPerson => LinkedinPerson != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLinkedinPerson(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchDtoClassCompletedCitationProfileVariant3? value)
        {
            value = LinkedinPerson;
            return IsLinkedinPerson;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant3 PickLinkedinPerson() => IsLinkedinPerson
            ? LinkedinPerson!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LinkedinPerson' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4? Person { get; init; }
#else
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4? Person { get; }
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
            out global::Exa.ResearchDtoClassCompletedCitationProfileVariant4? value)
        {
            value = Person;
            return IsPerson;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4 PickPerson() => IsPerson
            ? Person!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Person' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Profile(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1 value) => new Profile((global::Exa.ResearchDtoClassCompletedCitationProfileVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchDtoClassCompletedCitationProfileVariant1?(Profile @this) => @this.LinkedinCompany;

        /// <summary>
        /// 
        /// </summary>
        public Profile(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1? value)
        {
            LinkedinCompany = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Profile FromLinkedinCompany(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1? value) => new Profile(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Profile(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2 value) => new Profile((global::Exa.ResearchDtoClassCompletedCitationProfileVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchDtoClassCompletedCitationProfileVariant2?(Profile @this) => @this.Company;

        /// <summary>
        /// 
        /// </summary>
        public Profile(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2? value)
        {
            Company = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Profile FromCompany(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2? value) => new Profile(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Profile(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3 value) => new Profile((global::Exa.ResearchDtoClassCompletedCitationProfileVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchDtoClassCompletedCitationProfileVariant3?(Profile @this) => @this.LinkedinPerson;

        /// <summary>
        /// 
        /// </summary>
        public Profile(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3? value)
        {
            LinkedinPerson = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Profile FromLinkedinPerson(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3? value) => new Profile(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Profile(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4 value) => new Profile((global::Exa.ResearchDtoClassCompletedCitationProfileVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchDtoClassCompletedCitationProfileVariant4?(Profile @this) => @this.Person;

        /// <summary>
        /// 
        /// </summary>
        public Profile(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4? value)
        {
            Person = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Profile FromPerson(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4? value) => new Profile(value);

        /// <summary>
        /// 
        /// </summary>
        public Profile(
            global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminatorType? type,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant1? linkedinCompany,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2? company,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant3? linkedinPerson,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4? person
            )
        {
            Type = type;

            LinkedinCompany = linkedinCompany;
            Company = company;
            LinkedinPerson = linkedinPerson;
            Person = person;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Person as object ??
            LinkedinPerson as object ??
            Company as object ??
            LinkedinCompany as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LinkedinCompany?.ToString() ??
            Company?.ToString() ??
            LinkedinPerson?.ToString() ??
            Person?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLinkedinCompany && !IsCompany && !IsLinkedinPerson && !IsPerson || !IsLinkedinCompany && IsCompany && !IsLinkedinPerson && !IsPerson || !IsLinkedinCompany && !IsCompany && IsLinkedinPerson && !IsPerson || !IsLinkedinCompany && !IsCompany && !IsLinkedinPerson && IsPerson;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1, TResult>? linkedinCompany = null,
            global::System.Func<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2, TResult>? company = null,
            global::System.Func<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3, TResult>? linkedinPerson = null,
            global::System.Func<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4, TResult>? person = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLinkedinCompany && linkedinCompany != null)
            {
                return linkedinCompany(LinkedinCompany!);
            }
            else if (IsCompany && company != null)
            {
                return company(Company!);
            }
            else if (IsLinkedinPerson && linkedinPerson != null)
            {
                return linkedinPerson(LinkedinPerson!);
            }
            else if (IsPerson && person != null)
            {
                return person(Person!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1>? linkedinCompany = null,

            global::System.Action<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2>? company = null,

            global::System.Action<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3>? linkedinPerson = null,

            global::System.Action<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4>? person = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLinkedinCompany)
            {
                linkedinCompany?.Invoke(LinkedinCompany!);
            }
            else if (IsCompany)
            {
                company?.Invoke(Company!);
            }
            else if (IsLinkedinPerson)
            {
                linkedinPerson?.Invoke(LinkedinPerson!);
            }
            else if (IsPerson)
            {
                person?.Invoke(Person!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1>? linkedinCompany = null,
            global::System.Action<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2>? company = null,
            global::System.Action<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3>? linkedinPerson = null,
            global::System.Action<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4>? person = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLinkedinCompany)
            {
                linkedinCompany?.Invoke(LinkedinCompany!);
            }
            else if (IsCompany)
            {
                company?.Invoke(Company!);
            }
            else if (IsLinkedinPerson)
            {
                linkedinPerson?.Invoke(LinkedinPerson!);
            }
            else if (IsPerson)
            {
                person?.Invoke(Person!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LinkedinCompany,
                typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1),
                Company,
                typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2),
                LinkedinPerson,
                typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3),
                Person,
                typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4),
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
        public bool Equals(Profile other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1?>.Default.Equals(LinkedinCompany, other.LinkedinCompany) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2?>.Default.Equals(Company, other.Company) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3?>.Default.Equals(LinkedinPerson, other.LinkedinPerson) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4?>.Default.Equals(Person, other.Person) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Profile obj1, Profile obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Profile>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Profile obj1, Profile obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Profile o && Equals(o);
        }
    }
}
