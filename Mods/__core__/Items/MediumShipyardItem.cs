﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Occupancy;
    using Eco.Shared.Math;
    using System.Collections.Generic;
    using Eco.Shared.Localization;
    using Eco.Shared.SharedTypes;

    public partial class MediumShipyardItem : WorldObjectItem<MediumShipyardObject>
    {
        protected override OccupancyContext GetOccupancyContext => new PositionsRequirementContext(
            new List<PositionsRequirement>()
            {
                //The land part of the Shipyard requires ground below it to be solid.
                //..these are not really part of its occupancy, since Y = -1, more like requirements.
                new PositionsRequirement(
                    positions: new List<Vector3i>
                    {
                        new Vector3i(-4, -1, -8),
                        new Vector3i(-3, -1, -8),
                        new Vector3i(-2, -1, -8),
                        new Vector3i(-1, -1, -8),
                        new Vector3i(0, -1, -8),
                        new Vector3i(1, -1, -8),
                        new Vector3i(2, -1, -8),
                        new Vector3i(3, -1, -8),
                        new Vector3i(4, -1, -8),
                        new Vector3i(-4, -1, -7),
                        new Vector3i(-3, -1, -7),
                        new Vector3i(-2, -1, -7),
                        new Vector3i(-1, -1, -7),
                        new Vector3i(0, -1, -7),
                        new Vector3i(1, -1, -7),
                        new Vector3i(2, -1, -7),
                        new Vector3i(3, -1, -7),
                        new Vector3i(4, -1, -7),
                        new Vector3i(-4, -1, -6),
                        new Vector3i(-3, -1, -6),
                        new Vector3i(-2, -1, -6),
                        new Vector3i(-1, -1, -6),
                        new Vector3i(0, -1, -6),
                        new Vector3i(1, -1, -6),
                        new Vector3i(2, -1, -6),
                        new Vector3i(3, -1, -6),
                        new Vector3i(4, -1, -6),
                        new Vector3i(-4, -1, -5),
                        new Vector3i(-3, -1, -5),
                        new Vector3i(-2, -1, -5),
                        new Vector3i(-1, -1, -5),
                        new Vector3i(0, -1, -5),
                        new Vector3i(1, -1, -5),
                        new Vector3i(2, -1, -5),
                        new Vector3i(3, -1, -5),
                        new Vector3i(4, -1, -5),
                        new Vector3i(-4, -1, -4),
                        new Vector3i(-3, -1, -4),
                        new Vector3i(-2, -1, -4),
                        new Vector3i(-1, -1, -4),
                        new Vector3i(0, -1, -4),
                        new Vector3i(1, -1, -4),
                        new Vector3i(2, -1, -4),
                        new Vector3i(3, -1, -4),
                        new Vector3i(4, -1, -4),
                        new Vector3i(-4, -1, -3),
                        new Vector3i(-3, -1, -3),
                        new Vector3i(-2, -1, -3),
                        new Vector3i(-1, -1, -3),
                        new Vector3i(0, -1, -3),
                        new Vector3i(1, -1, -3),
                        new Vector3i(2, -1, -3),
                        new Vector3i(3, -1, -3),
                        new Vector3i(4, -1, -3),
                        new Vector3i(-4, -1, -2),
                        new Vector3i(-3, -1, -2),
                        new Vector3i(-2, -1, -2),
                        new Vector3i(-1, -1, -2),
                        new Vector3i(0, -1, -2),
                        new Vector3i(1, -1, -2),
                        new Vector3i(2, -1, -2),
                        new Vector3i(3, -1, -2),
                        new Vector3i(4, -1, -2),
                        new Vector3i(-4, -1, -1),
                        new Vector3i(-3, -1, -1),
                        new Vector3i(-2, -1, -1),
                        new Vector3i(-1, -1, -1),
                        new Vector3i(0, -1, -1),
                        new Vector3i(1, -1, -1),
                        new Vector3i(2, -1, -1),
                        new Vector3i(3, -1, -1),
                        new Vector3i(4, -1, -1),
                        new Vector3i(-4, -1, 0),
                        new Vector3i(-3, -1, 0),
                        new Vector3i(-2, -1, 0),
                        new Vector3i(-1, -1, 0),
                        new Vector3i(0, -1, 0),
                        new Vector3i(1, -1, 0),
                        new Vector3i(2, -1, 0),
                        new Vector3i(3, -1, 0),
                        new Vector3i(4, -1, 0),
                        new Vector3i(-4, -1, 1),
                        new Vector3i(-3, -1, 1),
                        new Vector3i(-2, -1, 1),
                        new Vector3i(-1, -1, 1),
                        new Vector3i(0, -1, 1),
                        new Vector3i(1, -1, 1),
                        new Vector3i(2, -1, 1),
                        new Vector3i(3, -1, 1),
                        new Vector3i(4, -1, 1),
                        new Vector3i(-4, -1, 2),
                        new Vector3i(-3, -1, 2),
                        new Vector3i(-2, -1, 2),
                        new Vector3i(-1, -1, 2),
                        new Vector3i(0, -1, 2),
                        new Vector3i(1, -1, 2),
                        new Vector3i(2, -1, 2),
                        new Vector3i(3, -1, 2),
                        new Vector3i(4, -1, 2),
                        new Vector3i(-4, -1, 3),
                        new Vector3i(-3, -1, 3),
                        new Vector3i(-2, -1, 3),
                        new Vector3i(-1, -1, 3),
                        new Vector3i(0, -1, 3),
                        new Vector3i(1, -1, 3),
                        new Vector3i(2, -1, 3),
                        new Vector3i(3, -1, 3),
                        new Vector3i(4, -1, 3),
                        new Vector3i(-4, -1, 4),
                        new Vector3i(-3, -1, 4),
                        new Vector3i(-2, -1, 4),
                        new Vector3i(-1, -1, 4),
                        new Vector3i(0, -1, 4),
                        new Vector3i(1, -1, 4),
                        new Vector3i(2, -1, 4),
                        new Vector3i(3, -1, 4),
                        new Vector3i(4, -1, 4),
                        new Vector3i(-4, -1, 5),
                        new Vector3i(-3, -1, 5),
                        new Vector3i(-2, -1, 5),
                        new Vector3i(-1, -1, 5),
                        new Vector3i(0, -1, 5),
                        new Vector3i(1, -1, 5),
                        new Vector3i(2, -1, 5),
                        new Vector3i(3, -1, 5),
                        new Vector3i(4, -1, 5),
                        new Vector3i(-4, -1, 6),
                        new Vector3i(-3, -1, 6),
                        new Vector3i(-2, -1, 6),
                        new Vector3i(-1, -1, 6),
                        new Vector3i(0, -1, 6),
                        new Vector3i(1, -1, 6),
                        new Vector3i(2, -1, 6),
                        new Vector3i(3, -1, 6),
                        new Vector3i(4, -1, 6),
                        new Vector3i(-4, -1, 7),
                        new Vector3i(-3, -1, 7),
                        new Vector3i(-2, -1, 7),
                        new Vector3i(-1, -1, 7),
                        new Vector3i(0, -1, 7),
                        new Vector3i(1, -1, 7),
                        new Vector3i(2, -1, 7),
                        new Vector3i(3, -1, 7),
                        new Vector3i(4, -1, 7),
                    },
                    requirement:      PositionRequirementType.OnSolidGround,
                    partName:         Localizer.DoStr("Base"),
                    placementMessage: Localizer.DoStr("on solid ground")
                ),
                //The part that connects ships with it needs to be in the water.
                //..these are not parts of the occupancy either, just requirements.
                new PositionsRequirement(
                    positions: new List<Vector3i>
                    {
                        new Vector3i(-4, -1, 8),
                        new Vector3i(-3, -1, 8),
                        new Vector3i(-2, -1, 8),
                        new Vector3i(-1, -1, 8),
                        new Vector3i(0, -1, 8),
                        new Vector3i(1, -1, 8),
                        new Vector3i(2, -1, 8),
                        new Vector3i(3, -1, 8),
                        new Vector3i(4, -1, 8),
                    },
                    requirement:      PositionRequirementType.InsideWater,
                    partName:         Localizer.DoStr("Waterfront"),
                    placementMessage: Localizer.DoStr("in water")
                )
            }
        );
    }
}
