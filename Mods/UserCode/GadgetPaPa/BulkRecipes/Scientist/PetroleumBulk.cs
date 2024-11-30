// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Small Bulk 10x with 2x Output

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

    [RequiresSkill(typeof(OilDrillingSkill), 3)]  // 1
    [Ecopedia("Blocks", "Liquids", subPageName: "Petroleum Small Bulk Item")]
    public partial class PetroleumBulkRecipe : RecipeFamily
    {
        public PetroleumBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PetroleumSmallBulk",  //noloc
                displayName: Localizer.DoStr("Petroleum Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BarrelItem), 10, true),  // 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PetroleumItem>(20)  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(OilDrillingSkill)); // 60 x 100
            this.CraftMinutes = new MultiDynamicValue(MultiDynamicOps.Multiply,
                CreateCraftTimeValue(beneficiary: typeof(PetroleumBulkRecipe), start: 300, skillType: typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent)),  // 30 x 10
                new LayerModifiedValue(Eco.Simulation.WorldLayers.LayerNames.Oilfield,30)  // 3 x 10
            );
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Petroleum Small Bulk"), recipeType: typeof(PetroleumBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(PumpJackObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
