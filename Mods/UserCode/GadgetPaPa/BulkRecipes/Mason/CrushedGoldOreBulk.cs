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
    [Ecopedia("Blocks", "Processed Rock", subPageName: "Crushed Gold Ore Small Bulk Item")]
    public partial class CrushedGoldOreBulkRecipe : RecipeFamily
    {
        public CrushedGoldOreBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CrushedGoldOreSmallBulk",  //noloc
                displayName: Localizer.DoStr("Crushed Gold Ore Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoldOreItem), 120, true),	// 12 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CrushedGoldOreItem>(40),		// 2 x 10 x 2 Boosted
                    new CraftingElement<CrushedGraniteItem>(20),		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f;	// 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(700, typeof(MiningSkill));	// 70 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CrushedGoldOreBulkRecipe), start: 20, skillType: typeof(MiningSkill));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Crushed Gold Ore Small Bulk"), recipeType: typeof(CrushedGoldOreBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ArrastraObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MiningSkill), 3)]		// 1
    public partial class CrushedGoldLv2BulkRecipe : RecipeFamily
    {
        public CrushedGoldLv2BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CrushedGoldLv2SmallBulk",  //noloc
                displayName: Localizer.DoStr("Crushed Gold Lv2 Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoldOreItem), 200, true),	// 20 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CrushedGoldOreItem>(80),	// 4 x 10 x 2 Boosted
                    new CraftingElement<CrushedGraniteItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f;	// 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(900, typeof(MiningSkill));	// 90 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CrushedGoldLv2BulkRecipe), start: 10, skillType: typeof(MiningSkill));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Crushed Gold Lv2 Small Bulk"), recipeType: typeof(CrushedGoldLv2BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StampMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MiningSkill), 4)]		// 2
    public partial class CrushedGoldLv3BulkRecipe : RecipeFamily
    {
        public CrushedGoldLv3BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CrushedGoldLv3Bulk",  //noloc
                displayName: Localizer.DoStr("Crushed Gold Lv3 Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoldOreItem), 500, true),	// 20 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CrushedGoldOreItem>(375),		// 5 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f;	// 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(3000, typeof(MiningSkill));		// 120 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CrushedGoldLv3BulkRecipe), start: 12.5f, skillType: typeof(MiningSkill));	// 0.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Crushed Gold Lv3 Bulk"), recipeType: typeof(CrushedGoldLv3BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(JawCrusherObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
