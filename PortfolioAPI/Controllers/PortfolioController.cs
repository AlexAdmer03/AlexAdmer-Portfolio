using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Models;
using PortfolioLibrary.Models;

namespace PortfolioAPI.Controllers
{
    public class PortfolioController : Controller
    {
        private static List<ProjectsModel> Projects = new List<ProjectsModel>
        {
            new ProjectsModel
            {
                ProjectId = 1,
                ProjectName = "Rabbit Bank",
                CreatedDate = new DateTime(21 - 03 - 2023),
                LastUptade = new DateTime(23 - 05 - 2023),
                Description =
                    "Bank System Administration Web Application This web application was developed as part of a " +
                    ".NET Web Development course assignment." +
                    " It is a banking system administration tool implemented using ASP.NET Core." +
                    " It enables efficient management of bank customers, their accounts, balances, and transactions.",
                Author = "Alex Admér",
                PreviewURL = "", //!!!!!!!!!!!!!!!!
                GithubURL = "https://github.com/AlexAdmer03/RabbitBank",
                Image = "https://imgur.com/a/BTo5dnF",
                Category = "Web application",
                SystemStructure = new SystemStructureModel
                {
                    ProgrammingLanguages = new List<string> { "c#", "css", "html", "javascript", },
                    FrameworksAndLibraries = new List<string> { "Entity Framework", "Asp .NET" },
                    Platforms = new List<string> { "Azure" },
                    Tools = new List<string> { "Github", "Visual Studio", "Bootstrap" },
                    Databases = new List<DatabaseModel>
                    {
                        new DatabaseModel
                        {
                            Name = "BankAppData",
                            Type = "SQL-database",
                            Version = "18. 12. 1",
                            HostName = "alex-dbserver.database.windows.net",
                            Tables = new List<string>
                            {
                                "dbo._EFMigrationsHistory",
                                "dbo.Accounts",
                                "dbo.AspNetRoleClaims",
                                "dbo.AspNetRoles",
                                "dbo.ApsNetUserClaims",
                                "dbo.AspNetUserLogins",
                                "dbo.AspNetUserRoles",
                                "dbo.AspNetUserTokens",
                                "dbo.AspNetUsers",
                                "dbo.Cards",
                                "dbo.Customers",
                                "dbo.Dispositions",
                                "dbo.Loans",
                                "dbo.PermenentOrder",
                                "dbo.Transactions",
                                "dbo.User",
                            }
                        },

                        new DatabaseModel
                        {
                            Name = "BankAppData",
                            Type = "SQL-database",
                            Version = "18. 12. 1",
                            HostName = "Local Host",
                            Tables = new List<string>
                            {
                                "dbo._EFMigrationsHistory",
                                "dbo.Accounts",
                                "dbo.AspNetRoleClaims",
                                "dbo.AspNetRoles",
                                "dbo.ApsNetUserClaims",
                                "dbo.AspNetUserLogins",
                                "dbo.AspNetUserRoles",
                                "dbo.AspNetUserTokens",
                                "dbo.AspNetUsers",
                                "dbo.Cards",
                                "dbo.Customers",
                                "dbo.Dispositions",
                                "dbo.Loans",
                                "dbo.PermenentOrder",
                                "dbo.Transactions",
                                "dbo.User",
                            }
                        }

                    }

                }

            },
            new ProjectsModel
            {
                ProjectId = 2,
                ProjectName = "FIXXO",
                CreatedDate = new DateTime(09-03-2023),
                LastUptade = new DateTime(17-03-2023),
                Description = "In this individual project, the task is to build two pages for an e-commerce website called Fixxo. " +
                              "The project provides a design file in XD format, which can be opened with Adobe XD or Sketch. " +
                              "The goal is to implement the design of the Home and Contacts pages, making necessary design decisions due to deviations from standard web design practices. " +
                              "The website can be built using static HTML files or technologies like React. To pass the project, all components on the Home and Contacts pages need to be implemented with a good code structure," +
                              " utilizing flexbox and CSS grid where appropriate. Buttons and links should have animations or transitions. To achieve a higher grade, SCSS should be used for structuring CSS, the contact form should be validated using JavaScript with appropriate error messages, " +
                              "and the form data should be submitted to a provided web API, displaying a confirmation message." +
                              " Additionally, the Home page should display products retrieved from another provided web API.",
                Author = "Alex Admér",
                PreviewURL = "",//!!!!!!!!!!!!!!!!!!!!!!!!!!!
                GithubURL = "https://github.com/AlexAdmer03/FIXXO-Assignment",
                Image = "https://imgur.com/a/ARihHFj",
                Category = "Frontend project",
                SystemStructure = new SystemStructureModel
                {
                    ProgrammingLanguages = new List<string> { "css", "html", "scss", },
                    Platforms = new List<string> { "" },
                    Tools = new List<string> { "Github", "Visual code"},
                }
            }

        };

        public IActionResult Index()
        {
            return View();
        }
    }
}
