// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe Asphalt Concrete 
// This recipe is 5x the output labor is only 2500 not 4500 and time lowered from 1 hour to 30 min

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
    [Ecopedia("Blocks", "Roads", subPageName: "Asphalt Concrete Item")]
    public partial class AsphaltConcreteBulkRecipe : RecipeFamily
    {
        public AsphaltConcreteBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Asphalt Concrete",  //noloc
                displayName: Localizer.DoStr("Asphalt Concrete in bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CementItem), 1f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement(typeof(SandItem), 2f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),			// 2 x 25
                    new IngredientElement("CrushedRock", 5f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)), //noloc	// 5 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<AsphaltConcreteItem>(2f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkOutput*2)	// 2 x 25 x 6
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1.5f*BulkRecipeSettings.BulkMultiplier; 	// 1.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(180f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill));	// 180 x 25  made it 2500
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AsphaltConcreteBulkRecipe), start: 2f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkCraft, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));	// 2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Asphalt Concrete in bulk"), recipeType: typeof(AsphaltConcreteBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(WainwrightTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
