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

    [RequiresSkill(typeof(MillingSkill), 4)]	// 2
    [Ecopedia("Food", "Ingredients", subPageName: "Huckleberry Extract Item Small Bulk")]
    public partial class HuckleberryExtractBulkRecipe : RecipeFamily
    {
        public HuckleberryExtractBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "HuckleberryExtractSmallBulk",  //noloc
                displayName: Localizer.DoStr("Huckleberry Extract Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(HuckleberriesItem), 200, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 20 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HuckleberryExtractItem>(20)		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(MillingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(HuckleberryExtractBulkRecipe), start: 20, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Huckleberry Extract Small Bulk"), recipeType: typeof(HuckleberryExtractBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 4)]  // 2
    public partial class ProcessedHuckleberryExtractBulkRecipe : RecipeFamily
    {
        public ProcessedHuckleberryExtractBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedHuckleberryExtractBulk",  //noloc
                displayName: Localizer.DoStr("Processed Huckleberry Extract Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(HuckleberriesItem), 1250, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 50 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HuckleberryExtractItem>(225),  // 3 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(MillingSkill));  // 100 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedHuckleberryExtractBulkRecipe), start: 25, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Huckleberry Extract Bulk"), recipeType: typeof(ProcessedHuckleberryExtractBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}