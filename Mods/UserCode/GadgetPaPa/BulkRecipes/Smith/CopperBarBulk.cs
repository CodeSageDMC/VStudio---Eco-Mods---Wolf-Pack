// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Smelting Copper Bars bulk recipe

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
    using Eco.Shared.Graphics;
    using Eco.World.Color;

    [RequiresSkill(typeof(SmeltingSkill), 4)]		// 2
    public partial class SmeltCopperBulkRecipe : RecipeFamily
    {
        public SmeltCopperBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SmeltCopperSmallBulk",  //noloc
                displayName: Localizer.DoStr("Smelt Copper Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CopperConcentrateItem), 20, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),	// 2 x 10
                    new IngredientElement(typeof(ClayMoldItem), 60, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),	// 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CopperBarItem>(120),		// 6 x 10 x 2 Boosted
                    new CraftingElement<SlagItem>(typeof(SmeltingSkill), 40, typeof(SmeltingLavishResourcesTalent)),	// 2 x 10 x 2
                    new CraftingElement<ClayMoldItem>(typeof(SmeltingSkill), 45, typeof(SmeltingLavishResourcesTalent)),	// 3 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 20;	// 2 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(SmeltingSkill));	// 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SmeltCopperBulkRecipe), start: 60, skillType: typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));	// 6 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Smelt Copper Small Bulk"), recipeType: typeof(SmeltCopperBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BloomeryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(SmeltingSkill), 4)]  // 2
    [Ecopedia("Blocks", "Metals", subPageName: "Copper Bar Bulk Item")]
    public partial class CopperBarBulkRecipe : RecipeFamily
    {
        public CopperBarBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CopperBar",  //noloc
                displayName: Localizer.DoStr("Copper Bar Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CopperConcentrateItem), 25, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(ClayMoldItem), 100, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),		// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CopperBarItem>(300), // 4 x 25 x 3 Boosted
                    new CraftingElement<SlagItem>(typeof(SmeltingSkill), 75, typeof(SmeltingLavishResourcesTalent)),	// 1 x 25 x 3
                    new CraftingElement<ClayMoldItem>(typeof(SmeltingSkill), 75, typeof(SmeltingLavishResourcesTalent)),	// 2 x 25 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 50;	// 2 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1500, typeof(SmeltingSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CopperBarBulkRecipe), start: 15f, skillType: typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));	// .6 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Copper Bar Bulk"), recipeType: typeof(CopperBarBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BlastFurnaceObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
