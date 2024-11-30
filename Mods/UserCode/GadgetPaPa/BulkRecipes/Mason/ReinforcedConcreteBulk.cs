// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 25x with 3x Output

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

    [RequiresSkill(typeof(MasonrySkill), 3)]	// 1
    [Ecopedia("Blocks", "Building Materials", subPageName: "Reinforced Concrete Item")]
    public partial class ReinforcedConcreteBulkRecipe : RecipeFamily
    {
        public ReinforcedConcreteBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ReinforcedConcreteBulk",  //noloc
                displayName: Localizer.DoStr("Reinforced Concrete Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CementItem), 25, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement(typeof(RebarItem), 50, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),		// 2 x 25
                    new IngredientElement(typeof(SandItem), 50, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),		// 2 x 25
                    new IngredientElement("CrushedRock", 125, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)), //noloc	// 5 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ReinforcedConcreteItem>(375)		// 5 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; 	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(625, typeof(MasonrySkill));	// 25 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ReinforcedConcreteBulkRecipe), start: 16f, skillType: typeof(MasonrySkill), typeof(MasonryFocusedSpeedTalent), typeof(MasonryParallelSpeedTalent)); 	// 0.64 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Reinforced Concrete Bulk"), recipeType: typeof(ReinforcedConcreteBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CementKilnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
