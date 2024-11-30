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

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeCrossedFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCrossedBlock : Block
    { }

    [RotatedVariants(typeof(AsphaltConcreteOrangeCrossedLineBlock), typeof(AsphaltConcreteOrangeCrossedLine90Block), typeof(AsphaltConcreteOrangeCrossedLine180Block), typeof(AsphaltConcreteOrangeCrossedLine270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeCrossedLineFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCrossedLineBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCrossedLine90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCrossedLine180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCrossedLine270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteOrangeCrossedCornerBlock), typeof(AsphaltConcreteOrangeCrossedCorner90Block), typeof(AsphaltConcreteOrangeCrossedCorner180Block), typeof(AsphaltConcreteOrangeCrossedCorner270Block))]
    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [IsForm(typeof(RoadExtOrangeCrossedCornerFormType), typeof(AsphaltConcreteItem))]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCrossedCornerBlock : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCrossedCorner90Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCrossedCorner180Block : Block
    { }

    [Serialized]
    [MakesRoads]
    [Road(1.2f)]
    [Wall, Constructed, Solid]
    [Tag("Constructable")]
    public partial class AsphaltConcreteOrangeCrossedCorner270Block : Block
    { }
}
