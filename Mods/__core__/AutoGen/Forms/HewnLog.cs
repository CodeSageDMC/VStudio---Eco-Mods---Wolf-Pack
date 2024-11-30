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
    [IsForm(typeof(FloorFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogFloorBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(CubeFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogCubeBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofCubeFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogRoofCubeBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(WallFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogWallBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogRoofBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(ColumnFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogColumnBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(WindowGrillesFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogWindowGrillesBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofPeakSetFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogRoofPeakSetBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksFenceXFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceXBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksColumnFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksColumnBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPillarBeamXFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamXBlock :
        Block, IRepresentsItem, IWaterLoggedBlock, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(HewnLogItem); } }
    }





    [RotatedVariants(typeof(HewnLogStairsBlock), typeof(HewnLogStairs90Block), typeof(HewnLogStairs180Block), typeof(HewnLogStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(StairsFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogStairsBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogStairs90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogStairs180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogStairs270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogLadderBlock), typeof(HewnLogLadder90Block), typeof(HewnLogLadder180Block), typeof(HewnLogLadder270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(LadderFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogLadderBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogLadder90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogLadder180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogLadder270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogRoofSideBlock), typeof(HewnLogRoofSide90Block), typeof(HewnLogRoofSide180Block), typeof(HewnLogRoofSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofSideFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogRoofSideBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofSide90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofSide180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofSide270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogRoofTurnBlock), typeof(HewnLogRoofTurn90Block), typeof(HewnLogRoofTurn180Block), typeof(HewnLogRoofTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofTurnFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogRoofTurnBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofTurn90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofTurn180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofTurn270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogRoofCornerBlock), typeof(HewnLogRoofCorner90Block), typeof(HewnLogRoofCorner180Block), typeof(HewnLogRoofCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofCornerFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogRoofCornerBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofCorner90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofCorner180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofCorner270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogRoofPeakBlock), typeof(HewnLogRoofPeak90Block), typeof(HewnLogRoofPeak180Block), typeof(HewnLogRoofPeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(RoofPeakFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogRoofPeakBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofPeak90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofPeak180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogRoofPeak270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksPillarBlock), typeof(HewnLogDocksPillar90Block), typeof(HewnLogDocksPillar180Block), typeof(HewnLogDocksPillar270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPillarFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillar90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillar180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillar270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksRampsBlock), typeof(HewnLogDocksRamps90Block), typeof(HewnLogDocksRamps180Block), typeof(HewnLogDocksRamps270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksRampsFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampsBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRamps90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRamps180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRamps270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksPlatformBlock), typeof(HewnLogDocksPlatform90Block), typeof(HewnLogDocksPlatform180Block), typeof(HewnLogDocksPlatform270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPlatformFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPlatformBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPlatform90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPlatform180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPlatform270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksPlatformFillBlock), typeof(HewnLogDocksPlatformFill90Block), typeof(HewnLogDocksPlatformFill180Block), typeof(HewnLogDocksPlatformFill270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPlatformFillFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPlatformFillBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPlatformFill90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPlatformFill180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPlatformFill270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksPillarBeamBlock), typeof(HewnLogDocksPillarBeam90Block), typeof(HewnLogDocksPillarBeam180Block), typeof(HewnLogDocksPillarBeam270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPillarBeamFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeam90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeam180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeam270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksFenceCornerBlock), typeof(HewnLogDocksFenceCorner90Block), typeof(HewnLogDocksFenceCorner180Block), typeof(HewnLogDocksFenceCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksFenceCornerFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceCornerBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceCorner90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceCorner180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceCorner270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksFenceMidBlock), typeof(HewnLogDocksFenceMid90Block), typeof(HewnLogDocksFenceMid180Block), typeof(HewnLogDocksFenceMid270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksFenceMidFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceMidBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceMid90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceMid180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceMid270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksFenceTBlock), typeof(HewnLogDocksFenceT90Block), typeof(HewnLogDocksFenceT180Block), typeof(HewnLogDocksFenceT270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksFenceTFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceTBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceT90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceT180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceT270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksPillarBeamEndBlock), typeof(HewnLogDocksPillarBeamEnd90Block), typeof(HewnLogDocksPillarBeamEnd180Block), typeof(HewnLogDocksPillarBeamEnd270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPillarBeamEndFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamEndBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamEnd90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamEnd180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamEnd270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksPillarBeamEndAltBlock), typeof(HewnLogDocksPillarBeamEndAlt90Block), typeof(HewnLogDocksPillarBeamEndAlt180Block), typeof(HewnLogDocksPillarBeamEndAlt270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPillarBeamEndAltFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamEndAltBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamEndAlt90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamEndAlt180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamEndAlt270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksPillarBeamJunctionBlock), typeof(HewnLogDocksPillarBeamJunction90Block), typeof(HewnLogDocksPillarBeamJunction180Block), typeof(HewnLogDocksPillarBeamJunction270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPillarBeamJunctionFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamJunctionBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamJunction90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamJunction180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamJunction270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksBarrelPlatformBlock), typeof(HewnLogDocksBarrelPlatform90Block), typeof(HewnLogDocksBarrelPlatform180Block), typeof(HewnLogDocksBarrelPlatform270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksBarrelPlatformFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksBarrelPlatformBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksBarrelPlatform90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksBarrelPlatform180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksBarrelPlatform270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksRampABlock), typeof(HewnLogDocksRampA90Block), typeof(HewnLogDocksRampA180Block), typeof(HewnLogDocksRampA270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksRampAFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampABlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampA90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampA180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampA270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksRampBBlock), typeof(HewnLogDocksRampB90Block), typeof(HewnLogDocksRampB180Block), typeof(HewnLogDocksRampB270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksRampBFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampBBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampB90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampB180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampB270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksRampCBlock), typeof(HewnLogDocksRampC90Block), typeof(HewnLogDocksRampC180Block), typeof(HewnLogDocksRampC270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksRampCFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampCBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampC90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampC180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampC270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksRampDBlock), typeof(HewnLogDocksRampD90Block), typeof(HewnLogDocksRampD180Block), typeof(HewnLogDocksRampD270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksRampDFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampDBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampD90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampD180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampD270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksFenceSoloBlock), typeof(HewnLogDocksFenceSolo90Block), typeof(HewnLogDocksFenceSolo180Block), typeof(HewnLogDocksFenceSolo270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksFenceSoloFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceSoloBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceSolo90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceSolo180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceSolo270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksFenceEndCapBlock), typeof(HewnLogDocksFenceEndCap90Block), typeof(HewnLogDocksFenceEndCap180Block), typeof(HewnLogDocksFenceEndCap270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksFenceEndCapFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceEndCapBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceEndCap90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceEndCap180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceEndCap270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksRampsCornerBlock), typeof(HewnLogDocksRampsCorner90Block), typeof(HewnLogDocksRampsCorner180Block), typeof(HewnLogDocksRampsCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksRampsCornerFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampsCornerBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampsCorner90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampsCorner180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampsCorner270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksRampsCornerInvertedBlock), typeof(HewnLogDocksRampsCornerInverted90Block), typeof(HewnLogDocksRampsCornerInverted180Block), typeof(HewnLogDocksRampsCornerInverted270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksRampsCornerInvertedFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampsCornerInvertedBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampsCornerInverted90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampsCornerInverted180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksRampsCornerInverted270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksFenceEndCapDoubleBlock), typeof(HewnLogDocksFenceEndCapDouble90Block), typeof(HewnLogDocksFenceEndCapDouble180Block), typeof(HewnLogDocksFenceEndCapDouble270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksFenceEndCapDoubleFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceEndCapDoubleBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceEndCapDouble90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceEndCapDouble180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksFenceEndCapDouble270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksPillarBeamCornerBlock), typeof(HewnLogDocksPillarBeamCorner90Block), typeof(HewnLogDocksPillarBeamCorner180Block), typeof(HewnLogDocksPillarBeamCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPillarBeamCornerFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamCornerBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamCorner90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamCorner180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamCorner270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(HewnLogDocksPillarBeamTBlock), typeof(HewnLogDocksPillarBeamT90Block), typeof(HewnLogDocksPillarBeamT180Block), typeof(HewnLogDocksPillarBeamT270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [IsForm(typeof(DocksPillarBeamTFormType), typeof(HewnLogItem))]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamTBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamT90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamT180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    [Tag("Constructable")]
    public partial class HewnLogDocksPillarBeamT270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

}