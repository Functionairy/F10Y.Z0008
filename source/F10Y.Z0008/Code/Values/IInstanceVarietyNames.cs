using System;

using F10Y.T0003;


namespace F10Y.Z0008
{
    /// <summary>
    /// Generally-applicable instance variety names.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [ValuesMarker]
    public partial interface IInstanceVarietyNames
    {
        /// <summary>
        /// <para><value>DataTypes</value></para>
        /// </summary>
        public string DataTypes => "DataTypes";

        /// <summary>
        /// <para><value>Functions</value></para>
        /// </summary>
        public string Functions => "Functions";

        /// <summary>
        /// <para><value>Types</value></para>
        /// </summary>
        public string Types => "Types";

        /// <summary>
        /// <para><value>UtilityTypes</value></para>
        /// </summary>
        public string UtilityTypes => "UtilityTypes";

        /// <summary>
        /// <para><value>Values</value></para>
        /// </summary>
        public string Values => "Values";
    }
}
