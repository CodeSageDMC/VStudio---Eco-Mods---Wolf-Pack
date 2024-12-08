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
    [BlockTier(1)]
    [IsForm(typeof(FloorFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeFloorBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(AdobeItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(CubeFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeCubeBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(AdobeItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(WallXFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeWallXBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(AdobeItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(RoofXFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeRoofXBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(AdobeItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(FenceXFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeFenceXBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(AdobeItem); } }
    }
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(RoofFillFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeRoofFillBlock :
        Block, IRepresentsItem, IColoredBlock
    {
        public Type RepresentedItemType { get { return typeof(AdobeItem); } }
    }





    [RotatedVariants(typeof(AdobeWallSoloBlock), typeof(AdobeWallSolo90Block), typeof(AdobeWallSolo180Block), typeof(AdobeWallSolo270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(WallSoloFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeWallSoloBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallSolo90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallSolo180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallSolo270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeWallMidBlock), typeof(AdobeWallMid90Block), typeof(AdobeWallMid180Block), typeof(AdobeWallMid270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(WallMidFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeWallMidBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallMid90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallMid180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallMid270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeWallEndBlock), typeof(AdobeWallEnd90Block), typeof(AdobeWallEnd180Block), typeof(AdobeWallEnd270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(WallEndFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeWallEndBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallEnd90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallEnd180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallEnd270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeWallTBlock), typeof(AdobeWallT90Block), typeof(AdobeWallT180Block), typeof(AdobeWallT270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(WallTFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeWallTBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallT90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallT180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallT270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeWallCornerBlock), typeof(AdobeWallCorner90Block), typeof(AdobeWallCorner180Block), typeof(AdobeWallCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(WallCornerFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeWallCornerBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallCorner90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallCorner180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWallCorner270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeRoofEndBlock), typeof(AdobeRoofEnd90Block), typeof(AdobeRoofEnd180Block), typeof(AdobeRoofEnd270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(RoofEndFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeRoofEndBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofEnd90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofEnd180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofEnd270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeRoofCornerBlock), typeof(AdobeRoofCorner90Block), typeof(AdobeRoofCorner180Block), typeof(AdobeRoofCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(RoofCornerFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeRoofCornerBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofCorner90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofCorner180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofCorner270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeRoofTBlock), typeof(AdobeRoofT90Block), typeof(AdobeRoofT180Block), typeof(AdobeRoofT270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(RoofTFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeRoofTBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofT90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofT180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofT270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeRoofMidBlock), typeof(AdobeRoofMid90Block), typeof(AdobeRoofMid180Block), typeof(AdobeRoofMid270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(RoofMidFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeRoofMidBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofMid90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofMid180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofMid270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeRoofSoloBlock), typeof(AdobeRoofSolo90Block), typeof(AdobeRoofSolo180Block), typeof(AdobeRoofSolo270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(RoofSoloFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeRoofSoloBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofSolo90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofSolo180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeRoofSolo270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeWindowBlock), typeof(AdobeWindow90Block), typeof(AdobeWindow180Block), typeof(AdobeWindow270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(WindowFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeWindowBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWindow90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWindow180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeWindow270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeFenceMidBlock), typeof(AdobeFenceMid90Block), typeof(AdobeFenceMid180Block), typeof(AdobeFenceMid270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(FenceMidFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeFenceMidBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceMid90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceMid180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceMid270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeFenceCornerBlock), typeof(AdobeFenceCorner90Block), typeof(AdobeFenceCorner180Block), typeof(AdobeFenceCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(FenceCornerFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeFenceCornerBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceCorner90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceCorner180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceCorner270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeFenceTBlock), typeof(AdobeFenceT90Block), typeof(AdobeFenceT180Block), typeof(AdobeFenceT270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(FenceTFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeFenceTBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceT90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceT180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceT270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeFenceSoloBlock), typeof(AdobeFenceSolo90Block), typeof(AdobeFenceSolo180Block), typeof(AdobeFenceSolo270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(FenceSoloFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeFenceSoloBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceSolo90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceSolo180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceSolo270Block : Block, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeFenceEndBlock), typeof(AdobeFenceEnd90Block), typeof(AdobeFenceEnd180Block), typeof(AdobeFenceEnd270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(FenceEndFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeFenceEndBlock : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceEnd90Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceEnd180Block : Block, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeFenceEnd270Block : Block, IColoredBlock
    { }

    [RotatedVariants(typeof(AdobeStairsSoloBlock), typeof(AdobeStairsSolo90Block), typeof(AdobeStairsSolo180Block), typeof(AdobeStairsSolo270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(StairsSoloFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeStairsSoloBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsSolo90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsSolo180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsSolo270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeLadderBlock), typeof(AdobeLadder90Block), typeof(AdobeLadder180Block), typeof(AdobeLadder270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(LadderFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeLadderBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeLadder90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeLadder180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeLadder270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeStairsCornerBlock), typeof(AdobeStairsCorner90Block), typeof(AdobeStairsCorner180Block), typeof(AdobeStairsCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(StairsCornerFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeStairsCornerBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsCorner90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsCorner180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsCorner270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeStairsTurnBlock), typeof(AdobeStairsTurn90Block), typeof(AdobeStairsTurn180Block), typeof(AdobeStairsTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(StairsTurnFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeStairsTurnBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsTurn90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsTurn180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsTurn270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeStairsMidBlock), typeof(AdobeStairsMid90Block), typeof(AdobeStairsMid180Block), typeof(AdobeStairsMid270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(StairsMidFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeStairsMidBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsMid90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsMid180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsMid270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeStairsEndLeftBlock), typeof(AdobeStairsEndLeft90Block), typeof(AdobeStairsEndLeft180Block), typeof(AdobeStairsEndLeft270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(StairsEndLeftFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeStairsEndLeftBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsEndLeft90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsEndLeft180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsEndLeft270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeStairsEndRightBlock), typeof(AdobeStairsEndRight90Block), typeof(AdobeStairsEndRight180Block), typeof(AdobeStairsEndRight270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(StairsEndRightFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeStairsEndRightBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsEndRight90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsEndRight180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeStairsEndRight270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }
    [RotatedVariants(typeof(AdobeUnderSlopeSideBlock), typeof(AdobeUnderSlopeSide90Block), typeof(AdobeUnderSlopeSide180Block), typeof(AdobeUnderSlopeSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [IsForm(typeof(UnderSlopeSideFormType), typeof(AdobeItem))]
    [Tag("Constructable")]
    public partial class AdobeUnderSlopeSideBlock : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeUnderSlopeSide90Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeUnderSlopeSide180Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(1)]
    [Tag("Constructable")]
    public partial class AdobeUnderSlopeSide270Block : Block, IWaterLoggedBlock, IColoredBlock
    { }

}