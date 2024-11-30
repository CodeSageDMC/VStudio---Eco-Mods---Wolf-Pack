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
    [Ecopedia("Food", "Ingredients", subPageName: "Rice Flour Item Small Bulk")]
    public partial class RiceFlourBulkRecipe : RecipeFamily
    {
        public RiceFlourBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RiceFlourSmallBulk",  //noloc
                displayName: Localizer.DoStr("Rice Flour Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RiceItem), 20, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RiceFlourItem>(20),	// 1 x 10 x 2
                    new CraftingElement<CerealGermItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 0.5f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(MillingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RiceFlourBulkRecipe), start: 20, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Rice Flour Small Bulk"), recipeType: typeof(RiceFlourBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 3)]  // 1
    public partial class ProcessedRiceFlourBulkRecipe : RecipeFamily
    {
        public ProcessedRiceFlourBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedRiceFlourBulk",  //noloc
                displayName: Localizer.DoStr("Processed Rice Flour Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RiceItem), 250, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 10 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RiceFlourItem>(450),  // 6 x 25 x 3
                    new CraftingElement<CerealGermItem>(375),  // 5 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 0.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(MillingSkill));  // 100 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedRiceFlourBulkRecipe), start: 25, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Rice Flour Bulk"), recipeType: typeof(ProcessedRiceFlourBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}