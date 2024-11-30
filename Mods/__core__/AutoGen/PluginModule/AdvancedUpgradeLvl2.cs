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
    /// <para>Server side recipe definition for "AdvancedUpgradeLvl2".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(SelfImprovementSkill), 1)]
    [Ecopedia("Upgrade Modules", "Advanced Upgrades", subPageName: "Advanced Upgrade 2 Item")]
    public partial class AdvancedUpgradeLvl2Recipe : RecipeFamily
    {
        public AdvancedUpgradeLvl2Recipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AdvancedUpgradeLvl2",  //noloc
                displayName: Localizer.DoStr("Advanced Upgrade 2"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(AgricultureResearchPaperModernItem), 1, true),
                    new IngredientElement(typeof(AdvancedUpgradeLvl1Item), 1, true),
                    new IngredientElement("Basic Research", 1, true), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<AdvancedUpgradeLvl2Item>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(90,typeof(SelfImprovementSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AdvancedUpgradeLvl2Recipe), start: 6, skillType: typeof(SelfImprovementSkill));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Advanced Upgrade 2"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Advanced Upgrade 2"), recipeType: typeof(AdvancedUpgradeLvl2Recipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(LaboratoryObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Advanced Upgrade 2")]
    [LocDescription("Advanced Upgrade that increases crafting efficiency.")]
    [Weight(1)]
    [Ecopedia("Upgrade Modules", "Advanced Upgrades", createAsSubPage: true)]                                                                      //_If_EcopediaPage_
    [Tag("Upgrade")]
    [Tag("AdvancedUpgrade")]
    public partial class AdvancedUpgradeLvl2Item :
        EfficiencyModule
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Advanced Upgrade 2"); } }

        public AdvancedUpgradeLvl2Item() : base(
            ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency,
            0.75f         
        ) { }
    }
}
