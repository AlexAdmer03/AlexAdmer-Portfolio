using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Models;
using PortfolioLibrary.Models;

namespace PortfolioAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class PortfolioController : Controller
    {
        private static List<ProjectsModel> Projects = new List<ProjectsModel>
        {
            new ProjectsModel
            {
                ProjectId = 1,
                ProjectName = "Rabbit Bank",
                CreatedDate = new DateTime(2023, 03, 21),
                LastUptade = new DateTime(2023, 05, 23),
                Description =
                    "Bank System Administration Web Application Detta webbprogram utvecklades som en del av en " +
                    ".NET Webbutvecklingskursuppgift." +
                    " Det är ett verktyg för administration av banksystem implementerat med ASP.NET Core." +
                    " Det möjliggör effektiv hantering av bankkunder, deras konton, saldon och transaktioner.",
                Author = "Alex Admér",
                PreviewURL = "https://rabbitbank.azurewebsites.net/",
                GithubURL = "https://github.com/AlexAdmer03/RabbitBank",
                Image = "https://i.imgur.com/TBSG51r.jpg",
                Category = "Web applikation",
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
                CreatedDate = new DateTime(2023, 03, 09),
                LastUptade = new DateTime(2023, 03, 17),
                Description =
                    "I detta individuella projekt är uppgiften att bygga två sidor (Homepage & Contact page) för en e-handelswebbplats som heter Fixxo. " +
                    "Projektet tillhandahåller en designfil i XD-format, som kan öppnas med Adobe XD eller Sketch. " +
                    "Målet är att implementera designen för startsidan och kontaktsidan, och göra nödvändiga designbeslut på grund av avvikelser från standardpraxis för webbdesign. " +
                    "Webbplatsen kan byggas med statiska HTML-filer eller teknologier som React. För att klara projektet måste alla komponenter på startsidan och kontaktsidan implementeras med en bra kodstruktur," +
                    " utnyttja flexbox och CSS-grid där det är lämpligt. Knappar och länkar bör ha animationer eller övergångar. För att få ett högre betyg bör SCSS användas för att strukturera CSS, " +
                    "kontaktformuläret bör valideras med JavaScript med lämpliga felmeddelanden, och formulärdata bör skickas till en tillhandahållen webb-API som visar ett bekräftelsemeddelande. " +
                    "Ytterligare ska startsidan visa produkter som hämtas från ett annat tillhandahållet webb-API.",
                Author = "Alex Admér",
                PreviewURL = "", //!!!!!!!!!!!!!!!!!!!!!!!!!!!
                GithubURL = "https://github.com/AlexAdmer03/FIXXO-Assignment",
                Image = "https://i.imgur.com/sgqITC3.jpg",
                Category = "Frontend projekt",
                SystemStructure = new SystemStructureModel
                {
                    ProgrammingLanguages = new List<string> { "css", "html", "scss", "Javascript" },
                    Platforms = new List<string> { "" },
                    Tools = new List<string> { "Github", "Visual code" },
                }
            },
            new ProjectsModel
            {
                ProjectId = 3,
                ProjectName = "Annons Web-API",
                CreatedDate = new DateTime(2023, 04, 20),
                LastUptade = new DateTime(2023, 05, 16),
                Description =
                    "Det här projektet handlar om att skapa en .NET WebAPI (RESTful) för att hantera annonser. API:et ska använda ASP.NET Core och databasen ska vara SQL Server implementerad med Code First. " +
                    "API:et ska vara RESTful och stödja olika HTTP-metoder för att utföra olika åtgärder på annonserna, inklusive GET för att lista alla annonser, GET med ett specifikt ID för att lista en enskild annons, " +
                    "POST för att skapa en ny annons, DELETE för att ta bort en annons och PUT för att uppdatera en annons (total uppdatering). Korrekta HTTP-statuskoder ska returneras för varje åtgärd.",
                Author = "Alex Admér",
                PreviewURL = "", //!!!!!!!!!!!!!!!!
                GithubURL = "https://github.com/AlexAdmer03/Api-Advert-assignment/tree/master",
                Image = "https://i.imgur.com/PSm6D5Y.jpg",
                Category = "API",
                SystemStructure = new SystemStructureModel
                {
                    ProgrammingLanguages = new List<string> { "C#" },
                    FrameworksAndLibraries = new List<string> { "Entity Framework" },
                    Platforms = new List<string> { "Swagger" },
                    Tools = new List<string> { "Visual studio", "ASP .NET Core Web API" },
                    Databases = new List<DatabaseModel>
                    {
                        new DatabaseModel
                        {
                            Name = "AdvertAPI",
                            Type = "SQL-Database",
                            Version = "18. 12. 1",
                            HostName = "Local Host",
                            Tables = new List<string>
                            {
                                "dbo.__EFMigrationsHistory",
                                "dbo.AdDbSet"
                            }
                        }
                    },
                    Api = new List<ApiModel>
                    {
                        new ApiModel
                        {
                            Name = "Annons Web-API",
                            Description =
                                "Det här projektet handlar om att skapa en .NET WebAPI (RESTful) för att hantera annonser. API:et ska använda ASP.NET Core och databasen ska vara SQL Server implementerad med Code First. " +
                                "API:et ska vara RESTful och stödja olika HTTP-metoder för att utföra olika åtgärder på annonserna, inklusive GET för att lista alla annonser, GET med ett specifikt ID för att lista en enskild annons, " +
                                "POST för att skapa en ny annons, DELETE för att ta bort en annons och PUT för att uppdatera en annons (total uppdatering). Korrekta HTTP-statuskoder ska returneras för varje åtgärd.",
                            URL = "https://localhost:7277/swagger/index.html",
                            Type = "Web-API"
                        }
                    }
                }
            }

        };
        [HttpGet]

        public async Task<ActionResult<List<ProjectsModel>>> GetAll()
        {
            return Ok(Projects);
        }

    }
}
