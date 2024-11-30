﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from ClothingTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Core.Items;
    using Eco.Shared.Gameplay;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;
    
    /// <summary>
    /// <para>
    /// Server side item definition for the "VillagersCowlRaised" clothing item. 
    /// </para>
    /// <para>More information about ClothingItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.ClothingItem.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Villagers Cowl Raised")] // Defines the localized name of the item.
    [LocDescription("A rough linen cowl raised, hiding your face partially.")] //The tooltip description for this clothing item.
    [StartsDiscovered] // Tells the server this item starts discovered when a new server is made.
    [Weight(100)] // Defines how heavy the VillagersCowlRaised is.
    [Tag("Clothes")]
    [Ecopedia("Items", "Clothing", createAsSubPage: true)]
    public partial class VillagersCowlRaisedItem :
        ClothingItem
    {

        /// <summary>Slot this clothing type belongs to</summary>
        public override string Slot                     { get { return AvatarAppearanceSlots.Head; } }

        public override bool Starter                    { get { return true ; } }

    }
    
}
