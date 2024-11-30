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
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(TailoringSkill), 3)]		// 1
    public partial class SpinWoolYarnBulkRecipe : RecipeFamily
    {
        public SpinWoolYarnBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SpinWoolYarnSmallBulk",  //noloc
                displayName: Localizer.DoStr("Spin Wool Yarn SmallBulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ShornWoolItem), 40, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),	// 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WoolYarnItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(TailoringSkill));	// 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SpinWoolYarnBulkRecipe), start: 10, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Spin Wool Yarn Small Bulk"), recipeType: typeof(SpinWoolYarnBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(TailoringTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(TailoringSkill), 3)]		// 1
    public partial class WoolYarnBulkRecipe : RecipeFamily
    {
        public WoolYarnBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WoolYarnBulk",  //noloc
                displayName: Localizer.DoStr("Wool Yarn Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ShornWoolItem), 75, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),	// 3 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WoolYarnItem>(75)		// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1500, typeof(TailoringSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WoolYarnBulkRecipe), start: 18.75f, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));	// 0.75 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Wool Yarn Bulk"), recipeType: typeof(WoolYarnBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AdvancedTailoringTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}