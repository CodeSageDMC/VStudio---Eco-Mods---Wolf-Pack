// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// 

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

        
    [RequiresSkill(typeof(OilDrillingSkill), 3)]		// 1
    [Ecopedia("Items", "Products", subPageName: "Nylon Bulk Item")]
    public partial class NylonBulkRecipe : RecipeFamily
    {
        public NylonBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "NylonBulk",  //noloc
                displayName: Localizer.DoStr("Nylon Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PetroleumItem), 100, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)),	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<NylonItem>(600),		// 8 x 25 x 3 Boosted
                    new CraftingElement<BarrelItem>(typeof(OilDrillingSkill), 75, typeof(OilDrillingLavishResourcesTalent)),	// 3 x 25
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25;	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(4500, typeof(OilDrillingSkill));	// 180 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(NylonBulkRecipe), start: 37.5f, skillType: typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent));	// 1.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Nylon Bulk"), recipeType: typeof(NylonBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(OilRefineryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}