// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x 1.5x Output

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
    using Eco.Shared.Time;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(MillingSkill), 4)]	// 2
    [Ecopedia("Food", "Ingredients", subPageName: "Simple Syrup Tiny Bulk Item")]
    public partial class SimpleSyrupBulkRecipe : RecipeFamily
    {
        public SimpleSyrupBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SimpleSyrupTinyBulk",  //noloc
                displayName: Localizer.DoStr("Simple Syrup Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SugarItem), 100, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 10 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SimpleSyrupItem>(15)	// 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(MillingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SimpleSyrupBulkRecipe), start: 20, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Simple Syrup Tiny Bulk"), recipeType: typeof(SimpleSyrupBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 7)]  // 5
    public partial class ProcessedSimpleSyrupBulkRecipe : RecipeFamily
    {
        public ProcessedSimpleSyrupBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedSimpleSyrupSmallBulk",  //noloc
                displayName: Localizer.DoStr("Processed Simple Syrup Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SugarItem), 250, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 25 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SimpleSyrupItem>(60),  // 3 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1000, typeof(MillingSkill));  // 100 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedSimpleSyrupBulkRecipe), start: 10, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Simple Syrup Small Bulk"), recipeType: typeof(ProcessedSimpleSyrupBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}