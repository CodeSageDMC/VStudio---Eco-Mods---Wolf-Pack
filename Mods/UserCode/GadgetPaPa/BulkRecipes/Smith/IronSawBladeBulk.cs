// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Small Bulk Recipe 10x 2x Output

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

        
    [RequiresModule(typeof(BloomeryObject))]
    [RequiresSkill(typeof(BlacksmithSkill), 4)]  // 2
    [Ecopedia("Items", "Products", subPageName: "Iron Saw Blade Small Bulk Item")]
    public partial class IronSawBladeBulkRecipe : RecipeFamily
    {
        public IronSawBladeBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronSawBladeSmallBulk",  //noloc
                displayName: Localizer.DoStr("Iron Saw Blade Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 60, typeof(BlacksmithSkill), typeof(BlacksmithLavishResourcesTalent)),  // 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronSawBladeItem>(20)  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 20; // 2 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(BlacksmithSkill));  // 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronSawBladeBulkRecipe), start: 12.0f, skillType: typeof(BlacksmithSkill), typeof(BlacksmithFocusedSpeedTalent), typeof(BlacksmithParallelSpeedTalent));  // 1.2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Iron Saw Blade Small Bulk"), recipeType: typeof(IronSawBladeBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}