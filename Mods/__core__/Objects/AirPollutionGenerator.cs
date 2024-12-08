﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Core.Controller;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(AirPollutionComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class AirPollutionGeneratorObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Air Pollution Generator"); } }
        public virtual Type RepresentedItemType { get { return typeof(AirPollutionGeneratorItem); } }
        protected override void Initialize()
        {
            this.GetComponent<AirPollutionComponent>().Initialize(1f);
        }
    }

    [Serialized]
    [Category("Hidden"), Tag("NotInBrowser"), NoIcon]
    [LocDisplayName("Air Pollution Generator")]
    [LocDescription("Dev object for testing air pollution.")]
    public partial class AirPollutionGeneratorItem : WorldObjectItem<AirPollutionGeneratorObject>
    {
    }

}
