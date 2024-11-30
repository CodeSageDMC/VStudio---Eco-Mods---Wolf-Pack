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

    [RequiresSkill(typeof(BakingSkill), 3)]	// 1
    [Ecopedia("Food", "Baking", subPageName: "Pastry Dough Item Small Bulk")]
    public partial class PastryDoughBulkRecipe : RecipeFamily
    {
        public PastryDoughBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PastryDoughSmallBulk",  //noloc
                displayName: Localizer.DoStr("Pastry Dough Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FlourItem), 20, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),	// 2 x 10
                    new IngredientElement(typeof(YeastItem), 10, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),	// 1 x 10
                    new IngredientElement("Fat", 20, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)), //noloc		// 2 x 10
                    // new IngredientElement(typeof(SunButterItem), 10, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)), // 1 x 10
					// new IngredientElement("Egg", 10, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),	// 1 x 10 When Ranching is installed
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PastryDoughItem>(20)		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(BakingSkill));	// 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PastryDoughBulkRecipe), start: 4f, skillType: typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));	// 0.4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Pastry Dough Small Bulk"), recipeType: typeof(PastryDoughBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BakeryOvenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}