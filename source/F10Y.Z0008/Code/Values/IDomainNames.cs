using System;

using F10Y.L0026.T007;
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
        /// <para><value>Descriptor</value></para>
        /// </summary>
        const string Descriptor_Constant = "Descriptor";

        /// <inheritdoc cref="Descriptor_Constant"/>
        string Descriptor => Descriptor_Constant;

        /// <summary>
        /// <para><value>.NET</value></para>
        /// </summary>
        const string dotNET_Constant = ".NET";

        /// <inheritdoc cref="dotNET_Constant"/>
        string dotNET => dotNET_Constant;

        /// <summary>
        /// <para><value>Element</value></para>
        /// </summary>
        const string Element_Constant = "Element";

        /// <inheritdoc cref="Element_Constant"/>
        string Element => Element_Constant;

        /// <summary>
        /// <para><value>Equality</value></para>
        /// </summary>
        const string Equality_Constant = "Equality";

        /// <inheritdoc cref="Equality_Constant"/>
        string Equality => Equality_Constant;

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
        const string Names_Constant = "Names";

        /// <inheritdoc cref="Names_Constant"/>
        string Names => Names_Constant;

        /// <summary>
        /// <para><value>Node</value></para>
        /// </summary>
        const string Node_Constant = "Node";

        /// <inheritdoc cref="Node_Constant"/>
        string Node => Node_Constant;

        /// <summary>
        /// <para><value>Octokit</value></para>
        /// </summary>
        string Octokit => "Octokit";

        /// <summary>
        /// <para><value>Operation</value></para>
        /// </summary>
        const string Operation_Constant = "Operation";

        /// <inheritdoc cref="Operation_Constant"/>
        string Operation => Operation_Constant;

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
        const string Project_Constant = "Project";

        /// <inheritdoc cref="Project_Constant"/>
        string Project => Project_Constant;

        /// <summary>
        /// <para><value>Set</value></para>
        /// </summary>
        const string Set_Constant = "Set";

        /// <inheritdoc cref="Set_Constant"/>
        string Set => Set_Constant;

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
        /// <para><value>Test</value></para>
        /// </summary>
        const string Test_Constant = "Test";

        /// <inheritdoc cref="Test_Constant"/>
        string Test => Test_Constant;

        /// <summary>
        /// <para><value>Visual Studio</value></para>
        /// </summary>
        string VisualStudio => "Visual Studio";

        /// <summary>
        /// <para><value>XML</value></para>
        /// </summary>
        const string XML_Constant = "XML";

        /// <inheritdoc cref="XML_Constant"/>
        string XML => XML_Constant;

#pragma warning restore IDE1006 // Naming Styles
    }
}
