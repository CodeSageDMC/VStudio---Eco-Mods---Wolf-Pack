// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Dowel 10x 2x output

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

        
    [RequiresSkill(typeof(LoggingSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Dowel Bulk Item")]
    public partial class DowelBulkRecipe : RecipeFamily
    {
        public DowelBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "DowelSmallBulk",  //noloc
                displayName: Localizer.DoStr("Dowel Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 20,typeof(LoggingSkill)), // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<DowelItem>(320)	// 16 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 0.5f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(400,typeof(LoggingSkill));	// 40 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DowelBulkRecipe), start: 4.0f, skillType: typeof(LoggingSkill));	// 0.4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Dowel Small Bulk"), recipeType: typeof(DowelBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}