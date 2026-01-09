using System;


namespace F10Y.Z0008
{
    public class DomainNameSets : IDomainNameSets
    {
        #region Infrastructure

        public static IDomainNameSets Instance { get; } = new DomainNameSets();


        private DomainNameSets()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0008.Raw
{
    public class DomainNameSets : IDomainNameSets
    {
        #region Infrastructure

        public static IDomainNameSets Instance { get; } = new DomainNameSets();


        private DomainNameSets()
        {
        }

        #endregion
    }
}
