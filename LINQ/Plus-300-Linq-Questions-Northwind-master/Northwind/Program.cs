using System;
using System.Linq;

namespace Northwind
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Easy: These questions focus on basic filtering, selection, and simple aggregation.

            #region Easy Questions (1-20)

            #region 1. Get all customers from Germany.
            // 1. Get all customers from Germany.
            #endregion

            #region 2. Find all products with a unit price greater than $25.
            // 2. Find all products with a unit price greater than $25.
            #endregion

            #region 3. List the full names of all employees.
            // 3. List the full names of all employees.
            #endregion

            #region 4. Find all discontinued products.
            // 4. Find all discontinued products.
            #endregion

            #region 5. Get the total number of customers.
            // 5. Get the total number of customers.
            #endregion

            #region 6. List all unique countries where customers are located.
            // 6. List all unique countries where customers are located.
            #endregion

            #region 7. Get all products with a UnitPrice of exactly $10.00.
            // 7. Get all products with a UnitPrice of exactly $10.00.
            #endregion

            #region 8. Find all employees who are Sales Representatives.
            // 8. Find all employees who are Sales Representatives.
            #endregion

            #region 9. List the names of all shippers.
            // 9. List the names of all shippers.
            #endregion

            #region 10. Get all orders placed on August 1, 1997.
            // 10. Get all orders placed on August 1, 1997.
            #endregion

            #region 11. Find the product with the highest unit price.
            // 11. Find the product with the highest unit price.
            #endregion

            #region 12. List all suppliers from the USA.
            // 12. List all suppliers from the USA.
            #endregion

            #region 13. Get all orders that have a freight cost less than $30.
            // 13. Get all orders that have a freight cost less than $30.
            #endregion

            #region 14. Find all products that are not discontinued.
            // 14. Find all products that are not discontinued.
            #endregion

            #region 15. Get the total number of categories.
            // 15. Get the total number of categories.
            #endregion

            #region 16. List the CompanyName and ContactName for all customers in the UK.
            // 16. List the CompanyName and ContactName for all customers in the UK.
            #endregion

            #region 17. Find the total number of products in stock.
            // 17. Find the total number of products in stock.
            #endregion

            #region 18. List all products with a unit price that is a multiple of 5.
            // 18. List all products with a unit price that is a multiple of 5.
            #endregion

            #region 19. Find all products where UnitsOnOrder is 0.
            // 19. Find all products where UnitsOnOrder is 0.
            #endregion

            #region 20. Get the average unit price of all products.
            // 20. Get the average unit price of all products.
            #endregion

            #endregion

            // Medium: These questions require grouping, ordering, and simple subqueries.

            #region Medium Questions (21-50)

            #region 21. Get the total number of products in each category.
            // 21. Get the total number of products in each category.
            #endregion

            #region 22. Retrieve the average unit price of products for each category.
            // 22. Retrieve the average unit price of products for each category.
            #endregion

            #region 23. Get all categories with more than 5 products.
            // 23. Get all categories with more than 5 products.
            #endregion

            #region 24. Find the top 5 customers who have placed the highest number of orders.
            // 24. Find the top 5 customers who have placed the highest number of orders.
            #endregion

            #region 25. Retrieve the average unit price of products in the "Beverages" category.
            // 25. Retrieve the average unit price of products in the "Beverages" category.
            #endregion

            #region 26. Find the supplier with the most products.
            // 26. Find the supplier with the most products.
            #endregion

            #region 27. Retrieve the names of all customers who have placed at least 3 orders.
            // 27. Retrieve the names of all customers who have placed at least 3 orders.
            #endregion

            #region 28. Get the total number of orders placed by customers from each city.
            // 28. Get the total number of orders placed by customers from each city.
            #endregion

            #region 29. List all employees who are managers.
            // 29. List all employees who are managers.
            #endregion

            #region 30. Get the total freight cost for each shipper and list them in ascending order.
            // 30. Get the total freight cost for each shipper and list them in ascending order.
            #endregion

            #region 31. Find the top 3 cities with the most customers.
            // 31. Find the top 3 cities with the most customers.
            #endregion

            #region 32. Get all orders that were shipped on the same date they were ordered.
            // 32. Get all orders that were shipped on the same date they were ordered.
            #endregion

            #region 33. List all products that have a unit price greater than the average unit price of all products.
            // 33. List all products that have a unit price greater than the average unit price of all products.
            #endregion

            #region 34. Find all orders where the freight cost is below the average freight cost for the year 1997.
            // 34. Find all orders where the freight cost is below the average freight cost for the year 1997.
            #endregion

            #region 35. List the names of all employees who have processed orders.
            // 35. List the names of all employees who have processed orders.
            #endregion

            #region 36. Get the total number of products supplied by each supplier.
            // 36. Get the total number of products supplied by each supplier.
            #endregion

            #region 37. Retrieve the names of customers who have ordered products with a unit price greater than $50.
            // 37. Retrieve the names of customers who have ordered products with a unit price greater than $50.
            #endregion

            #region 38. Find the total freight cost for all orders shipped to the USA.
            // 38. Find the total freight cost for all orders shipped to the USA.
            #endregion

            #region 39. List all employees who do not report to a manager.
            // 39. List all employees who do not report to a manager.
            #endregion

            #region 40. Find the product with the lowest `UnitsInStock`.
            // 40. Find the product with the lowest `UnitsInStock`.
            #endregion

            #region 41. Get the number of products on order for each supplier.
            // 41. Get the number of products on order for each supplier.
            #endregion

            #region 42. List all orders that were shipped to a city in a specific region (e.g., 'CA').
            // 42. List all orders that were shipped to a city in a specific region (e.g., 'CA').
            #endregion

            #region 43. Get the average discount applied to all order details.
            // 43. Get the average discount applied to all order details.
            #endregion

            #region 44. Find the product with the longest `QuantityPerUnit` string.
            // 44. Find the product with the longest `QuantityPerUnit` string.
            #endregion

            #region 45. Get the number of customers from each country, sorted by count in descending order.
            // 45. Get the number of customers from each country, sorted by count in descending order.
            #endregion

            #region 46. Retrieve the total freight cost for orders placed by each customer.
            // 46. Retrieve the total freight cost for orders placed by each customer.
            #endregion

            #region 47. Find the employee with the most recent hire date.
            // 47. Find the employee with the most recent hire date.
            #endregion

            #region 48. Get the names of all products that have been ordered at least once.
            // 48. Get the names of all products that have been ordered at least once.
            #endregion

            #region 49. Find the orders that have an order date in the year 1997 and a shipped date in 1998.
            // 49. Find the orders that have an order date in the year 1997 and a shipped date in 1998.
            #endregion

            #region 50. Retrieve the names of all customers who have placed more than 5 orders.
            // 50. Retrieve the names of all customers who have placed more than 5 orders.
            #endregion

            #endregion

            // Hard: These questions require complex subqueries, multi-step logic, and advanced aggregation.

            #region Hard Questions (51-70)

            #region 51. Find products that have been ordered more than 50 times in total.
            // 51. Find products that have been ordered more than 50 times in total.
            #endregion

            #region 52. List all products that are in stock but have never been ordered.
            // 52. List all products that are in stock but have never been ordered.
            #endregion

            #region 53. Get the names of all categories that do not have any discontinued products.
            // 53. Get the names of all categories that do not have any discontinued products.
            #endregion

            #region 54. Find the customers who have placed orders with products that have a unit price higher than the average unit price of products in their category.
            // 54. Find the customers who have placed orders with products that have a unit price higher than the average unit price of products in their category.
            #endregion

            #region 55. List the products with the highest quantity ordered for each category.
            // 55. List the products with the highest quantity ordered for each category.
            #endregion

            #region 56. Find the top 5 customers with the highest average order value and the number of orders they have placed.
            // 56. Find the top 5 customers with the highest average order value and the number of orders they have placed.
            #endregion

            #region 57. Retrieve the names of customers who have not ordered any products from the "Seafood" category.
            // 57. Retrieve the names of customers who have not ordered any products from the "Seafood" category.
            #endregion

            #region 58. List all products that are supplied by the supplier with the most products and have been ordered more than the average quantity.
            // 58. List all products that are supplied by the supplier with the most products and have been ordered more than the average quantity.
            #endregion

            #region 59. Find all products that have a reorder level equal to the maximum reorder level for their category.
            // 59. Find all products that have a reorder level equal to the maximum reorder level for their category.
            #endregion

            #region 60. Get the names of employees who have processed orders with a freight cost above the median freight cost of all orders.
            // 60. Get the names of employees who have processed orders with a freight cost above the median freight cost of all orders.
            #endregion

            #region 61. Find the orders that have a ship city different from the customer’s city.
            // 61. Find the orders that have a ship city different from the customer’s city.
            #endregion

            #region 62. List all products that have a UnitPrice greater than the average price in their category and with a ReorderLevel above 10.
            // 62. List all products that have a UnitPrice greater than the average price in their category and with a ReorderLevel above 10.
            #endregion

            #region 63. Find all products that have been ordered in at least 3 different months.
            // 63. Find all products that have been ordered in at least 3 different months.
            #endregion

            #region 64. Get the total sales amount for each customer, including customers who have no orders.
            // 64. Get the total sales amount for each customer, including customers who have no orders.
            #endregion

            #region 65. Find all products that have been ordered by customers from a country that has more than 5 customers.
            // 65. Find all products that have been ordered by customers from a country that has more than 5 customers.
            #endregion

            #region 66. Get all customers who have placed orders with a discount greater than 0.
            // 66. Get all customers who have placed orders with a discount greater than 0.
            #endregion

            #region 67. Find the orders that have products from at least two different categories.
            // 67. Find the orders that have products from at least two different categories.
            #endregion

            #region 68. Find all customers who have ordered from a city that has only one customer.
            // 68. Find all customers who have ordered from a city that has only one customer.
            #endregion

            #region 69. Get the top 5 customers with the most orders that were shipped within 5 days of the order date.
            // 69. Get the top 5 customers with the most orders that were shipped within 5 days of the order date.
            #endregion

            #region 70. Find the names of employees who have shipped orders to more than 5 different countries.
            // 70. Find the names of employees who have shipped orders to more than 5 different countries.
            #endregion

            #endregion
        }
    }
}
