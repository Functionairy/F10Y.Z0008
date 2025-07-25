using System;

using F10Y.T0003;


namespace F10Y.Z0008.Raw
{
    [ValuesMarker]
    public partial interface IDomainSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDomains _Domains => Domains.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// For C#/.NET.
        /// </summary>
        public string[] N_0001 => new[]
        {
            _Domains.CSharp,
            _Domains.dotNET,
        };

        /// <summary>
        /// For .NET project file XML node names.
        /// <para>
        /// Ordered set, ordered from .NET to Names.
        /// </para>
        /// </summary>
        public string[] N_0002 => new[]
        {
            _Domains.dotNET,
            _Domains.Project,
            _Domains.File,
            _Domains.XML,
            _Domains.Node,
            _Domains.Names,
        };

        /// <summary>
        /// Example paths and path-parts.
        /// </summary>
        public string[] N_0003 => new[]
        {
            _Domains.Examples,
            _Domains.Paths,
            _Domains.PathParts,
        };
    }
}
