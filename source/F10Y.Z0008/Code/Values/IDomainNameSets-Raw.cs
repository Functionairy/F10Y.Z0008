using System;

using F10Y.T0003;


namespace F10Y.Z0008.Raw
{
    [ValuesMarker]
    public partial interface IDomainNameSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDomainNames _DomainNames => DomainNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// For C#/.NET.
        /// </summary>
        string[] N_0001 => new[]
        {
            _DomainNames.CSharp,
            _DomainNames.dotNET,
        };

        /// <summary>
        /// For .NET project file XML node names.
        /// <para>
        /// Ordered set, ordered from .NET to Names.
        /// </para>
        /// </summary>
        string[] N_0002 => new[]
        {
            _DomainNames.dotNET,
            _DomainNames.Project,
            _DomainNames.File,
            _DomainNames.XML,
            _DomainNames.Node,
            _DomainNames.Names,
        };

        /// <summary>
        /// Example paths and path-parts.
        /// </summary>
        string[] N_0003 => new[]
        {
            _DomainNames.Examples,
            _DomainNames.Paths,
            _DomainNames.PathParts,
        };
    }
}
