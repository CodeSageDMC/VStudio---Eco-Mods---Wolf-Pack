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
    [Ecopedia("Items", "Products", subPageName: "Whetstone Tiny Bulk Item")]
    public partial class WhetstoneBulkRecipe : RecipeFamily
    {
        public WhetstoneBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WhetstoneTinyBulk",  //noloc
                displayName: Localizer.DoStr("Whetstone Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Rock", 30,typeof(MasonrySkill)), // 3 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WhetstoneItem>(15)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(300,typeof(MasonrySkill));  // 30 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WhetstoneBulkRecipe), start: 2.0f, skillType: typeof(MasonrySkill), typeof(MasonryFocusedSpeedTalent), typeof(MasonryParallelSpeedTalent));  // 0.2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Whetstone Tiny Bulk"), recipeType: typeof(WhetstoneBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MasonryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}