// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Ceramic Mold Bulk Recipe

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

    [RequiresSkill(typeof(PotterySkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Ceramic Mold Bulk Item")]
    public partial class CeramicMoldBulkRecipe : RecipeFamily
    {
        public CeramicMoldBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CeramicMoldBulk",  //noloc
                displayName: Localizer.DoStr("Ceramic Mold Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ClayItem), 25, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(SandItem), 25, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement("Silica", 25, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)), //noloc	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CeramicMoldItem>(600)	// 8 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(5000, typeof(PotterySkill));	// 200 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CeramicMoldBulkRecipe), start: 5.0f, skillType: typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));	// 0.2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Ceramic Mold Bulk"), recipeType: typeof(CeramicMoldBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(PotteryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}