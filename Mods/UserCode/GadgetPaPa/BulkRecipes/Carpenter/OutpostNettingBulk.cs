﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk 10x with 1.5x output

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Shared.Networking;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.Core.Utils;
	using Eco.Gameplay.Components.Storage;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(ShipwrightSkill), 3)]  // 1
    [Ecopedia("Crafted Objects", "Storage", subPageName: "Outpost Netting Item")]
    public partial class OutpostNettingBulkRecipe : RecipeFamily
    {
        public OutpostNettingBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "OutpostNettingTinyBulk",  //noloc
                displayName: Localizer.DoStr("Outpost Netting Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(HempMooringRopeItem), 6f*BulkRecipeSettings.TinyBulkMultiplier, typeof(ShipwrightSkill), typeof(ShipwrightLavishResourcesTalent)),  // 6 x 10
                    new IngredientElement("HewnLog", 8f*BulkRecipeSettings.TinyBulkMultiplier, typeof(ShipwrightSkill), typeof(ShipwrightLavishResourcesTalent)), // 8 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OutpostNettingItem>(1f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkOutput)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2f*BulkRecipeSettings.TinyBulkMultiplier; // 2 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(180f*BulkRecipeSettings.TinyBulkMultiplier, typeof(ShipwrightSkill));  // 180 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(OutpostNettingBulkRecipe), start: 5f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkCraft, skillType: typeof(ShipwrightSkill), typeof(ShipwrightFocusedSpeedTalent), typeof(ShipwrightParallelSpeedTalent));  // 5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Outpost Netting Tiny Bulk"), recipeType: typeof(OutpostNettingBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SmallShipyardObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}