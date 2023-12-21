using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class FoodRatings
    {
        private class FoodItem
        {
            public string Cuisine { get; set; }
            public int Rating { get; set; }

            public FoodItem(string cuisine, int rating)
            {
                Cuisine = cuisine;
                Rating = rating;
            }
        }

        private Dictionary<string, FoodItem> foodItems;
        private Dictionary<string, SortedDictionary<int, SortedSet<string>>> cuisineRatings;

        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            foodItems = new Dictionary<string, FoodItem>();
            cuisineRatings = new Dictionary<string, SortedDictionary<int, SortedSet<string>>>();

            for (int i = 0; i < foods.Length; i++)
            {
                string food = foods[i];
                string cuisine = cuisines[i];
                int rating = ratings[i];

                foodItems[food] = new FoodItem(cuisine, rating);

                if (!cuisineRatings.ContainsKey(cuisine))
                    cuisineRatings[cuisine] = new SortedDictionary<int, SortedSet<string>>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

                if (!cuisineRatings[cuisine].ContainsKey(rating))
                    cuisineRatings[cuisine][rating] = new SortedSet<string>();

                cuisineRatings[cuisine][rating].Add(food);
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            var foodItem = foodItems[food];
            cuisineRatings[foodItem.Cuisine][foodItem.Rating].Remove(food);

            if (!cuisineRatings[foodItem.Cuisine][foodItem.Rating].Any())
                cuisineRatings[foodItem.Cuisine].Remove(foodItem.Rating);

            foodItem.Rating = newRating;

            if (!cuisineRatings[foodItem.Cuisine].ContainsKey(newRating))
                cuisineRatings[foodItem.Cuisine][newRating] = new SortedSet<string>();

            cuisineRatings[foodItem.Cuisine][newRating].Add(food);
        }

        public string? HighestRated(string cuisine) => cuisineRatings[cuisine].First().Value.Min;
    }
    /*
    * Your FoodRatings object will be instantiated and called as such:
    * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
    * obj.ChangeRating(food,newRating);
    * string param_2 = obj.HighestRated(cuisine);
    */
}
