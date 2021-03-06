using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whats_For_Dinner.Models;

namespace Whats_For_Dinner
{
    public class RecipeCollectionContext:DbContext
    {
        //Add DBsets here! :)
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeTag> RecipeTags { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var ConnectionString = "Server=(localdb)\\mssqllocaldb; Database=based_database_420; Trusted_Connection=True";

            builder.UseSqlServer(ConnectionString).UseLazyLoadingProxies();
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Recipe>().HasData(
                //new Recipe() { Id =, Name = , Ingredients = , Instructions = , Description = },
                //Because we can't build lists into seed data, we'll have to edit our recipes manually and add the ingredients later


                new Recipe() { 
                    Id = 1, 
                    Name = "Grilled Peaches with Balsamic Vinegar", 
                    Ingredients = "4 peaches, halved (with pits removed)|;|2 teaspoons olive oil|;|1/2 cup balsamic vinegar (preferably vanilla flavored!)",
                    Instructions = "Heat a grill to medium-high.|:| Brush a very light layer of olive oil on each side of the cut side of each peach half.|:| Put the peaches face down on the grill and brush the skin side with olive oil. |:| Grill peaches 4 to 5 minutes, undisturbed, until there are distinct grill marks on the peaches. |:| Flip the peaches and allow then to grill on the skin side until they are charred, warmed through and tender, but not mushy.  4 - 5 minutes.", 
                    Description = "What an easy way to transform a simple peach that can then be used in all types of dishes to bring interest and flavor." 
                },

                new Recipe() { 
                    Id = 2, 
                    Name = "Vanilla Balsamic Chicken", 
                    Ingredients = "1/2 cup vanilla balsamic vinegar|;|1/2 cup reduced sodium fat-free chicken broth|;|1/4 cup shallots, finely chopped|;|1/4 teaspoon orange zest|;|1/4 cup orange juice|;|1 clove garlic, minced|;|8 boneless skinless chicken thighs|;|1 tablespoon olive oil|;|1 teaspoon salt, divided|;|1/2 teaspoon black pepper",
                    Instructions = "Preheat oven to 450*. |:| Combine the vinegar, chicken broth, shallot, orange zest, and juice, and simmer until mixture is reduced to half a cup (about 20 minutes). Add half a teaspoon of salt and set aside. |:|While the sauce is reducing, combine half a teaspoon salt and pepper in a small bowl. Season chicken on all sides, and set aside in a single layer in a roasting pan that has been coated with the olive oil. |:| Bake in preheated oven for 10 minutes.|:|Brush half of the reduced broth mixture over chicken. Bake 5 minutes more, then brush on the remaining broth mixture. |:| Bake approximately 15 more minutes, or until internal temperature reaches at least 165*. |:| Serve over noodles, rice, or quinoa.", 
                    Description = "Our vanilla balsamic chicken uses rich vanilla balsamic vinegar and a touch of orange juice to create the traditional sweet and sour flavor combo that is so wonderful on chicken." 
                },

                new Recipe() { 
                    Id = 3, 
                    Name = "Hearty Stuffed Autumn Squash", 
                    Ingredients = "3 tablespoons Chipotle Olive Oil|;|3 tablespoons Black Currant Balsamic Vinegar, divided|;|1 medium or large acorn, delicata or small butternut squash|;|½ teaspoon kosher salt|;|¼ teaspoon freshly ground black pepper|;|6 oz spicy Italian sausage, bulk or with casings removed(turkey, or chicken sausage as work well)|;|3 green onions, sliced|;|2 clove garlic, minced|;|2 cups tightly packed baby kale or torn kale leaves|;|3 tablespoons chicken stock|;|¼ cup pine nuts or pepitas|;|2 tablespoons grated fresh Parmesan|;|2 tablespoons panko breadcrumbs|;|½ tablespoon Pumpkin Seed Oil (optional)",
                    Instructions = "Preheat oven to 375°.|:| Optional step to make cutting the squash easier: using a fork, poke each squash 5 - 6 times so steam can escape.Put in microwave on high for 2 minutes.Remove carefully and let cool a couple of minutes.|:| Halve the squash down the middle, and remove the seeds.Cut a thin slice off the round bottom side of each squash half to create a stable base for when filling and broiling the squash.Score the inside of the squash with a sharp knife and brush each half with 1 / 2 tablespoon of oil and 1 / 2 tablespoon of vinegar.Allow to sit upright for 5 minutes for the oil and vinegar to penetrate the scoring.Sprinkle squash with salt and pepper.|:| 4. Coat a foil - lined baking sheet with cooking spray, place squash flesh side down and bake until golden and tender, 30 - 40 minutes. Remove from oven; flip squash and set aside. 5. While the squash is cooking: Heat 1 tablespoon olive oil in a large nonstick skillet over medium heat. Cook the sausage through, breaking into pieces(about 6 minutes), and transfer to a paper towel-lined dish to drain. 6. Add final tablespoon of olive oil to the same pan and cook the onions until soft, about 3 minutes.Add the garlic and cook until fragrant, about 30 seconds.Add kale and combine. Add the chicken stock and 1 tablespoon balsamic vinegar.Cook until kale is tender, about 5 minutes, Stir in sausage and remove from heat. 7. When the filling is cooked and the squash is done roasting, divide the filling between the squash \"bowls.\" 8. Combine the nuts, Parmesan, panko breadcrumbs, and the nut oil of choice in a small bowl.Sprinkle evenly over squash. 9. Place in oven and roast 5 minutes. 10. Leave squash in the oven and turn oven to broil, and broil the squash an additional 2 - 3 minutes until the topping is golden brown, about 2 minutes. 11. Let cool 5 minutes and drizzle remaining Black Currant Balsamic Vinegar over the finished squash before serving. If serving 4, cut each half into half again at the table.", 
                    Description = "Spicy olive oil & Italian sausage pair with sweet balsamic vinegar & squash for a filling meal or a hearty side dish. The combination of nutty, sweet and spicy, makes this recipe irresistible."
                },

                new Recipe() {
                    Id = 4,
                    Name = "Old Fashioned Pancakes",
                    Ingredients = "1½ cups all-purpose flour|;|3½ teaspoons baking powder|;|¼ teaspoon salt, or more to taste|;|1 tablespoon white sugar|;|1¼ cups milk|;|1 egg|;|3 tablespoons butter, melted",
                    Instructions = "In a large bowl, sift together the flour, baking powder, salt and sugar. Make a well in the center and pour in the milk, egg and melted butter; mix until smooth.|:| Heat a lightly oiled griddle or frying pan over medium-high heat. Pour or scoop the batter onto the griddle, using approximately 1/4 cup for each pancake. Brown on both sides and serve hot.",
                    Description = "Easy delicious breakfast the entire family will love."
                },

                new Recipe() {
                    Id = 5,
                    Name = "Healthy Taco Soup",
                    Ingredients = "1 lb Ground beef, chicken or turkey, lean|;|1 can Black beans|;|1 cup Corn|;|2 cloves Garlic|;|1 can Kidney beans|;|1 Onion|;|3 cups Chicken broth|;|2 cans Rotel tomatoes with chili|;|1 packet Taco seasonings",
                    Instructions = "Add ground turkey or chicken.|:|Cook on high until meat is no longer pink.|.|Drain meat.|:|Add garlic and onion. |:|Continue cooking for 1-2 minutes until meat is crumbled and brown.|:|Add in your beans, corn, tomatoes, and chicken broth.|:|Cook on High heat for 1 hour.|:|Serve with your favorite toppings.",
                    Description = "This Taco Soup is a zero point Freestyle Weight Watchers recipe. This healthy recipe is loaded with incredible flavor. It's really easy to make and so satisfying! Make this nutritious soup for lunch or pop it in the freezer for a quick meal during busy weeks!"
                },

                new Recipe() {
                    Id = 6,
                    Name = "Cake Mix Santa Cookies",
                    Ingredients = "1 box of white cake mix|;|2 large egg whites|;|2 tbsp flour|;|1/2 cup vegetable oil|;|1/4 cup white chocolate chips|;|1/4 cup milk OR dark chocolate chips|;|1/4 cup of your favorite holiday-colored sprinkles",
                    Instructions = "Combine cake mix, egg whites, flour and oil in a large bowl.|:|Add in the 1/4 cup of both chocolate chips and 1/4 cup of holiday sprinkles and gently fold in|:|Bake at 350 degrees for 8-10 minutes|:|Enjoy!",
                    Description = "A fun holiday treat to make with your children to leave out for Santa,(and Mom and Dad too)"
                },

                new Recipe()
                {
                    Id = 7,
                    Name = "Almost Apple Pie",
                    Ingredients = "1 cup steel cut oats|;|2 cups water |;|2 cups non-dairy milk, such as almond or soy |;|2 teaspoons cinnamon |;|2 teaspoons vanilla extract |;|2 tablespoons ground flax seed |;|2 large apples, medium dice",
                    Instructions = "Place all ingredients into a large pot and bring to a boil.|:|Simmer for 40 minutes, stirring occasionally.|:|Take off heat and let sit for 5 minutes. Divide evenly into 4 bowls. Refrigerate leftovers.",
                    Description = "A sweet and satisfying start to your day. Makes enough to last for four breakfasts, which is nice when you are busy!"
                },

                new Recipe()
                {
                    Id = 8,
                    Name = "Simple Tomato Soup",
                    Ingredients = "1 tablespoon unsalted butter or margarine|;|1 tablespoon olive oil|;|1 onion, thinly sliced|;|2 large garlic cloves, peeled and crushed|;|2 (28 ounce) cans whole peeled tomatoes|;|1 cup water|;|1 tablespoon sugar|;|1 teaspoon salt, plus more to taste|;|freshly ground black pepper to taste|;|1 pinch red pepper flakes|;|¼ teaspoon celery seed|;|¼ teaspoon dried oregano",
                    Instructions = "Heat butter and olive oil in a large saucepan over medium-low heat and cook onion and garlic until onion is soft and translucent, about 5 minutes.|:| Add tomatoes, water, sugar, salt, pepper, red pepper flakes, celery seed, and oregano.|:|Bring to a boil. Reduce heat, cover, and simmer for 15 minutes.|:|Remove from heat and puree with an immersion blender. Reheat soup until warm and season with more salt and pepper if desired.",
                    Description = "Simply delicious creamy tomato soup"
                },

                new Recipe()
                {
                    Id = 9,
                    Name = "Classic Green Bean Casserole",
                    Ingredients = "1  can (10 3/4 ounces) Campbell's Condensed Cream of Mushroom Soup |;|1 cup Milk |;|1  tsp.  soy sauce |;|Dash ground black pepper |;|4  cups cooked cut green beans |;|1  cup  French's French Fried Onions|;| |;| |;| |;| |;| |;| |;| |;| |;| |;| |;| ",
                    Instructions = "Mix soup, milk, soy, black pepper, beans and <b>2/3 cup</b> onions in 1 1/2-qt. casserole.|:|Bake at 350°F. for 25 min. or until hot.|:|Stir . Sprinkle with remaining onions. Bake 5 min.|:|Tip: Use <b>1 bag</b> (16 to 20 oz.) frozen green beans, <b>2 pkg.</b> (9 oz. <b>each</b>) frozen green beans, <b>2 cans</b> (about 16 oz. <b>each</b>) green beans <b>or</b> about <b>1 1/2 lb.</b> fresh green beans for this recipe.|:|Tip: For a change of pace, substitute <b>4 cups</b> cooked broccoli flowerets for the green beans.|:|Tip: For a creative twist, stir in <b>1/2 cup</b> shredded Cheddar cheese with soup. Omit soy sauce. Sprinkle with <b>1/4 cup</b> additional Cheddar cheese when adding the remaining onions.|:|Tip: For a festive touch, stir in <b>1/4 cup</b> chopped red pepper with soup.|:|Tip: For a heartier mushroom flavor, substitute Campbell's® Condensed Golden Mushroom Soup for Cream of Mushroom Soup. Omit soy sauce. Stir in <b>1/4 cup</b> chopped red pepper with green beans.",
                    Description = "It's the dish everyone's expecting on the holidays, but it's so easy to make, you can serve it any day.What makes our green bean casserole so good? (secret ingredient - cream of mushroom soup)."
                },

                new Recipe()
                {
                    Id = 10,
                    Name = "Char-Grilled Rib Eye with Roasted Shallot and Herb Butter",
                    Ingredients = "Olive oil|;|Four 12-ounce rib-eye steaks, bone in, about 1 1/2 inch thick |;|Kosher salt and freshly ground black pepper |;|For Roasted Shallot and Herb Butter Sauce:|;|1 medium shallot, peeled |;|1 tablespoon olive oil|;|1 stick salted butter, room temperature|;|1 tablespoon finely chopped fresh parsley |;|1 tablespoon finely chopped fresh basil|;|1 tablespoon finely chopped fresh tarragon |;|1 teaspoon grated lemon zest |;|Pinch of crushed red-pepper flakes |;| |;| |;| |;| |;| |;| ",
                    Instructions = "Take your steaks out of the fridge 30 minutes before you want to start grilling, so they can come to room temperature. Prepare the charcoal grill to medium-high heat on one side of your grill, and medium-low heat on the other. You will need just a few briquettes on the cooler side of the grill to maintain the low heat. (If using a gas grill, heat one side of the grill to medium-high heat and the other to low.)|:|When the grill is hot and ready to go, brush the grill grates with some olive oil. Season the steaks generously with salt and pepper. Place the steaks on the hot side of the grill for 3 to 4 minutes, then flip and grill for another 4 minutes. Once the steaks have a nice caramelized crust, move them to the cooler part of the grill, and continue cooking for 6 to 7 minutes for medium rare, or 8 to 9 minutes for medium. Remove the steaks from grill, and tent loosely with foil to keep warm. Let the steaks rest for 5 minutes, so the juices can redistribute throughout the meat. Spread steaks with the roasted shallot and herb butter.|:|ROASTED SHALLOT AND HERB BUTTER: |:| Roasting the shallot gives it a deep, sweet flavor, and the lemon zest lightens the whole thing up. This butter would also be an excellent topping for fish or chicken. |:| Preheat the oven to 350 degrees F. Place the shallot on a square of foil, drizzle lightly with olive oil, and season with salt and pepper. Fold up the foil into a little packet, and place in the oven for 1 hour. Let cool completely. Pulse the roasted shallot and remaining ingredients in a food processor until combined but still coarse. Scrape the butter onto a piece of plastic wrap, spread it across lengthwise, and roll into a log. Twist the ends to seal. Place in the fridge to firm up for at least 35 minutes before serving. |:| When you're grilling such a thick piece of meat, it's best to cook at a high temperature, to sear the outside nicely, then move to the cooler side of the grill, to give the inside of the steak a moment to catch up. This is especially important if you like your steaks the way Pat does, more on the medium side than medium rare.",
                    Description = "There is nothing like a Rib Eye: it is the most flavorful steak you can buy. The thin streams of fat running through this cut of steak create outstanding flavor. You'll only need to season this with salt and pepper, because we're going to make a shallot-and-herb butter to slap on top of this baby once it's off the grill. As with any good steak, let this one rest for a few minutes before digging in. It will be moist and tender. SERVES 4 GENEROUSLY "
                }

            );

            builder.Entity<Tag>().HasData(
                //new Tag() { Id = , Name = }
                new Tag(){ Id = 1, Name = "dessert" },
                new Tag() { Id = 2, Name = "fruit" },
                new Tag() { Id = 3, Name = "grill" },
                new Tag() { Id = 4, Name = "vegan" },
                new Tag() { Id = 5, Name = "entree" },
                new Tag() { Id = 6, Name = "chicken" },
                new Tag() { Id = 7, Name = "sweet and sour" },
                new Tag() { Id = 8, Name = "beef" },
                new Tag() { Id = 9, Name = "vegetable" },
                new Tag() { Id = 10, Name =  "spicy" },
                new Tag() { Id = 11, Name = "Italian" },
                new Tag() { Id = 12, Name = "breakfast" },
                new Tag() { Id = 13, Name = "dairy" },
                new Tag() { Id = 14, Name = "soup"},
                new Tag() { Id = 15, Name = "Mexican"},
                new Tag() { Id = 16, Name = "Weight Watchers"},
                new Tag() { Id = 17, Name = "Kid Friendly Fun"},
                new Tag() { Id = 18, Name = "contains apple"},
                new Tag() { Id = 19, Name = "sauce" },
                new Tag() { Id = 20, Name = "steak" }
                );

            builder.Entity<RecipeTag>().HasData(
                //new RecipeTag() { Id = , RecipeId = , TagId = }
                new RecipeTag() { Id = 1, RecipeId = 1, TagId = 1 },
                new RecipeTag() { Id = 2, RecipeId = 1, TagId = 2 },
                new RecipeTag() { Id = 3, RecipeId = 1, TagId = 3 },
                new RecipeTag() { Id = 4, RecipeId = 1, TagId = 4 },
                new RecipeTag() { Id = 5, RecipeId = 2, TagId = 5 },
                new RecipeTag() { Id = 6, RecipeId = 2, TagId = 6 },
                new RecipeTag() { Id = 7, RecipeId = 2, TagId = 7 },
                new RecipeTag() { Id = 8, RecipeId = 3, TagId = 5 },
                new RecipeTag() { Id = 9, RecipeId = 3, TagId = 8 },
                new RecipeTag() { Id = 10, RecipeId = 3, TagId = 9 },
                new RecipeTag() { Id = 11, RecipeId = 3, TagId = 10 },
                new RecipeTag() { Id = 12, RecipeId = 3, TagId = 11 },
                new RecipeTag() { Id = 13, RecipeId = 4, TagId = 12},
                new RecipeTag() { Id = 14, RecipeId = 5, TagId = 14},
                new RecipeTag() { Id = 15, RecipeId = 5, TagId = 15},
                new RecipeTag() { Id = 16, RecipeId = 6, TagId = 17},
                new RecipeTag() { Id = 17, RecipeId = 6, TagId = 1},
                new RecipeTag() { Id = 18, RecipeId = 7, TagId = 1},
                new RecipeTag() { Id = 19, RecipeId = 7, TagId = 18},
                new RecipeTag() { Id = 20, RecipeId = 8, TagId = 9},
                new RecipeTag() { Id = 21, RecipeId = 8, TagId = 14},
                new RecipeTag() { Id = 22, RecipeId = 9, TagId = 9},
                new RecipeTag() { Id = 23, RecipeId = 10, TagId = 20}
                );


            builder.Entity<User>().HasData(
                new User( 1, "Ziyah", "Ziyah123", "12345")               
                );


            base.OnModelCreating(builder);
        }


    }
}
