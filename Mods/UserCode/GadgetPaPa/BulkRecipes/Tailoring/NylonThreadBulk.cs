﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe

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

    [RequiresSkill(typeof(TailoringSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Nylon Thread Item Bulk")]
    public partial class NylonThreadBulkRecipe : RecipeFamily
    {
        public NylonThreadBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "NylonThreadBulk",  //noloc
                displayName: Localizer.DoStr("Nylon Thread Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(NylonItem), 50, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<NylonThreadItem>(300)		// 4 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1500, typeof(TailoringSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(NylonThreadBulkRecipe), start: 18.75f, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));	// 0.75 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Nylon Thread Bulk"), recipeType: typeof(NylonThreadBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SpinMelterObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}