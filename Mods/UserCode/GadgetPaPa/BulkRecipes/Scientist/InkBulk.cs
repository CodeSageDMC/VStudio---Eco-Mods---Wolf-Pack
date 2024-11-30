// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Ink Bulk Recipe 25x 3x Output

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

        
    [RequiresSkill(typeof(PaintingSkill), 6)]	// 4
    [Ecopedia("Items", "Products", subPageName: "Ink Item Bulk")]
    public partial class InkBulkRecipe : RecipeFamily
    {
        public InkBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "InkBulk",  //noloc
                displayName: Localizer.DoStr("Ink Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CharcoalPowderItem), 50, typeof(PaintingSkill), typeof(PaintingLavishResourcesTalent)),	// 2 x 25
                    new IngredientElement(typeof(GlassItem), 25, typeof(PaintingSkill), typeof(PaintingLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement("Oil", 25, typeof(PaintingSkill), typeof(PaintingLavishResourcesTalent)), // 1 x 25
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<InkItem>(150)	// 2 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(4500, typeof(PaintingSkill));	// 180 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(InkBulkRecipe), start: 25, skillType: typeof(PaintingSkill), typeof(PaintingFocusedSpeedTalent), typeof(PaintingParallelSpeedTalent)); // 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Ink Bulk"), recipeType: typeof(InkBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(PaintMixerObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}