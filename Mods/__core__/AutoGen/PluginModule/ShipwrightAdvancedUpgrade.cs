﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from PluginModuleTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
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

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>

    /// <summary>
    /// <para>Server side recipe definition for "ShipwrightAdvancedUpgrade".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(ShipwrightSkill), 7)]
    [Ecopedia("Upgrade Modules", "Specialty Upgrades", subPageName: "Shipwright Advanced Upgrade Item")]
    public partial class ShipwrightAdvancedUpgradeRecipe : RecipeFamily
    {
        public ShipwrightAdvancedUpgradeRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ShipwrightAdvancedUpgrade",  //noloc
                displayName: Localizer.DoStr("Shipwright Advanced Upgrade"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(AdvancedUpgradeLvl4Item), 1, true),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<ShipwrightAdvancedUpgradeItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(6000,typeof(ShipwrightSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ShipwrightAdvancedUpgradeRecipe), start: 15, skillType: typeof(ShipwrightSkill), typeof(ShipwrightFocusedSpeedTalent), typeof(ShipwrightParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Shipwright Advanced Upgrade"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Shipwright Advanced Upgrade"), recipeType: typeof(ShipwrightAdvancedUpgradeRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(MediumShipyardObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Shipwright Advanced Upgrade")]
    [LocDescription("Advanced Upgrade that greatly increases efficiency when crafting Shipwright recipes.")]
    [Weight(1)]
    [Ecopedia("Upgrade Modules", "Specialty Upgrades", createAsSubPage: true)]                                                                      //_If_EcopediaPage_
    [Tag("Upgrade")]
    public partial class ShipwrightAdvancedUpgradeItem :
        EfficiencyModule
    {

        public ShipwrightAdvancedUpgradeItem() : base(
            ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency,
            0.5f + 0.05f,
            typeof(ShipwrightSkill),
            0.5f         
        ) { }
    }
}
