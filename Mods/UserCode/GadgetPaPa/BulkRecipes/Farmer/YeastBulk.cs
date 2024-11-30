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

    [RequiresSkill(typeof(MillingSkill), 6)]	// 4
    [Ecopedia("Food", "Ingredients", subPageName: "Yeast Item Small Bulk")]
    public partial class YeastBulkRecipe : RecipeFamily
    {
        public YeastBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "YeastSmallBulk",  //noloc
                displayName: Localizer.DoStr("Yeast Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SugarItem), 20, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<YeastItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(MillingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(YeastBulkRecipe), start: 20, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Yeast Small Bulk"), recipeType: typeof(YeastBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 6)]  // 4
    public partial class ProcessedYeastBulkRecipe : RecipeFamily
    {
        public ProcessedYeastBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedYeastBulk",  //noloc
                displayName: Localizer.DoStr("Processed Yeast Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SugarItem), 250, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 10 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<YeastItem>(450),  // 6 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(MillingSkill));  // 1 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedYeastBulkRecipe), start: 25, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Yeast Bulk"), recipeType: typeof(ProcessedYeastBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}