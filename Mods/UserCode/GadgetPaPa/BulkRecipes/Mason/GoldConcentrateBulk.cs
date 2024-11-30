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
    [Ecopedia("Blocks", "Processed Rock", subPageName: "Gold Concentrate Small Bulk Item")]
    public partial class GoldConcentrateBulkRecipe : RecipeFamily
    {
        public GoldConcentrateBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "GoldConcentrateSmallBulk",  //noloc
                displayName: Localizer.DoStr("Gold Concentrate Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CrushedGoldOreItem), 100, typeof(MiningSkill)),	// 10 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GoldConcentrateItem>(20),	// 1 x 10 x 2 Boosted
                    new CraftingElement<WetTailingsItem>(typeof(MiningSkill), 80),	// 4 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 20;	// 2 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(MiningSkill));	// 50 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(GoldConcentrateBulkRecipe), start: 15.0f, skillType: typeof(MiningSkill));	// 1.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Gold Concentrate Bulk"), recipeType: typeof(GoldConcentrateBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RockerBoxObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MiningSkill), 6)]		// 4
    public partial class ConcentrateGoldLv2BulkRecipe : RecipeFamily
    {
        public ConcentrateGoldLv2BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ConcentrateGoldLv2Bulk",  //noloc
                displayName: Localizer.DoStr("Concentrate Gold Lv2 Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CrushedGoldOreItem), 250, typeof(MiningSkill)),	// 10 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GoldConcentrateItem>(150),	// 2 x 25 x 3 Boosted
                    new CraftingElement<WetTailingsItem>(typeof(MiningSkill), 225),	// 3 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 50;	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(4500, typeof(MiningSkill));	// 180 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ConcentrateGoldLv2BulkRecipe), start: 20f, skillType: typeof(MiningSkill));	// 0.8 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Concentrate Gold Lv2 Bulk"), recipeType: typeof(ConcentrateGoldLv2BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FrothFloatationCellObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
