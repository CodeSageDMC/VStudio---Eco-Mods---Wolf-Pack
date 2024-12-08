﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from AnimalTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Animals;
    using Eco.Mods.Organisms;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Vector3 = System.Numerics.Vector3;
    using Eco.Simulation.Agents;
    using Eco.Simulation.Types;
    using Eco.Shared.SharedTypes;

    /// <summary>
    /// <para>Server side animal entity definition for "Otter".</para>
    /// <para>More information about AnimalEntity objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Animals.AnimalEntity.html</para>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    /// </summary>
    public class Otter : AnimalEntity
    {
        public Otter(Animal parent, Vector3 pos, bool corpse = false) : base(parent, pos, species, corpse) { }
        static AnimalSpecies species;

        /// <summary>
        /// <para>Server side species definition for "Otter".</para>
        /// <para>More information about AnimalSpecies objects can be found at https://docs.play.eco/api/server/eco.simulation/Eco.Simulation.Types.AnimalSpecies.html</para>
        /// </summary>
        /// <inheritdoc/>
        [Ecopedia("Animals", "Mammals", createAsSubPage: true)]
        [Localized(false, true)]
        public class OtterSpecies : AnimalSpecies
        {
            public OtterSpecies() : base()
            {
                species = this; // Set the static species variable from our AnimalEntity instance to ourselves for lookup later
                this.InstanceType = typeof(Otter); // Define our instance type to be a typeof instance of our selves.

                // Define the species name, display name, and description here. These values will be used to represent the animal to the client user.
                this.Name = "Otter"; //noloc
                this.DisplayName = Localizer.DoStr("Otter");
                this.DisplayDescription = Localizer.DoStr("A playful and agile semi-aquatic mammal, often seen floating on their backs or playing with objects in the water. Otters have a thick, waterproof fur coat that keeps them warm in cold water, and webbed feet that make them excellent swimmers.");

                // Define our how long in days it takes this species to mature
                this.MaturityAgeDays = 1;
                
                // Define what our species eats as object type representations as well as our calorie value.
                // If our species does not eat anything the FoodSources variable can represent an empty List object.
                this.FoodSources = new List<System.Type>()
                {
                    typeof(Clam),
                    typeof(Urchin),
                    typeof(Tuna),
                    typeof(Salmon),
                    typeof(Trout),
                };
                this.CalorieValue = 50;

                // Movement
                this.Swimming = true;
                this.FloatOnSurface = true;
                this.WanderingSpeed = 0.5f;
                this.Speed = 3;
                this.ClimbHeight = 1;

                // Resources
                this.ResourceList = new List<SpeciesResource>()
                {
                    new SpeciesResource(typeof(OtterCarcassItem), new Range(1, 1)),
                };
                this.ResourceBonusAtGrowth = 0.9f;
                
                // Behavior
                this.BrainType = typeof(AmphibiousBrain);
                this.Health = 1.5f;
                this.Damage = 1;
                this.DelayBetweenAttacksRangeSec = new Range(0.8f, 2.5f);
                this.FearFactor = 1;
                this.FleePlayers = true;
                this.AttackRange = 1;
                // Climate
                this.ReleasesCO2TonsPerDay = 0.02f;
            }

            // Otters can spawn on land or water
            public override bool IsValidSpawnPathPos(Vector3i pos) { return true; }
        }
    


    }
}
