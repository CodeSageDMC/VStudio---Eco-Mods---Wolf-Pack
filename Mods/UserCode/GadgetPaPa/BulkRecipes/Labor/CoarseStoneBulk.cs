// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x with 1.5x Output

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
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

        
    [Ecopedia("Items", "Products", subPageName: "Coarse Stone Tiny Bulk Item")]
    public partial class CoarseStoneBulkRecipe : RecipeFamily
    {
        public CoarseStoneBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CoarseStoneTinyBulk",  //noloc
                displayName: Localizer.DoStr("Coarse Stone Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Rock", 10, true), // 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CoarseStoneItem>(15)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(200);	// 20 x 10
            this.CraftMinutes = CreateCraftTimeValue(2.0f);  // 0.2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Coarse Stone Tiny Bulk"), recipeType: typeof(CoarseStoneBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ToolBenchObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}