using System.Text.RegularExpressions;

namespace Eco.Mods.TechTree
{    
    public static class BulkRecipeSettings
    {
		// Adjusting these setting will change the Recipe qty, Crafted Qty, Experience Gained, Labor Calories & Craft Time on all Bulk Recipes in that type
		// Bulk Multiplier is how many times bigger the recipe is than the original recipe
			// Multiplies amount to the Ingredients, crafted item, Experience, Labor Calories, Crafting Time
		// Bulk Output increases the output amount times quantity
			// multiplies the crafted item & the mulitplier
		// Bulk Craft Increase or Decrease time to craft.
			// multiplies the crafting time & the mulitplier 
			// Less than 1 decreases time. more than 1 increase time. 1 is the same as Bulk Multiplier.
			// 0.75f would make the recipes finish 25% faster.  1.25f will make it 25% longer.
		// Example: if a recipe calls for 1 item to craft 3 items 
		// Size     Craft Ingredients			Crafting Output
		// Tiny,	Ingredient 1 x 10 = 10,		Output 3 x 10 x 1.5 = 45
		// Small,	Ingredient 1 x 10 = 10,		Output 3 x 10 x 2   = 60
		// Bulk,	Ingredient 1 x 25 = 25,		Output 3 x 25 x 3   = 225
		//  Change the number below after the = sign,  the number after the // is the default value if you want to go back.
		//  		Setting for Tiny Bulk recipes
		public const float TinyBulkMultiplier = 10.0f;	// 10.0f
		public const float TinyBulkOutput = 1.5f;		// 1.5f 
		public const float TinyBulkCraft = 0.75f;		// 0.75f 
		//  		Settings for Small Bulk recipes
		public const float SmallBulkMultiplier = 10.0f;	// 10.0f
		public const float SmallBulkOutput = 2.0f;		// 2.0f
		public const float SmallBulkCraft = 0.75f;		// 0.75f
		//  		Settings for Bulk recipes
		public const float BulkMultiplier = 25.0f;		// 25.0f
		public const float BulkOutput = 3.0f;			// 3.0f
		public const float BulkCraft = 0.75f;			// 0.75f
		// Server restart is required after making changes above
	}

//  Please don't make changes below this point. 
/*    public class BulkRecipesMod : IModInit
    {
        public static ModRegistration Register() => new() 
        { 
            ModName = "BulkRecipes",
            ModDescription = "Adds over 265 Bulk Recipes for popular recipes",
            ModDisplayName = "Bulk Recipes",
        };
    }*/
}