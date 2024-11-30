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
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Tag = Eco.Core.Items.TagAttribute;

    [RotatedVariants(typeof(AsphaltConcreteOrangeArrowLBlock), typeof(AsphaltConcreteOrangeArrowL90Block), typeof(AsphaltConcreteOrangeArrowL180Block), typeof(AsphaltConcreteOrangeArrowL270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeArrowLFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowLBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowL90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowL180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowL270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeArrowRBlock), typeof(AsphaltConcreteOrangeArrowR90Block), typeof(AsphaltConcreteOrangeArrowR180Block), typeof(AsphaltConcreteOrangeArrowR270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeArrowRFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowRBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowR90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowR180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowR270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeArrowLRBlock), typeof(AsphaltConcreteOrangeArrowLR90Block), typeof(AsphaltConcreteOrangeArrowLR180Block), typeof(AsphaltConcreteOrangeArrowLR270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeArrowLRFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowLRBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowLR90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowLR180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowLR270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeArrowSLBlock), typeof(AsphaltConcreteOrangeArrowSL90Block), typeof(AsphaltConcreteOrangeArrowSL180Block), typeof(AsphaltConcreteOrangeArrowSL270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeArrowSLFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSLBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSL90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSL180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSL270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeArrowSRBlock), typeof(AsphaltConcreteOrangeArrowSR90Block), typeof(AsphaltConcreteOrangeArrowSR180Block), typeof(AsphaltConcreteOrangeArrowSR270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeArrowSRFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSRBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSR90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSR180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSR270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeArrowSLRBlock), typeof(AsphaltConcreteOrangeArrowSLR90Block), typeof(AsphaltConcreteOrangeArrowSLR180Block), typeof(AsphaltConcreteOrangeArrowSLR270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeArrowSLRFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSLRBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSLR90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSLR180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSLR270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeArrowSLineBlock), typeof(AsphaltConcreteOrangeArrowSLine90Block), typeof(AsphaltConcreteOrangeArrowSLine180Block), typeof(AsphaltConcreteOrangeArrowSLine270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeArrowSLineFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSLineBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSLine90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSLine180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSLine270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeArrowSTipBlock), typeof(AsphaltConcreteOrangeArrowSTip90Block), typeof(AsphaltConcreteOrangeArrowSTip180Block), typeof(AsphaltConcreteOrangeArrowSTip270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeArrowSTipFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSTipBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSTip90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSTip180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeArrowSTip270Block : Block
    { }
}
