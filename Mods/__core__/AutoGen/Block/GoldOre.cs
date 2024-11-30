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
    [Solid, Wall, Minable(3)]
        public partial class GoldOreBlock :
        Block
        , IRepresentsItem
    {
        public virtual Type RepresentedItemType { get { return typeof(GoldOreItem); } }
    }

    [Serialized]
    [LocDisplayName("Gold Ore")]
    [LocDescription("Unrefined ore with traces of gold.")]
    [MaxStackSize(20)]
    [Weight(7500)]
    [ResourcePile]
    [Ecopedia("Natural Resources", "Ore", createAsSubPage: true)]
    [Tag("Ore")]
    [Tag("Excavatable")]
    public partial class GoldOreItem :
 
    BlockItem<GoldOreBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Gold Ore"); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
            typeof(GoldOreStacked1Block),
            typeof(GoldOreStacked2Block),
            typeof(GoldOreStacked3Block),
            typeof(GoldOreStacked4Block)
        };
        
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Tag("Ore")]
    [Tag("Excavatable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class GoldOreStacked1Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Ore")]
    [Tag("Excavatable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class GoldOreStacked2Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Ore")]
    [Tag("Excavatable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class GoldOreStacked3Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Ore")]
    [Tag("Excavatable")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid,Wall] public class GoldOreStacked4Block : PickupableBlock, IWaterLoggedBlock { } //Only a wall if it's all 4 GoldOre
}
