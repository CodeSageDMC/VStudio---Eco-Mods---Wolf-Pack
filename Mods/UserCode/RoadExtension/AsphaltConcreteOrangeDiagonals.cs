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

    [RotatedVariants(typeof(AsphaltConcreteOrangeCornerBlock), typeof(AsphaltConcreteOrangeCorner90Block), typeof(AsphaltConcreteOrangeCorner180Block), typeof(AsphaltConcreteOrangeCorner270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeCornerFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCornerBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCorner90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCorner180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCorner270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeCornerSmallBlock), typeof(AsphaltConcreteOrangeCornerSmall90Block), typeof(AsphaltConcreteOrangeCornerSmall180Block), typeof(AsphaltConcreteOrangeCornerSmall270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeCornerSmallFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCornerSmallBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCornerSmall90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCornerSmall180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCornerSmall270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonalOffsetBlock), typeof(AsphaltConcreteOrangeDiagonalOffset90Block), typeof(AsphaltConcreteOrangeDiagonalOffset180Block), typeof(AsphaltConcreteOrangeDiagonalOffset270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonalOffsetFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalOffsetBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalOffset90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalOffset180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalOffset270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonalBigBlock), typeof(AsphaltConcreteOrangeDiagonalBig90Block), typeof(AsphaltConcreteOrangeDiagonalBig180Block), typeof(AsphaltConcreteOrangeDiagonalBig270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonalBigFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalBigBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalBig90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalBig180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalBig270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonalBlock), typeof(AsphaltConcreteOrangeDiagonal90Block), typeof(AsphaltConcreteOrangeDiagonal180Block), typeof(AsphaltConcreteOrangeDiagonal270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonalFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonalEndLBlock), typeof(AsphaltConcreteOrangeDiagonalEndL90Block), typeof(AsphaltConcreteOrangeDiagonalEndL180Block), typeof(AsphaltConcreteOrangeDiagonalEndL270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonalEndLFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalEndLBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalEndL90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalEndL180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalEndL270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonalEndRBlock), typeof(AsphaltConcreteOrangeDiagonalEndR90Block), typeof(AsphaltConcreteOrangeDiagonalEndR180Block), typeof(AsphaltConcreteOrangeDiagonalEndR270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonalEndRFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalEndRBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalEndR90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalEndR180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonalEndR270Block : Block
    { }
}
