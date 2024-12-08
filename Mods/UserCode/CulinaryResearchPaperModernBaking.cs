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

        
  
    [RequiresSkill(typeof(AdvancedBakingSkill), 2)]
    [Ecopedia("Items", "Research Papers", subPageName: "Culinary Research Paper Modern Bakery Item")]
    public partial class CulinaryResearchPaperModernBakeryRecipe : RecipeFamily
    {
        public CulinaryResearchPaperModernBakeryRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CulinaryResearchPaperModernBakery",  //noloc
                displayName: Localizer.DoStr("Culinary Research Paper Modern Bakery"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CornFrittersItem), 10, true),
                    new IngredientElement(typeof(FruitTartItem), 10, true),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<CulinaryResearchPaperModernItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 6; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(600, typeof(AdvancedBakingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CulinaryResearchPaperModernBakeryRecipe), start: 1, skillType: typeof(AdvancedBakingSkill), typeof(AdvancedBakingFocusedSpeedTalent), typeof(AdvancedBakingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Culinary Research Paper Modern"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Culinary Research Paper Modern Baking"), recipeType: typeof(CulinaryResearchPaperModernBakeryRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(LaboratoryObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
    

    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Culinary Research Paper Modern Bakery")] // Defines the localized name of the item.
    [Weight(10)] // Defines how heavy CulinaryResearchPaperModern is.
    [Ecopedia("Items", "Research Papers", createAsSubPage: true)]
    [Tag("Modern Research")]
    [Tag("Research")]
    public partial class CulinaryResearchPaperModernBakeryItem : Item
    {


    }
}
