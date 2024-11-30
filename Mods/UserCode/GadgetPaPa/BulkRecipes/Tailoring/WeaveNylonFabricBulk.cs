// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(TailoringSkill), 3)]	// 1
    public partial class WeaveNylonFabricBulkRecipe : RecipeFamily
    {
        public WeaveNylonFabricBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WeaveNylonFabricBulk",  //noloc
                displayName: Localizer.DoStr("Weave Nylon Fabric Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(NylonThreadItem), 100, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<NylonFabricItem>(150),	// 2 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2000, typeof(TailoringSkill));	// 80 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WeaveNylonFabricBulkRecipe), start: 25, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));	// 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Weave Nylon Fabric Bulk"), recipeType: typeof(WeaveNylonFabricBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AutomaticLoomObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
