﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from ItemTemplate.tt/>

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

    [RequiresSkill(typeof(HuntingSkill), 3)]
    public partial class BreedBassRecipe : RecipeFamily
    {
        public BreedBassRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BreedBass", 
                displayName: Localizer.DoStr("Breed Bass"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BassItem), 2, typeof(HuntingSkill), typeof(HuntingLavishResourcesTalent)),
                    new IngredientElement(typeof(FishFoodItem), 2, typeof(HuntingSkill), typeof(HuntingLavishResourcesTalent)),
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<BassItem>(3)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2; 
            
            this.LaborInCalories = CreateLaborInCaloriesValue(75, typeof(HuntingSkill));

            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BreedBassRecipe), start: 15f, skillType: typeof(HuntingSkill), typeof(HuntingFocusedSpeedTalent), typeof(HuntingParallelSpeedTalent));

            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Breed Bass"), recipeType: typeof(BreedBassRecipe));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(PondObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();


    }
}