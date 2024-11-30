﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from WorldObjectTemplate.tt />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using static Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Occupancy;

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(PowerGridComponent))]
    [RequireComponent(typeof(PowerGeneratorComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(SolarGeneratorComponent))]
    [RequireComponent(typeof(LiquidConsumerComponent))]
    [PowerGenerator(typeof(ElectricPower))]
    [Ecopedia("Crafted Objects", "Power Generation", subPageName: "AngledSolarpanel Item")]
    public partial class AngledSolarpanelObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(AngledSolarpanelItem);
        public override LocString DisplayName => Localizer.DoStr("Angled Solar panel");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;
		static AngledSolarpanelObject()
		 {
								var BlockOccupancyList = new List<BlockOccupancy>
								{
								new BlockOccupancy(new Vector3i(0, 0, 0)),
								new BlockOccupancy(new Vector3i(1, 0, 0)),		
								};
						AddOccupancy<AngledSolarpanelObject>(BlockOccupancyList);
		 }

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<PowerGridComponent>().Initialize(30, new ElectricPower(), 10, true);
            this.GetComponent<PowerGeneratorComponent>().Initialize(180);
            this.GetComponent<HousingComponent>().HomeValue = AngledSolarpanelItem.homeValue;
            this.GetComponent<LiquidConsumerComponent>().Setup(typeof(WaterItem), 0.0f, BlockOccupancyType.WaterInputPort, 0.0f);
            this.ModsPostInitialize();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Angled Solar panel")]
	[LocDescription("Generates electrical power from the sun! Requires a clear view of the sky. Internal batteries hold a charge for power generation during nighttime.")]
    [Ecopedia("Crafted Objects", "Power Generation", createAsSubPage: true)]
    public partial class AngledSolarpanelItem : WorldObjectItem<AngledSolarpanelObject>
    {
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            Category                 = HousingConfig.GetRoomCategory("Industrial"),
            TypeForRoomLimit         = Localizer.DoStr(""),
        };

        [NewTooltip(CacheAs.SubType, 8)] public static LocString PowerProductionTooltip()  => Localizer.Do($"Produces: {Text.Info(180)}w of {new ElectricPower().Name} power.");
    }

    /// <summary>
    /// <para>Server side recipe definition for "AngledSolarpanel".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(MechanicsSkill), 6)]
    [Ecopedia("Crafted Objects", "Power Generation", subPageName: "AngledSolarpanel Item")]
    public partial class AngledSolarpanelRecipe : RecipeFamily
    {
        public AngledSolarpanelRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AngledSolarpanel",  //noloc
                displayName: Localizer.DoStr("Angled Solar panel"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronPlateItem), 12, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),
                    new IngredientElement(typeof(CopperWiringItem), 40, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),
					new IngredientElement(typeof(CopperPlateItem), 8, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),
                    new IngredientElement(typeof(SilicaplateItem), 8, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<AngledSolarpanelItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 20; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(MechanicsSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AngledSolarpanelRecipe), start: 6, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Angled Solar panel"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Angled Solar panel"), recipeType: typeof(AngledSolarpanelRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(AssemblyLineObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
