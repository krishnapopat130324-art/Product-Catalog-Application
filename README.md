# Product Catalog Application

A simple **Product Catalog Application** built using **ASP.NET Core and C#**. The application displays product details in a clean and simple table format.

## Features

* Displays Product ID
* Displays Product Name
* Displays Product Description
* Displays Product Price
* Displays Product Quantity
* Simple and easy-to-understand implementation
* Single-file implementation using `Program.cs`

## Technologies Used

* C#
* ASP.NET Core
* HTML
* CSS

## Product Details

| Product ID | Product Name | Description         | Price | Quantity |
| ---------- | ------------ | ------------------- | ----- | -------- |
| 1          | Laptop       | HP Laptop           | 55000 | 10       |
| 2          | Mobile       | Samsung Mobile      | 25000 | 15       |
| 3          | Headphones   | Wireless Headphones | 2000  | 20       |

## Project Structure

```text
Product-Catalog-Application/
│
└── Program.cs
```

## How to Run

### 1. Clone the Repository

```bash
git clone https://github.com/krishnapopat130324-art/Product-Catalog-Application.git
```

### 2. Open the Project

Open the project folder in **Visual Studio Code** or **Visual Studio**.

### 3. Run the Application

Open the terminal in the project folder and execute:

```bash
dotnet run
```

### 4. Open in Browser

After running the application, the terminal will display a localhost URL.

Open that URL in your browser to view the **Product Catalog**.

## Output

The application displays the following product catalog:

```text
Product Catalog

-----------------------------------------------------------------
Product ID | Product Name | Description           | Price | Quantity
-----------------------------------------------------------------
1          | Laptop       | HP Laptop             | 55000 | 10
2          | Mobile       | Samsung Mobile        | 25000 | 15
3          | Headphones   | Wireless Headphones   | 2000  | 20
-----------------------------------------------------------------
```

## Application Architecture

The application follows a simple **MVC-based concept**:

* **Model:** Represents product information.
* **Controller:** Provides product data.
* **View:** Displays the product catalog using HTML.

The complete implementation is contained in a single `Program.cs` file.

## Author

**Krishna Popat**
