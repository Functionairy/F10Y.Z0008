using System;

using F10Y.T0003;


namespace F10Y.Z0008
{
    /// <summary>
    /// Generally-applicable applicability values.
    /// </summary>
    [ValuesMarker]
    [DomainDescriptor(IDomainNames.Applicability_Names_Constant)]
    public partial interface IApplicabilities
    {
        /// <summary>
        /// <para><value>All</value></para>
        /// </summary>
        string All => "All";

        /// <summary>
        /// <para><value>General</value></para>
        /// </summary>
        const string General_Constant = "General";

        /// <inheritdoc cref="General_Constant"/>
        string General => General_Constant;

        /// <summary>
        /// <para><value>Organization</value></para>
        /// </summary>
        string Organization => "Organization";

        /// <summary>
        /// <para><value>Machine</value></para>
        /// </summary>
        string Machine => "Machine";

        /// <summary>
        /// <para><value>Non-Windows</value></para>
        /// </summary>
        string Non_Windows => "Non-Windows";

        /// <summary>
        /// <para><value>Personal</value></para>
        /// </summary>
        string Personal => "Personal";

        /// <summary>
        /// <para><value>Project</value></para>
        /// </summary>
        string Project => "Project";

        /// <summary>
        /// <para><value>System</value></para>
        /// </summary>
        string System => "System";

        /// <summary>
        /// <para><value>Windows</value></para>
        /// </summary>
        string Windows => "Windows";

        /// <inheritdoc cref="Non_Windows"/>
        string Windows_Non => this.Non_Windows;
    }
}
