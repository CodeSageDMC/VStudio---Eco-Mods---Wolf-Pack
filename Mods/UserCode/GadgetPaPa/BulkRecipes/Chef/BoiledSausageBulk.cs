// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk 10x input with 1.5x output

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

    [RequiresSkill(typeof(AdvancedCookingSkill), 3)]	// 2
    [Ecopedia("Food", "Cooking", subPageName: "Boiled Sausage Item Tiny Bulk")]
    public partial class BoiledSausageBulkRecipe : RecipeFamily
    {
        public BoiledSausageBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BoiledSausageTinyBulk",  //noloc
                displayName: Localizer.DoStr("Boiled Sausage Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawSausageItem), 40, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)), // 4 x 10
                    new IngredientElement(typeof(MeatStockItem), 40, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BoiledSausageItem>(15)	// 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(450, typeof(AdvancedCookingSkill));	// 45 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BoiledSausageBulkRecipe), start: 40, skillType: typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));	// 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Boiled Sausage Tiny Bulk"), recipeType: typeof(BoiledSausageBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}