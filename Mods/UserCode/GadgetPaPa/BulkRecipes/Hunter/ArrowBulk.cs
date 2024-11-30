// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x more output 

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

    [Ecopedia("Items", "Tools", subPageName: "Arrow Item Small Bulk")]
    [RequiresSkill(typeof(HuntingSkill), 2)]	// 0
    public partial class ArrowBulkRecipe : RecipeFamily
    {
        public ArrowBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ArrowSmallBulk",  //noloc
                displayName: Localizer.DoStr("Arrow Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 1f*BulkRecipeSettings.SmallBulkMultiplier, typeof(HuntingSkill), typeof(HuntingLavishResourcesTalent)), // 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ArrowItem>(4f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 4 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(30f*BulkRecipeSettings.SmallBulkMultiplier, typeof(HuntingSkill));	// 30 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ArrowBulkRecipe), start: 0.1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(HuntingSkill));	// 0.1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Arrow Small Bulk"), recipeType: typeof(ArrowBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ToolBenchObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(HuntingSkill), 3)]	// 1
    public partial class ArrowBundleBulkRecipe : RecipeFamily
    {
        public ArrowBundleBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ArrowBundleBulk",  //noloc
                displayName: Localizer.DoStr("Feathered Arrow Bundle Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 10f*BulkRecipeSettings.SmallBulkMultiplier,typeof(HuntingSkill), typeof(HuntingLavishResourcesTalent)), // 10 x 10
			new IngredientElement(typeof(FeatherItem), 10f*BulkRecipeSettings.SmallBulkMultiplier,typeof(HuntingSkill), typeof(HuntingLavishResourcesTalent)), // 10 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ArrowItem>(20f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput),	// 20 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 0.5f*BulkRecipeSettings.SmallBulkMultiplier; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(180f*BulkRecipeSettings.SmallBulkMultiplier,typeof(HuntingSkill));	// 180 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ArrowBundleBulkRecipe), start: 0.5f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(HuntingSkill));	//0.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Feathered Arrow Bundle Small Bulk"), recipeType: typeof(ArrowBundleBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FletchingTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

}