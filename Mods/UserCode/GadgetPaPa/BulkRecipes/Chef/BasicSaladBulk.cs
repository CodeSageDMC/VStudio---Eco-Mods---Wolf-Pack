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
    public partial class RainforestSaladBulkRecipe : RecipeFamily
    {
        public RainforestSaladBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RainforestSaladSmallBulk",  //noloc
                displayName: Localizer.DoStr("Rainforest Salad Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(TaroRootItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                    new IngredientElement(typeof(BoleteMushroomsItem), 80, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 8 x 10
                    new IngredientElement(typeof(PapayaItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BasicSaladItem>(20),  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RainforestSaladBulkRecipe), start: 40, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Rainforest Salad Small Bulk"), recipeType: typeof(RainforestSaladBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 3)]  // 1
    public partial class ExoticSaladBulkRecipe : RecipeFamily
    {
        public ExoticSaladBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ExoticSaladSmallBulk",  //noloc
                displayName: Localizer.DoStr("Exotic Salad Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PricklyPearFruitItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                    new IngredientElement(typeof(CriminiMushroomsItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                    new IngredientElement(typeof(RiceItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BasicSaladItem>(20),  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ExoticSaladBulkRecipe), start: 40, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Exotic Salad Small Bulk"), recipeType: typeof(ExoticSaladBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 3)]  // 1
    public partial class ForestSaladBulkRecipe : RecipeFamily
    {
        public ForestSaladBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ForestSaladSmallBulk",  //noloc
                displayName: Localizer.DoStr("Forest Salad Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FiddleheadsItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                    new IngredientElement(typeof(HuckleberriesItem), 80, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 8 x 10
                    new IngredientElement(typeof(BeansItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BasicSaladItem>(20),  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ForestSaladBulkRecipe), start: 40, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Forest Salad Small Bulk"), recipeType: typeof(ForestSaladBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 3)]  // 1
    public partial class GrasslandSaladBulkRecipe : RecipeFamily
    {
        public GrasslandSaladBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "GrasslandSaladSmallBulk",  //noloc
                displayName: Localizer.DoStr("Grassland Salad Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CornItem), 50, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 5 x 10
                    new IngredientElement(typeof(TomatoItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                    new IngredientElement(typeof(BeetItem), 50, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 5 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BasicSaladItem>(20),  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(GrasslandSaladBulkRecipe), start: 40, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Grassland Salad Small Bulk"), recipeType: typeof(GrasslandSaladBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 3)]  // 1
    public partial class MixedSaladBulkRecipe : RecipeFamily
    {
        public MixedSaladBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MixedSaladSmallBulk",  //noloc
                displayName: Localizer.DoStr("Mixed Salad Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FiddleheadsItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                    new IngredientElement(typeof(TomatoItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                    new IngredientElement(typeof(FireweedShootsItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BasicSaladItem>(20),  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MixedSaladBulkRecipe), start: 40, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Mixed Salad Small Bulk"), recipeType: typeof(MixedSaladBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
