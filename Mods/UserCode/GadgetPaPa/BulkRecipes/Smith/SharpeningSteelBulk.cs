// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk 10x 1.5x Output

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
    [Ecopedia("Items", "Products", subPageName: "Sharpening Steel Tiny Bulk Item")]
    public partial class SharpeningSteelBulkRecipe : RecipeFamily
    {
        public SharpeningSteelBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SharpeningSteelTinyBulk",  //noloc
                displayName: Localizer.DoStr("Sharpening Steel Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 10,typeof(BlacksmithSkill)),  // 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SharpeningSteelItem>(15)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600,typeof(BlacksmithSkill));  // 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SharpeningSteelBulkRecipe), start: 2.0f, skillType: typeof(BlacksmithSkill), typeof(BlacksmithFocusedSpeedTalent), typeof(BlacksmithParallelSpeedTalent));  // 0.2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Sharpening Steel Tiny Bulk"), recipeType: typeof(SharpeningSteelBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}