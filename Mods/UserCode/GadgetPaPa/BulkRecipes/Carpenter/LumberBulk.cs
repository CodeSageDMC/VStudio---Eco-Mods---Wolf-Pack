// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Lumber Bulk Pecipe

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

    [RequiresSkill(typeof(CarpentrySkill), 3)]		// 1
    [Ecopedia("Blocks", "Building Materials", subPageName: "Lumber Bulk Item")]
    public partial class LumberBulkRecipe : RecipeFamily
    {
        public LumberBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "LumberBulk",  //noloc
                displayName: Localizer.DoStr("Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(NailItem), 50, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),			// 2 x 25
                    new IngredientElement(typeof(FlaxseedOilItem), 12.5f, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),	// 0.5 x 25
                    new IngredientElement("WoodBoard", 250, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), //noloc		// 10 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<LumberItem>(150)		// 2 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25;	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1500, typeof(CarpentrySkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(LumberBulkRecipe), start: 8f, skillType: typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));	// 0.32 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Lumber Bulk"), recipeType: typeof(LumberBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SawmillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

	// Hardwood Lumber Bulk
    [RequiresSkill(typeof(CarpentrySkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Hardwood Lumber Bulk Item")]
    public partial class HardwoodLumberBulkRecipe : Recipe
    {
        public HardwoodLumberBulkRecipe()
        {
            this.Init(
                name: "HardwoodLumberBulk",  //noloc
                displayName: Localizer.DoStr("Hardwood Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(HardwoodBoardItem), 250, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),	// 10 x 25
                    new IngredientElement(typeof(NailItem), 50, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),			// 2 x 25
                    new IngredientElement(typeof(FlaxseedOilItem), 12.5f, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),	// 0.5 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HardwoodLumberItem>(150)		// 2 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(SawmillObject), typeof(LumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	// Softwood Lumber Bulk
    [RequiresSkill(typeof(CarpentrySkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Softwood Lumber Bulk Item")]
    public partial class SoftwoodLumberBulkRecipe : Recipe
    {
        public SoftwoodLumberBulkRecipe()
        {
            this.Init(
                name: "SoftwoodLumberBulk",  //noloc
                displayName: Localizer.DoStr("Softwood Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SoftwoodBoardItem), 250, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),	// 10 x 25
                    new IngredientElement(typeof(NailItem), 50, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),			// 2 x 25
                    new IngredientElement(typeof(FlaxseedOilItem), 12.5f, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),	// 0.5 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SoftwoodLumberItem>(150)		// 2 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(SawmillObject), typeof(LumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}
