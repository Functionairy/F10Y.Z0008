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

        [Ignore]
        Raw.IDomainNameSets _Raw => Raw.DomainNameSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IDomainNameSets.N_0001"/>
        string[] CSharp_NET => _Raw.N_0001;

        /// <inheritdoc cref="Raw.IDomainNameSets.N_0003"/>
        string[] Example_PathsAndPathParts => _Raw.N_0003;

        /// <inheritdoc cref="Raw.IDomainNameSets.N_0002"/>
        string[] ProjectFile_XmlNodeNames => _Raw.N_0002;
    }
}
