// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Steel Axle Bulk recipe

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

        
    [RequiresSkill(typeof(IndustrySkill), 3)]	// 1
    public partial class SteelAxleBulkRecipe : RecipeFamily
    {
        public SteelAxleBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteelAxleSmallBulk",  //noloc
                displayName: Localizer.DoStr("Steel Axle Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),	// 4 x 10
                    new IngredientElement(typeof(EpoxyItem), 3f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),	// 3 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelAxleItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.SmallBulkMultiplier; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(60f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill));	// 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteelAxleBulkRecipe), start: 1.5f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(IndustrySkill), typeof(IndustryFocusedSpeedTalent), typeof(IndustryParallelSpeedTalent));	// 1.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steel Axle Small Bulk"), recipeType: typeof(SteelAxleBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectricLatheObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}