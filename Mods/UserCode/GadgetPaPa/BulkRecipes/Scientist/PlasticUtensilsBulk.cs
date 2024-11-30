// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk 10x with 1.5x output

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


    [RequiresSkill(typeof(OilDrillingSkill), 3)]  // 1
    public partial class PlasticUtensilsBulkRecipe : RecipeFamily
    {
        public PlasticUtensilsBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PlasticUtensilsTinyBulk",  //noloc
                displayName: Localizer.DoStr("Plastic Utensils Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PlasticItem), 2f*BulkRecipeSettings.TinyBulkMultiplier, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)),  // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CookingUtensilsItem>(1f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkOutput),  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.TinyBulkMultiplier; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(50f*BulkRecipeSettings.TinyBulkMultiplier, typeof(OilDrillingSkill));  // 50 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PlasticUtensilsBulkRecipe), start: 0.4f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkCraft, skillType: typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent));  // 0.4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Plastic Utensils Tiny Bulk"), recipeType: typeof(PlasticUtensilsBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(InjectionMoldMachineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
