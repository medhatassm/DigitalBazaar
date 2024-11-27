# Digital Bazaar

Digital Bazaar is a dynamic e-commerce platform dedicated to electronic products, bringing innovation and motion to online shopping. 🛒 💻 Users can sign up as **Customers** 👥, **Admins** ⚙️, or **Companies** 🏢, each with customized features and permissions. Customers can easily browse and purchase products 🛍️, Admins ensure smooth operations and manage transactions 🔧, and Companies can showcase their products directly to users 📦. The platform provides a flexible, secure, and engaging experience, offering tailored solutions for each user type 🎯.

---

## Covered Content
- N-Tier Architecture.
- Repository Pattern & Unite of Work.
- TempData / ViewBag / ViewData in .Net Core.
- API Controllers with Razor Pages.
- Sweet Alert / Rich Text Editor / Data Tables with .Net Core.
- Scaffold Identity (Razor Class Library).
- Roles and Authorization in .Net Core.
- Strip Payment / Refund with .Net Core.
- Session in .Net Core.
- Emails With Send Grid.
- User Management.
- Social Login Using Google Account & Facebook Account.
- Seed Db with DbInitializer
- Deploy to Azure

---

# First - Category CRUD Operations

## Database Category Table (UML)

| Properties | Data Type | Configuration Conventions                          |
| -- | --- |----------------------------------------------------|
| Id | int | - Primary Key <br/>- Auto Increment                |
| Title | string | - Required <br/> - MaxLength(30)                   |
| Count | int | - Default Value: 0                                 |
| Priority | int | - Default Value: 0 <br/> - Required <br/> - Unique 
| CreatedDate | DateTime | - Default Value:  `GETDATE()` <br/> - Required     |
| UpdatedDate | DateTime? | - Nullable <br/> - Auto Increment                  |
| IsActive | bool | - Default Value:  `true` <br/> - Required          |

### **NuGet Packages**

- microsoft.EntityFrameworkCore.Tools
- microsoft.EntityFrameworkCore.SqlServer

### Features Completed

- Display All Category into List.
- Insert New Category To Database.
- Update Category Data and Save it to Database.
- Delete Category From Database.

### ASP.Net Tools

- Entity Framework To Deal With Database.
- Dependency Injection To Set DbContext Configuration.
- MVC Pattern To Build The Project.
- Using Data Annotation For Configuration Convention.

### Tools and Resources

- [Bootswatch - Litera Theme](https://bootswatch.com/litera/)
- [Toastr](https://github.com/CodeSeven/toastr)

---

