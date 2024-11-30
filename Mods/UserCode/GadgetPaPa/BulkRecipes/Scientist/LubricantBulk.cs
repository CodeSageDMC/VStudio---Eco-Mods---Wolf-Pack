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
    [Ecopedia("Items", "Products", subPageName: "Lubricant Tiny BulkItem")]
    public partial class LubricantBulkRecipe : RecipeFamily
    {
        public LubricantBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "LubricantTinyBulk",  //noloc
                displayName: Localizer.DoStr("Lubricant Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PetroleumItem), 40, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<LubricantItem>(30),  // 2 x 10 x 1.5
                    new CraftingElement<BarrelItem>(typeof(OilDrillingSkill), 30, typeof(OilDrillingLavishResourcesTalent)),  // 3 x 10
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1800, typeof(OilDrillingSkill));  // 180 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(LubricantBulkRecipe), start: 15.0f, skillType: typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent));  // 1.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Lubricant Tiny Bulk"), recipeType: typeof(LubricantBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(OilRefineryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}