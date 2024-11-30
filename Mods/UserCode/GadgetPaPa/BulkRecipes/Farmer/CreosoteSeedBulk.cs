// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(FarmingSkill), 7)]	// 5
    [Ecopedia("Food", "Ingredients", subPageName: "Creosote Bush Seed Small Bulk")]
    public partial class CreosoteBushSeedBulkRecipe : RecipeFamily
    {
        public CreosoteBushSeedBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CreosoteSeedSmallBulk",  //noloc
                displayName: Localizer.DoStr("Creosote Bush Seed Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CreosoteFlowerItem), 40, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)),	// 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CreosoteBushSeedItem>(40)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(FarmingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CreosoteBushSeedRecipe), start: 10, skillType: typeof(FarmingSkill), typeof(FarmingFocusedSpeedTalent), typeof(FarmingParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Creosote Bush Seed Small Bulk"), recipeType: typeof(CreosoteBushSeedBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FarmersTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    
}