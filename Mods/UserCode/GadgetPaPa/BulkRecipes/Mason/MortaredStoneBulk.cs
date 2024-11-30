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

    [RequiresSkill(typeof(MasonrySkill), 3)]		// 1
    [Ecopedia("Blocks", "Building Materials", subPageName: "Mortared Stone Bulk Item")]
    public partial class MortaredStoneBulkRecipe : RecipeFamily
    {
        public MortaredStoneBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MortaredStoneBulk",  //noloc
                displayName: Localizer.DoStr("Mortared Stone Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Rock", 100, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)), //noloc		// 4 x 25
                    new IngredientElement(typeof(MortarItem), 25, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MortaredStoneItem>(75)	// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f;	// 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(375, typeof(MasonrySkill));	// 15 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MortaredStoneBulkRecipe), start: 4f, skillType: typeof(MasonrySkill), typeof(MasonryFocusedSpeedTalent), typeof(MasonryParallelSpeedTalent));	// 0.16 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Mortared Stone Bulk"), recipeType: typeof(MortaredStoneBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MasonryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MasonrySkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Mortared Granite Bulk Item")]
    public partial class MortaredGraniteBulkRecipe : Recipe
    {
        public MortaredGraniteBulkRecipe()
        {
            this.Init(
                name: "MortaredGraniteBulk",  //noloc
                displayName: Localizer.DoStr("Mortared Granite Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GraniteItem), 100, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),	// 4 x 25
                    new IngredientElement(typeof(MortarItem), 25, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),		// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MortaredGraniteItem>(75)	// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(MasonryTableObject), typeof(MortaredStoneBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MasonrySkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Mortared Limestone Bulk Item")]
    public partial class MortaredLimestoneBulkRecipe : Recipe
    {
        public MortaredLimestoneBulkRecipe()
        {
            this.Init(
                name: "MortaredLimestoneBulk",  //noloc
                displayName: Localizer.DoStr("Mortared Limestone Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LimestoneItem), 100, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),	// 4 x 25
                    new IngredientElement(typeof(MortarItem), 25, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),		// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MortaredLimestoneItem>(75)	// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(MasonryTableObject), typeof(MortaredStoneBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MasonrySkill), 3)]		//1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Mortared Sandstone Bulk Item")]
    public partial class MortaredSandstoneBulkRecipe : Recipe
    {
        public MortaredSandstoneBulkRecipe()
        {
            this.Init(
                name: "MortaredSandstoneBulk",  //noloc
                displayName: Localizer.DoStr("Mortared Sandstone Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SandstoneItem), 100, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),	// 4 x 25
                    new IngredientElement(typeof(MortarItem), 25, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),		// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MortaredSandstoneItem>(75)	// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(MasonryTableObject), typeof(MortaredStoneBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

}
