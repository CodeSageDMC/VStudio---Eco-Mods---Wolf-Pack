// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10 x with 2x output

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
    [Ecopedia("Items", "Products", subPageName: "Electric Motor Small Bulk Item")]
    public partial class ElectricMotorBulkRecipe : RecipeFamily
    {
        public ElectricMotorBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ElectricMotorSmallBulk",  //noloc
                displayName: Localizer.DoStr("Electric Motor Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BasicCircuitItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),	// 4 x 10
                    new IngredientElement(typeof(CopperWiringItem), 10f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),	// 10 x 10
                    new IngredientElement(typeof(SteelBarItem), 8f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),	// 8 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ElectricMotorItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10f*BulkRecipeSettings.SmallBulkMultiplier; // 10 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(360f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill));	// 360 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ElectricMotorBulkRecipe), start: 2f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Electric Motor Small Bulk"), recipeType: typeof(ElectricMotorBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectronicsAssemblyObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}