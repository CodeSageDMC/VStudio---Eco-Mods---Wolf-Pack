// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 25x with 3x Output

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
    [Ecopedia("Items", "Products", subPageName: "Steel Plate Item Bulk")]
    public partial class SteelPlateBulkRecipe : RecipeFamily
    {
        public SteelPlateBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteelPlateBulk",  //noloc
                displayName: Localizer.DoStr("Steel Plate Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 3f*BulkRecipeSettings.BulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),	// 3 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelPlateItem>(1f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkOutput)	// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.BulkMultiplier; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(120f*BulkRecipeSettings.BulkMultiplier, typeof(IndustrySkill));	// 120 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteelPlateBulkRecipe), start: 1.5f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkCraft, skillType: typeof(IndustrySkill), typeof(IndustryFocusedSpeedTalent), typeof(IndustryParallelSpeedTalent));	// 1.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steel Plate Bulk"), recipeType: typeof(SteelPlateBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectricStampingPressObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}