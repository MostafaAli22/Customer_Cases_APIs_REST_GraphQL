# APISolution
 API solution Demo built with ASP.NET Core 8, Entity Framework Core, and Hot Chocolate GraphQL. This project demonstrates how to implement both REST and GraphQL endpoints to manage Customers and their associated Cases.

🌟 Features
✅ REST API with full CRUD operations for Customers and Cases
✅ GraphQL support using Hot Chocolate with filtering, sorting, projections, and pagination
✅ EF Core database integration with SQL Server
✅ Reference loop handling with Newtonsoft.Json
✅ Interactive Swagger UI for REST API documentation
✅ GraphQL Playground (Banana Cake Pop) for schema exploration and query testing



🛠️ Technologies Used:


✅ ASP.NET Core 8

✅ Entity Framework Core

✅ Hot Chocolate GraphQL

✅ SQL Server

✅ Swagger (Swashbuckle)

✅ Newtonsoft.Json


🚀 Getting Started
📥 Clone the Repository

git clone [https://github.com/MostafaAli22/Customer_Cases_APIs_REST_GraphQL.git](https://github.com/MostafaAli22/Customer_Cases_APIs_REST_GraphQL)


🔧 Set Up the Database
Create the Database Manually (Optional):
Run the provided SQL script Create_CustomerCasesDB.sql to create the initial database and tables:


-- Open SQL Server Management Studio (SSMS) or your preferred SQL tool
-- Run the script:
-- Create_CustomerCasesDB.sql
OR Use EF Core Migrations:
Update appsettings.json with your SQL Server connection string:


"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=CustomerCasesDB;Trusted_Connection=True;"
}
Run EF Core migrations:


dotnet ef database update

Open appsettings.json and update the SQL Server connection string:


"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=CustomerCasesDB;Trusted_Connection=True;"
}
Apply migrations:


dotnet ef database update
▶️ Run the Application

dotnet run
🌐 Access the APIs
Swagger UI (REST): https://localhost:7021/swagger

GraphQL Playground: https://localhost:7021/graphql

📚 Example GraphQL Queries
🔍 Get All Customers with Cases

query {
  customers {
    customerID
    firstName
    lastName
    cases {
      caseID
      title
      description
    }
  }
}
🔍 Get a Specific Case by ID

query {
  case(caseID: 1001) {
    caseID
    title
    description
    customer {
      customerID
      firstName
    }
  }
}
🔍 Paginate Cases

query {
  cases(take: 5, skip: 10) {
    caseID
    title
  }
}
✍️ Update Customer Email

mutation {
  updateCustomerEmail(customerID: 1002, email: "mostafa@mail.com") {
    customerID
    email
  }
}



🙌 Contributing
Feel free to open issues, submit pull requests, or suggest features!
