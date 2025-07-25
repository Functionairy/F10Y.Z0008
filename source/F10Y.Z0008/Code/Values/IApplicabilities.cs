using System;

using F10Y.T0003;


namespace F10Y.Z0008
{
    /// <summary>
    /// Generally-applicable applicability values.
    /// </summary>
    [ValuesMarker]
    public partial interface IApplicabilities
    {
        /// <summary>
        /// <para><value>All</value></para>
        /// </summary>
        public string All => "All";

        /// <summary>
        /// <para><value>General</value></para>
        /// </summary>
        public string General => "General";

        /// <summary>
        /// <para><value>Organization</value></para>
        /// </summary>
        public string Organization => "Organization";

        /// <summary>
        /// <para><value>Machine</value></para>
        /// </summary>
        public string Machine => "Machine";

        /// <summary>
        /// <para><value>Non-Windows</value></para>
        /// </summary>
        public string Non_Windows => "Non-Windows";

        /// <summary>
        /// <para><value>Personal</value></para>
        /// </summary>
        public string Personal => "Personal";

        /// <summary>
        /// <para><value>Project</value></para>
        /// </summary>
        public string Project => "Project";

        /// <summary>
        /// <para><value>System</value></para>
        /// </summary>
        public string System => "System";

        /// <summary>
        /// <para><value>Windows</value></para>
        /// </summary>
        public string Windows => "Windows";

        /// <inheritdoc cref="Non_Windows"/>
        public string Windows_Non => this.Non_Windows;
    }
}
