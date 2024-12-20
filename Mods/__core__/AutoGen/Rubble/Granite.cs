﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from RubbleTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using Eco.Shared.Serialization;
    using Eco.Gameplay.Objects;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Core.Items;

    [BecomesRubble(typeof(GraniteRubbleSet1Chunk1Object), typeof(GraniteRubbleSet1Chunk2Object), typeof(GraniteRubbleSet1Chunk3Object))]
    [BecomesRubble(typeof(GraniteRubbleSet2Chunk1Object), typeof(GraniteRubbleSet2Chunk2Object), typeof(GraniteRubbleSet2Chunk3Object), typeof(GraniteRubbleSet2Chunk4Object))]
    [BecomesRubble(typeof(GraniteRubbleSet3Chunk1Object), typeof(GraniteRubbleSet3Chunk2Object), typeof(GraniteRubbleSet3Chunk3Object))]
    [BecomesRubble(typeof(GraniteRubbleSet4Chunk1Object), typeof(GraniteRubbleSet4Chunk2Object), typeof(GraniteRubbleSet4Chunk3Object))]
    [Tag("Minable")]
    public partial class GraniteBlock : Block { }

    [Serialized, Tag("FastPickupable")] public partial class GraniteRubbleSet1Chunk1Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable")] public partial class GraniteRubbleSet1Chunk2Object : RubbleObject<GraniteItem> { }

    [BecomesRubble(typeof(GraniteRubbleSet1Chunk3Split1Object), typeof(GraniteRubbleSet1Chunk3Split2Object)), Tag("MinableRubble")]
    [Serialized] public partial class GraniteRubbleSet1Chunk3Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet1Chunk3Split1Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet1Chunk3Split2Object : RubbleObject<GraniteItem> { }

    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet2Chunk1Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet2Chunk2Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet2Chunk3Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet2Chunk4Object : RubbleObject<GraniteItem> { }

    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet3Chunk1Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet3Chunk2Object : RubbleObject<GraniteItem> { }
    [BecomesRubble(typeof(GraniteRubbleSet3Chunk3Split1Object), typeof(GraniteRubbleSet3Chunk3Split2Object))]
    [Serialized, Tag("MinableRubble")]    public partial class GraniteRubbleSet3Chunk3Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet3Chunk3Split1Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet3Chunk3Split2Object : RubbleObject<GraniteItem> { }

    [BecomesRubble(typeof(GraniteRubbleSet4Chunk1Split1Object), typeof(GraniteRubbleSet4Chunk1Split2Object))]
    [Serialized, Tag("MinableRubble")]    public partial class GraniteRubbleSet4Chunk1Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet4Chunk1Split1Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet4Chunk1Split2Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet4Chunk2Object : RubbleObject<GraniteItem> { }
    [Serialized, Tag("FastPickupable"), Tag("Pickupable")] public partial class GraniteRubbleSet4Chunk3Object : RubbleObject<GraniteItem> { }
}
