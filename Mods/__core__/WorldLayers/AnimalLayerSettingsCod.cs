﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.WorldLayers
{
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers.Layers;

    public class AnimalLayerSettingsCod : AnimalLayerSettings
    {
        public AnimalLayerSettingsCod() : base()
        {
            this.Name = "Cod";
            this.MinimapName = Localizer.Do($"{Localizer.DoStr("Cod")} Population");
            this.InitMultiplier = 1f;
            this.SyncToClient = false;
            this.Range = new Range(0f, 2f);
            this.OverrideRenderRange = null;
            this.MinColor = new Color(1f, 1f, 1f);
            this.MaxColor = new Color(0f, 1f, 0f);
            this.SumRelevant = true;
            this.Unit = "Cod";
            this.VoxelsPerEntry = 40;
            this.Category = WorldLayerCategory.Animal;
            this.ValueType = WorldLayerValueType.Amount;
            this.AreaDescription = string.Empty;
            this.HabitabilityLayer = "CodCapacity";
            this.SpreadRate = 0.5f;
            this.SpeciesChangeRate = 0.9f;

        }
    }
}
