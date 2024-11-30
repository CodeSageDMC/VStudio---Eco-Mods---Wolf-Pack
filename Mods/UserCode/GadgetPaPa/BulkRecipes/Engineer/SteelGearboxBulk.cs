// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output 

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

    [RequiresSkill(typeof(IndustrySkill), 4)]	// 2
    [Ecopedia("Items", "Products", subPageName: "Steel Gearbox Item Small Bulk")]
    public partial class SteelGearboxBulkRecipe : RecipeFamily
    {
        public SteelGearboxBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteelGearboxSmallBulk",  //noloc
                displayName: Localizer.DoStr("Steel Gearbox Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 8f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),	// 8 x 10
                    new IngredientElement(typeof(SteelGearItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),	// 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelGearboxItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2.5f*BulkRecipeSettings.SmallBulkMultiplier; // 2.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(100f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill));	// 100 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteelGearboxBulkRecipe), start: 2f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(IndustrySkill), typeof(IndustryFocusedSpeedTalent), typeof(IndustryParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steel Gearbox Small Bulk"), recipeType: typeof(SteelGearboxBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectricPlanerObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}