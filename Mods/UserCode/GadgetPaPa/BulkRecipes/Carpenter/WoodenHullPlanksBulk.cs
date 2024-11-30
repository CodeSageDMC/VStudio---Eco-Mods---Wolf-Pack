// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Hull Planks  10x, 2x more output

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

        
    [RequiresSkill(typeof(ShipwrightSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Wooden Hull Planks Bulk Item")]
    public partial class WoodenHullPlanksBulkRecipe : RecipeFamily
    {
        public WoodenHullPlanksBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WoodenHullPlanksBulk",  //noloc
                displayName: Localizer.DoStr("Wooden Hull Planks Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("HewnLog", 40, typeof(ShipwrightSkill), typeof(ShipwrightLavishResourcesTalent)), // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodenHullPlanksItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(ShipwrightSkill));	// 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WoodenHullPlanksBulkRecipe), start: 10, skillType: typeof(ShipwrightSkill), typeof(ShipwrightFocusedSpeedTalent), typeof(ShipwrightParallelSpeedTalent));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Wooden Hull Planks Small Bulk"), recipeType: typeof(WoodenHullPlanksBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SmallShipyardObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}