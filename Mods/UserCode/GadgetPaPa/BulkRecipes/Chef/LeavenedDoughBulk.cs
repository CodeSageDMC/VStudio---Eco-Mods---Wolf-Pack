// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(BakingSkill), 3)]	// 1
    [Ecopedia("Food", "Baking", subPageName: "Leavened Dough Item Small Bulk")]
    public partial class LeavenedDoughBulkRecipe : RecipeFamily
    {
        public LeavenedDoughBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "LeavenedDoughSmallBulk",  //noloc
                displayName: Localizer.DoStr("Leavened Dough Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FlourItem), 40, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),	// 4 x 10
                    new IngredientElement(typeof(YeastItem), 10, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<LeavenedDoughItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(BakingSkill));		// 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(LeavenedDoughBulkRecipe), start: 4f, skillType: typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));	// 0.4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Leavened Dough Small Bulk"), recipeType: typeof(LeavenedDoughBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BakeryOvenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}