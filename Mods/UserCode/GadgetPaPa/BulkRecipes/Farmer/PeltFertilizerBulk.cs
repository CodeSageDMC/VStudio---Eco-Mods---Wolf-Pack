// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using System.ComponentModel;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(FarmingSkill), 4)]	// 2
    [Ecopedia("Items", "Fertilizers", subPageName: "Pelt Fertilizer Item Small Bulk")]
    public partial class PeltFertilizerBulkRecipe : RecipeFamily
    {
        public PeltFertilizerBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PeltFertilizerSmallBulk",  //noloc
                displayName: Localizer.DoStr("Pelt Fertilizer Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FurPeltItem), 30, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)),	// 3 x 10
                    new IngredientElement("FertilizerFiller", 10, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)), // 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PeltFertilizerItem>(20)		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(FarmingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PeltFertilizerBulkRecipe), start: 3f, skillType: typeof(FarmingSkill), typeof(FarmingFocusedSpeedTalent), typeof(FarmingParallelSpeedTalent));	// 0.3 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Pelt Fertilizer Small Bulk"), recipeType: typeof(PeltFertilizerBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FarmersTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
