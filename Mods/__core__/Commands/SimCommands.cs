﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods
{
    using Eco.Core.Tests;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Systems.Messaging.Notifications;
    using Eco.Gameplay.Systems.Messaging.Chat.Commands;
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers;

    [ChatCommandHandler]
    public static class SimCommands
    {
        [CITest]
        [ChatSubCommand("Sim", "Raises the sea level by a passed in amount.  Careful with this one!", ChatAuthorizationLevel.DevTier)]
        public static void RaiseSeaLevel(User user, float val = 1.5f)
        {
            var seaLevel = WorldLayerManager.Obj.ClimateSim.State.SeaLevel;
            WorldLayerManager.Obj.ClimateSim.SetSeaLevel(seaLevel + val);
            NotificationManager.ServerMessageToAll(Localizer.Format("{0} has raised the seas by {1}!", user.Name, Text.StyledNum(val)));
        }

        [CITest]
        [ChatSubCommand("Sim", "Displays the current sea level and how much it has risen.", "sea", ChatAuthorizationLevel.User)]
        public static void SeaLevel(User user) 
        {
            NotificationManager.TemporaryServerMessageToPlayer(Localizer.Format("Current sea level: {0}  Amount raised so far: {1}", Text.StyledNum(WorldLayerManager.Obj.ClimateSim.State.SeaLevel), Text.StyledNum(WorldLayerManager.Obj.ClimateSim.State.SeaLevel - WorldLayerManager.Obj.ClimateSim.State.InitialSeaLevel)), user);
        }
    }
}
