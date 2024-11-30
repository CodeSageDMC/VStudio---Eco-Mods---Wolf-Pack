// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output

namespace Eco.Mods.TechTree
{
    using System;
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

    [RequiresSkill(typeof(MillingSkill), 7)]	// 5
    [Ecopedia("Food", "Ingredients", subPageName: "Acorn Powder Item Small Bulk")]
    public partial class AcornPowderBulkRecipe : RecipeFamily
    {
        public AcornPowderBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AcornPowderSmallBulk",  //noloc
                displayName: Localizer.DoStr("Acorn Powder Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(AcornItem), 40, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<AcornPowderItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(MillingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AcornPowderBulkRecipe), start: 20, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Acorn Powder Small Bulk"), recipeType: typeof(AcornPowderBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 7)]  // 5
    public partial class ProcessedAcornPowderBulkRecipe : RecipeFamily
    {
        public ProcessedAcornPowderBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedAcornPowderBulk",  //noloc
                displayName: Localizer.DoStr("Processed Acorn Powder Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(AcornItem), 500, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 20 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<AcornPowderItem>(450),	// 6 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(MillingSkill));  // 100 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedAcornPowderBulkRecipe), start: 25, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Acorn Powder Bulk"), recipeType: typeof(ProcessedAcornPowderBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}