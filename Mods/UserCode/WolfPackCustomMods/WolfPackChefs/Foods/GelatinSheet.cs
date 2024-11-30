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


    /// <summary>
    /// <para>
    /// Server side food GelatinSheet definition for the "GelatinSheet" GelatinSheet. 
    /// This object inherits the FoodGelatinSheet base class to allow for consumption mechanics.
    /// </para>
    /// <para>More information about FoodGelatinSheet objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.GelatinSheets.FoodGelatinSheet.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Gelatin Sheet")] // Defines the localized name of the GelatinSheet.
    [Weight(300)] // Defines how heavy the GelatinSheet is.

    [Ecopedia("Food", "Product", createAsSubPage: true)]
    [LocDescription("Evaporated Gelatin Liquid, leaving sheets of solid Gelatin.")] //The tooltip description for the food GelatinSheet.
    public partial class GelatinSheetItem : FoodItem
    {


        /// <summary>The amount of calories awarded for eating the food GelatinSheet.</summary>
        public override float Calories => 0;
        /// <summary>The nutritional value of the food GelatinSheet.</summary>
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 0, Protein = 0, Vitamins = 0 };

        /// <summary>Defines the default time it takes for this GelatinSheet to spoil. This value can be modified by the inventory this GelatinSheet currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(120);
    }


    
    [RequiresSkill(typeof(AdvancedBakingSkill), 2)]
    public partial class GelatinSheetRecipe : RecipeFamily
    {
        public GelatinSheetRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "GelatinSheet",  //noloc
                displayName: Localizer.DoStr("Evaporate Gelatin Liquid"),

                // Defines the ingredients needed to craft this recipe. An ingredient GelatinSheets takes the following inputs
                // type of the GelatinSheet, the amount of the GelatinSheet, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GelatinLiquidItem), 20, typeof(AdvancedBakingSkill), typeof(AdvancedBakingLavishResourcesTalent)),
                    new IngredientElement(typeof(CheeseclothItem), 2, true),

                },

                // Define our recipe output GelatinSheets.
                // For every output GelatinSheet there needs to be one CraftingElement entry with the type of the final GelatinSheet and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<GelatinSheetItem>(5),
                    new CraftingElement<CheeseclothItem>(2),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.

            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(800, typeof(AdvancedBakingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(GelatinSheetRecipe), start: 6f, skillType: typeof(AdvancedBakingSkill), typeof(AdvancedBakingFocusedSpeedTalent), typeof(AdvancedBakingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "GelatinSheet"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Evaporate Gelatin Liquid"), recipeType: typeof(GelatinSheetRecipe));
            this.ModsPostInitialize();

    // Register our RecipeFamily instance with the crafting system so it can be crafted.
    CraftingComponent.AddRecipe(tableType: typeof(StoveObject), recipe: this);
    }

    /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
    partial void ModsPreInitialize();

    /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
    partial void ModsPostInitialize();
}



}
