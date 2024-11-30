// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Small Bulk Recipe 10x with 2x output

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
    using Eco.Shared.Graphics;
    using Eco.World.Color;

    [RequiresSkill(typeof(OilDrillingSkill), 4)]  // 2
    [Ecopedia("Blocks", "Liquids", subPageName: "Gasoline Small Bulk Item")]
    public partial class GasolineBulkRecipe : RecipeFamily
    {
        public GasolineBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "GasolineSmallBulk",  //noloc
                displayName: Localizer.DoStr("Gasoline Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PetroleumItem), 40, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GasolineItem>(20)  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1200, typeof(OilDrillingSkill));  // 120 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(GasolineBulkRecipe), start: 8.0f, skillType: typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent));  // 0.8 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Gasoline Small Bulk"), recipeType: typeof(GasolineBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(OilRefineryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
