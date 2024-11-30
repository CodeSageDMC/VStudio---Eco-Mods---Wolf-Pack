﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from FormsTemplate.tt/>

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
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Water;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Tag = Eco.Core.Items.TagAttribute;
    using Eco.World.Color;


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(5)]
    [IsForm(typeof(FloorFormType), typeof(CottonCarpetItem))]
    [Tag("Constructable")]
    public partial class CottonCarpetFloorBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(CottonCarpetItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(5)]
    [IsForm(typeof(FullWallFormType), typeof(CottonCarpetItem))]
    [Tag("Constructable")]
    public partial class CottonCarpetFullWallBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(CottonCarpetItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(5)]
    [IsForm(typeof(SimpleFloorFormType), typeof(CottonCarpetItem))]
    [Tag("Constructable")]
    public partial class CottonCarpetSimpleFloorBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(CottonCarpetItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(5)]
    [IsForm(typeof(CubeFormType), typeof(CottonCarpetItem))]
    [Tag("Constructable")]
    public partial class CottonCarpetCubeBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(CottonCarpetItem); } }
    }





    [RotatedVariants(typeof(CottonCarpetCanopyWindowBlock), typeof(CottonCarpetCanopyWindow90Block), typeof(CottonCarpetCanopyWindow180Block), typeof(CottonCarpetCanopyWindow270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(5)]
    [IsForm(typeof(CanopyWindowFormType), typeof(CottonCarpetItem))]
    [Tag("Constructable")]
    public partial class CottonCarpetCanopyWindowBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(5)]
    [Tag("Constructable")]
    public partial class CottonCarpetCanopyWindow90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(5)]
    [Tag("Constructable")]
    public partial class CottonCarpetCanopyWindow180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(5)]
    [Tag("Constructable")]
    public partial class CottonCarpetCanopyWindow270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

}