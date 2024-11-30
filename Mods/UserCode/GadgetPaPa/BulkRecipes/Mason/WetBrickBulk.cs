// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// WetBrick ShaleBrick Bulk Recipe

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
    using Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(PotterySkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Wet Brick Bulk Item")]
    public partial class WetBrickBulkRecipe : RecipeFamily
    {
        public WetBrickBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WetBrickBulk",  //noloc
                displayName: Localizer.DoStr("Wet Brick Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SandItem), 75, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),		// 3 x 25
                    new IngredientElement(typeof(ClayItem), 300, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),	// 12 x 25
                    new IngredientElement(typeof(WoodenMoldItem), 100, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WetBrickItem>(300),	// 4 x 25 x 3
                    new CraftingElement<WoodenMoldItem>(typeof(PotterySkill), 50, typeof(PotteryLavishResourcesTalent)),		// 2 x 25
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(PotterySkill));	// 100 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WetBrickBulkRecipe), start: 12.5f, skillType: typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));	// 0.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Wet Brick Bulk"), recipeType: typeof(WetBrickBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(PotteryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


    [RequiresSkill(typeof(PotterySkill), 3)] // 1
    public partial class ShaleBrickBulkRecipe : RecipeFamily
    {
        public ShaleBrickBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ShaleBrickBulk",  //noloc
                displayName: Localizer.DoStr("Shale Brick Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SandItem), 150, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),		// 6 x 25
                    new IngredientElement(typeof(CrushedShaleItem), 100, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),	// 4 x 25
                    new IngredientElement(typeof(ClayItem), 300, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),	// 12 x 25
                    new IngredientElement(typeof(WoodenMoldItem), 200, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),	// 8 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WetBrickItem>(600),	// 8 x 25 x 3
                    new CraftingElement<WoodenMoldItem>(typeof(PotterySkill), 100, typeof(PotteryLavishResourcesTalent)),		// 4 x 25
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(5000, typeof(PotterySkill));	// 200 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ShaleBrickBulkRecipe), start: 25, skillType: typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));	// 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Shale Brick Bulk"), recipeType: typeof(ShaleBrickBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(PotteryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}