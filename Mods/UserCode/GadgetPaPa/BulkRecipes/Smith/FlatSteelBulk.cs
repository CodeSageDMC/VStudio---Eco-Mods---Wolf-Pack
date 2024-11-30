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

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 7)]		// 5
    [Ecopedia("Blocks", "Building Materials", subPageName: "Flat Steel Bulk Item")]
    public partial class FlatSteelBulkRecipe : RecipeFamily
    {
        public FlatSteelBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FlatSteelBulk",  //noloc
                displayName: Localizer.DoStr("Flat Steel Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 75, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),	// 3 x 25
                    new IngredientElement(typeof(EpoxyItem), 50, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),		// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FlatSteelItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 37.5f;	// 1.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(3000, typeof(AdvancedSmeltingSkill));	// 120 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FlatSteelBulkRecipe), start: 16f, skillType: typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));	// 0.64 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Flat Steel Bulk"), recipeType: typeof(FlatSteelBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RollingMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
