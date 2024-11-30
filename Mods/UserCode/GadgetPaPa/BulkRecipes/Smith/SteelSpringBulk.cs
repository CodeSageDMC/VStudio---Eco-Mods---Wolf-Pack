// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10 x 1.5 output

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

        
    [RequiresModule(typeof(PowerHammerObject))]
    [RequiresSkill(typeof(AdvancedSmeltingSkill), 4)]  // 2
    [Ecopedia("Items", "Products", subPageName: "Steel Spring Tiny Bulk Item")]
    public partial class SteelSpringBulkRecipe : RecipeFamily
    {
        public SteelSpringBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteelSpringTinyBulk",  //noloc
                displayName: Localizer.DoStr("Steel Spring Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 10, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),  // 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelSpringItem>(45)  // 3 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(850, typeof(AdvancedSmeltingSkill));  // 85 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteelSpringBulkRecipe), start: 8.0f, skillType: typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));  // 0.8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steel Spring Tiny Bulk"), recipeType: typeof(SteelSpringBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BlastFurnaceObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}