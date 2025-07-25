using System;


namespace F10Y.Z0008
{
    public class InstanceVarietyNames : IInstanceVarietyNames
    {
        #region Infrastructure

        public static IInstanceVarietyNames Instance { get; } = new InstanceVarietyNames();


        private InstanceVarietyNames()
        {
        }

        #endregion
    }
}
