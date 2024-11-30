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

    [RequiresSkill(typeof(PotterySkill), 3)]	// 1
    [Ecopedia("Blocks", "Building Materials", subPageName: "Brick Bulk Item")]
    public partial class BrickBulkRecipe : RecipeFamily
    {
        public BrickBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BrickBulk",  //noloc
                displayName: Localizer.DoStr("Brick Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(WetBrickItem), 25, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement(typeof(MortarItem), 100, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),			// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BrickItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25;	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(375, typeof(PotterySkill));	// 15 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BrickBulkRecipe), start: 8f, skillType: typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));	// 0.32 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Brick Bulk"), recipeType: typeof(BrickBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(KilnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
