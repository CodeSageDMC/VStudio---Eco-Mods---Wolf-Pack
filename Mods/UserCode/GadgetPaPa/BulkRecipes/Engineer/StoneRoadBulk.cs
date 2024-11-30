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

    [RequiresSkill(typeof(BasicEngineeringSkill), 3)]	// 1
    [Ecopedia("Blocks", "Roads", subPageName: "Stone Road Item")]
    public partial class StoneRoadBulkRecipe : RecipeFamily
    {
        public StoneRoadBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Stone Road",  //noloc
                displayName: Localizer.DoStr("Stone Road in Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(MortarItem), 3f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),	// 3 x 25
                    new IngredientElement("CrushedRock", 2f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)), //noloc	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<StoneRoadItem>(1f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkOutput)	// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.BulkMultiplier; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(60f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(StoneRoadBulkRecipe), start: 0.5f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkCraft, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));	// 0.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Stone Road in Bulk"), recipeType: typeof(StoneRoadBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(WainwrightTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

}
