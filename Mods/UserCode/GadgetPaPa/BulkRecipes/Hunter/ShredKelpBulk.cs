// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Small Bulk Recipe 10x with 2x output

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

    [RequiresSkill(typeof(HuntingSkill), 2)]	// 0
    public partial class ShredKelpBulkRecipe : RecipeFamily
    {
        public ShredKelpBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ShredKelpSmallBulk",  //noloc
                displayName: Localizer.DoStr("Shred Kelp Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(KelpItem), 80, typeof(HuntingSkill), typeof(HuntingLavishResourcesTalent)),	// 8 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PlantFibersItem>(140),	// 7 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(HuntingSkill));	// 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ShredKelpBulkRecipe), start: 10, skillType: typeof(HuntingSkill));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Shred Kelp Small Bulk"), recipeType: typeof(ShredKelpBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FisheryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
