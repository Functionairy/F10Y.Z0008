using System;


namespace F10Y.Z0008
{
    public class ContextNames : IContextNames
    {
        #region Infrastructure

        public static IContextNames Instance { get; } = new ContextNames();


        private ContextNames()
        {
        }

        #endregion
    }
}
