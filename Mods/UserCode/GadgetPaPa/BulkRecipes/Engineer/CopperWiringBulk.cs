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
    [Ecopedia("Items", "Products", subPageName: "Copper Wiring Item Bulk")]
    public partial class CopperWiringBulkRecipe : RecipeFamily
    {
        public CopperWiringBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CopperWiringBulk",  //noloc
                displayName: Localizer.DoStr("Copper Wiring Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CopperBarItem), 4f*BulkRecipeSettings.BulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CopperWiringItem>(2f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkOutput)	// 2 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.BulkMultiplier; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(60f*BulkRecipeSettings.BulkMultiplier, typeof(MechanicsSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CopperWiringBulkRecipe), start: 0.4f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkCraft, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));	// 0.4 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Copper Wiring Bulk"), recipeType: typeof(CopperWiringBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MachinistTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}