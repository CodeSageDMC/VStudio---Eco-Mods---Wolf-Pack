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

    [RequiresSkill(typeof(CampfireCookingSkill), 3)]	// 1
    public partial class RenderFatBulkRecipe : RecipeFamily
    {
        public RenderFatBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RenderFatSmallBulk",  //noloc
                displayName: Localizer.DoStr("Render Fat Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ScrapMeatItem), 100, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),	// 10 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<TallowItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(CampfireCookingSkill));	// 20 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RenderFatBulkRecipe), start: 8f, skillType: typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));	// 0.8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Render Fat Small Bulk"), recipeType: typeof(RenderFatBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CampfireObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
