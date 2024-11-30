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

        
    [RequiresSkill(typeof(ElectronicsSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Basic Circuit Item")]
    public partial class BasicCircuitBulkRecipe : RecipeFamily
    {
        public BasicCircuitBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BasicCircuitBulk",  //noloc
                displayName: Localizer.DoStr("Basic Circuit Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CopperWiringItem), 6f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),	// 6 x 25
                    new IngredientElement(typeof(GoldFlakesItem), 10f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),		// 10 x 25
                    new IngredientElement(typeof(SubstrateItem), 2f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),		// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BasicCircuitItem>(1f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkOutput)  // 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4f*BulkRecipeSettings.BulkMultiplier; 	// 4 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(45f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill));	// 45 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BasicCircuitBulkRecipe), start: 0.8f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkCraft, skillType: typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));	// 0.8 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Basic Circuit Bulk"), recipeType: typeof(BasicCircuitBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectronicsAssemblyObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}