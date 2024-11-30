﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Items;
    using Eco.Core.Controller;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Gameplay;

    /// <summary>
    /// <para>
    /// Server side item definition for the "JazzHands" clothing item. 
    /// </para>
    /// <para>This item is currently hidden from the player. It is either an internal use item or not ready for public release. Removing the hidden tag is not recommended.</para>
    /// <para>More information about ClothingItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.ClothingItem.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Jazz Hands")] // Defines the localized name of the item.
    [LocDescription("Hands")] //The tooltip description for this clothing item.
    [Weight(0)] // Defines how heavy the JazzHands is.
    [Category("Hidden"), Tag("NotInBrowser"), NoIcon] // Hides this object from the player. It is not recommended you remove this tag. 
    public partial class JazzHandsItem : ClothingItem
    {

        /// <summary>Slot this clothing type belongs to</summary>
        public override string Slot                  { get { return AvatarAppearanceSlots.Hands; } }
    }
}
