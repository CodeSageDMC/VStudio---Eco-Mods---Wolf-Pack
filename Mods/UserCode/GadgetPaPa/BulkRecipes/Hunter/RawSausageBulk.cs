// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10 x recipe with 2 x output

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

    [RequiresSkill(typeof(ButcherySkill), 4)]	// 2
    [Ecopedia("Food", "Raw Meat", subPageName: "Raw Sausage Small Bulk Item")]
    public partial class RawSausageBulkRecipe : RecipeFamily
    {
        public RawSausageBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RawSausageSmallBulk",  //noloc
                displayName: Localizer.DoStr("Raw Sausage Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ScrapMeatItem), 30, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),	// 3 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawSausageItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(ButcherySkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RawSausageBulkRecipe), start: 8.0f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));	// 0.8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Raw Sausage Small Bulk"), recipeType: typeof(RawSausageBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}