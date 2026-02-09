using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0008
{
    /// <summary>
    /// Generally-applicable domain sets.
    /// </summary>
    [ValuesMarker]
    public partial interface IDomainNameSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDomainNames _DomainNames => DomainNames.Instance;

        [Ignore]
        Raw.IDomainNameSets _Raw => Raw.DomainNameSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="Raw.IDomainNameSets.N_0001"/>
        string[] CSharp_NET => _Raw.N_0001;

        /// <inheritdoc cref="Raw.IDomainNameSets.N_0003"/>
        string[] Example_PathsAndPathParts => _Raw.N_0003;

        /// <inheritdoc cref="Raw.IDomainNameSets.N_0002"/>
        string[] ProjectFile_XmlNodeNames => _Raw.N_0002;

        /// <summary>
        /// <value>
        /// <list type="bullet">
        /// <item><inheritdoc cref="IDomainNames.dotNET" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Project" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.XML" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Node" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Names" path="descendant::value"/></item>
        /// </list>
        /// </value>
        /// </summary>
        string[] dotNETProjectXmlNodeNames => new[]
        {
            _DomainNames.dotNET,
            _DomainNames.Project,
            _DomainNames.XML,
            _DomainNames.Node,
            _DomainNames.Names,
        };

        /// <summary>
        /// <value>
        /// <list type="bullet">
        /// <item><inheritdoc cref="IDomainNames.dotNET" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Project" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.XML" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Element" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Names" path="descendant::value"/></item>
        /// </list>
        /// </value>
        /// </summary>
        string[] dotNETProjectXmlElementNames => new[]
        {
            _DomainNames.dotNET,
            _DomainNames.Project,
            _DomainNames.XML,
            _DomainNames.Element,
            _DomainNames.Names,
        };

        /// <summary>
        /// <value>
        /// <list type="bullet">
        /// <item><inheritdoc cref="IDomainNames.dotNET" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Project" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.XML" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Names" path="descendant::value"/></item>
        /// </list>
        /// </value>
        /// </summary>
        string[] dotNETProjectXml_Names => new[]
        {
            _DomainNames.dotNET,
            _DomainNames.Project,
            _DomainNames.XML,
            _DomainNames.Names,
        };

        /// <summary>
        /// <value>
        /// <list type="bullet">
        /// <item><inheritdoc cref="IDomainNames.dotNET" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Project" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.XML" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Node" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Names" path="descendant::value"/></item>
        /// </list>
        /// </value>
        /// </summary>
        string[] dotNETProjectXmlNodeNamesTest => new[]
        {
            _DomainNames.dotNET,
            _DomainNames.Project,
            _DomainNames.XML,
            _DomainNames.Node,
            _DomainNames.Names,
            _DomainNames.Test,
        };

        /// <summary>
        /// <value>
        /// <list type="bullet">
        /// <item><inheritdoc cref="IDomainNames.dotNET" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Project" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.XML" path="descendant::value"/></item>
        /// </list>
        /// </value>
        /// </summary>
        string[] dotNETProjectXml => new[]
        {
            _DomainNames.dotNET,
            _DomainNames.Project,
            _DomainNames.XML,
        };

        /// <summary>
        /// <value>
        /// <list type="bullet">
        /// <item><inheritdoc cref="IDomainNames.Equality" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Operation" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Descriptor" path="descendant::value"/></item>
        /// </list>
        /// </value>
        /// </summary>
        string[] EqualityOperationDescriptor => new[]
        {
            _DomainNames.Equality,
            _DomainNames.Operation,
            _DomainNames.Descriptor,
        };

        /// <summary>
        /// <value>
        /// <list type="bullet">
        /// <item><inheritdoc cref="IDomainNames.Set" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Equality" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Operation" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IDomainNames.Descriptor" path="descendant::value"/></item>
        /// </list>
        /// </value>
        /// </summary>
        string[] SetEqualityOperationDescriptor => new[]
        {
            _DomainNames.Set,
            _DomainNames.Equality,
            _DomainNames.Operation,
            _DomainNames.Descriptor,
        };

#pragma warning restore IDE1006 // Naming Styles
    }
}
