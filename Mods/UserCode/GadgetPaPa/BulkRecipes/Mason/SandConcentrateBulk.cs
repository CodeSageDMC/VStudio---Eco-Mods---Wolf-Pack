// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output earlier tables and 25x with 3x output on latter tables

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

    [RequiresSkill(typeof(MiningSkill), 3)]	// 1
    public partial class SandConcentrateBulkRecipe : RecipeFamily
    {
        public SandConcentrateBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SandConcentrateSmallBulk",  //noloc
                displayName: Localizer.DoStr("Sand Concentrate Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Silica", 20, typeof(MiningSkill)), // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SandItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(MiningSkill));	// 50 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SandConcentrateBulkRecipe), start: 7.0f, skillType: typeof(MiningSkill));	// 0.7 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Sand Concentrate Small Bulk"), recipeType: typeof(SandConcentrateBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RockerBoxObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(MiningSkill), 4)]		// 2
    public partial class SandConcentrateLv2BulkRecipe : RecipeFamily
    {
        public SandConcentrateLv2BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SandConcentrateLv2Bulk",  //noloc
                displayName: Localizer.DoStr("Sand Concentrate Lv2 Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Silica", 100, typeof(MiningSkill)), // 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SandItem>(150),	// 2 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(MiningSkill));	// 100 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SandConcentrateLv2BulkRecipe), start: 17.5f, skillType: typeof(MiningSkill));	// 0.7 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Sand Concentrate Lv2 Bulk"), recipeType: typeof(SandConcentrateLv2BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ScreeningMachineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(MiningSkill), 7)]		// 6
    public partial class SandConcentrateLv3BulkRecipe : RecipeFamily
    {
        public SandConcentrateLv3BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SandConcentrateLv3Bulk",  //noloc
                displayName: Localizer.DoStr("Sand Concentrate Lv3 Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Silica", 150, typeof(MiningSkill)), // 6 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SandItem>(225),	// 3 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 37.5f; // 1.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(3750, typeof(MiningSkill));	// 150 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SandConcentrateLv3BulkRecipe), start: 12.5f, skillType: typeof(MiningSkill));	// 0.5 * 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Sand Concentrate Lv3 Bulk"), recipeType: typeof(SandConcentrateLv3BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SensorBasedBeltSorterObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
