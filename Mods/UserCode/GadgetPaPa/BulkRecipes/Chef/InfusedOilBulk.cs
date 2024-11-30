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

    [RequiresSkill(typeof(AdvancedCookingSkill), 3)]	// 1
    [Ecopedia("Food", "Ingredients", subPageName: "Infused Oil Item Small Bulk")]
    public partial class InfusedOilBulkRecipe : RecipeFamily
    {
        public InfusedOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "InfusedOilSmallBulk",  //noloc
                displayName: Localizer.DoStr("Infused Oil Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(HuckleberryExtractItem), 20, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),	// 2 x 10
                    new IngredientElement("Oil", 20, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)), //noloc	// 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<InfusedOilItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(AdvancedCookingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(InfusedOilBulkRecipe), start: 10, skillType: typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Infused Oil Small Bulk"), recipeType: typeof(InfusedOilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(KitchenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}