// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using Eco.Core.Items;
    using Eco.Core.Plugins.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;
    using Eco.Shared.Items;
    using Eco.Gameplay.Housing.PropertyValues.Internal;
    using static Eco.Gameplay.Housing.PropertyValues.Internal.RoomTierUtils;
    using Eco.Gameplay.Systems;
    using Eco.Shared;
    using Eco.Gameplay.Rooms;

    public class HousingValues : IModInit
    {
        //This part is configurable by admin of the server. You can put specific buff for any count of the residents, like "1 resident gets 100%, 2 residents gets 110% bonus, 3 residents gets 115% etc"
        public static float GetCrowdingFactor(int residentsCount) 
        {
            residentsCount = Mathf.Clamp(residentsCount, 0, RoomData.Obj.RoomConfig.HousePointsMultiplierPerResidentsCount.Length - 1);
            var val = RoomData.Obj.RoomConfig.HousePointsMultiplierPerResidentsCount[residentsCount];
            return val;
        }

        public static void Initialize()
        {
            //We set a housing-points penalty for multiple people in a property based on the follow table:
            //Number of residents on a property:     1    2    3    4    5     <more>
            //Formula of occupancy multipliers. 
            //It makes following values:             0   1/2  1/3 1/4 1/5 1/6 etc
            //Its just basic fair share for each member of house.
            HousingConfig.OccupancyMultiplierGenerator = (x) => 
            {
                if (x <= 1) return 1f;
                return (1f / x) * GetCrowdingFactor(x);
            };

            //Detailed description of the multiplier for X residents
            HousingConfig.OccupancyMultiplierGeneratorDescriptior = (x) =>
            {
                LocStringBuilder lsb = new();
                lsb.AppendLine(Localizer.Do($"Each resident receives "));
                lsb.AppendLine(Localizer.NotLocalized($"{Text.InfoLight(Localizer.DoStr("Housing Value"))} / {Text.InfoLight(Localizer.DoStr("Number of Residents"))}  + {Text.InfoLight(Localizer.DoStr("Crowding Factor"))}"));
                lsb.AppendLine();

                var top = Mathf.Max(x + 2, RoomData.Obj.RoomConfig.HousePointsMultiplierPerResidentsCount.Length);
                for (int i = 1; i < RoomData.Obj.RoomConfig.HousePointsMultiplierPerResidentsCount.Count(); i++)
                {
                    var residents = i;//This is needed because otherwise it would use all the time last "I" 
                    var mult = 1 - ((1f / residents) * GetCrowdingFactor(residents));
                    if (i == x) lsb.AppendDashLineLocStr(Localizer.Do($"{residents} residents: -{Text.StyledNegativePercent(mult)} {Localizer.NotLocalizedStr(" <- ")} Current"));
                    else        lsb.AppendDashLineLocStr(Localizer.Do($"{residents} residents: -{Text.StyledNegativePercent(mult)}"));
                }

                lsb.AppendLine();
                lsb.AppendLineLoc($"Typically sharing a house with 1 or 2 others will be more cost efficient than each building a house of their own. However, for roommates beyond those numbers, the benefits start to shift.  So having some roommates, but not too many, is advantageous.");
                lsb.AppendLine();
                lsb.AppendLine(TextLoc.SubtextLoc($"Note: when there are multiple residents, the penalty for multiple rooms of the same type is reduced.  IE, more bedrooms is more beneficial when you have roommates."));
                return lsb.ToLocString();
            };

            //Set the limits for housing points based on each tier of material.  After the 'softcap' is reached, returns are diminised at the percent given, with 'hardcap' being the infinite limit.
            HousingConfig.SetRoomTiers(new[]
            {
                new RoomTier { TierVal = 0, SoftCap = 2f,  HardCap = 4f,  DiminishingReturnPercent = .5f },
                new RoomTier { TierVal = 1, SoftCap = 5f,  HardCap = 10f, DiminishingReturnPercent = .5f },
                new RoomTier { TierVal = 2, SoftCap = 10f, HardCap = 20f, DiminishingReturnPercent = .5f },
                new RoomTier { TierVal = 3, SoftCap = 15f, HardCap = 30f, DiminishingReturnPercent = .5f },
                new RoomTier { TierVal = 4, SoftCap = 20f, HardCap = 40f, DiminishingReturnPercent = .5f },
                new RoomTier { TierVal = 5, SoftCap = 25f, HardCap = 50f, DiminishingReturnPercent = .5f }
            });


            //Setup our room categories
            HousingConfig.SetRoomCategories(new[]
            {
                //Residency rooms
                new RoomCategory() { Color = new Color("DB48C5"),  DisplayName = Localizer.DoStr("Living Room"),   AffectsPropertyTypes = new[] { PropertyType.Residence}, SupportingRoomCategoryNames = new[] {"Seating", "Cultural", "General", "Decoration", "Lighting"}              },
                new RoomCategory() { Color = new Color("00B4A5"),  DisplayName = Localizer.DoStr("Bedroom"),       AffectsPropertyTypes = new[] { PropertyType.Residence}, SupportingRoomCategoryNames = new[] {"Seating", "General", "Decoration", "Lighting", "Cultural"  }  },
                new RoomCategory() { Color = new Color("4C7BD9"),  DisplayName = Localizer.DoStr("Kitchen"),       AffectsPropertyTypes = new[] { PropertyType.Residence}, SupportingRoomCategoryNames = new[] {"Seating", "General", "Decoration", "Lighting", "Cultural" }             },
                new RoomCategory() { Color = new Color("ffcc33"),  DisplayName = Localizer.DoStr("Dining Room"),   AffectsPropertyTypes = new[] { PropertyType.Residence}, SupportingRoomCategoryNames = new[] {"Seating", "Cultural", "General", "Decoration", "Lighting"  } },  // Added new room
                new RoomCategory() { Color = new Color("f9ff5a"),  DisplayName = Localizer.DoStr("Office"),   AffectsPropertyTypes = new[] { PropertyType.Residence}, SupportingRoomCategoryNames = new[] {"Seating", "Cultural", "General", "Decoration", "Lighting"  } },  // Added new room
                new RoomCategory() { Color = new Color("A6E1EA"),  DisplayName = Localizer.DoStr("Bathroom"),      AffectsPropertyTypes = new[] { PropertyType.Residence}, SupportingRoomCategoryNames = new[] {"Seating", "General", "Decoration", "Lighting", "Cultural" }},
                new RoomCategory() { Color = new Color("68E897"),  DisplayName = Localizer.DoStr("Outdoor"),       SupportingRoomCategoryNames = new[] {"Seating", "Cultural", "General", "Decoration", "Lighting" }, ShouldCapFromRoomMaterials = false, CanAutoChooseCategory = false },
                
                //Special room types.
                new RoomCategory() { Color = EcoColors.Culture  ,  DisplayName = Localizer.DoStr("Cultural"),      AffectsPropertyTypes = new[] { PropertyType.Cultural},  SupportingRoomCategoryNames = new[] {"Seating", "General", "Decoration", "Lighting" } },
                new RoomCategory() { Color = new Color("A300B4"),  DisplayName = Localizer.DoStr("Industrial"),    NegatesValue = true },
                
                //Supporting rooms, these do not generating their own unique room types but only add value to existing rooms based on the percentile value set.
                //This value cannot exceed the total value of the MaxSupportPercent.
                new RoomCategory() { Color = new Color("E5956E"),  DisplayName = Localizer.DoStr("Seating"),       CanBeRoomCategory = false},
                
                new RoomCategory() { Color = new Color("12db10"),  DisplayName = Localizer.DoStr("General"),       CanBeRoomCategory = false },
                
                            new RoomCategory() { Color = new Color("6BD6B4"),  DisplayName = Localizer.DoStr("Decoration"),    CanBeRoomCategory = false},
                new RoomCategory() { Color = new Color("FFD6B4"),  DisplayName = Localizer.DoStr("Lighting")  ,    CanBeRoomCategory = false},
            });
        }

        //refactor todo: move out of mods
        public static void PostInitialize()
        {
            var categoryToTags = TagAttribute.CategoryToTags ?? new Dictionary<string, string[]>();
            var tiers = new HashSet<float> { 0 };
            foreach (var item in Item.AllItemsIncludingHidden)
            {
                if (item.Hidden) continue;
                var itemTier = ItemAttribute.Get<TierAttribute>(item.Type);
                if (itemTier != null)
                    tiers.Add(itemTier.Tier);
            }

            categoryToTags["Tiers"] = tiers.OrderBy(x => x).Select(x => $"Tier {x}").ToArray();
            TagAttribute.CategoryToTags = categoryToTags;
        }
    }
}
