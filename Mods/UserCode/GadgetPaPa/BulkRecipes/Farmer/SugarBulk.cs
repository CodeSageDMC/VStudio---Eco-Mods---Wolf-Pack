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

    [RequiresSkill(typeof(MillingSkill), 3)]	// 1
    [Ecopedia("Food", "Ingredients", subPageName: "Sugar Item Small Bulk")]
    public partial class SugarBulkRecipe : RecipeFamily
    {
        public SugarBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SugarSmallBulk",  //noloc
                displayName: Localizer.DoStr("Sugar Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(HuckleberriesItem), 80, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 8 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SugarItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f; // 0.5 X 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(MillingSkill));	// 15 X 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SugarBulkRecipe), start: 20, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 2 X 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Sugar Small Bulk"), recipeType: typeof(SugarBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 3)]	// 1
    public partial class BeetSugarBulkRecipe : RecipeFamily
    {
        public BeetSugarBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BeetSugarSmallBulk",  //noloc
                displayName: Localizer.DoStr("Beet Sugar Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BeetItem), 60, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SugarItem>(60),	// 3 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(MillingSkill));	// 50 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BeetSugarBulkRecipe), start: 20, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Beet Sugar Small Bulk"), recipeType: typeof(BeetSugarBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 5)]  // 3
    public partial class ProcessedBeetSugarBulkRecipe : RecipeFamily
    {
        public ProcessedBeetSugarBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedBeetSugarBulk",  //noloc
                displayName: Localizer.DoStr("Processed Beet Sugar Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BeetItem), 500, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 20 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SugarItem>(900),  // 12 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(MillingSkill));  // 100 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedBeetSugarBulkRecipe), start: 25, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Beet Sugar Bulk"), recipeType: typeof(ProcessedBeetSugarBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

[RequiresSkill(typeof(MillingSkill), 3)]  // 1 
    public partial class ProcessedSugarBulkRecipe : RecipeFamily
    {
        public ProcessedSugarBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedSugarBulk",  //noloc
                displayName: Localizer.DoStr("Processed Sugar Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(HuckleberriesItem), 500, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 20 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SugarItem>(300),  // 4 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(MillingSkill));  // 100 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedSugarBulkRecipe), start: 25, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Sugar Bulk"), recipeType: typeof(ProcessedSugarBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}