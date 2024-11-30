// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Charcoal & Dense Charcoal Bulk Recipes

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;

        
    [RequiresSkill(typeof(LoggingSkill), 6)]	// 4
    [Ecopedia("Items", "Products", subPageName: "Charcoal Bulk Item")]
    public partial class CharcoalBulkRecipe : RecipeFamily
    {
        public CharcoalBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Charcoal Bulk",  //noloc
                displayName: Localizer.DoStr("Charcoal Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 175, typeof(LoggingSkill)), //noloc	// 7 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CharcoalItem>(150)  // 2 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; 	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(625, typeof(LoggingSkill));	// 25 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CharcoalBulkRecipe), start: 30f, skillType: typeof(LoggingSkill));	// 1.2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Charcoal Bulk"), recipeType: typeof(CharcoalBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(KilnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(LoggingSkill), 7)]	// 5
    public partial class DenseCharcoalBulkRecipe : RecipeFamily
    {
        public DenseCharcoalBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "DenseCharcoalBulk",
                displayName: Localizer.DoStr("Dense Charcoal Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("HewnLog", 175,typeof(LoggingSkill)), // 7 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CharcoalItem>(300),	// 4 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 50; // 2 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1250,typeof(LoggingSkill));	// 50 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DenseCharcoalBulkRecipe), start: 60.0f, skillType: typeof(LoggingSkill));	// 2.4 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Dense Charcoal Bulk"), recipeType: typeof(DenseCharcoalBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(KilnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}