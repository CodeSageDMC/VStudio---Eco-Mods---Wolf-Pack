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
    using Eco.Gameplay.Items.Recipes;

    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomVolume(20)]
    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Office", subPageName: "Teachers Desk Modern Item")]
    public partial class TeachersDeskT3Object : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(TeachersDeskT3Item);
        public override LocString DisplayName => Localizer.DoStr("Teachers Desk Modern");
        public override TableTextureMode TableTexture => TableTextureMode.Wood;

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<HousingComponent>().HomeValue = TeachersDeskT3Item.homeValue;
            this.ModsPostInitialize();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Teachers Desk Modern")]
    [LocDescription("An modern desk for teachers or anyone who wants a desk. ")]
    [Ecopedia("Housing Objects", "Office", createAsSubPage: true)]
    [Tag("Housing")]
    [Weight(3500)]
    [Tag(nameof(SurfaceTags.CanBeOnRug))]
    public partial class TeachersDeskT3Item : WorldObjectItem<TeachersDeskT3Object>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName = typeof(TeachersDeskT3Object).UILink(),
            Category = HousingConfig.GetRoomCategory("Office"),
            BaseValue = 10f,
            TypeForRoomLimit = Localizer.DoStr("Desk"),
            DiminishingReturnMultiplier = 0.1f

        };

    }

    [RequiresSkill(typeof(CarpentrySkill), 6)]
    [Ecopedia("Housing Objects", "Seating", subPageName: "Teachers Desk Modern Item")]
    public partial class TeachersDeskT3Recipe : RecipeFamily
    {
        public TeachersDeskT3Recipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "TeachersDeskT3",  //noloc
                displayName: Localizer.DoStr("Teachers Desk Modern"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Lumber", 15, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement(typeof(NailItem), 10, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement("Modern Research", 20, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement(typeof(PaperItem), 20, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement(typeof(GearboxItem), 2, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement(typeof(IronPlateItem), 5, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<TeachersDeskT3Item>()
    });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 6; // Defines how much experience is gained when crafted.

            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(60, typeof(CarpentrySkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(TeachersDeskT3Recipe), start: 6, skillType: typeof(CarpentrySkill));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Teachers Desk Modern"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Teachers Desk Modern"), recipeType: typeof(TeachersDeskT3Recipe));
            this.ModsPostInitialize();

    // Register our RecipeFamily instance with the crafting system so it can be crafted.
    CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipe: this);
    }

    /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
    partial void ModsPreInitialize();

    /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
    partial void ModsPostInitialize();
}

}
