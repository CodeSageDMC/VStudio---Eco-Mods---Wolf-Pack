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
    [RequireComponent(typeof(BedComponent))]
    [RequireComponent(typeof(MountComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomContainment]
    [RequireRoomVolume(18)]
    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Bedroom", subPageName: "Cast Iron Bed Item")]
            public partial class CastIronBedObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(CastIronBedItem);
        public override LocString DisplayName => Localizer.DoStr("Cast Iron Bed");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<HousingComponent>().HomeValue = CastIronBedItem.homeValue;
            this.GetComponent<MountComponent>().Initialize(1);
            this.ModsPostInitialize();
        }
        protected override void OnCreatePostInitialize()
        {
            base.OnCreatePostInitialize();
            this.GetComponent<PropertyAuthComponent>().SetPublic();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Cast Iron Bed")]
    [LocDescription("A solid bed made slightly more comfortable by adding cotton.")]
    [Ecopedia("Housing Objects", "Bedroom", createAsSubPage: true)]
    [Tag("Housing")]
    [Tag("Mountable")]
    [Weight(2000)] // Defines how heavy CastIronBed is.
    [Tag(nameof(SurfaceTags.CanBeOnRug))] 
        public partial class CastIronBedItem : WorldObjectItem<CastIronBedObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext( 0  | DirectionAxisFlags.Down , WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName                              = typeof(CastIronBedObject).UILink(),
            Category                                = HousingConfig.GetRoomCategory("Bedroom"),
            BaseValue                               = 7.5f,
            TypeForRoomLimit                        = Localizer.DoStr("Bed"),
            DiminishingReturnMultiplier             = 0.3f
            
        };

    }

    /// <summary>
    /// <para>Server side recipe definition for "CastIronBed".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(TailoringSkill), 6)]
    [Ecopedia("Housing Objects", "Bedroom", subPageName: "Cast Iron Bed Item")]
    public partial class CastIronBedRecipe : RecipeFamily
    {
        public CastIronBedRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CastIronBed",  //noloc
                displayName: Localizer.DoStr("Cast Iron Bed"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CottonFabricItem), 40, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),
                    new IngredientElement(typeof(IronBarItem), 16, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<CastIronBedItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(180, typeof(TailoringSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CastIronBedRecipe), start: 6, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Cast Iron Bed"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Cast Iron Bed"), recipeType: typeof(CastIronBedRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(TailoringTableObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}