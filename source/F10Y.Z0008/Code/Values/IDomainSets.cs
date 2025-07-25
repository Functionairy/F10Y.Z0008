using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0008
{
    /// <summary>
    /// Generally-applicable domain sets.
    /// </summary>
    [ValuesMarker]
    public partial interface IDomainSets
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IDomainSets _Raw => Raw.DomainSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IDomainSets.N_0001"/>
        public string[] CSharp_NET => _Raw.N_0001;

        /// <inheritdoc cref="Raw.IDomainSets.N_0003"/>
        public string[] Example_PathsAndPathParts => _Raw.N_0003;

        /// <inheritdoc cref="Raw.IDomainSets.N_0002"/>
        public string[] ProjectFile_XmlNodeNames => _Raw.N_0002;
    }
}
