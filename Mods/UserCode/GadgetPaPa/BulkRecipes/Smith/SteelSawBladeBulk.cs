// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Steel Saw Blade Small Bulk Recipe

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

        
    [RequiresSkill(typeof(BlacksmithSkill), 6)]	// 4
    [Ecopedia("Items", "Products", subPageName: "Steel Saw Blade Small Bulk Item")]
    public partial class SteelSawBladeBulkRecipe : RecipeFamily
    {
        public SteelSawBladeBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteelSawBladeSmallBulk",  //noloc
                displayName: Localizer.DoStr("Steel Saw Blade Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 100, typeof(BlacksmithSkill), typeof(BlacksmithLavishResourcesTalent)),	// 10 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelSawBladeItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 20; // 2 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1800, typeof(BlacksmithSkill));	// 180 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteelSawBladeBulkRecipe), start: 12.0f, skillType: typeof(BlacksmithSkill), typeof(BlacksmithFocusedSpeedTalent), typeof(BlacksmithParallelSpeedTalent));	// 1.2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steel Saw Blade Small Bulk"), recipeType: typeof(SteelSawBladeBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(PowerHammerObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}