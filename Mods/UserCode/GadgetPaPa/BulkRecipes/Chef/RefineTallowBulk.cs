// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(AdvancedCookingSkill), 3)]	// 1
    public partial class RefineTallowBulkRecipe : RecipeFamily
    {
        public RefineTallowBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RefineTallowSmallBulk",  //noloc
                displayName: Localizer.DoStr("Refine Tallow Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(TallowItem), 180, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),	// 18 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OilItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(AdvancedCookingSkill));	// 20 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RefineTallowBulkRecipe), start: 8f, skillType: typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));	// 0.8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Refine Tallow Small Bulk"), recipeType: typeof(RefineTallowBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
