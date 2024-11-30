// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x with 1.5x output

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

    [RequiresSkill(typeof(CookingSkill), 5)]	// 3
    [Ecopedia("Food", "Ingredients", subPageName: "Vegetable Stock Item Tiny Bulk")]
    public partial class VegetableStockBulkRecipe : RecipeFamily
    {
        public VegetableStockBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "VegetableStockTinyBulk",  //noloc
                displayName: Localizer.DoStr("Vegetable Stock Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(VegetableMedleyItem), 10, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<VegetableStockItem>(15)		// 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(CookingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(VegetableStockBulkRecipe), start: 80, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));	// 8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Vegetable Stock Tiny Bulk"), recipeType: typeof(VegetableStockBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}