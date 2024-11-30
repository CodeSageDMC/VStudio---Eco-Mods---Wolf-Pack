// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 25x with 3x output 

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

    [RequiresSkill(typeof(MechanicsSkill), 3)]	// 1
    public partial class IronGearSBulkRecipe : RecipeFamily
    {
        public IronGearSBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronGearSmallBulk",  //noloc
                displayName: Localizer.DoStr("Iron Gear Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 1f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronGearItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.SmallBulkMultiplier; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(75f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill));	// 75 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronGearSBulkRecipe), start: 0.4f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));	// 0.4 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Iron Gear Small Bulk"), recipeType: typeof(IronGearSBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ShaperObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(MechanicsSkill), 5)]	// 1
    public partial class IronGearBulkRecipe : RecipeFamily
    {
        public IronGearBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronGearBulk",  //noloc
                displayName: Localizer.DoStr("Iron Gear Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 25, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronGearItem>(75)		// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1875, typeof(MechanicsSkill));	// 75 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronGearBulkRecipe), start: 10.0f, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));	// 0.4 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Iron Gear Bulk"), recipeType: typeof(IronGearBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ShaperObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}