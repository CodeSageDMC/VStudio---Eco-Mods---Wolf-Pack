// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// 

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
    [Ecopedia("Items", "Products", subPageName: "Cotton Thread Item")]
    public partial class CottonThreadBulkRecipe : RecipeFamily
    {
        public CottonThreadBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CottonThreadBulk",  //noloc
                displayName: Localizer.DoStr("Cotton Thread Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CottonLintItem), 25, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CottonThreadItem>(150)	// 2 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2.5f; 	// 0.1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(750, typeof(TailoringSkill));		// 30 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CottonThreadBulkRecipe), start: 25, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));	// 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Cotton Thread Bulk"), recipeType: typeof(CottonThreadBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(TailoringTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}