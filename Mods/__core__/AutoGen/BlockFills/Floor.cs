﻿﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from BlockFillsTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;
    using Eco.Shared.SharedTypes;

    /// <summary>
    /// <para>Server side block fill definition for "Floor".</para>
    /// <para>More information about BlockFill objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Blocks.BlockFill.html</para>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    /// </summary>
    public class FloorFill : BlockFill
    {
        public override int SortOrder => 4;
        public override string Name => "Floor";
        public override LocString DisplayName => Localizer.DoStr("Floor");
        public override LocString DisplayDescription => Localizer.DoStr("A flat rectangle of blocks.");
        public override int HammerTier => 2;
        public override SelectionMode SelectionMode => SelectionMode.Floor;
    }
}
