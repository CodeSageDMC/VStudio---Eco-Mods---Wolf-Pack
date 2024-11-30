﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from PlantTemplate.tt/>


// WORLD LAYER INFO
namespace Eco.Mods.WorldLayers
{
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers.Layers;

    /// <summary>
    /// <para>Server side layer settings definition for the "Spruce" plant layer setting.</para>
    /// <para>More information about Item objects can be found at https://docs.play.eco/api/server/eco.simulation/Eco.Simulation.WorldLayers.Layers.PlantLayerSettings.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    public partial class PlantLayerSettingsSpruce : PlantLayerSettings
    {
        public PlantLayerSettingsSpruce() : base()
        {
            this.Name = "Spruce";  //noloc
            this.MinimapName = Localizer.Do($"{Localizer.DoStr("Spruce")} Population"); // Sets the localized display name of the plant population layer
            this.InitMultiplier = 1;
            this.SyncToClient = false;
            this.Range = new Range(0f, 1f);
            this.OverrideRenderRange = new Range(0f, 0.05f);
            this.MinColor = new Color(1f, 1f, 1f);
            this.MaxColor = new Color(0f, 1f, 0f);
            this.SumRelevant = true;
            this.Unit = "Spruce"; //noloc
            this.VoxelsPerEntry = 20;
            this.Category = WorldLayerCategory.Plant;
            this.ValueType = WorldLayerValueType.FillRate;
            this.AreaDescription = "";
            this.Subcategory = "Spruce".AddSpacesBetweenCapitals(); //noloc
        }
    }
}

namespace Eco.Mods.Organisms
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Plants;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Serialization;
    using Eco.Shared.SharedTypes;
    using Eco.Simulation;
    using Eco.Simulation.Types;
    using Eco.World.Blocks;

    /// <summary>
    /// <para>Server side entity definition for the "Spruce" entity.</para>
    /// <para>More information about Item objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Plants.TreeEntity.html</para>
    /// </summary>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    public partial class Spruce : TreeEntity
    {
        public Spruce(WorldPosition3i mapPos, PlantPack plantPack) : base(species, mapPos, plantPack) { }
        public Spruce() { }
        static TreeSpecies species;

        [Ecopedia("Plants", "Trees", createAsSubPage: true)]  // Registers this plant species with the Ecopedia
        [Tag("Plants")]
        [Localized(false, true)]
        public partial class SpruceSpecies : TreeSpecies
        {
            public SpruceSpecies() : base()
            {
                species = this;
                this.InstanceType = typeof(Spruce);
                this.SetDefaultProperties();

                // Info
                this.Decorative = false; // Controls the decorative flag state. Decorative plants are not simulated after being spawned
                this.Name = "Spruce"; //noloc
                this.DisplayName = Localizer.DoStr("Spruce"); // Define our localized plant display name

                // Lifetime
                this.MaturityAgeDays = 5.5f; // Maturity age in days.  Organisms older than this value are considered fully grown and can reproduce.

                // Seeding and spread customization. This is detailing how often a plant can spread, the distance over which it checks and how many plants it is allowed to seed at once.
                this.SeedingTime = 2.5f;
                this.SeedingArea = 24;
                this.PlantAgeToSeed = 0.6f;
                this.SeedsCount = 2;

                // Generation
                this.Height = 1; // Defines the total height of the plant;
                this.GenerationDefinitions.ChanceToBeSpawnOutsideOfGroup = 1;
                this.GenerationDefinitions.MinDistanceBetweenGroups = new Range(10, 20);
                this.GenerationDefinitions.PlantsInGroup = new Range(1, 3);
                this.GenerationDefinitions.CountOfClusters = new Range(0, 0);
                this.GenerationDefinitions.RadiusOfGroup = new Range(4, 6);
                this.GenerationDefinitions.ClusterRadiusInWorldSize = new Range(0.05f, 0.14f);

                // Food
                this.CalorieValue = 15; // Defines the calorie value of the plant

                // Resources
                this.PostHarvestingGrowth = 0; // After harvesting, we reset their growth percent to this value, 0 -1.  0 means kill the plant.
                this.PickableAtPercent = 0; // Defines the percentage this plant can be picked at

                // Define the item types that are given to the player when gathered
                this.ResourceList = new List<SpeciesResource>()
                {
                    new SpeciesResource(typeof(SpruceLogItem), new Range(0, 50), 1),
                };
                this.ResourceBonusAtGrowth = 0.9f;

                // Visuals

                // Climate
                this.ReleasesCO2TonsPerDay = -0.075f; // Configures the amount of CO2 produced or removed by this plant per day.

                // WorldLayers
                this.MaxGrowthRate = 0.02f; // The exponential rate parameter describing the birth rate of the species in ideal growth conditions and no competition.  The % of the population in the area that will reproduce in one tick.
                this.MaxDeathRate = 0.01f; // The exponential rate parameter describing the death rate of the species in ideal growth conditions and no competition.  The % of the population in the area that will die in one tick.  Should always be LESS than MaxGrowthRate.
                this.SpreadRate = 0.0001f; // The exponential rate parameter describing the rate at which the plant spreads to adjacent locations.

                // Define our resource constraints. These control the required layer/block resources typically provided either at the time of world generation or by
                // fertilizers.
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "SoilMoisture", HalfSpeedConcentration = 0.1f, MaxResourceContent = 0.5f }); //noloc

                // Define our capacity constraints
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "FertileGround", ConsumedCapacityPerPop = 5 }); //noloc
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "CanopySpace", ConsumedCapacityPerPop = 26 }); //noloc

                this.BlanketSpawnPercent = 0.5f;
                this.IdealTemperatureRange = new Range(0.22f, 0.3f);
                this.IdealMoistureRange = new Range(0.25f, 0.45f);
                this.IdealWaterRange = new Range(0, 0.1f);
                this.WaterExtremes = new Range(0, 0.2f);
                this.TemperatureExtremes = new Range(0.2f, 0.32f);
                this.MoistureExtremes = new Range(0.2f, 0.55f);
                this.MaxPollutionDensity = 0.7f;
                this.PollutionDensityTolerance = 0.1f;
                this.VoxelsPerEntry = 20;
                this.ModsPostInitialize();
            }

            /// <summary>Hook for setting the base default properties of a plant species before initialization.</summary>
            partial void SetDefaultProperties();
            /// <summary>Hook for mods to customize the properties of plant species after initialization.</summary>
            partial void ModsPostInitialize();
        }
    }

}