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
    [BlockTier(2)]
    [IsForm(typeof(FloorFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneFloorBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(MortaredStoneItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(CubeFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneCubeBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(MortaredStoneItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofCubeFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofCubeBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(MortaredStoneItem); } }
    }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(WallFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneWallBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(MortaredStoneItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(MortaredStoneItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(ColumnFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneColumnBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(MortaredStoneItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(WindowGrillesFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneWindowGrillesBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(MortaredStoneItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofPeakSetFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofPeakSetBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(MortaredStoneItem); } }
    }





    [RotatedVariants(typeof(MortaredStoneStairsBlock), typeof(MortaredStoneStairs90Block), typeof(MortaredStoneStairs180Block), typeof(MortaredStoneStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(StairsFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneStairsBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneStairs90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneStairs180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneStairs270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(MortaredStoneRoofSideBlock), typeof(MortaredStoneRoofSide90Block), typeof(MortaredStoneRoofSide180Block), typeof(MortaredStoneRoofSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofSideFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofSideBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofSide90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofSide180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofSide270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(MortaredStoneRoofTurnBlock), typeof(MortaredStoneRoofTurn90Block), typeof(MortaredStoneRoofTurn180Block), typeof(MortaredStoneRoofTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofTurnFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofTurnBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofTurn90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofTurn180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofTurn270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(MortaredStoneRoofCornerBlock), typeof(MortaredStoneRoofCorner90Block), typeof(MortaredStoneRoofCorner180Block), typeof(MortaredStoneRoofCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofCornerFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofCornerBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofCorner90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofCorner180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofCorner270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(MortaredStoneRoofPeakBlock), typeof(MortaredStoneRoofPeak90Block), typeof(MortaredStoneRoofPeak180Block), typeof(MortaredStoneRoofPeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofPeakFormType), typeof(MortaredStoneItem))]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofPeakBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofPeak90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofPeak180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class MortaredStoneRoofPeak270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

}