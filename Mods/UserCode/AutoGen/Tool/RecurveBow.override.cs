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
    /// <para>Server side recipe definition for "RecurveBow".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(HuntingSkill), 3)]
    [Ecopedia("Items", "Tools", subPageName: "Recurve Bow Item")]
    public partial class RecurveBowRecipe : RecipeFamily
    {
        public RecurveBowRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RecurveBow",  //noloc
                displayName: Localizer.DoStr("Recurve Bow"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 20,typeof(HuntingSkill)),
                    new IngredientElement(typeof(LinenYarnItem), 20,typeof(HuntingSkill)),
                    new IngredientElement(typeof(LeatherHideItem), 6,typeof(HuntingSkill)),
                    new IngredientElement("Lumber", 5,typeof(HuntingSkill)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<RecurveBowItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(250,typeof(HuntingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RecurveBowRecipe), start: 0.5f, skillType: typeof(HuntingSkill));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Recurve Bow"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Recurve Bow"), recipeType: typeof(RecurveBowRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(FletchingTableObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Recurve Bow")]
    [LocDescription("A recurve bow that shoots faster and more powerful than a traditional wooden bow. Requires arrows to fire.")]
    [Tier(3)]
    [RepairRequiresSkill(typeof(SelfImprovementSkill), 0)]
    [Weight(1000)]
    [Category("Tool")]
    [Tag("Tool")]
    [Ecopedia("Items", "Tools", createAsSubPage: true)]
    public partial class RecurveBowItem : BowItem
    {

        [SyncToView] public override float FireVelocity      => 65f;
        [SyncToView] public override float DrawTime          => 1f;
        [SyncToView] public override string ArrowPrefab      => "ArrowIron";
                                                                                                                                                                                                                                           // Static values
        private static IDynamicValue caloriesBurn           = new MultiDynamicValue(MultiDynamicOps.Multiply, new TalentModifiedValue(typeof(RecurveBowItem), typeof(ToolEfficiencyTalent)), CreateCalorieValue(20, typeof(HuntingSkill), typeof(RecurveBowItem)));
        private static IDynamicValue damage                 = CreateDamageValue(1.2f, typeof(HuntingSkill), typeof(RecurveBowItem));
        private static IDynamicValue exp                    = new ConstantValue(1);
        private static IDynamicValue tier                   = new ConstantValue(3);
        private static SkillModifiedValue skilledRepairCost = new SkillModifiedValue(2, HuntingSkill.MultiplicativeStrategy, typeof(HuntingSkill), typeof(RecurveBowItem), Localizer.DoStr("repair cost"), DynamicValueType.Efficiency);


        // Tool overrides

        public override IDynamicValue CaloriesBurn      => caloriesBurn;
        public override IDynamicValue Damage            => damage;
        public override Type ExperienceSkill            => typeof(HuntingSkill);
        public override IDynamicValue ExperienceRate    => exp;
        public override IDynamicValue Tier              => tier;
        public override IDynamicValue SkilledRepairCost => skilledRepairCost;
        public override float OriginalMaxDurability     => 2000f;
        public override int FullRepairAmount            => 2;

        // This handles multiple repair elements and how much reduction in cost of the material type
        // meaning 1 = full cost and .1 = 10% of the total cost for 100% repair.
        public override IEnumerable<RepairingItem> RepairItems {get
        {
                yield return new() { Item = Item.Get("LinenYarnItem"), MaterialMult = 1 };
        } }
    }
}
