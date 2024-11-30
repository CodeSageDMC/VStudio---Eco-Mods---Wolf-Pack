// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Small Bulk Recipe 10x 2x output

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


    [RequiresSkill(typeof(CookingSkill), 3)]  // 1
    public partial class ExoticFruitSaladBulkRecipe : RecipeFamily
    {
        public ExoticFruitSaladBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ExoticFruitSaladSmallBulk",  //noloc
                displayName: Localizer.DoStr("Exotic Fruit Salad Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PricklyPearFruitItem), 100, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)), // 10 x 10
                    new IngredientElement(typeof(PumpkinItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FruitSaladItem>(20),  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ExoticFruitSaladBulkRecipe), start: 40, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Exotic Fruit Salad Small Bulk"), recipeType: typeof(ExoticFruitSaladBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(CookingSkill), 3)]  // 1
    public partial class MixedFruitSaladBulkRecipe : RecipeFamily
    {
        public MixedFruitSaladBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MixedFruitSaladSmallBulk",  //noloc
                displayName: Localizer.DoStr("Mixed Fruit Salad Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(HuckleberriesItem), 100, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 10 x 10
                    new IngredientElement(typeof(BeetItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FruitSaladItem>(20), // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MixedFruitSaladBulkRecipe), start: 40, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Mixed Fruit Salad Small Bulk"), recipeType: typeof(MixedFruitSaladBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
	}

    [RequiresSkill(typeof(CookingSkill), 3)]  // 1
    public partial class RainforestFruitSaladBulkRecipe : RecipeFamily
    {
        public RainforestFruitSaladBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RainforestFruitSaladSmallBulk",  //noloc
                displayName: Localizer.DoStr("Rainforest Fruit Salad Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PapayaItem), 100, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 10 x 10
                    new IngredientElement(typeof(PineappleItem), 80, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 8 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FruitSaladItem>(20),  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RainforestFruitSaladBulkRecipe), start: 40, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Rainforest Fruit Salad Small Bulk"), recipeType: typeof(RainforestFruitSaladBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
