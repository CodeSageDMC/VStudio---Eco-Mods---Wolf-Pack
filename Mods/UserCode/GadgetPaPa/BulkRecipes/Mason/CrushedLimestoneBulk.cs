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
    [Ecopedia("Blocks", "Processed Rock", subPageName: "Crushed Limestone Small Bulk Item")]
    public partial class CrushedLimestoneBulkRecipe : RecipeFamily
    {
        public CrushedLimestoneBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CrushedLimestoneSmallBulk",  //noloc
                displayName: Localizer.DoStr("Crushed Limestone Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LimestoneItem), 120, true),	// 12 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CrushedLimestoneItem>(60)		// 3 x 10 x 2 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f;	// 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(MiningSkill));	// 50 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CrushedLimestoneBulkRecipe), start: 20, skillType: typeof(MiningSkill));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Crushed Limestone Small Bulk"), recipeType: typeof(CrushedLimestoneBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ArrastraObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MiningSkill), 3)]		// 1
    public partial class CrushedLimestoneLv2BulkRecipe : RecipeFamily
    {
        public CrushedLimestoneLv2BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CrushedLimestoneLv2SmallBulk",  //noloc
                displayName: Localizer.DoStr("Crushed Limestone Lv2 Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LimestoneItem), 200, true),	// 20 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CrushedLimestoneItem>(100),	// 5 x 10 x 2 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f;	// 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(700, typeof(MiningSkill));		// 70 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CrushedLimestoneLv2BulkRecipe), start: 10, skillType: typeof(MiningSkill));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Crushed Limestone Lv2 Small Bulk"), recipeType: typeof(CrushedLimestoneLv2BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StampMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MiningSkill), 4)]		// 2
    public partial class CrushedLimestoneLv3BulkRecipe : RecipeFamily
    {
        public CrushedLimestoneLv3BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CrushedLimestoneLv3Bulk",  //noloc
                displayName: Localizer.DoStr("Crushed Limestone Lv3 Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LimestoneItem), 500, true),	// 20 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CrushedLimestoneItem>(375),		// 5 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f;	// 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2250, typeof(MiningSkill));		// 90 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CrushedLimestoneLv3BulkRecipe), start: 12.5f, skillType: typeof(MiningSkill));	// 0.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Crushed Limestone Lv3 Bulk"), recipeType: typeof(CrushedLimestoneLv3BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(JawCrusherObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
