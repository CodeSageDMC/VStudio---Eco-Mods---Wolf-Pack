// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Small Bulk 10x 2x output

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

    [RequiresSkill(typeof(AdvancedCookingSkill), 1)]
    public partial class BoiledRiceBulkRecipe : RecipeFamily
    {
        public BoiledRiceBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BoiledRiceSmallBulk",  //noloc
                displayName: Localizer.DoStr("Boiled Rice Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RiceItem), 10f*BulkRecipeSettings.SmallBulkMultiplier, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)), // 10 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BoiledRiceItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.SmallBulkMultiplier; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(15f*BulkRecipeSettings.SmallBulkMultiplier, typeof(AdvancedCookingSkill));  // 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BoiledRiceBulkRecipe), start: 2f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));  // 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Boiled Rice Small Bulk"), recipeType: typeof(BoiledRiceBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(KitchenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}