﻿﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from BlockFormTypeTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.World.Water;
    using Eco.Shared.Localization;
    using Eco.World.Blocks;
    using Eco.World.Color;

    /// <summary>
    /// <para>Server side definition for the "UnderBraceTurn" form type. </para>
    /// <para>More information about FormType objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Blocks.FormType.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    public partial class UnderBraceTurnFormType : FormType, IWaterLoggedBlock , IColoredBlock     {
        /// <summary>Basic name of the block form type.</summary>
        public override string Name => "UnderBraceTurn";
        /// <summary>The plural localization name for the block form type.</summary>
        public override LocString DisplayName => Localizer.DoStr("Under Brace Turn");
        /// <summary>The tooltip description for the block form type.</summary>
        public override LocString DisplayDescription => Localizer.DoStr("Under Brace Turn");
        /// <summary>The block FormGroup this form type belongs to</summary>
        public override Type GroupType => typeof(SupportsFormGroup);
        /// <summary>Defines the sort order used by this block form type</summary>
        public override int SortOrder => 83;
        /// <summary>Defines the minimum hammer tier for this block form type</summary>
        public override int MinTier => 1;
    }
}
