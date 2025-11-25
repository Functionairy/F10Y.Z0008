using System;


namespace F10Y.Z0008
{
    public class InstanceVarietyNameSets : IInstanceVarietyNameSets
    {
        #region Infrastructure

        public static IInstanceVarietyNameSets Instance { get; } = new InstanceVarietyNameSets();


        private InstanceVarietyNameSets()
        {
        }

        #endregion
    }
}
