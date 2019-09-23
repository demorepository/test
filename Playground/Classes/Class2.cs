
using Playground.CatalogB;
using System.Collections.Generic;

namespace Playground
    {
    public class Class2
        {

        public Product product1 = new Product
            {
            Id = 1,
            Name = "Kawa",
            City = "Gdansk",
            Details = new Details
                {
                Id = 1,
                Name = "Kawowe",
                City = "Test"
                },
            Categories = new List<Category>
                {
                new Category
                    {
                    Id = 1,
                    Name = "Kawowe",
                    isAvailable = true
                    },

                new Category
                    {
                    Id = 2,
                    Name = "Kawtest",
                    isAvailable = false
                    }

                }

            };
        public List<Product> listOfProducts = new List<Product>()
            {
                 new Product
            {
            Id = 1,
            Name = "Kawa",
            City = "Gdansk",
            Details = new Details
                {
                Id = 1,
                Name = "Kawowe",
                City = "Test"
                },
            Categories = new List<Category>
                {
                new Category
                    {
                    Id = 1,
                    Name = "Kawowe",
                    isAvailable = true
                    },

                new Category
                    {
                    Id = 2,
                    Name = "Kawtest",
                    isAvailable = false
                    }

                },

            },
                 new Product()
                     {
                      Id = 1,
           Name = "Kawa",
           City = "Gdansk",
           Details = new Details
               {
               Id = 1,
               Name = "Kawowe",
               City = "Test"
               },
           Categories = new List<Category>
                {
                new Category
                    {
                    Id = 1,
                    Name = "Kawowe",
                    isAvailable = true
                    },

                new Category
                    {
                    Id = 2,
                    Name = "Kawtest",
                    isAvailable = false
                    }

                }
                     }

            };

        public List<Product> returnProducts ( )
            {
            return listOfProducts;

            }

        public List<Product> findById (int num)
            {
            foreach ( var item in listOfProducts )
                {
                if ( item.Id == num )
                    {
                     num = item.Id;
                    }
                }
            return listOfProducts;
            }

        }



    }


