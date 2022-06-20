using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added successfully";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "System maintenance";
        public static string ProductsListed = "Products listed";
        public static string ProductCountOfCategoryError = "A category can have up to 10 products";
        public static string ProductNameAlreadyExists = "ProductName already Exists";
        public static string CategoryLimitExceed = "Category Limit Exceed";
        public static string AuthorizationDenied = "You are not authorized";
    }
}
