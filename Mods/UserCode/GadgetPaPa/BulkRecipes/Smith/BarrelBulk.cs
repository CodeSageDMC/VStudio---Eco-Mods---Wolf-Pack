// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Barrel Bulk Recipe

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
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.SharedTypes;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.World.Water;
    using Eco.Gameplay.Pipes;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Shared.Graphics;
    using Eco.World.Color;

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 3)]	// 1
    [Ecopedia("Blocks", "Liquids", subPageName: "Barrel Bulk Item")]
    public partial class BarrelBulkRecipe : RecipeFamily
    {
        public BarrelBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BarrelBulk",  //noloc
                displayName: Localizer.DoStr("Barrel Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 100, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BarrelItem>(300)	// 4 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 50.0f; 	// 2 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(18000, typeof(AdvancedSmeltingSkill));	// 720 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BarrelBulkRecipe), start: 50, skillType: typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));	// 2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Barrel Bulk"), recipeType: typeof(BarrelBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RollingMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
