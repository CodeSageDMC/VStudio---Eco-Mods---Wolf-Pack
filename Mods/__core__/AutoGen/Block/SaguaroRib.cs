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
    [Solid, Wall, Constructed]
        public partial class SaguaroRibBlock :
        Block
        , IRepresentsItem
    {
        public virtual Type RepresentedItemType { get { return typeof(SaguaroRibItem); } }
    }

    [Serialized]
    [LocDisplayName("Saguaro Rib")]
    [LocDescription("Saguaro rib is a basic, lightweight wood harvested from the saguaro cactus.")]
    [MaxStackSize(20)]
    [Weight(10000)]
    [Fuel(4000)][Tag("Fuel")]
    [Ecopedia("Natural Resources", "Logs", createAsSubPage: true)]
    [Tag("Wood")]
    [Tag("Burnable Fuel")]
    public partial class SaguaroRibItem :
 
    BlockItem<SaguaroRibBlock>
    {

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
            typeof(SaguaroRibStacked1Block),
            typeof(SaguaroRibStacked2Block),
            typeof(SaguaroRibStacked3Block),
            typeof(SaguaroRibStacked4Block)
        };
        
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Tag("Wood")]
    [Tag("Burnable Fuel")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class SaguaroRibStacked1Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Wood")]
    [Tag("Burnable Fuel")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class SaguaroRibStacked2Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Wood")]
    [Tag("Burnable Fuel")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class SaguaroRibStacked3Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Wood")]
    [Tag("Burnable Fuel")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid,Wall] public class SaguaroRibStacked4Block : PickupableBlock, IWaterLoggedBlock { } //Only a wall if it's all 4 SaguaroRib
}
