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

        
    [RequiresModule(typeof(MachinistTableObject))]
    [RequiresSkill(typeof(MechanicsSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Copper Plate Item Bulk")]
    public partial class CopperPlateBulkRecipe : RecipeFamily
    {
        public CopperPlateBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CopperPlateBulk",  //noloc
                displayName: Localizer.DoStr("Copper Plate Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CopperBarItem), 1f*BulkRecipeSettings.BulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CopperPlateItem>(1f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkOutput)	// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.BulkMultiplier; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(60f*BulkRecipeSettings.BulkMultiplier, typeof(MechanicsSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CopperPlateBulkRecipe), start: 2f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkCraft, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));	// 2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Copper Plate Bulk"), recipeType: typeof(CopperPlateBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ScrewPressObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

}