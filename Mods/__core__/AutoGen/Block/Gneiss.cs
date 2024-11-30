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
    [Solid, Wall, Minable(4)]
        public partial class GneissBlock :
        Block
        , IRepresentsItem
    {
        public virtual Type RepresentedItemType { get { return typeof(GneissItem); } }
    }

    [Serialized]
    [LocDisplayName("Gneiss")]
    [LocDescription("A hard rock with some uses in construction. Gneiss is a metamorphic rock formed from previous rock recrystallizing at high pressures and temperatures deep in the earth.")]
    [MaxStackSize(20)]
    [Weight(7000)]
    [ResourcePile]
    [Ecopedia("Natural Resources", "Stone", createAsSubPage: true)]
    [Tag("Rock")]
    [Tag("Excavatable")]
    public partial class GneissItem :
 
    BlockItem<GneissBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Gneiss"); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
            typeof(GneissStacked1Block),
            typeof(GneissStacked2Block),
            typeof(GneissStacked3Block),
            typeof(GneissStacked4Block)
        };
        
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Tag("Rock")]
    [Tag("Excavatable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class GneissStacked1Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Rock")]
    [Tag("Excavatable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class GneissStacked2Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Rock")]
    [Tag("Excavatable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class GneissStacked3Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Rock")]
    [Tag("Excavatable")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid,Wall] public class GneissStacked4Block : PickupableBlock, IWaterLoggedBlock { } //Only a wall if it's all 4 Gneiss
}