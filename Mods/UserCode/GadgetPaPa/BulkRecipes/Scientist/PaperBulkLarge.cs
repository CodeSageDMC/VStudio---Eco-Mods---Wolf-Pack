// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Paper Large Bulk Recipe 50x 3x output

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

        
    [RequiresSkill(typeof(PaintingSkill), 6)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Paper Bulk Large Item")]
    public partial class PaperBulkLargeRecipe : RecipeFamily
    {
        public PaperBulkLargeRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PaperBulkLarge",  //noloc
                displayName: Localizer.DoStr("Paper Bulk Large"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CelluloseFiberItem), 100, typeof(PaintingSkill), typeof(PaintingLavishResourcesTalent)),	// 2 x 100
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PaperItem>(300)	// 1 x 100 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 50; // 1 x 50
            this.LaborInCalories = CreateLaborInCaloriesValue(2000, typeof(PaintingSkill)); // 20 x 50
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PaperBulkLargeRecipe), start: 10f, skillType: typeof(PaintingSkill), typeof(PaintingFocusedSpeedTalent), typeof(PaintingParallelSpeedTalent));	// 0.1 x 50
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Paper Bulk Large"), recipeType: typeof(PaperBulkLargeRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(PaperMachineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}