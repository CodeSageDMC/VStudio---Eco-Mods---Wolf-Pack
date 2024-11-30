// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x 2x output

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

    [RequiresSkill(typeof(CarpentrySkill), 7)]
    [Ecopedia("Housing Objects", "Lighting", subPageName: "Wooden Ceiling Light Item")]
    public partial class WoodenCeilingLightBulkRecipe : RecipeFamily
    {
        public WoodenCeilingLightBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WoodenCeilingLightSmallBulk",  //noloc
                displayName: Localizer.DoStr("Wooden Ceiling Light Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CopperWiringItem), 40, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),	// 4 x 10
                    new IngredientElement("Lumber", 60, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), // 6 x 10
                    new IngredientElement("WoodBoard", 40, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), // 4 x 10
                    new IngredientElement("Fabric", 60, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), // 6 x 10
                    new IngredientElement(typeof(LightBulbItem), 10, true),	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodenCeilingLightItem>(20) // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 30; // 3 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1200, typeof(CarpentrySkill));	// 120 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WoodenCeilingLightBulkRecipe), start: 40, skillType: typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));	// 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Wooden Ceiling Light Small Bulk"), recipeType: typeof(WoodenCeilingLightBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SawmillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
