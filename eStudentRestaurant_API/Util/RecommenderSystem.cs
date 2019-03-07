using eStudentRestaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eStudentRestaurant_API.Util
{
    public class RecommenderSystem
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        Dictionary<int, List<Rating>> products = new Dictionary<int, List<Rating>>();

        public List<Product> GetRecommendedProducts(int productId)
        {
            GetProductsData(productId);

            List<Rating> ratingsOfThisProduct = db.Rating.Where(x => x.ProductID == productId).OrderBy(x => x.StudentID).ToList();

            List<Rating> ratings1 = new List<Rating>();
            List<Rating> ratings2 = new List<Rating>();

            List<Product> recommendedProduct = new List<Product>();

            foreach (var prod in products)
            {
                foreach (Rating r in ratingsOfThisProduct)
                {
                    if (prod.Value.Where(x=>x.StudentID == r.StudentID).Count() > 0)
                    {
                        ratings1.Add(r);
                        ratings2.Add(prod.Value.Where(x => x.StudentID == r.StudentID).First());
                    }
                }

                double similarity = 0;
                similarity = GetSimilarity(ratings1, ratings2);

                if (similarity > 0.6)
                {
                    recommendedProduct.Add(db.Product.Where(p => p.ProductID == prod.Key).FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }

            return recommendedProduct;
           
        }

        private double GetSimilarity(List<Rating> ratings1, List<Rating> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }

            double numerator = 0, denominator1 = 0, denominator2 = 0;

            for (int i = 0; i < ratings1.Count; i++)
            {
                numerator = ratings1[i].Rating1 * ratings2[i].Rating1;

                denominator1 = ratings1[i].Rating1 * ratings1[i].Rating1*1.0;
                denominator2 = ratings2[i].Rating1 * ratings2[i].Rating1*1.0;

            }
            denominator1 = Math.Sqrt(denominator1);
            denominator2 = Math.Sqrt(denominator2);

            double denominator = denominator1 * denominator2;
            if (denominator == 0)
            {
                return 0;
            }
            else
            {
                return numerator / denominator;
            }

        }



        private void GetProductsData(int productId)
        {
            List<Product> activeProduct = db.Product.Where(x => x.ProductID != productId && x.Status == true).ToList();
            List<Rating> ratings;

            foreach (Product item in activeProduct)
            {
                ratings = db.Rating.Where(x => x.ProductID == item.ProductID).OrderBy(x => x.StudentID).ToList();

                if (ratings.Count > 0)
                {
                    products.Add(item.ProductID, ratings);
                }
            }


        }
    }
}