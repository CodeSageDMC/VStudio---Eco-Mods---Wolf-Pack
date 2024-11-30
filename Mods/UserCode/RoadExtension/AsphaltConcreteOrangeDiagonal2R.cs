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

    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonal2RCornerBlock), typeof(AsphaltConcreteOrangeDiagonal2RCorner90Block), typeof(AsphaltConcreteOrangeDiagonal2RCorner180Block), typeof(AsphaltConcreteOrangeDiagonal2RCorner270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonal2RCornerFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2RCornerBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2RCorner90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2RCorner180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2RCorner270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonal2RBlock), typeof(AsphaltConcreteOrangeDiagonal2R90Block), typeof(AsphaltConcreteOrangeDiagonal2R180Block), typeof(AsphaltConcreteOrangeDiagonal2R270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonal2RFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2RBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2R90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2R180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2R270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonal2REndBlock), typeof(AsphaltConcreteOrangeDiagonal2REnd90Block), typeof(AsphaltConcreteOrangeDiagonal2REnd180Block), typeof(AsphaltConcreteOrangeDiagonal2REnd270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonal2REndFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2REndBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2REnd90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2REnd180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2REnd270Block : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeDiagonal2RModLineBlock), typeof(AsphaltConcreteOrangeDiagonal2RModLine90Block), typeof(AsphaltConcreteOrangeDiagonal2RModLine180Block), typeof(AsphaltConcreteOrangeDiagonal2RModLine270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeDiagonal2RModLineFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2RModLineBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2RModLine90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2RModLine180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeDiagonal2RModLine270Block : Block
    { }
}
