// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 25x with 3x output

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
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.SharedTypes;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.World.Water;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Shared.Graphics;
    using Eco.World.Color;

    [RequiresSkill(typeof(SmeltingSkill), 3)]		// 3 
    public partial class SmeltIronBulkRecipe : RecipeFamily
    {
        public SmeltIronBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SmeltIronSmallBulk",  //noloc
                displayName: Localizer.DoStr("Smelt Iron Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronConcentrateItem), 20, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),	// 2 x 10
                    new IngredientElement(typeof(ClayMoldItem), 60, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),			// 6 X 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronBarItem>(120),		// 6 X 10 X 2
                    new CraftingElement<SlagItem>(typeof(SmeltingSkill), 40, typeof(SmeltingLavishResourcesTalent)),	// 2 X 10 X 2
                    new CraftingElement<ClayMoldItem>(typeof(SmeltingSkill), 45, typeof(SmeltingLavishResourcesTalent)),	// 3 X 10 X 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 20;	// 2 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(SmeltingSkill));	// 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SmeltIronBulkRecipe), start: 50, skillType: typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));	// 5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Smelt Iron Small Bulk"), recipeType: typeof(SmeltIronBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BloomeryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(SmeltingSkill), 3)]	// 1
    [Ecopedia("Blocks", "Metals", subPageName: "Iron Bar Bulk Item")]
    public partial class IronBarBulkRecipe : RecipeFamily
    {
        public IronBarBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronBarBulk",  //noloc
                displayName: Localizer.DoStr("Iron Bar Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronConcentrateItem), 25, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(ClayMoldItem), 100, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),		// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronBarItem>(300),	// 4 x 25 x 3 Boosted
                    new CraftingElement<SlagItem>(typeof(SmeltingSkill), 75, typeof(SmeltingLavishResourcesTalent)),	// 1 x 25 x 3
                    new CraftingElement<ClayMoldItem>(typeof(SmeltingSkill), 75, typeof(SmeltingLavishResourcesTalent)),	// 2 x 25 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 50;	// 2 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1500, typeof(SmeltingSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronBarBulkRecipe), start: 15f, skillType: typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));	// 0.6 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Iron Bar Bulk"), recipeType: typeof(IronBarBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BlastFurnaceObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
