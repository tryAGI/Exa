
#nullable enable

namespace Exa
{
    /// <summary>
    /// Identifier of an Exa Connect data provider.
    /// </summary>
    public enum AgentDataSourceProvider
    {
        /// <summary>
        ///
        /// </summary>
        Affiliate,
        /// <summary>
        ///
        /// </summary>
        Baselayer,
        /// <summary>
        ///
        /// </summary>
        Fiber,
        /// <summary>
        ///
        /// </summary>
        FinancialDatasets,
        /// <summary>
        ///
        /// </summary>
        Jinko,
        /// <summary>
        ///
        /// </summary>
        Macrobond,
        /// <summary>
        ///
        /// </summary>
        Particle,
        /// <summary>
        ///
        /// </summary>
        Polymarket,
        /// <summary>
        ///
        /// </summary>
        Similarweb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentDataSourceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentDataSourceProvider value)
        {
            return value switch
            {
                AgentDataSourceProvider.Affiliate => "affiliate",
                AgentDataSourceProvider.Baselayer => "baselayer",
                AgentDataSourceProvider.Fiber => "fiber",
                AgentDataSourceProvider.FinancialDatasets => "financial_datasets",
                AgentDataSourceProvider.Jinko => "jinko",
                AgentDataSourceProvider.Macrobond => "macrobond",
                AgentDataSourceProvider.Particle => "particle",
                AgentDataSourceProvider.Polymarket => "polymarket",
                AgentDataSourceProvider.Similarweb => "similarweb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentDataSourceProvider? ToEnum(string value)
        {
            return value switch
            {
                "affiliate" => AgentDataSourceProvider.Affiliate,
                "baselayer" => AgentDataSourceProvider.Baselayer,
                "fiber" => AgentDataSourceProvider.Fiber,
                "financial_datasets" => AgentDataSourceProvider.FinancialDatasets,
                "jinko" => AgentDataSourceProvider.Jinko,
                "macrobond" => AgentDataSourceProvider.Macrobond,
                "particle" => AgentDataSourceProvider.Particle,
                "polymarket" => AgentDataSourceProvider.Polymarket,
                "similarweb" => AgentDataSourceProvider.Similarweb,
                _ => null,
            };
        }
    }
}