// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// 

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
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(MiningSkill), 3)]  // 1
    [Ecopedia("Blocks", "Processed Rock", subPageName: "Iron Concentrate Small Bulk Item")]
    public partial class IronConcentrateBulkRecipe : RecipeFamily
    {
        public IronConcentrateBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronConcentrateSmallBulk",  //noloc
                displayName: Localizer.DoStr("Iron Concentrate Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CrushedIronOreItem), 50, typeof(MiningSkill)),	// 5 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronConcentrateItem>(20),		// 1 x 10 x 2 Boosted
                    new CraftingElement<WetTailingsItem>(typeof(MiningSkill), 40),	// 2 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 20;	// 2 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(MiningSkill));	// 50 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronConcentrateBulkRecipe), start: 15.0f, skillType: typeof(MiningSkill));	// 1.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Iron Concentrate Small Bulk"), recipeType: typeof(IronConcentrateBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RockerBoxObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MiningSkill), 4)]		// 2
    public partial class ConcentrateDryIronBulkRecipe : RecipeFamily
    {
        public ConcentrateDryIronBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ConcentrateDryIronSmallBulk",  //noloc
                displayName: Localizer.DoStr("Concentrate Dry Iron Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CrushedIronOreItem), 30, typeof(MiningSkill)),	// 3 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronConcentrateItem>(20),	// 1 x 10 x 2 Boosted
                    new CraftingElement<TailingsItem>(typeof(MiningSkill), 20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10;	// 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1200, typeof(MiningSkill));		// 120 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ConcentrateDryIronBulkRecipe), start: 12.0f, skillType: typeof(MiningSkill));	// 1.2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Concentrate Dry Iron Small Bulk"), recipeType: typeof(ConcentrateDryIronBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ScreeningMachineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MiningSkill), 7)]		// 6
    public partial class ConcentrateDryIronLv2BulkRecipe : RecipeFamily
    {
        public ConcentrateDryIronLv2BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ConcentrateDryIronLv2Bulk",  //noloc
                displayName: Localizer.DoStr("Concentrate Dry Iron Lv2 Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CrushedIronOreItem), 125, typeof(MiningSkill)),	// 5 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronConcentrateItem>(150),	// 2 x 25 x 3 Boosted
                    new CraftingElement<TailingsItem>(typeof(MiningSkill), 75),	// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 50;	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(3750, typeof(MiningSkill));	// 150 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ConcentrateDryIronLv2BulkRecipe), start: 10f, skillType: typeof(MiningSkill));	// 0.4 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Concentrate Dry Iron Lv2 Bulk"), recipeType: typeof(ConcentrateDryIronLv2BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SensorBasedBeltSorterObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MiningSkill), 6)]		// 4
    public partial class ConcentrateIronLv2BulkRecipe : RecipeFamily
    {
        public ConcentrateIronLv2BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ConcentrateIronLv2Bulk",  //noloc
                displayName: Localizer.DoStr("Concentrate Iron Lv2 Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CrushedIronOreItem), 125, typeof(MiningSkill)),	// 5 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronConcentrateItem>(150),	// 2 x 25 x 3 Boosted
                    new CraftingElement<WetTailingsItem>(typeof(MiningSkill), 75),	// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25;	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(4500, typeof(MiningSkill));	// 180 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ConcentrateIronLv2BulkRecipe), start: 20f, skillType: typeof(MiningSkill));	// 0.8 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Concentrate Iron Lv2 Bulk"), recipeType: typeof(ConcentrateIronLv2BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FrothFloatationCellObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
