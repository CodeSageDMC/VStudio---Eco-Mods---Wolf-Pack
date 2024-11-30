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

    [RequiresSkill(typeof(MechanicsSkill), 6)]	// 4
    [Ecopedia("Items", "Products", subPageName: "Gold Wiring Item Small Bulk")]
    public partial class GoldWiringSBulkRecipe : RecipeFamily
    {
        public GoldWiringSBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "GoldWiringSmallBulk",  //noloc
                displayName: Localizer.DoStr("Gold Wiring Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoldBarItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GoldWiringItem>(2f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 2 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.SmallBulkMultiplier; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(120f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill));		// 120 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(GoldWiringSBulkRecipe), start: 0.4f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));	// 0.4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Gold Wiring Small Bulk"), recipeType: typeof(GoldWiringSBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectricMachinistTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}