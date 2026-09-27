using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.Run();

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        List<Product> products = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                ProductName = "Laptop",
                Description = "HP Laptop",
                Price = 55000,
                Quantity = 10
            },

            new Product
            {
                ProductId = 2,
                ProductName = "Mobile",
                Description = "Samsung Mobile",
                Price = 25000,
                Quantity = 15
            },

            new Product
            {
                ProductId = 3,
                ProductName = "Headphones",
                Description = "Wireless Headphones",
                Price = 2000,
                Quantity = 20
            }
        };

        string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Product Catalog</title>

    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 30px;
            background-color: white;
        }

        h1 {
            font-size: 32px;
            margin-bottom: 30px;
        }

        table {
            border-collapse: collapse;
            width: 700px;
        }

        th, td {
            border: 1px solid #aaa;
            padding: 8px;
            text-align: left;
        }

        th {
            font-weight: bold;
            background-color: #f5f5f5;
        }

        tr {
            height: 35px;
        }
    </style>
</head>

<body>

    <h1>Product Catalog</h1>

    <table>

        <tr>
            <th>Product ID</th>
            <th>Product Name</th>
            <th>Description</th>
            <th>Price</th>
            <th>Quantity</th>
        </tr>

        <tr>
            <td>1</td>
            <td>Laptop</td>
            <td>HP Laptop</td>
            <td>55000</td>
            <td>10</td>
        </tr>

        <tr>
            <td>2</td>
            <td>Mobile</td>
            <td>Samsung Mobile</td>
            <td>25000</td>
            <td>15</td>
        </tr>

        <tr>
            <td>3</td>
            <td>Headphones</td>
            <td>Wireless Headphones</td>
            <td>2000</td>
            <td>20</td>
        </tr>

    </table>

</body>
</html>
";

        return Content(html, "text/html");
    }
}