// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe  10x 1.5x Output

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
    using static Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(PaintingSkill), 3)]  // 1
    [Ecopedia("Housing Objects", "Outdoor", subPageName: "Large Paper Lantern Tiny Bulk Item")]
    public partial class LargePaperLanternBulkRecipe : RecipeFamily
    {
        public LargePaperLanternBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "LargePaperLanternTinyBulk",  //noloc
                displayName: Localizer.DoStr("Large Paper Lantern Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PaperItem), 200, typeof(PaintingSkill), typeof(PaintingLavishResourcesTalent)),	// 20 x 10
                    new IngredientElement(typeof(CottonFabricItem), 80, typeof(PaintingSkill), typeof(PaintingLavishResourcesTalent)),  // 8 x 10
                    new IngredientElement(typeof(LightBulbItem), 10, true),  // 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<LargePaperLanternItem>(15)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(PaintingSkill));  // 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(LargePaperLanternBulkRecipe), start: 10, skillType: typeof(PaintingSkill), typeof(PaintingFocusedSpeedTalent), typeof(PaintingParallelSpeedTalent));  // 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Large Paper Lantern Tiny Bulk"), recipeType: typeof(LargePaperLanternBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SmallPaperMachineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
