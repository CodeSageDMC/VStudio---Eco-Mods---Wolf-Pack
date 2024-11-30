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
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    /// <summary>
    /// <para>
    /// Server side food item definition for the "GiantCactusFruit" item. 
    /// This object inherits the FoodItem base class to allow for consumption mechanics.
    /// </para>
    /// <para>More information about FoodItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.FoodItem.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Giant Cactus Fruit")] // Defines the localized name of the item.
    [Weight(75)] // Defines how heavy the GiantCactusFruit is.
    [Yield(typeof(GiantCactusFruitItem), typeof(FarmingSkill), new float[] {1f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 2.0f})]
    [Crop] // Defines this item as a crop item
    [Tag("Crop")] // Marks this item as a crop for use in recipes/ecopedia
    [Tag("Harvestable")] // Marks this item as a harvestable for use in recipes/ecopedia
    [Tag("Fruit")]
    [Tag("Raw Food")]
    [Ecopedia("Food", "Produce", createAsSubPage: true)]
    [LocDescription("A bulbous fruit that used to top Saguaro cacti.")] //The tooltip description for the food item.
    public partial class GiantCactusFruitItem : FoodItem
    {


        /// <summary>The amount of calories awarded for eating the food item.</summary>
        public override float Calories                  => 100;
        /// <summary>The nutritional value of the food item.</summary>
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 2, Fat = 2, Protein = 0, Vitamins = 4};

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife            => (float)TimeUtil.HoursToSeconds(96);
    }

}