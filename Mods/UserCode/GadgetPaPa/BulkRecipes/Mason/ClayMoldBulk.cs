// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Clay Mold Bulk Recipe

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

    [RequiresSkill(typeof(FarmingSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Clay Mold Bulk Item")]
    public partial class ClayMoldBulkRecipe : RecipeFamily
    {
        public ClayMoldBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ClayMoldBulk",  //noloc
                displayName: Localizer.DoStr("Clay Mold Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ClayItem), 25, typeof(FarmingSkill)),		// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ClayMoldItem>(200)	// 4 x 25 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1250, typeof(FarmingSkill));	// 50 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ClayMoldBulkRecipe), start: 5.0f, skillType: typeof(FarmingSkill));	// 0.2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Clay Mold Bulk"), recipeType: typeof(ClayMoldBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(PotteryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}