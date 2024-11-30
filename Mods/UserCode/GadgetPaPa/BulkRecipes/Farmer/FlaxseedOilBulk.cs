// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// 

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

    [Serialized] 
    [RequiresSkill(typeof(MillingSkill), 5)]	// 3
    [Ecopedia("Food", "Ingredients", subPageName: "Flaxseed Oil Item Bulk")]
    public partial class FlaxseedOilBulkRecipe : RecipeFamily
    {
        public FlaxseedOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FlaxseedOilSmallBulk",  //noloc
                displayName: Localizer.DoStr("Flaxseed Oil Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FlaxSeedItem), 160, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 16 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FlaxseedOilItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(MillingSkill));	// 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FlaxseedOilBulkRecipe), start: 10, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Flaxseed Oil Small Bulk"), recipeType: typeof(FlaxseedOilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 5)]  // 3
    public partial class ProcessedFlaxseedOilBulkRecipe : RecipeFamily
    {
        public ProcessedFlaxseedOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedFlaxseedOilBulk",  //noloc
                displayName: Localizer.DoStr("Processed Flaxseed Oil Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FlaxSeedItem), 300, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 12 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FlaxseedOilItem>(75),  // 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(MillingSkill));  // 100 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedFlaxseedOilBulkRecipe), start: 25, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Flaxseed Oil Bulk"), recipeType: typeof(ProcessedFlaxseedOilBulkRecipe));
            this.ModsPostInitialize();
           CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}