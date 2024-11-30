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
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomContainment]
    [RequireRoomVolume(2)]
    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Cultural", subPageName: "Iron Frame Wide Item")]
            public partial class IronFrameWideObject : PictureFrameObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(IronFrameWideItem);
        public override LocString DisplayName => Localizer.DoStr("Iron Frame Wide");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            base.Initialize();

            this.GetComponent<HousingComponent>().HomeValue = IronFrameWideItem.homeValue;
            this.ModsPostInitialize();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Iron Frame Wide")]
    [LocDescription("An iron frame useful for simple picture and art displays.")]
    [Ecopedia("Housing Objects", "Cultural", createAsSubPage: true)]
    [Tag("Housing")]
    [Weight(1000)] // Defines how heavy IronFrameWide is.
            public partial class IronFrameWideItem : WorldObjectItem<IronFrameWideObject>, IPersistentData
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext( 0  | DirectionAxisFlags.Backward , WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName                              = typeof(IronFrameWideObject).UILink(),
            Category                                = HousingConfig.GetRoomCategory("Cultural"),
            BaseValue                               = 0,
            TypeForRoomLimit                        = Localizer.DoStr("Cultural"),
            DiminishingMultiplierAcrossFullProperty = 0.5f
            
        };

        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)] public object PersistentData { get; set; }
    }

    /// <summary>
    /// <para>Server side recipe definition for "IronFrameWide".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresModule(typeof(BlacksmithTableObject))]
    [RequiresSkill(typeof(BlacksmithSkill), 4)]
    [Ecopedia("Housing Objects", "Cultural", subPageName: "Iron Frame Wide Item")]
    public partial class IronFrameWideRecipe : RecipeFamily
    {
        public IronFrameWideRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronFrameWide",  //noloc
                displayName: Localizer.DoStr("Iron Frame Wide"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 2, typeof(BlacksmithSkill), typeof(BlacksmithLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronFrameWideItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(160, typeof(BlacksmithSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronFrameWideRecipe), start: 1, skillType: typeof(BlacksmithSkill), typeof(BlacksmithFocusedSpeedTalent), typeof(BlacksmithParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Iron Frame Wide"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Iron Frame Wide"), recipeType: typeof(IronFrameWideRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}