﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from SeedTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Gameplay.Blocks;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.SearchAndSelect;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.Time;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Players;
    using System.ComponentModel;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    /// <summary>
    /// <para>
    /// Server side seed item definition for the "CriminiMushroomSpores" item. 
    /// This object inherits the SeedIem base class to allow for planting/consumption mechanics.
    /// </para>
    /// <para>More information about SeedIem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.SeedItem.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Crimini Mushroom Spores")] // Defines the localized name of the item.
    [Weight(50)] // Defines how heavy the CriminiMushroomSpores is.
    [Ecopedia("Food", "Seed", createAsSubPage: true)]
    [StartsDiscovered] // Defines if this item starts discovered when a new world is created.
    [Tag("Crop Seed")]
    [LocDescription("Plant to grow crimini mushrooms.")] //The tooltip description for the food item.
    public partial class CriminiMushroomSporesItem : SeedItem
    {
        static CriminiMushroomSporesItem() { }

        /// <summary>The name of the plant species this seed is responsible for.</summary>
        public override LocString SpeciesName           => Localizer.DoStr("CriminiMushroom");

        /// <summary>The amount of calories awarded for eating the seed item.</summary>
        public override float Calories                  => 0;
        /// <summary>The nutriential value of the food item.</summary>
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 0, Fat = 0, Protein = 0, Vitamins = 0};

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife            => (float)TimeUtil.HoursToSeconds(168);
    }

    /// <summary>
    /// <para>
    /// Server side seed pack item definition for the "CriminiMushroomSpores Pack" item. 
    /// This object inherits the SeedPackItem base class to allow for planting/consumption mechanics.
    /// </para>
    /// <para>This item is currently hidden from the player. It is either an internal use item or not ready for public release. Removing the hidden tag is not recommended.</para>
    /// <para>More information about SeedPackItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.SeedPackItem.html</para>
    /// </summary>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Crimini Mushroom Spores Pack")] // Defines the localized name of the item.
    [Category("Hidden")] // Hides this object from the player. It is not recommended you remove this tag.
    [Weight(50)] // Defines how heavy the CriminiMushroomSpores is.
    [LocDescription("Plant to grow crimini mushrooms.")] //The tooltip description for the seed pack item.
    public partial class CriminiMushroomSporesPackItem : SeedPackItem
    {
        static CriminiMushroomSporesPackItem() { }

        /// <summary>The name of the plant species this seed pack is responsible for</summary>
        public override LocString SpeciesName        { get { return Localizer.DoStr("CriminiMushroom"); } }
    }


    /// <summary>
    /// <para>Server side recipe definition for "CriminiMushroomSpores".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(FarmingSkill), 1)]
    [Ecopedia("Food", "Seed", subPageName: "Crimini Mushroom Spores Item")]
    public partial class CriminiMushroomSporesRecipe : RecipeFamily
    {
        public CriminiMushroomSporesRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CriminiMushroomSpores",  //noloc
                displayName: Localizer.DoStr("Crimini Mushroom Spores"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CriminiMushroomsItem), 1, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<CriminiMushroomSporesItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(FarmingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CriminiMushroomSporesRecipe), start: 0.4f, skillType: typeof(FarmingSkill), typeof(FarmingFocusedSpeedTalent), typeof(FarmingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Crimini Mushroom Spores"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Crimini Mushroom Spores"), recipeType: typeof(CriminiMushroomSporesRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(FarmersTableObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}