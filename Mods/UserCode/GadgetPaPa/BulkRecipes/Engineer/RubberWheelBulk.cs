// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Rubber Wheel Bulk recipe

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

        
    [RequiresSkill(typeof(IndustrySkill), 1)]
    public partial class RubberWheelBulkRecipe : RecipeFamily
    {
        public RubberWheelBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RubberWheelSmallBulk",  //noloc
                displayName: Localizer.DoStr("Rubber Wheel Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SyntheticRubberItem), 8f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),	// 8 x 10
                    new IngredientElement(typeof(SteelBarItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),		// 4 x 10
                    new IngredientElement(typeof(CrushedSulfurItem), 2f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RubberWheelItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3.5f*BulkRecipeSettings.SmallBulkMultiplier; // 3.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(60f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill));	// 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RubberWheelBulkRecipe), start: 2f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(IndustrySkill), typeof(IndustryFocusedSpeedTalent), typeof(IndustryParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Rubber Wheel Small Bulk"), recipeType: typeof(RubberWheelBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectricLatheObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}