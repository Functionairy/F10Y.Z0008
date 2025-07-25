using System;


namespace F10Y.Z0008
{
    public class DomainSets : IDomainSets
    {
        #region Infrastructure

        public static IDomainSets Instance { get; } = new DomainSets();


        private DomainSets()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0008.Raw
{
    public class DomainSets : IDomainSets
    {
        #region Infrastructure

        public static IDomainSets Instance { get; } = new DomainSets();


        private DomainSets()
        {
        }

        #endregion
    }
}
