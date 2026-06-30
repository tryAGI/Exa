#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Entity : global::System.IEquatable<Entity>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.CompanyEntity? Company { get; init; }
#else
        public global::Exa.CompanyEntity? Company { get; }
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
            out global::Exa.CompanyEntity? value)
        {
            value = Company;
            return IsCompany;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.CompanyEntity PickCompany() => IsCompany
            ? Company!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Company' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.PersonEntity? Person { get; init; }
#else
        public global::Exa.PersonEntity? Person { get; }
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
            out global::Exa.PersonEntity? value)
        {
            value = Person;
            return IsPerson;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.PersonEntity PickPerson() => IsPerson
            ? Person!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Person' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ArticleEntity? Article { get; init; }
#else
        public global::Exa.ArticleEntity? Article { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Article))]
#endif
        public bool IsArticle => Article != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArticle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ArticleEntity? value)
        {
            value = Article;
            return IsArticle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ArticleEntity PickArticle() => IsArticle
            ? Article!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Article' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.ResearchPaperEntity? ResearchPaper { get; init; }
#else
        public global::Exa.ResearchPaperEntity? ResearchPaper { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResearchPaper))]
#endif
        public bool IsResearchPaper => ResearchPaper != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResearchPaper(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.ResearchPaperEntity? value)
        {
            value = ResearchPaper;
            return IsResearchPaper;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.ResearchPaperEntity PickResearchPaper() => IsResearchPaper
            ? ResearchPaper!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResearchPaper' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.CustomEntity? Custom { get; init; }
#else
        public global::Exa.CustomEntity? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.CustomEntity? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.CustomEntity PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Entity(global::Exa.CompanyEntity value) => new Entity((global::Exa.CompanyEntity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.CompanyEntity?(Entity @this) => @this.Company;

        /// <summary>
        /// 
        /// </summary>
        public Entity(global::Exa.CompanyEntity? value)
        {
            Company = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Entity FromCompany(global::Exa.CompanyEntity? value) => new Entity(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Entity(global::Exa.PersonEntity value) => new Entity((global::Exa.PersonEntity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.PersonEntity?(Entity @this) => @this.Person;

        /// <summary>
        /// 
        /// </summary>
        public Entity(global::Exa.PersonEntity? value)
        {
            Person = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Entity FromPerson(global::Exa.PersonEntity? value) => new Entity(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Entity(global::Exa.ArticleEntity value) => new Entity((global::Exa.ArticleEntity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ArticleEntity?(Entity @this) => @this.Article;

        /// <summary>
        /// 
        /// </summary>
        public Entity(global::Exa.ArticleEntity? value)
        {
            Article = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Entity FromArticle(global::Exa.ArticleEntity? value) => new Entity(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Entity(global::Exa.ResearchPaperEntity value) => new Entity((global::Exa.ResearchPaperEntity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.ResearchPaperEntity?(Entity @this) => @this.ResearchPaper;

        /// <summary>
        /// 
        /// </summary>
        public Entity(global::Exa.ResearchPaperEntity? value)
        {
            ResearchPaper = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Entity FromResearchPaper(global::Exa.ResearchPaperEntity? value) => new Entity(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Entity(global::Exa.CustomEntity value) => new Entity((global::Exa.CustomEntity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.CustomEntity?(Entity @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Entity(global::Exa.CustomEntity? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Entity FromCustom(global::Exa.CustomEntity? value) => new Entity(value);

        /// <summary>
        /// 
        /// </summary>
        public Entity(
            global::Exa.CompanyEntity? company,
            global::Exa.PersonEntity? person,
            global::Exa.ArticleEntity? article,
            global::Exa.ResearchPaperEntity? researchPaper,
            global::Exa.CustomEntity? custom
            )
        {
            Company = company;
            Person = person;
            Article = article;
            ResearchPaper = researchPaper;
            Custom = custom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Custom as object ??
            ResearchPaper as object ??
            Article as object ??
            Person as object ??
            Company as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Company?.ToString() ??
            Person?.ToString() ??
            Article?.ToString() ??
            ResearchPaper?.ToString() ??
            Custom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompany && !IsPerson && !IsArticle && !IsResearchPaper && !IsCustom || !IsCompany && IsPerson && !IsArticle && !IsResearchPaper && !IsCustom || !IsCompany && !IsPerson && IsArticle && !IsResearchPaper && !IsCustom || !IsCompany && !IsPerson && !IsArticle && IsResearchPaper && !IsCustom || !IsCompany && !IsPerson && !IsArticle && !IsResearchPaper && IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.CompanyEntity, TResult>? company = null,
            global::System.Func<global::Exa.PersonEntity, TResult>? person = null,
            global::System.Func<global::Exa.ArticleEntity, TResult>? article = null,
            global::System.Func<global::Exa.ResearchPaperEntity, TResult>? researchPaper = null,
            global::System.Func<global::Exa.CustomEntity, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompany && company != null)
            {
                return company(Company!);
            }
            else if (IsPerson && person != null)
            {
                return person(Person!);
            }
            else if (IsArticle && article != null)
            {
                return article(Article!);
            }
            else if (IsResearchPaper && researchPaper != null)
            {
                return researchPaper(ResearchPaper!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.CompanyEntity>? company = null,

            global::System.Action<global::Exa.PersonEntity>? person = null,

            global::System.Action<global::Exa.ArticleEntity>? article = null,

            global::System.Action<global::Exa.ResearchPaperEntity>? researchPaper = null,

            global::System.Action<global::Exa.CustomEntity>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompany)
            {
                company?.Invoke(Company!);
            }
            else if (IsPerson)
            {
                person?.Invoke(Person!);
            }
            else if (IsArticle)
            {
                article?.Invoke(Article!);
            }
            else if (IsResearchPaper)
            {
                researchPaper?.Invoke(ResearchPaper!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.CompanyEntity>? company = null,
            global::System.Action<global::Exa.PersonEntity>? person = null,
            global::System.Action<global::Exa.ArticleEntity>? article = null,
            global::System.Action<global::Exa.ResearchPaperEntity>? researchPaper = null,
            global::System.Action<global::Exa.CustomEntity>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompany)
            {
                company?.Invoke(Company!);
            }
            else if (IsPerson)
            {
                person?.Invoke(Person!);
            }
            else if (IsArticle)
            {
                article?.Invoke(Article!);
            }
            else if (IsResearchPaper)
            {
                researchPaper?.Invoke(ResearchPaper!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
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
                typeof(global::Exa.CompanyEntity),
                Person,
                typeof(global::Exa.PersonEntity),
                Article,
                typeof(global::Exa.ArticleEntity),
                ResearchPaper,
                typeof(global::Exa.ResearchPaperEntity),
                Custom,
                typeof(global::Exa.CustomEntity),
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
        public bool Equals(Entity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.CompanyEntity?>.Default.Equals(Company, other.Company) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.PersonEntity?>.Default.Equals(Person, other.Person) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ArticleEntity?>.Default.Equals(Article, other.Article) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.ResearchPaperEntity?>.Default.Equals(ResearchPaper, other.ResearchPaper) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.CustomEntity?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Entity obj1, Entity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Entity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Entity obj1, Entity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Entity o && Equals(o);
        }
    }
}
