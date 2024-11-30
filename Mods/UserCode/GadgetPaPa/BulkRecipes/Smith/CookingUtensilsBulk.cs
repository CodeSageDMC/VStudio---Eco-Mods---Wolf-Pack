// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x 1.5x Output

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

        
    [RequiresSkill(typeof(BlacksmithSkill), 3)]  // 1
    [Ecopedia("Items", "Products", subPageName: "Cooking Utensils Tiny Bulk Item")]
    public partial class CookingUtensilsBulkRecipe : RecipeFamily
    {
        public CookingUtensilsBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CookingUtensilsTinyBulk",  //noloc
                displayName: Localizer.DoStr("Cooking Utensils Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 20, typeof(BlacksmithSkill), typeof(BlacksmithLavishResourcesTalent)),  // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CookingUtensilsItem>(15)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(BlacksmithSkill));  // 50 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CookingUtensilsBulkRecipe), start: 4.0f, skillType: typeof(BlacksmithSkill), typeof(BlacksmithFocusedSpeedTalent), typeof(BlacksmithParallelSpeedTalent));  // 0.4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Cooking Utensils Tiny Bulk"), recipeType: typeof(CookingUtensilsBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}