﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from ToolTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Internal;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Shared.Math;
    using Eco.Core.Controller;
    using Eco.Gameplay.Interactions.Interactors;
    using Eco.Gameplay.Items.Recipes;


    /// <summary>
    /// <para>Server side recipe definition for "StoneMachete".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Ecopedia("Items", "Tools", subPageName: "Stone Machete Item")]
    public partial class StoneMacheteRecipe : RecipeFamily
    {
        public StoneMacheteRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "StoneMachete",  //noloc
                displayName: Localizer.DoStr("Stone Machete"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 8,typeof(Skill)), //noloc
                    new IngredientElement("Rock", 20,typeof(Skill)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<StoneMacheteItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(10);

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(0.5f);

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Stone Machete"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Stone Machete"), recipeType: typeof(StoneMacheteRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(ToolBenchObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Stone Machete")]
    [LocDescription("A machete used to quickly clear plants.")]
    [Tier(1)]
    [RepairRequiresSkill(typeof(SelfImprovementSkill), 0)]
    [Weight(1000)]
    [Category("Tool")]
    [Tag("Tool")]
    [Ecopedia("Items", "Tools", createAsSubPage: true)]
    public partial class StoneMacheteItem : MacheteItem
    {

                                                                                                                                                                                                                                           // Static values
        private static IDynamicValue caloriesBurn           = new MultiDynamicValue(MultiDynamicOps.Multiply, new TalentModifiedValue(typeof(StoneMacheteItem), typeof(GatheringToolEfficiencyTalent)), CreateCalorieValue(20, typeof(FarmingSkill), typeof(StoneMacheteItem)));
        private static IDynamicValue exp                    = new ConstantValue(0.05f);
        private static IDynamicValue tier                   = new ConstantValue(1);
        private static IDynamicValue skilledRepairCost      = new ConstantValue(2);


        // Tool overrides

        public override IDynamicValue CaloriesBurn      => caloriesBurn;
        public override Type ExperienceSkill            => typeof(FarmingSkill);
        public override IDynamicValue ExperienceRate    => exp;
        public override IDynamicValue Tier              => tier;
        public override IDynamicValue SkilledRepairCost => skilledRepairCost;
        public override float OriginalMaxDurability     => 400f;
        public override int FullRepairAmount            => 2;

        // This handles multiple repair elements and how much reduction in cost of the material type
        // meaning 1 = full cost and .1 = 10% of the total cost for 100% repair.
        public override IEnumerable<RepairingItem> RepairItems {get
        {
                yield return new() { Item = Item.Get("CoarseStoneItem"), MaterialMult = 2 };
        yield return new() { Item = Item.Get("WhetstoneItem"), MaterialMult = 2 };
        } }
    }
}
