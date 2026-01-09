using System;

using F10Y.T0003;


namespace F10Y.Z0008
{
    /// <summary>
    /// Instance set domain names.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [ValuesMarker]
    [DomainDescriptor(Z0008.IDomainNames.Domain_Names_Constant)]
    public partial interface IDomainNames
    {
#pragma warning disable IDE1006 // Naming Styles

        #region Instance Set Related

        /// <summary>
        /// <para><value>Applicability Names</value></para>
        /// </summary>
        const string Applicability_Names_Constant = "Applicability Names";

        /// <inheritdoc cref="Applicability_Names_Constant"/>
        string Applicability_Names => Applicability_Names_Constant;

        /// <summary>
        /// <para><value>Domain Names</value></para>
        /// </summary>
        const string Domain_Names_Constant = "Domain Names";

        /// <inheritdoc cref="Domain_Names_Constant"/>
        string Domain_Names => Domain_Names_Constant;

        /// <summary>
        /// <para><value>Opinion Names</value></para>
        /// </summary>
        const string Opinion_Names_Constant = "Opinion Names";

        /// <inheritdoc cref="Opinion_Names_Constant"/>
        string Opinion_Names => Opinion_Names_Constant;

        /// <summary>
        /// <para><value>Organization Names</value></para>
        /// </summary>
        const string Organization_Names_Constant = "Organization Names";

        /// <inheritdoc cref="Organization_Names_Constant"/>
        string Organization_Names => Organization_Names_Constant;

        #endregion

        /// <summary>
        /// <para><value>Attribute</value></para>
        /// </summary>
        string Attribute => "Attribute";

        /// <summary>
        /// <para><value>C#</value></para>
        /// </summary>
        string CSharp => "C#";

        /// <summary>
        /// <para><value>.NET</value></para>
        /// </summary>
        string dotNET => ".NET";

        /// <summary>
        /// <para><value>Element</value></para>
        /// </summary>
        string Element => "Element";

        /// <summary>
        /// <para><value>Examples</value></para>
        /// </summary>
        string Examples => "Examples";

        /// <summary>
        /// <para><value>File</value></para>
        /// </summary>
        string File => "File";

        /// <summary>
        /// <para><value>HTML</value></para>
        /// </summary>
        string HTML => "HTML";

        /// <summary>
        /// <para><value>Names</value></para>
        /// </summary>
        string Names => "Names";

        /// <summary>
        /// <para><value>Node</value></para>
        /// </summary>
        string Node => "Node";

        /// <summary>
        /// <para><value>Octokit</value></para>
        /// </summary>
        string Octokit => "Octokit";

        /// <summary>
        /// <para><value>Path-Parts</value></para>
        /// </summary>
        string PathParts => "Path-Parts";

        /// <summary>
        /// <para><value>Paths</value></para>
        /// </summary>
        string Paths => "Paths";

        /// <summary>
        /// <para><value>Project</value></para>
        /// </summary>
        string Project => "Project";

        /// <summary>
        /// <para><value>Static HTML</value></para>
        /// </summary>
        string StaticHtml => "Static HTML";

        /// <summary>
        /// <para><value>Tickers</value></para>
        /// (Stock Tickers)
        /// </summary>
        const string Tickers_Constant = "Tickers";

        /// <inheritdoc cref="Tickers_Constant"/>
        string Tickers => Tickers_Constant;

        /// <summary>
        /// <para><value>Visual Studio</value></para>
        /// </summary>
        string VisualStudio => "Visual Studio";

        /// <summary>
        /// <para><value>XML</value></para>
        /// </summary>
        string XML => "XML";

#pragma warning restore IDE1006 // Naming Styles
    }
}
