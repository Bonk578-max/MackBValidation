using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MackBMCValidation.Services
{
    public class MCTenServices
    {
        public string RandomizedRestaurant(string foodcategory)
        {
            switch (foodcategory.ToLower())
            {
                case "fancy":
                    Random rnd = new Random();
                    int fancy = rnd.Next(1, 11);
                    switch (fancy)
                    {
                        case 1:
                            return "How about Le Bernardin? That sounds exquisite.";
                            
                        case 2:
                            return "How about Quince? That sounds exquisite.";
                            
                        case 3:
                            return "How about Daniel? That sounds exquisite.";
                            
                        case 4:
                            return "How about Eleven Madison Park? That sounds exquisite.";
                            
                        case 5:
                            return "How about Per Se? That sounds exquisite.";
                            
                        case 6:
                            return "How about Alinea? That sounds exquisite.";
                            
                        case 7:
                            return "How about Gramercy Tavern? That sounds exquisite.";
                            
                        case 8:
                            return "How about The French Laundry? That sounds exquisite.";
                            
                        case 9:
                            return "How about Masa? That sounds exquisite.";
                            
                        case 10:
                            return "How about Chez Panisse? That sounds exquisite.";
                            
                        default:
                            return "Please enter valid input.";
                            
                    }
                    
                case "fried":
                    Random rnd2 = new Random();
                    int fried = rnd2.Next(1, 11);
                    switch (fried)
                    {
                        case 1:
                            return "How about Southern Comfort Fried Chicken? That sounds delicious.";
                            
                        case 2:
                            return "How about The Fry? That sounds delicious.";
                            
                        case 3:
                            return "How about Crispy Dragon? That sounds delicious.";
                            
                        case 4:
                            return "How about Golden Wok Fried? That sounds delicious.";
                            
                        case 5:
                            return "How about Deep Fryer's Paradise? That sounds delicious.";
                            
                        case 6:
                            return "How about The Crispy Lotus? That sounds delicious.";
                            
                        case 7:
                            return "How about Fried & True? That sounds delicious.";
                            
                        case 8:
                            return "How about Golden Crisp Kitchen? That sounds delicious.";
                            
                        case 9:
                            return "How about Crunch House? That sounds delicious.";
                            
                        case 10:
                            return "How about Deep Fried Delights? That sounds delicious.";
                            
                        default:
                            return "Please enter valid input.";
                            
                    }
                    
                case "old timey":
                    Random rnd3 = new Random();
                    int oldTimey = rnd3.Next(1, 11);
                    switch (oldTimey)
                    {
                        case 1:
                            return "How about Rustic Kitchen Tavern? That sounds wonderful.";
                            
                        case 2:
                            return "How about The Heritage Diner? That sounds wonderful.";
                            
                        case 3:
                            return "How about Grandma's Table? That sounds wonderful.";
                            
                        case 4:
                            return "How about The Old Homestead? That sounds wonderful.";
                            
                        case 5:
                            return "How about Classic Comfort House? That sounds wonderful.";
                            
                        case 6:
                            return "How about Vintage Kitchen? That sounds wonderful.";
                            
                        case 7:
                            return "How about The Country Inn? That sounds wonderful.";
                            
                        case 8:
                            return "How about Main Street Diner? That sounds wonderful.";
                            
                        case 9:
                            return "How about The Nostalgia Grill? That sounds wonderful.";
                            
                        case 10:
                            return "How about Old Recipes Bistro? That sounds wonderful.";
                            
                        default:
                            return "Please enter valid input.";
                            
                    }
                case "default":
                {
                    return "Please enter only either 'fancy', 'fried', or 'old timey' as a category." ;  
                }
                    
            }
        return "Please enter only either 'fancy', 'fried', or 'old timey' as a category." ;  
        }
    }
}