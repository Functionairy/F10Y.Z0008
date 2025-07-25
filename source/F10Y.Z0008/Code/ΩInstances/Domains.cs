using System;


namespace F10Y.Z0008
{
    public class Domains : IDomains
    {
        #region Infrastructure

        public static IDomains Instance { get; } = new Domains();


        private Domains()
        {
        }

        #endregion
    }
}
