﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from FoodTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.Time;
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;


    


    //Item

    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Food Coloring")] // Defines the localized name of the FoodColoring.
    [Weight(300)] // Defines how heavy the FoodColoring is.

    [Ecopedia("Food", "Product", createAsSubPage: true)]
    [LocDescription("A different assortment of artificial food coloring.")] //The tooltip description for the food FoodColoring.
    public partial class FoodColoringItem : FoodItem
    {


        /// <summary>The amount of calories awarded for eating the food FoodColoring.</summary>
        public override float Calories => 0;
        /// <summary>The nutritional value of the food FoodColoring.</summary>
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 0, Protein = 0, Vitamins = 0 };

        /// <summary>Defines the default time it takes for this FoodColoring to spoil. This value can be modified by the inventory this FoodColoring currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }


    //Recipe


    [RequiresSkill(typeof(BiochemistSkill), 2)]
    [Ecopedia("Food", "Ingredient", subPageName: "Food Coloring Item")]
    public partial class FoodColoringRecipe : RecipeFamily
    {
        public FoodColoringRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FoodColoring",  //noloc
                displayName: Localizer.DoStr("Food Coloring"),

                // Defines the ingredients needed to craft this recipe. An ingredient FoodColorings takes the following inputs
                // type of the FoodColoring, the amount of the FoodColoring, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PetroleumItem), 1, typeof(BiochemistSkill), typeof(BiochemistLavishResourcesTalent)),
                    
                },

                // Define our recipe output FoodColorings.
                // For every output FoodColoring there needs to be one CraftingElement entry with the type of the final FoodColoring and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<FoodColoringItem>(50),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.

            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(800, typeof(BiochemistSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FoodColoringRecipe), start: 6f, skillType: typeof(BiochemistSkill), typeof(BiochemistFocusedSpeedTalent), typeof(BiochemistParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "FoodColoring"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Food Coloring"), recipeType: typeof(FoodColoringRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(ChemicalLaboratoryObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }



}