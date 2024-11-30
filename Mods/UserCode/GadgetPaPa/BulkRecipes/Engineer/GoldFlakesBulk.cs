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

    [RequiresSkill(typeof(ElectronicsSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Gold Flakes Item Bulk")]
    public partial class GoldFlakesBulkRecipe : RecipeFamily
    {
        public GoldFlakesBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "GoldFlakesBulk",  //noloc
                displayName: Localizer.DoStr("Gold Flakes Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoldBarItem), 2f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GoldFlakesItem>(4f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkOutput)	// 4 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.BulkMultiplier; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(75f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill));	// 75 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(GoldFlakesBulkRecipe), start: 0.8f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkCraft, skillType: typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));	// 0.8 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Gold Flakes Bulk"), recipeType: typeof(GoldFlakesBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectronicsAssemblyObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}