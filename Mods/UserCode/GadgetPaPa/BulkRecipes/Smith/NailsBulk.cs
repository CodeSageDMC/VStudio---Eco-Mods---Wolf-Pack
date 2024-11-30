// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 25x with 3x output 

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

    [RequiresSkill(typeof(BlacksmithSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Nail Item Bulk")]
    public partial class NailBulkRecipe : RecipeFamily
    {
        public NailBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "NailBulk",  //noloc
                displayName: Localizer.DoStr("Nail Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 25, typeof(BlacksmithSkill), typeof(BlacksmithLavishResourcesTalent)),	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<NailItem>(1200)	// 16 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25.0f; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1250, typeof(BlacksmithSkill));	// 50 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(NailBulkRecipe), start: 20f, skillType: typeof(BlacksmithSkill), typeof(BlacksmithFocusedSpeedTalent), typeof(BlacksmithParallelSpeedTalent));	// 0.8 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Nail Bulk"), recipeType: typeof(NailBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}