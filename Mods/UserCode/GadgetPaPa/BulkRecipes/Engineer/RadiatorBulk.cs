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

    [RequiresSkill(typeof(IndustrySkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Radiator Item Small Bulk")]
    public partial class RadiatorBulkRecipe : RecipeFamily
    {
        public RadiatorBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RadiatorSmallBulk",  //noloc
                displayName: Localizer.DoStr("Radiator Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(HeatSinkItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),		// 4 x 10
                    new IngredientElement(typeof(CopperWiringItem), 8f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),	// 8 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RadiatorItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3f*BulkRecipeSettings.SmallBulkMultiplier; // 3 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(35f*BulkRecipeSettings.SmallBulkMultiplier, typeof(IndustrySkill));	// 35 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RadiatorBulkRecipe), start: 1.5f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(IndustrySkill), typeof(IndustryFocusedSpeedTalent), typeof(IndustryParallelSpeedTalent));	// 1.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Radiator Small Bulk"), recipeType: typeof(RadiatorBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectricStampingPressObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}