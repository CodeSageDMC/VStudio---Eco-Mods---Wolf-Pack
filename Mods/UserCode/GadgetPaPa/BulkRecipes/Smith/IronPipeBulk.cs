// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output 

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
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(SmeltingSkill), 3)]	// 1
    [Ecopedia("Blocks", "Pipes", subPageName: "Iron Pipe Item Small Bulk")]
    public partial class IronPipeSBulkRecipe : RecipeFamily
    {
        public IronPipeSBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronPipeSmallBulk",  //noloc
                displayName: Localizer.DoStr("Iron Pipe Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 10, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronPipeItem>(20)		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(SmeltingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronPipeSBulkRecipe), start: 8f, skillType: typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));	// 0.8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Iron Pipe Small Bulk"), recipeType: typeof(IronPipeSBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
