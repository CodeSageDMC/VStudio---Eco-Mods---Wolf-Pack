// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe Crushed Stone Road

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


    [RequiresSkill(typeof(MiningSkill), 6)]	// 4
    public partial class CrushedStoneRoadBulkRecipe : RecipeFamily
    {
        public CrushedStoneRoadBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CrushedStoneRoadSmall",  //noloc
                displayName: Localizer.DoStr("Crushed Stone Road Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(StoneRoadItem), 50, true),	// 5 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CrushedMixedRockItem>(40),	// 2 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(900, typeof(MiningSkill));	// 90 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CrushedStoneRoadBulkRecipe), start: 5.0f, skillType: typeof(MiningSkill));	// 0.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Crushed Stone RoadSmall Bulk"), recipeType: typeof(CrushedStoneRoadBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StampMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(MiningSkill), 7)]	// 6
    public partial class CrushedStoneRoadLv2BulkRecipe : RecipeFamily
    {
        public CrushedStoneRoadLv2BulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CrushedStoneRoadLv2Bulk",  //noloc
                displayName: Localizer.DoStr("Crushed Stone Road Lv2 Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(StoneRoadItem), 125, true),	// 5 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CrushedMixedRockItem>(150),	// 2 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(3000, typeof(MiningSkill));	// 120 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CrushedStoneRoadLv2BulkRecipe), start: 5.0f, skillType: typeof(MiningSkill));	// 0.2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Crushed Stone Road Lv2 Bulk"), recipeType: typeof(CrushedStoneRoadLv2BulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(JawCrusherObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
	