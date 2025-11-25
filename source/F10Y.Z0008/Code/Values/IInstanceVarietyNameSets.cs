using System;

using F10Y.T0003;


namespace F10Y.Z0008
{
    [ValuesMarker]
    public partial interface IInstanceVarietyNameSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IInstanceVarietyNames _InstanceVarietyNames => Z0008.InstanceVarietyNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        string[] All => new[]
        {
            _InstanceVarietyNames.Applications,
            _InstanceVarietyNames.ConventionProviders,
            _InstanceVarietyNames.Conventions,
            _InstanceVarietyNames.DataTypes,
            _InstanceVarietyNames.DbContextDefinitions,
            _InstanceVarietyNames.DbContextImplementations,
            _InstanceVarietyNames.Demonstrations,
            _InstanceVarietyNames.Documentations,
            _InstanceVarietyNames.Entities,
            _InstanceVarietyNames.Experiments,
            _InstanceVarietyNames.Explorations,
            _InstanceVarietyNames.Functions,
            _InstanceVarietyNames.HasXs,
            _InstanceVarietyNames.MarkerAttributes,
            _InstanceVarietyNames.Operations,
            _InstanceVarietyNames.OverloadTypes,
            _InstanceVarietyNames.PhysicalDbContexts,
            _InstanceVarietyNames.RazorComponents,
            _InstanceVarietyNames.RazorLayouts,
            _InstanceVarietyNames.RazorPages,
            _InstanceVarietyNames.Scripts,
            _InstanceVarietyNames.ServiceDefinitions,
            _InstanceVarietyNames.ServiceImplementations,
            _InstanceVarietyNames.SurveyAttributes,
            _InstanceVarietyNames.TestArticleDefinitions,
            _InstanceVarietyNames.TestArticles,
            _InstanceVarietyNames.TestFixtureDefinitions,
            _InstanceVarietyNames.TestFixtures,
            _InstanceVarietyNames.Types,
            _InstanceVarietyNames.UtilityTypes,
            _InstanceVarietyNames.Values,
            _InstanceVarietyNames.WithXs
        };
    }
}
