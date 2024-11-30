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

    [RequiresSkill(typeof(GlassworkingSkill), 3)]		// 1
    [Ecopedia("Blocks", "Building Materials", subPageName: "Glass Bulk Item")]
    public partial class GlassBulkRecipe : RecipeFamily
    {
        public GlassBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "GlassBulk",  //noloc
                displayName: Localizer.DoStr("Glass Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SandItem), 100, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),	// 4 x 25
                    new IngredientElement(typeof(CrushedLimestoneItem), 25, true),	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GlassItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25;	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(750, typeof(GlassworkingSkill));	// 30 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(GlassBulkRecipe), start: 30f, skillType: typeof(GlassworkingSkill), typeof(GlassworkingFocusedSpeedTalent), typeof(GlassworkingParallelSpeedTalent));	// 1.2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Glass Bulk"), recipeType: typeof(GlassBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(GlassworksObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(GlassworkingSkill), 7)]		// 5
    [Ecopedia("Blocks", "Building Materials", subPageName: "Framed Glass Bulk Item")]
    public partial class FramedGlassBulkRecipe : RecipeFamily
    {
        public FramedGlassBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FramedGlassBulk",  //noloc
                displayName: Localizer.DoStr("Framed Glass Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GlassItem), 125, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),	// 5 x 25
                    new IngredientElement(typeof(SteelBarItem), 50, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),	// 2 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),		// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FramedGlassItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 37.5f;	// 1.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(3000, typeof(GlassworkingSkill));	// 120 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FramedGlassBulkRecipe), start: 16f, skillType: typeof(GlassworkingSkill), typeof(GlassworkingFocusedSpeedTalent), typeof(GlassworkingParallelSpeedTalent));	// 0.64 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Framed Glass Bulk"), recipeType: typeof(FramedGlassBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(GlassworksObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(GlassworkingSkill), 6)]		// 4
    public partial class QuicklimeGlassBulkRecipe : RecipeFamily
    {
        public QuicklimeGlassBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "QuicklimeGlassBulk",  //noloc
                displayName: Localizer.DoStr("Quicklime Glass Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SandItem), 75, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),		// 3 x 25
                    new IngredientElement(typeof(QuicklimeItem), 50, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GlassItem>(75),		// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25;	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1125, typeof(GlassworkingSkill));	// 45 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(QuicklimeGlassBulkRecipe), start: 25, skillType: typeof(GlassworkingSkill), typeof(GlassworkingFocusedSpeedTalent), typeof(GlassworkingParallelSpeedTalent));	// 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Quicklime Glass Bulk"), recipeType: typeof(QuicklimeGlassBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(GlassworksObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
