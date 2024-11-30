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

    [RequiresSkill(typeof(LoggingSkill), 7)]	// 5
    [Ecopedia("Food", "Ingredients", subPageName: "Acorn Small Bulk")]
    public partial class AcornBulkRecipe : RecipeFamily
    {
        public AcornBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AcornSmallBulk",  //noloc
                displayName: Localizer.DoStr("Acorn Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(OakLogItem), 20, typeof(LoggingSkill)),	// 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<AcornItem>(40)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(LoggingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AcornBulkRecipe), start: 10, skillType: typeof(LoggingSkill), typeof(LoggingFocusedSpeedTalent), typeof(LoggingParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Acorn Small Bulk"), recipeType: typeof(AcornBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FarmersTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    
}