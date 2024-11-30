// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny/Small Bulk Recipe 10x with 1.5x Output

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

        
    [RequiresSkill(typeof(TailoringSkill), 4)]  // 2
    [Ecopedia("Items", "Products", subPageName: "Canvas Tiny Bulk Item")]
    public partial class CanvasBulkRecipe : RecipeFamily
    {
        public CanvasBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CanvasTinyBulk",  //noloc
                displayName: Localizer.DoStr("Canvas Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LinenFabricItem), 60, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),  // 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CanvasItem>(15)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(TailoringSkill));  // 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CanvasBulkRecipe), start: 5.0f, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));  // 0.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Canvas Tiny Bulk"), recipeType: typeof(CanvasBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(LoomObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(TailoringSkill), 4)]  // 2
    public partial class CottonCanvasBulkRecipe : RecipeFamily
    {
        public CottonCanvasBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CottonCanvasTinyBulk",  //noloc
                displayName: Localizer.DoStr("Cotton Canvas Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CottonFabricItem), 60, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),  // 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CanvasItem>(15),  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(TailoringSkill));  // 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CottonCanvasBulkRecipe), start: 5.0f, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));  // 0.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Cotton Canvas Tiny Bulk"), recipeType: typeof(CottonCanvasBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(LoomObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

// Automatic Loom Recipes 
	[RequiresSkill(typeof(TailoringSkill), 4)]  // 2
    public partial class WeaveLinenCanvasBulkRecipe : RecipeFamily
    {
        public WeaveLinenCanvasBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WeaveLinenCanvasSmallBulk",  //noloc
                displayName: Localizer.DoStr("Weave Linen Canvas Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LinenFabricItem), 40, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CanvasItem>(20),  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(TailoringSkill));  // 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WeaveLinenCanvasBulkRecipe), start: 5.0f, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));  // 0.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Weave Linen Canvas Small Bulk"), recipeType: typeof(WeaveLinenCanvasBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AutomaticLoomObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(TailoringSkill), 4)]  // 2
    public partial class WeaveCottonCanvasBulkRecipe : RecipeFamily
    {
        public WeaveCottonCanvasBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WeaveCottonCanvasSmallBulk",  //noloc
                displayName: Localizer.DoStr("Weave Cotton Canvas Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CottonFabricItem), 40, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CanvasItem>(20),  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(TailoringSkill));  // 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WeaveCottonCanvasBulkRecipe), start: 5.0f, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));  // 0.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Weave Cotton Canvas Small Bulk"), recipeType: typeof(WeaveCottonCanvasBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AutomaticLoomObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}