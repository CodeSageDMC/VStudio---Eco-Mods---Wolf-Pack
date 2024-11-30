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

        
    /// <summary>
    /// <para>Server side recipe definition for "SteamTractorSower".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(MechanicsSkill), 2)]
    [Ecopedia("Items", "Tools", subPageName: "Steam Tractor Sower Item")]
    public partial class SteamTractorSowerRecipe : RecipeFamily
    {
        public SteamTractorSowerRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteamTractorSower",  //noloc
                displayName: Localizer.DoStr("Steam Tractor Sower"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronPlateItem), 8, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),
                    new IngredientElement(typeof(ScrewsItem), 18, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),
                    new IngredientElement(typeof(IronPipeItem), 8, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteamTractorSowerItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(120, typeof(MechanicsSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteamTractorSowerRecipe), start: 2, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Steam Tractor Sower"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steam Tractor Sower"), recipeType: typeof(SteamTractorSowerRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(AssemblyLineObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
    
    /// <summary>
    /// <para>Server side item definition for the "SteamTractorSower" item.</para>
    /// <para>More information about VehicleToolItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.VehicleToolItem.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Steam Tractor Sower")] // Defines the localized name of the item.
    [Weight(10000)] // Defines how heavy SteamTractorSower is.
    [RepairRequiresSkill(typeof(MechanicsSkill), 0)]
    [Category("Tool")] // Overrides internal inherited hidden categorization from abstract parents.
    [Ecopedia("Items", "Tools", createAsSubPage: true)]
    [Tag("Tool")]
    [LocDescription("An attachment for the steam tractor that allows for quick planting of seeds.")] //The tooltip description for the item.
    public partial class SteamTractorSowerItem : VehicleToolItem    {
        private static SkillModifiedValue skilledRepairCost = new SkillModifiedValue(2, MechanicsSkill.MultiplicativeStrategy, typeof(MechanicsSkill), typeof(SteamTractorSowerItem), Localizer.DoStr("repair cost"), DynamicValueType.Efficiency);

        public override float OriginalMaxDurability     => 5000f;
        public override IDynamicValue SkilledRepairCost => skilledRepairCost;
        public override int FullRepairAmount            => 2;

        // This handles multiple repair elements and how much reduction in cost of the material type
        // meaning 1 = full cost and .1 = 10% of the total cost for 100% repair.
        public override IEnumerable<RepairingItem> RepairItems {get
        {
                    yield return new() { Item = Item.Get("IronPlateItem"), MaterialMult = 1 };
        } }
    }
}