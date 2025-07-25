using System;


namespace F10Y.Z0008
{
    public class Applicabilities : IApplicabilities
    {
        #region Infrastructure

        public static IApplicabilities Instance { get; } = new Applicabilities();


        private Applicabilities()
        {
        }

        #endregion
    }
}
