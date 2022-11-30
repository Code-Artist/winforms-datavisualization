﻿using Microsoft.DotNet.DesignTools.Client.TypeRouting;

using System.Collections.Generic;

namespace WinForms.DataVisualization.Designer.Client
{
    [ExportTypeRoutingDefinitionProvider]
    internal class TypeRoutingProvider : TypeRoutingDefinitionProvider
    {
        public override IEnumerable<TypeRoutingDefinition> GetDefinitions()
        {
            return new[]
            {
                new TypeRoutingDefinition(TypeRoutingKinds.Editor, nameof(ImageValueEditor), typeof(ImageValueEditor)),
                new TypeRoutingDefinition(TypeRoutingKinds.Editor, nameof(AxesArrayEditor), typeof(AxesArrayEditor)),
                new TypeRoutingDefinition(TypeRoutingKinds.Editor, nameof(GradientEditor), typeof(GradientEditor)),
                new TypeRoutingDefinition(TypeRoutingKinds.Editor, nameof(ColorPaletteEditor), typeof(ColorPaletteEditor)),
                new TypeRoutingDefinition(TypeRoutingKinds.Editor, nameof(ChartColorEditor), typeof(ChartColorEditor)),
                new TypeRoutingDefinition(TypeRoutingKinds.Editor, nameof(FlagsEnumUITypeEditor), typeof(FlagsEnumUITypeEditor)),
                new TypeRoutingDefinition(TypeRoutingKinds.Editor, nameof(HatchStyleEditor), typeof(HatchStyleEditor)),
                new TypeRoutingDefinition(TypeRoutingKinds.Editor, nameof(MarkerStyleEditor), typeof(MarkerStyleEditor)),
                new TypeRoutingDefinition(TypeRoutingKinds.Editor, nameof(KeywordsStringEditor), typeof(KeywordsStringEditor)),
            };
        }
    }
}
