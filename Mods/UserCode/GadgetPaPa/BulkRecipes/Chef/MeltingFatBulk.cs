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
    [RequiresSkill(typeof(BakingSkill), 4)]		// 2
    public partial class MeltingFatBulkRecipe : RecipeFamily
    {
        public MeltingFatBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MeltingFatSmallBulk",  //noloc
                displayName: Localizer.DoStr("Melting Fat Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ScrapMeatItem), 60, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),	// 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<TallowItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(BakingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MeltingFatBulkRecipe), start: 5f, skillType: typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));	// 0.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Melting Fat SmallBulk"), recipeType: typeof(MeltingFatBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BakeryOvenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
