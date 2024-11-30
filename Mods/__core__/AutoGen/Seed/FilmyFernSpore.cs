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
    /// Server side seed item definition for the "FilmyFernSpore" item. 
    /// This object inherits the SeedIem base class to allow for planting/consumption mechanics.
    /// </para>
    /// <para>More information about SeedIem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.SeedItem.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Filmy Fern Spore")] // Defines the localized name of the item.
    [Weight(50)] // Defines how heavy the FilmyFernSpore is.
    [Ecopedia("Food", "Seed", createAsSubPage: true)]
    [StartsDiscovered] // Defines if this item starts discovered when a new world is created.
    [LocDescription("Plant to grow a filmy fern.")] //The tooltip description for the food item.
    public partial class FilmyFernSporeItem : SeedItem
    {
        static FilmyFernSporeItem() { }

        /// <summary>The name of the plant species this seed is responsible for.</summary>
        public override LocString SpeciesName           => Localizer.DoStr("FilmyFern");

        /// <summary>The amount of calories awarded for eating the seed item.</summary>
        public override float Calories                  => 0;
        /// <summary>The nutriential value of the food item.</summary>
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 0, Fat = 0, Protein = 0, Vitamins = 0};

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife            => (float)TimeUtil.HoursToSeconds(168);
    }

    /// <summary>
    /// <para>
    /// Server side seed pack item definition for the "FilmyFernSpore Pack" item. 
    /// This object inherits the SeedPackItem base class to allow for planting/consumption mechanics.
    /// </para>
    /// <para>This item is currently hidden from the player. It is either an internal use item or not ready for public release. Removing the hidden tag is not recommended.</para>
    /// <para>More information about SeedPackItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.SeedPackItem.html</para>
    /// </summary>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Filmy Fern Spore Pack")] // Defines the localized name of the item.
    [Category("Hidden")] // Hides this object from the player. It is not recommended you remove this tag.
    [Weight(50)] // Defines how heavy the FilmyFernSpore is.
    [LocDescription("Plant to grow a filmy fern.")] //The tooltip description for the seed pack item.
    public partial class FilmyFernSporePackItem : SeedPackItem
    {
        static FilmyFernSporePackItem() { }

        /// <summary>The name of the plant species this seed pack is responsible for</summary>
        public override LocString SpeciesName        { get { return Localizer.DoStr("FilmyFern"); } }
    }

}
