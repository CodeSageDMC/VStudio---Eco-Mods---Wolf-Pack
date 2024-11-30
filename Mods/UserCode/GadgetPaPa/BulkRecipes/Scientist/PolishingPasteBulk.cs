// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x with 1.5x Output

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

        
    [RequiresSkill(typeof(OilDrillingSkill), 3)]  // 1
    [Ecopedia("Items", "Products", subPageName: "Polishing Paste Tiny Bulk Item")]
    public partial class PolishingPasteBulkRecipe : RecipeFamily
    {
        public PolishingPasteBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PolishingPasteTinyBulk",  //noloc
                displayName: Localizer.DoStr("Polishing Paste Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LubricantItem), 10,typeof(OilDrillingSkill)),  // 1 x 10
                    new IngredientElement("Silica", 30,typeof(OilDrillingSkill)), // 3 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PolishingPasteItem>(15)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1200,typeof(OilDrillingSkill));  // 120 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PolishingPasteBulkRecipe), start: 2.0f, skillType: typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent));  // 0.2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Polishing Paste Tiny Bulk"), recipeType: typeof(PolishingPasteBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(OilRefineryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}