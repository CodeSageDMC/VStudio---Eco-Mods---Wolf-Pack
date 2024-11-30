﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from TechTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Items;
    using Eco.Core.Utils;
    using Eco.Core.Utils.AtomicAction;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Services;
    using Eco.Shared.Utils;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
    [Serialized]
    [LocDisplayName("Smelting")]
    [LocDescription("Metal is an important part of progress and smelting is the first step into a new age. Levels up by crafting related recipes.")]
    [Ecopedia("Professions", "Smith", createAsSubPage: true)]
    [RequiresSkill(typeof(SmithSkill), 0), Tag("Smith Specialty"), Tier(3)]
    [Tag("Specialty")]
    [Tag("Teachable")]
    public partial class SmeltingSkill : Skill
    {

        public override void OnLevelUp(User user)
        {
            user.Skillset.AddExperience(typeof(SelfImprovementSkill), 20, Localizer.DoStr("for leveling up another specialization."));
        }


        public static MultiplicativeStrategy MultiplicativeStrategy =
            new MultiplicativeStrategy(new float[] { 
                1,
                1 - 0.2f,
                1 - 0.25f,
                1 - 0.3f,
                1 - 0.35f,
                1 - 0.4f,
                1 - 0.45f,
                1 - 0.5f,
            });
        public override MultiplicativeStrategy MultiStrategy => MultiplicativeStrategy;

        public static AdditiveStrategy AdditiveStrategy =
            new AdditiveStrategy(new float[] { 
                0,
                0.5f,
                0.55f,
                0.6f,
                0.65f,
                0.7f,
                0.75f,
                0.8f,
            });
        public override AdditiveStrategy AddStrategy => AdditiveStrategy;
        public override int MaxLevel { get { return 7; } }
        public override int Tier { get { return 3; } }
    }

    [Serialized]
    [Weight(1000)]
    [LocDisplayName("Smelting Skill Book")]
    [Ecopedia("Items", "Skill Books", createAsSubPage: true)]
    public partial class SmeltingSkillBook : SkillBook<SmeltingSkill, SmeltingSkillScroll> {}

    [Serialized]
    [Weight(100)]
    [LocDisplayName("Smelting Skill Scroll")]
    public partial class SmeltingSkillScroll : SkillScroll<SmeltingSkill, SmeltingSkillBook> {}


    /// <summary>
    /// <para>Server side recipe definition for "Smelting".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(MiningSkill), 1)]
    [Ecopedia("Professions", "Smith", subPageName: "Smelting Skill Book Item")]
    public partial class SmeltingSkillBookRecipe : RecipeFamily
    {
        public SmeltingSkillBookRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Smelting",  //noloc
                displayName: Localizer.DoStr("Smelting Skill Book"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(MetallurgyResearchPaperBasicItem), 10, typeof(MiningSkill)),
                    new IngredientElement(typeof(DendrologyResearchPaperAdvancedItem), 5, typeof(MiningSkill)),
                    new IngredientElement(typeof(GeologyResearchPaperAdvancedItem), 5, typeof(MiningSkill)),
                    new IngredientElement("Basic Research", 5, typeof(MiningSkill)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<SmeltingSkillBook>()
                });
            this.Recipes = new List<Recipe> { recipe };
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(2400, typeof(MiningSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SmeltingSkillBookRecipe), start: 15, skillType: typeof(MiningSkill));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Smelting Skill Book"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Smelting Skill Book"), recipeType: typeof(SmeltingSkillBookRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(ResearchTableObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
