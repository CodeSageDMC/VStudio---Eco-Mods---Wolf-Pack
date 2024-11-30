// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk recipe 1 x 10 with 1.5x putput

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

        
    [RequiresSkill(typeof(OilDrillingSkill), 3)]  //1
    [Ecopedia("Items", "Products", subPageName: "Nitric Acid Tiny Bulk Item")]
    public partial class NitricAcidBulkRecipe : RecipeFamily
    {
        public NitricAcidBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "NitricAcidTinyBulk",  //noloc
                displayName: Localizer.DoStr("Nitric Acid Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CompostItem), 4f*BulkRecipeSettings.TinyBulkMultiplier, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)),  // 4 x 10
                    new IngredientElement(typeof(CrushedCopperOreItem), 2f*BulkRecipeSettings.TinyBulkMultiplier, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)),  // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<NitricAcidItem>(1f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkOutput)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.TinyBulkMultiplier; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(50f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkCraft, typeof(OilDrillingSkill));  // 50 x 10 x 1
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(NitricAcidBulkRecipe), start: 1, skillType: typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Nitric Acid Tiny Bulk"), recipeType: typeof(NitricAcidBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(OilRefineryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}