// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x with 1.5x Output

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;


    [RequiresSkill(typeof(ButcherySkill), 3)]  //1
    public partial class GreaseBulkRecipe : RecipeFamily
    {
        public GreaseBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "GreaseTinyBulk",  //noloc
                displayName: Localizer.DoStr("Grease Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(TallowItem), 20, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),  // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<LubricantItem>(60), // 4 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1800, typeof(ButcherySkill));  // 180 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(GreaseBulkRecipe), start: 15.0f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));  // 1.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Grease Tiny Bulk"), recipeType: typeof(GreaseBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
