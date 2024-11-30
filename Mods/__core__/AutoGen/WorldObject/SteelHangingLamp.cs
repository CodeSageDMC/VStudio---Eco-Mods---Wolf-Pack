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
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
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
    using Eco.Shared.Networking;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.Core.Utils;
	using Eco.Gameplay.Components.Storage;
    using static Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue;
    using Eco.Gameplay.Items.Recipes;

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(PowerGridComponent))]
    [RequireComponent(typeof(PowerConsumptionComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Lighting", subPageName: "Steel Hanging Lamp Item")]
            public partial class SteelHangingLampObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(SteelHangingLampItem);
        public override LocString DisplayName => Localizer.DoStr("Steel Hanging Lamp");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<PowerConsumptionComponent>().Initialize(60);
            this.GetComponent<PowerGridComponent>().Initialize(10, new ElectricPower());
            this.GetComponent<HousingComponent>().HomeValue = SteelHangingLampItem.homeValue;
            this.ModsPostInitialize();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Steel Hanging Lamp")]
    [LocDescription("A more modern way to light up a room.")]
    [Ecopedia("Housing Objects", "Lighting", createAsSubPage: true)]
    [Tag("Housing")]
    [Weight(500)] // Defines how heavy SteelHangingLamp is.
            public partial class SteelHangingLampItem : WorldObjectItem<SteelHangingLampObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext( 0  | DirectionAxisFlags.Up , WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName                              = typeof(SteelHangingLampObject).UILink(),
            Category                                = HousingConfig.GetRoomCategory("Lighting"),
            BaseValue                               = 8,
            TypeForRoomLimit                        = Localizer.DoStr("Lights"),
            DiminishingReturnMultiplier             = 0.7f
            
        };

        [NewTooltip(CacheAs.SubType, 7)] public static LocString PowerConsumptionTooltip() => Localizer.Do($"Consumes: {Text.Info(60)}w of {new ElectricPower().Name} power.");
    }

    /// <summary>
    /// <para>Server side recipe definition for "SteelHangingLamp".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(ElectronicsSkill), 4)]
    [Ecopedia("Housing Objects", "Lighting", subPageName: "Steel Hanging Lamp Item")]
    public partial class SteelHangingLampRecipe : RecipeFamily
    {
        public SteelHangingLampRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteelHangingLamp",  //noloc
                displayName: Localizer.DoStr("Steel Hanging Lamp"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 4, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),
                    new IngredientElement(typeof(PlasticItem), 6, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),
                    new IngredientElement(typeof(CopperWiringItem), 5, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),
                    new IngredientElement("CompositeLumber", 6, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)), //noloc
                    new IngredientElement(typeof(LightBulbItem), 1, true),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelHangingLampItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(120, typeof(ElectronicsSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteelHangingLampRecipe), start: 4, skillType: typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Steel Hanging Lamp"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steel Hanging Lamp"), recipeType: typeof(SteelHangingLampRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(RoboticAssemblyLineObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
