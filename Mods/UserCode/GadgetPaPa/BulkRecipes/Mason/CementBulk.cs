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

        
    [RequiresSkill(typeof(MasonrySkill), 6)]	// 4
    [Ecopedia("Items", "Products", subPageName: "Cement Item")]
    public partial class CementBulkRecipe : RecipeFamily
    {
        public CementBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Cement",  //noloc
                displayName: Localizer.DoStr("Cement in bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(QuicklimeItem), 62.5f, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),	// 2.5 x 25
                    new IngredientElement(typeof(ClayItem), 25, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),		// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CementItem>(150)	// 2 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25;	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1750, typeof(MasonrySkill));	// 70 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CementBulkRecipe), start: 40f, skillType: typeof(MasonrySkill), typeof(MasonryFocusedSpeedTalent), typeof(MasonryParallelSpeedTalent)); 	// 1.6 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Cement in bulk"), recipeType: typeof(CementBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CementKilnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
    
}