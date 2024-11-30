﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from ItemTemplate.tt/>

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
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

            
    /// <summary>
    /// <para>Server side item definition for the "PlantFibers" item.</para>
    /// <para>More information about Item objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.Item.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Plant Fibers")] // Defines the localized name of the item.
    [Compostable] // Defines if the object is compostable
    [Weight(25)] // Defines how heavy PlantFibers is.
    [Fuel(100)][Tag("Fuel")] // Marks PlantFibers as fuel item.
    [Yield(typeof(PlantFibersItem), typeof(GatheringSkill), new float[] { 1f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 2.0f })]
    [Ecopedia("Items", "Products", createAsSubPage: true)]
    [Tag("NaturalFiber")]
    [Tag("Burnable Fuel")]
    [Tag("Crop")]
    [LocDescription("Harvested from a number of plants, these fibers are useful for a surprising number of things.")] //The tooltip description for the item.
    public partial class PlantFibersItem : Item    {


    }
}