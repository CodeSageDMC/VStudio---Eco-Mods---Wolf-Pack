// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Pecipe 10x with 1.5 output

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

        
    [RequiresSkill(typeof(MasonrySkill), 3)]  // 1
    [Ecopedia("Items", "Products", subPageName: "Mill Stone Tiny Bulk Item")]
    public partial class MillStoneBulkRecipe : RecipeFamily
    {
        public MillStoneBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MillStoneTinyBulk",  //noloc
                displayName: Localizer.DoStr("Mill Stone Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Rock", 50,typeof(MasonrySkill)), // 5 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MillStoneItem>(15)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1200,typeof(MasonrySkill));  // 120 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MillStoneBulkRecipe), start: 4.0f, skillType: typeof(MasonrySkill), typeof(MasonryFocusedSpeedTalent), typeof(MasonryParallelSpeedTalent));  // 0.4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Mill Stone Tiny Bulk"), recipeType: typeof(MillStoneBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MasonryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}