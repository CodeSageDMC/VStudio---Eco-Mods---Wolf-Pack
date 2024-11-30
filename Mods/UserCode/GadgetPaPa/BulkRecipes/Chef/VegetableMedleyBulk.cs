// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x 1.5x output

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
    public partial class ExoticVegetableMedleyBulkRecipe : RecipeFamily
    {
        public ExoticVegetableMedleyBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ExoticVegetableMedleyTinyBulk",  //noloc
                displayName: Localizer.DoStr("Exotic Vegetable Medley Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BeansItem), 80, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 8 x 10
                    new IngredientElement(typeof(TomatoItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                    new IngredientElement(typeof(BeetItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<VegetableMedleyItem>(15),  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ExoticVegetableMedleyBulkRecipe), start: 8.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 0.8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Exotic Vegetable Medley Tiny Bulk"), recipeType: typeof(ExoticVegetableMedleyBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 3)]  // 1
    public partial class MixedVegetableMedleyBulkRecipe : RecipeFamily
    {
        public MixedVegetableMedleyBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MixedVegetableMedleyTinyBulk",  //noloc
                displayName: Localizer.DoStr("Mixed Vegetable Medley"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CornItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                    new IngredientElement(typeof(CamasBulbItem), 60, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<VegetableMedleyItem>(15),  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MixedVegetableMedleyBulkRecipe), start: 8.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 0.8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Mixed Vegetable Medley Tiny Bulk"), recipeType: typeof(MixedVegetableMedleyBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 3)]  // 1
    public partial class MushroomMedleyBulkRecipe : RecipeFamily
    {
        public MushroomMedleyBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MushroomMedleyTinyBulk",  //noloc
                displayName: Localizer.DoStr("Mushroom Medley Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CriminiMushroomsItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                    new IngredientElement(typeof(CookeinaMushroomsItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                    new IngredientElement(typeof(BoleteMushroomsItem), 40, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<VegetableMedleyItem>(15),  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(CookingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MushroomMedleyBulkRecipe), start: 8.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));  // 0.8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Mushroom Medley Tiny Bulk"), recipeType: typeof(MushroomMedleyBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
