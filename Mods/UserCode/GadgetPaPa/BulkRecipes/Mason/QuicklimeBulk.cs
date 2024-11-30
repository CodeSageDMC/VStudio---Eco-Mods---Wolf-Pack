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

        
    [RequiresSkill(typeof(MasonrySkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Quicklime Bulk Item")]
    public partial class QuicklimeBulkRecipe : RecipeFamily
    {
        public QuicklimeBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "QuicklimeBulk",  //noloc
                displayName: Localizer.DoStr("Quicklime Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CrushedLimestoneItem), 25, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<QuicklimeItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2.5f;	// 0.1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1250, typeof(MasonrySkill));	// 50 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(QuicklimeBulkRecipe), start: 05f, skillType: typeof(MasonrySkill), typeof(MasonryFocusedSpeedTalent), typeof(MasonryParallelSpeedTalent));	// 0.2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Quicklime Bulk"), recipeType: typeof(QuicklimeBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BlastFurnaceObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}