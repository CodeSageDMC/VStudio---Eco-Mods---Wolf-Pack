﻿// Copyright (c) Strange Loop Games. All rights reserved.
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

    [RequiresSkill(typeof(ButcherySkill), 3)]	// 1
    [Ecopedia("Food", "Raw Meat", subPageName: "Scrap Meat Small Bulk Item")]
    public partial class ScrapMeatBulkRecipe : RecipeFamily
    {
        public ScrapMeatBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ScrapMeatSmallBulk",  //noloc
                displayName: Localizer.DoStr("Scrap Meat Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawMeatItem), 10, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(60)	// 3 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(ButcherySkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ScrapMeatBulkRecipe), start: 5.0f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));	// 0.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Scrap Meat Small Bulk"), recipeType: typeof(ScrapMeatBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}