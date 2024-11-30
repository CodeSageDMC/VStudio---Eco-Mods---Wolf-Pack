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
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.SharedTypes;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.World.Water;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 4)]		// 2
    [Ecopedia("Blocks", "Building Materials", subPageName: "Corrugated Steel Bulk Item")]
    public partial class CorrugatedSteelBulkRecipe : RecipeFamily
    {
        public CorrugatedSteelBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CorrugatedSteelBulk",  //noloc
                displayName: Localizer.DoStr("Corrugated Steel Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 50, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CorrugatedSteelItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f;	// 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(625, typeof(AdvancedSmeltingSkill));	// 25 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CorrugatedSteelBulkRecipe), start: 8f, skillType: typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));	// 0.32 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Corrugated Steel Bulk"), recipeType: typeof(CorrugatedSteelBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RollingMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
