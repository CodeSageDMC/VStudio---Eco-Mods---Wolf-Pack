// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// 

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


    [RequiresSkill(typeof(MasonrySkill), 3)]	// 1
    public partial class MasonryMortarBulkRecipe : RecipeFamily
    {
        public MasonryMortarBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MasonryMortarBulk",  //noloc
                displayName: Localizer.DoStr("Masonry Mortar Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SandItem), 25, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MortarItem>(225),		// 3 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f;	// 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(625, typeof(MasonrySkill));	// 25 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MasonryMortarBulkRecipe), start: 05f, skillType: typeof(MasonrySkill), typeof(MasonryFocusedSpeedTalent), typeof(MasonryParallelSpeedTalent));	// 0.2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Masonry Mortar Bulk"), recipeType: typeof(MasonryMortarBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MasonryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
