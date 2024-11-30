// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Steel Bar Bulk recipe

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

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 3)]		// 1
    [Ecopedia("Blocks", "Metals", subPageName: "Steel Bar Bulk Item")]
    public partial class SteelBarBulkRecipe : RecipeFamily
    {
        public SteelBarBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteelBarBulk",  //noloc
                displayName: Localizer.DoStr("Steel Bar Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronConcentrateItem), 25, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(CeramicMoldItem), 100, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),	// 4 x 25
                    new IngredientElement(typeof(QuicklimeItem), 100, true),		// 4 x 25
                    new IngredientElement(typeof(CrushedCoalItem), 100, true),	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelBarItem>(300),		// 4 x 25 x 3 Boosted
                    new CraftingElement<SlagItem>(typeof(AdvancedSmeltingSkill), 300, typeof(AdvancedSmeltingLavishResourcesTalent)),	// 4 x 25 x 3
                    new CraftingElement<CeramicMoldItem>(typeof(AdvancedSmeltingSkill), 75, typeof(AdvancedSmeltingLavishResourcesTalent)),	// 3 x 25
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 50;	// 2 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1500, typeof(AdvancedSmeltingSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteelBarBulkRecipe), start: 37.5f, skillType: typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));	// 1.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steel Bar Bulk"), recipeType: typeof(SteelBarBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BlastFurnaceObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(AdvancedSmeltingSkill), 3)]  // 1
    public partial class CharcoalSteelBulkRecipe : RecipeFamily
    {
        public CharcoalSteelBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CharcoalSteelBulk",  //noloc
                displayName: Localizer.DoStr("Charcoal Steel Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronConcentrateItem), 25, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(CeramicMoldItem), 100, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),		// 4 x 25
                    new IngredientElement(typeof(QuicklimeItem), 100, true),	// 4 x 25
                    new IngredientElement(typeof(CharcoalItem), 200, true),	// 8 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelBarItem>(300),	// 4 x 25 x 3 Boosted
                    new CraftingElement<SlagItem>(typeof(AdvancedSmeltingSkill), 300, typeof(AdvancedSmeltingLavishResourcesTalent)),	// 4 x 25 x 3
                    new CraftingElement<CeramicMoldItem>(typeof(AdvancedSmeltingSkill), 75, typeof(AdvancedSmeltingLavishResourcesTalent)),	// 3 x 25
                });
            this.Recipes = new List<Recipe> { recipe };
            this .ExperienceOnCraft = 50;	// 2 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1500, typeof(AdvancedSmeltingSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CharcoalSteelBulkRecipe), start: 37.5f, skillType: typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));	// 1.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Charcoal Steel Bulk"), recipeType: typeof(CharcoalSteelBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BlastFurnaceObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
