// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(CookingSkill), 4)]	// 2
    [Ecopedia("Food", "Ingredients", subPageName: "Meat Stock Item Small Bulk")]
    public partial class MeatStockBulkRecipe : RecipeFamily
    {
        public MeatStockBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MeatStockSmallBulk",  //noloc
                displayName: Localizer.DoStr("Meat Stock Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ScrapMeatItem), 80, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),	// 8 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MeatStockItem>(20)	// 1 x 10 x2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(CookingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MeatStockBulkRecipe), start: 80, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));	// 8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Meat Stock Small Bulk"), recipeType: typeof(MeatStockBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(CookingSkill), 7)]	// 5
    public partial class FishStockBulkRecipe : RecipeFamily
    {
        public FishStockBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FishStockSmallBulk",
                displayName: Localizer.DoStr("Fish Stock Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawFishItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),	// 4 X 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MeatStockItem>(20),	// 1 X 10 X 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 X 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(CookingSkill));	// 15 X 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FishStockBulkRecipe), start: 80, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));	// 8 X 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Fish Stock Small Bulk"), recipeType: typeof(FishStockBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}