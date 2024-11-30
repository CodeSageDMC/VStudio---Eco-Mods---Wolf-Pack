// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Small Bulk Recipe

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

        
    [RequiresModule(typeof(PowerHammerObject))]
    [RequiresSkill(typeof(AdvancedSmeltingSkill), 4)]	// 2
    [Ecopedia("Items", "Products", subPageName: "Rivet Item Bulk")]
    public partial class RivetBulkRecipe : RecipeFamily
    {
        public RivetBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Rivet Small Bulk",  //noloc
                displayName: Localizer.DoStr("Rivet Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 25, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    // if you want to increase the output quantity change the number between the () braces below
					new CraftingElement<RivetItem>(225)	// 3 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2125, typeof(AdvancedSmeltingSkill));	// 85 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RivetBulkRecipe), start: 20.0f, skillType: typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));	// 0.8 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Rivet Bulk"), recipeType: typeof(RivetBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BlastFurnaceObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}