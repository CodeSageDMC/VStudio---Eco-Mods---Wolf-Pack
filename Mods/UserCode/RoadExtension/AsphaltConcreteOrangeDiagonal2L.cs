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

    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonal2LCornerBlock), typeof(AsphaltConcreteOrangeDiagonal2LCorner90Block), typeof(AsphaltConcreteOrangeDiagonal2LCorner180Block), typeof(AsphaltConcreteOrangeDiagonal2LCorner270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonal2LCornerFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LCornerBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LCorner90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LCorner180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LCorner270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonal2LBlock), typeof(AsphaltConcreteOrangeDiagonal2L90Block), typeof(AsphaltConcreteOrangeDiagonal2L180Block), typeof(AsphaltConcreteOrangeDiagonal2L270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonal2LFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2L90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2L180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2L270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonal2LEndBlock), typeof(AsphaltConcreteOrangeDiagonal2LEnd90Block), typeof(AsphaltConcreteOrangeDiagonal2LEnd180Block), typeof(AsphaltConcreteOrangeDiagonal2LEnd270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonal2LEndFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LEndBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LEnd90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LEnd180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LEnd270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonal2LModLineBlock), typeof(AsphaltConcreteOrangeDiagonal2LModLine90Block), typeof(AsphaltConcreteOrangeDiagonal2LModLine180Block), typeof(AsphaltConcreteOrangeDiagonal2LModLine270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonal2LModLineFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LModLineBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LModLine90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LModLine180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2LModLine270Block : Block
    { }
}
