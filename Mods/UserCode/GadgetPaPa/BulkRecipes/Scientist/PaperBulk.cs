// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Paper Bulk Recipe 25x 3x output

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

        
    [RequiresSkill(typeof(PaintingSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Paper Bulk Item")]
    public partial class PaperBulkRecipe : RecipeFamily
    {
        public PaperBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PaperBulk",  //noloc
                displayName: Localizer.DoStr("Paper Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CelluloseFiberItem), 50, typeof(PaintingSkill), typeof(PaintingLavishResourcesTalent)),	// 2 x 50
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PaperItem>(75)	// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(PaintingSkill)); // 20 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PaperBulkRecipe), start: 2.5f, skillType: typeof(PaintingSkill), typeof(PaintingFocusedSpeedTalent), typeof(PaintingParallelSpeedTalent));	// 0.1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Paper Bulk"), recipeType: typeof(PaperBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SmallPaperMachineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}