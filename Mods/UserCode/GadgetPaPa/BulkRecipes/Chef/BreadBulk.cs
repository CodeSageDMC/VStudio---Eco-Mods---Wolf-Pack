// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk 10x input with 1.5x output

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

    [RequiresSkill(typeof(BakingSkill), 5)]	// 4
    [Ecopedia("Food", "Baking", subPageName: "Bread Item Tiny Bulk")]
    public partial class BreadBulkRecipe : RecipeFamily
    {
        public BreadBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BreadTinyBulk",  //noloc
                displayName: Localizer.DoStr("Bread Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LeavenedDoughItem), 20, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),	// 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BreadItem>(15)	// 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(BakingSkill));	// 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BreadBulkRecipe), start: 30, skillType: typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent)); // 3 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Bread Tiny Bulk"), recipeType: typeof(BreadBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BakeryOvenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}