// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x with 1.5x output

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
    using Eco.Shared.Graphics;
    using Eco.World.Color;

    [Ecopedia("Blocks", "Building Materials", subPageName: "Adobe Tiny Bulk Item")]
    public partial class AdobeBulkRecipe : RecipeFamily
    {
        public AdobeBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AdobeTinyBulk",  //noloc
                displayName: Localizer.DoStr("Adobe Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(DirtItem), 10,typeof(Skill)),  // 1 x 10
                    new IngredientElement("Wood", 10,typeof(Skill)), // 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<AdobeItem>(60)  // 4 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(200);  // 20 x 10
            this.CraftMinutes = CreateCraftTimeValue(01.6f);  // 0.16 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Adobe Tiny Bulk"), recipeType: typeof(AdobeBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(WorkbenchObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
