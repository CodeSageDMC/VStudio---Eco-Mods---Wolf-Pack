﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from BlockTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.SharedTypes;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.World.Water;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Shared.Graphics;
    using Eco.World.Color;

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>

    [Serialized]
    [Solid, Wall, Diggable, Crushed]
    [Tag(BlockTags.Diggable)]
        public partial class CrushedSlagBlock :
        Block
        , IRepresentsItem
    {
        public virtual Type RepresentedItemType { get { return typeof(CrushedSlagItem); } }
    }

    [Serialized]
    [LocDisplayName("Crushed Slag")]
    [LocDescription("Slag that has been crushed into a fine gravel.")]
    [MaxStackSize(10)]
    [Weight(24000)]
    [Ecopedia("Blocks", "Processed Rock", createAsSubPage: true)]
    [Tag("CrushedRock")]
    [Tag("Excavatable")]
    [RequiresTool(typeof(ShovelItem))]
    public partial class CrushedSlagItem :
 
    BlockItem<CrushedSlagBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Crushed Slag"); } }

        public override bool CanStickToWalls { get { return false; } }
    }

}
