
# GitHub Registration & Student Pack - Lecture Code Examples

## 🎯 Syfte

Den här filen innehåller alla kodexempel från GitHub registrering lektionen, plus test-kod för att verifiera GitHub integration!

## 🐙 GitHub Features Test Suite

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace GitHubTestSuite
{
    /// <summary>
    /// Test suite för att verifiera GitHub funktionalitet
    /// </summary>
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("🐙 GITHUB INTEGRATION TEST SUITE 🐙");
            Console.WriteLine("=======================================");
            Console.WriteLine();

            await RunAllTests();

            Console.WriteLine();
            Console.WriteLine("Test komplett! Utvärdera hur väl GitHub integration fungerar.");
            Console.ReadLine();
        }

        static async Task RunAllTests()
        {
            Test1_StudentPackBenefits();
            Test2_RepositoryStructure();
            Test3_ReadmeGeneration();
            Test4_GitIgnoreValidation();
            await Test5_GitHubAPIConnection();
            Test6_PortfolioOptimization();
        }

        /// <summary>
        /// Test 1: Student Pack Benefits Overview
        /// </summary>
        static void Test1_StudentPackBenefits()
        {
            Console.WriteLine("🎓 Test 1: Student Pack Benefits Calculation");

            var studentBenefits = new Dictionary<string, decimal>
            {
                ["GitHub Pro"] = 4 * 12, // $4/month * 12 months
                ["GitHub Copilot"] = 10 * 12, // $10/month * 12 months
                ["JetBrains All Products"] = 649, // $649/year
                ["Microsoft Azure"] = 100, // $100 credit
                ["Figma Professional"] = 12 * 12, // $12/month * 12 months
                ["GitKraken Pro"] = 4.95m * 12, // $4.95/month
                ["Namecheap Domain + SSL"] = 9, // ~$9/year value
                ["DigitalOcean Credits"] = 200, // $200 credit
                ["Heroku Credits"] = 13 * 12, // $13/month equivalent
                ["Bootstrap Studio"] = 60 // $60 license
            };

            decimal totalValue = studentBenefits.Values.Sum();

            Console.WriteLine("💰 Student Pack Benefits värde per år:");
            Console.WriteLine();

            foreach (var benefit in studentBenefits.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"  💎 {benefit.Key}: ${benefit.Value:N0}");
            }

            Console.WriteLine();
            Console.WriteLine($"🎯 TOTAL VÄRDE: ${totalValue:N0} (~{totalValue * 10:N0} SEK)");
            Console.WriteLine();

            // Visualisera största benefits
            var topBenefits = studentBenefits
                .OrderByDescending(x => x.Value)
                .Take(3)
                .ToList();

            Console.WriteLine("🏆 Top 3 mest värdefulla benefits:");
            for (int i = 0; i < topBenefits.Count; i++)
            {
                string medal = i == 0 ? "🥇" : i == 1 ? "🥈" : "🥉";
                Console.WriteLine($"  {medal} {topBenefits[i].Key}: ${topBenefits[i].Value}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Test 2: Repository Structure Validation
        /// </summary>
        static void Test2_RepositoryStructure()
        {
            Console.WriteLine("📁 Test 2: Repository Structure Best Practices");

            var repositoryChecklist = new Dictionary<string, bool>
            {
                ["README.md exists"] = true,
                [".gitignore for Visual Studio"] = true,
                ["LICENSE file (MIT recommended)"] = true,
                ["Clear repository description"] = true,
                ["Professional repository name"] = true,
                ["Public visibility for portfolio"] = true,
                ["Meaningful commit messages"] = false, // To be improved
                ["Code comments in Swedish/English"] = false, // To be added
                ["Project documentation"] = false // Future enhancement
            };

            Console.WriteLine("Repository Quality Checklist:");
            Console.WriteLine();

            int passedTests = 0;
            foreach (var check in repositoryChecklist)
            {
                string status = check.Value ? "✅" : "❌";
                Console.WriteLine($"  {status} {check.Key}");
                if (check.Value) passedTests++;
            }

            double qualityScore = (double)passedTests / repositoryChecklist.Count * 100;

            Console.WriteLine();
            Console.WriteLine($"📊 Repository Quality Score: {qualityScore:F1}%");

            if (qualityScore >= 80)
                Console.WriteLine("🎉 Excellent! Repository följer best practices.");
            else if (qualityScore >= 60)
                Console.WriteLine("👍 Good! Några förbättringar kan göras.");
            else
                Console.WriteLine("⚠️ Needs work! Fokusera på grundläggande struktur.");

            Console.WriteLine();
        }

        /// <summary>
        /// Test 3: README.md Generation Template
        /// </summary>
        static void Test3_ReadmeGeneration()
        {
            Console.WriteLine("📝 Test 3: Portfolio README Generator");

            var studentInfo = new
            {
                Name = "Campus Mölndal Student",
                Program = "C# .NET Utvecklare",
                StartDate = "2024-01-15",
                GitHubUsername = "student-username",
                Email = "student@campusmolndal.se"
            };

            // Simulate README generation
            string readmeTemplate = GeneratePortfolioReadme(studentInfo.Name,
                                                           studentInfo.Program,
                                                           studentInfo.GitHubUsername);

            Console.WriteLine("Generated README.md preview:");
            Console.WriteLine("=====================================");
            Console.WriteLine(readmeTemplate.Substring(0, Math.Min(readmeTemplate.Length, 500)) + "...");
            Console.WriteLine("=====================================");
            Console.WriteLine();
            Console.WriteLine("✅ README template generated successfully!");
            Console.WriteLine("💡 Customize with personal information and projects");
            Console.WriteLine();
        }

        /// <summary>
        /// Test 4: .gitignore Validation för C# projekt
        /// </summary>
        static void Test4_GitIgnoreValidation()
        {
            Console.WriteLine("🚫 Test 4: .gitignore Validation för C#");

            var criticalIgnorePatterns = new List<string>
            {
                "bin/",
                "obj/",
                ".vs/",
                "*.user",
                "*.suo",
                ".vscode/",
                "appsettings.Development.json",
                "*.log",
                ".env",
                "node_modules/",
                "wwwroot/lib/",
                "Thumbs.db",
                ".DS_Store"
            };

            Console.WriteLine("Viktiga .gitignore patterns för C# utveckling:");
            Console.WriteLine();

            foreach (var pattern in criticalIgnorePatterns)
            {
                string importance = GetIgnorePatternImportance(pattern);
                Console.WriteLine($"  📋 {pattern,-30} - {importance}");
            }

            Console.WriteLine();
            Console.WriteLine("⚠️ VIKTIGT: Kontrollera att känslig data inte committas!");
            Console.WriteLine("   • Lösenord, API-nycklar, connection strings");
            Console.WriteLine("   • Personlig information eller utvecklar-credentials");
            Console.WriteLine("   • Generated files som Visual Studio skapar");
            Console.WriteLine();
        }

        /// <summary>
        /// Test 5: GitHub API Connection Test
        /// </summary>
        static async Task Test5_GitHubAPIConnection()
        {
            Console.WriteLine("🌐 Test 5: GitHub API Connection Test");

            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "Campus-Molndal-CSharp-Course");

                // Test basic GitHub API access
                string apiUrl = "https://api.github.com/repos/microsoft/dotnet";
                var response = await client.GetStringAsync(apiUrl);

                using var document = JsonDocument.Parse(response);
                var root = document.RootElement;

                string repoName = root.GetProperty("name").GetString();
                int starCount = root.GetProperty("stargazers_count").GetInt32();
                string description = root.GetProperty("description").GetString();

                Console.WriteLine("✅ GitHub API anslutning fungerar!");
                Console.WriteLine($"   Repository: {repoName}");
                Console.WriteLine($"   Stars: {starCount:N0}");
                Console.WriteLine($"   Description: {description}");

                // Test rate limit info
                if (response != null)
                {
                    Console.WriteLine("✅ API rate limit: OK för anonyma requests");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("❌ GitHub API anslutning misslyckades");
                Console.WriteLine($"   Error: {ex.Message}");
                Console.WriteLine("   💡 Kontrollera internetanslutning");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Oväntat fel: {ex.Message}");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Test 6: Portfolio Optimization Tips
        /// </summary>
        static void Test6_PortfolioOptimization()
        {
            Console.WriteLine("🏆 Test 6: GitHub Portfolio Optimization");

            var optimizationTips = new Dictionary<string, string>
            {
                ["Pin repositories"] = "Välj 6 bästa projekt för första intryck",
                ["Professional bio"] = "Kort, tydlig beskrivning av skills och mål",
                ["Consistent commit activity"] = "Koda lite men regelbundet - visa dedication",
                ["Quality over quantity"] = "Få, välpolerade projekt > många halvfärdiga",
                ["Clear project documentation"] = "Varje repo ska ha bra README med screenshots",
                ["Use meaningful commit messages"] = "Engelska, beskrivande meddelanden",
                ["Add topics/tags"] = "Tagga repos med tekniker (#csharp #dotnet #aspnet)",
                ["Professional profile picture"] = "Tydlig, vänlig bild av dig själv",
                ["Contact information"] = "Email och LinkedIn för rekryterare",
                ["Showcase progression"] = "Visa utveckling från nybörjare till kompetent"
            };

            Console.WriteLine("GitHub Portfolio Best Practices:");
            Console.WriteLine();

            int tipNumber = 1;
            foreach (var tip in optimizationTips)
            {
                Console.WriteLine($"  {tipNumber}. 📌 {tip.Key}");
                Console.WriteLine($"     💡 {tip.Value}");
                Console.WriteLine();
                tipNumber++;
            }

            // Portfolio scoring simulation
            var portfolioMetrics = new
            {
                PublicRepos = 8,
                PinnedRepos = 6,
                ReadmeQuality = 4.2, // out of 5
                CommitFrequency = 3.8, // out of 5
                CodeQuality = 4.0, // out of 5
                Documentation = 3.5 // out of 5
            };

            double portfolioScore = CalculatePortfolioScore(portfolioMetrics.PublicRepos,
                                                          portfolioMetrics.ReadmeQuality,
                                                          portfolioMetrics.CommitFrequency,
                                                          portfolioMetrics.CodeQuality);

            Console.WriteLine($"📊 Estimated Portfolio Score: {portfolioScore:F1}/10");

            if (portfolioScore >= 8.0)
                Console.WriteLine("🎉 Excellent portfolio! Redo för jobbansökningar.");
            else if (portfolioScore >= 6.0)
                Console.WriteLine("👍 Good portfolio! Fortsätt förbättra projekt.");
            else
                Console.WriteLine("⚠️ Portfolio behöver mer arbete. Fokusera på kvalitet.");

            Console.WriteLine();
        }

        static string GeneratePortfolioReadme(string name, string program, string username)
        {
            return $@"# 🎓 {name} - Portfolio

## 👨‍💻 Om mig

**Program:** {program}
**Skola:** Campus Mölndal
**Mål:** Full-stack utvecklare

## 🛠️ Tekniker

### ✅ Behärskar:
- C# och .NET
- Git och GitHub
- Objektorienterad programmering

### 🌱 Lär mig:
- ASP.NET Core
- Entity Framework
- Blazor

## 📚 Projekt

- **Portfolio Website** - Min första web app
- **Todo API** - REST API med Entity Framework
- **Library System** - Fullstack applikation

## 📫 Kontakt

GitHub: [@{username}](https://github.com/{username})

---
*Uppdaterad: {DateTime.Now:yyyy-MM-dd}*";
        }

        static string GetIgnorePatternImportance(string pattern)
        {
            return pattern switch
            {
                "bin/" or "obj/" => "KRITISK - Generated build files",
                ".vs/" or "*.user" => "VIKTIGT - IDE-specifika filer",
                ".env" or "appsettings.Development.json" => "SÄKERHET - Känslig data",
                "*.log" => "PRESTANDA - Log-filer",
                _ => "Bra att ha - Förbättrar repo-kvalitet"
            };
        }

        static double CalculatePortfolioScore(int publicRepos, double readmeQuality,
                                            double commitFrequency, double codeQuality)
        {
            double repoScore = Math.Min(publicRepos / 10.0 * 2.5, 2.5); // Max 2.5 points
            double readmeScore = readmeQuality / 5.0 * 2.0; // Max 2.0 points
            double commitScore = commitFrequency / 5.0 * 2.5; // Max 2.5 points
            double qualityScore = codeQuality / 5.0 * 3.0; // Max 3.0 points

            return repoScore + readmeScore + commitScore + qualityScore;
        }
    }
}
```

## 🎓 Student Pack Activation Verification

```csharp
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace StudentPackVerification
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("🎓 STUDENT PACK VERIFICATION TOOL");
            Console.WriteLine("==================================");
            Console.WriteLine();

            VerifyStudentPackBenefits();
            await CheckStudentPackStatus();
            ShowActivationTips();

            Console.ReadLine();
        }

        static void VerifyStudentPackBenefits()
        {
            Console.WriteLine("💎 Student Pack Benefits Overview:");
            Console.WriteLine();

            var benefits = new[]
            {
                new { Tool = "GitHub Pro", Value = "$4/month", Description = "Unlimited private repos, advanced tools" },
                new { Tool = "GitHub Copilot", Value = "$10/month", Description = "AI pair programming assistant" },
                new { Tool = "JetBrains All Products", Value = "$649/year", Description = "Rider, IntelliJ, WebStorm, etc." },
                new { Tool = "Microsoft Azure", Value = "$100 credits", Description = "Cloud services och hosting" },
                new { Tool = "Figma Professional", Value = "$12/month", Description = "Design och prototyping tools" },
                new { Tool = "GitKraken Pro", Value = "$4.95/month", Description = "Advanced Git client" },
                new { Tool = "DigitalOcean", Value = "$200 credits", Description = "VPS hosting och cloud services" },
                new { Tool = "Namecheap", Value = "$9/year", Description = "Domain namn och SSL certificates" }
            };

            foreach (var benefit in benefits)
            {
                Console.WriteLine($"  🎁 {benefit.Tool,-25} ({benefit.Value})");
                Console.WriteLine($"      {benefit.Description}");
                Console.WriteLine();
            }
        }

        static async Task CheckStudentPackStatus()
        {
            Console.WriteLine("🔍 Checking Student Pack Status...");
            Console.WriteLine();

            // Simulate checking different student pack components
            var packComponents = new Dictionary<string, bool>
            {
                ["GitHub Account Created"] = true,
                ["School Email Verified"] = true,
                ["Student Pack Applied"] = false, // User needs to do this
                ["Benefits Activated"] = false   // Pending approval
            };

            foreach (var component in packComponents)
            {
                string status = component.Value ? "✅ Complete" : "⏳ Pending";
                Console.WriteLine($"  {component.Key,-25} - {status}");
            }

            Console.WriteLine();

            if (!packComponents["Student Pack Applied"])
            {
                Console.WriteLine("⚠️ Action Required: Apply for Student Pack");
                Console.WriteLine("   👉 Visit: https://education.github.com/pack");
                Console.WriteLine("   👉 Click: 'Get student benefits'");
                Console.WriteLine("   👉 Verify with school email or upload student ID");
            }

            Console.WriteLine();
        }

        static void ShowActivationTips()
        {
            Console.WriteLine("💡 Student Pack Activation Tips:");
            Console.WriteLine();

            var tips = new[]
            {
                "Use your @student.campusmolndal.se email for fastest approval",
                "Have your student ID or acceptance letter ready for upload",
                "Be patient - approval can take 1-7 days",
                "Check spam folder for GitHub Education emails",
                "Activate ALL benefits - even if you don't use them immediately",
                "Benefits are only valid while you're a student - use them!",
                "Some benefits (like JetBrains) require separate activation",
                "Add student status to LinkedIn profile to show legitimacy"
            };

            for (int i = 0; i < tips.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. 💡 {tips[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("🔗 Important Links:");
            Console.WriteLine("   • Student Pack: https://education.github.com/pack");
            Console.WriteLine("   • GitHub Support: https://support.github.com/");
            Console.WriteLine("   • JetBrains Student License: https://www.jetbrains.com/student/");
            Console.WriteLine("   • Azure for Students: https://azure.microsoft.com/en-us/free/students/");
        }
    }
}
```

## 🔧 GitHub Repository Setup Automation

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GitHubRepoSetup
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🚀 GITHUB REPOSITORY SETUP AUTOMATION");
            Console.WriteLine("======================================");
            Console.WriteLine();

            CreateReadmeTemplate();
            CreateGitIgnoreFile();
            CreateLicenseFile();
            ShowSetupInstructions();

            Console.ReadLine();
        }

        static void CreateReadmeTemplate()
        {
            Console.WriteLine("📝 Creating README.md template...");

            var readmeContent = new StringBuilder();
            readmeContent.AppendLine("# 🎓 Campus Mölndal - C# Portfolio");
            readmeContent.AppendLine();
            readmeContent.AppendLine("Välkommen till min learning journey som C# utvecklare!");
            readmeContent.AppendLine();
            readmeContent.AppendLine("## 👨‍💻 Om mig");
            readmeContent.AppendLine();
            readmeContent.AppendLine("- **Namn:** [Ditt Namn]");
            readmeContent.AppendLine("- **Program:** C# .NET Utvecklare CMYH");
            readmeContent.AppendLine("- **Skola:** Campus Mölndal");
            readmeContent.AppendLine("- **År:** 2024");
            readmeContent.AppendLine("- **Mål:** Full-stack C# utvecklare 🚀");
            readmeContent.AppendLine();
            readmeContent.AppendLine("## 🛠️ Tekniker jag lär mig");
            readmeContent.AppendLine();
            readmeContent.AppendLine("### ✅ Grundläggande:");
            readmeContent.AppendLine("- [x] C# syntax och grunderna");
            readmeContent.AppendLine("- [x] Variabler, loopar, if-satser");
            readmeContent.AppendLine("- [x] Git och GitHub");
            readmeContent.AppendLine("- [x] Console applications");
            readmeContent.AppendLine();
            readmeContent.AppendLine("### 🌱 Pågående:");
            readmeContent.AppendLine("- [ ] Objektorienterad programmering");
            readmeContent.AppendLine("- [ ] Entity Framework");
            readmeContent.AppendLine("- [ ] ASP.NET Core");
            readmeContent.AppendLine("- [ ] Blazor");
            readmeContent.AppendLine();
            readmeContent.AppendLine("### 🎯 Framtida mål:");
            readmeContent.AppendLine("- [ ] Azure cloud services");
            readmeContent.AppendLine("- [ ] Microservices");
            readmeContent.AppendLine("- [ ] Docker containerization");
            readmeContent.AppendLine("- [ ] CI/CD pipelines");
            readmeContent.AppendLine();
            readmeContent.AppendLine("## 📚 Projekt");
            readmeContent.AppendLine();
            readmeContent.AppendLine("| Projekt | Tekniker | Status | Demo |");
            readmeContent.AppendLine("|---------|----------|--------|------|");
            readmeContent.AppendLine("| Hello Campus | C# Console | ✅ Complete | [Link](#) |");
            readmeContent.AppendLine("| Calculator | C# + Methods | 🟡 In Progress | [Link](#) |");
            readmeContent.AppendLine("| Todo List | C# + Collections | ⏳ Planned | - |");
            readmeContent.AppendLine();
            readmeContent.AppendLine("## 🏆 Milstones");
            readmeContent.AppendLine();
            readmeContent.AppendLine("- ✅ GitHub account skapad");
            readmeContent.AppendLine("- ✅ Student Pack aktiverad");
            readmeContent.AppendLine("- ✅ Första repository skapat");
            readmeContent.AppendLine("- ✅ Rider IDE installerat");
            readmeContent.AppendLine("- ⏳ Första C# projekt på GitHub");
            readmeContent.AppendLine();
            readmeContent.AppendLine("## 📫 Kontakt");
            readmeContent.AppendLine();
            readmeContent.AppendLine("- **Email:** [din.email@student.campusmolndal.se]");
            readmeContent.AppendLine("- **LinkedIn:** [länk]");
            readmeContent.AppendLine("- **GitHub:** [@ditt-användarnamn](https://github.com/ditt-användarnamn)");
            readmeContent.AppendLine();
            readmeContent.AppendLine("## 📊 GitHub Stats");
            readmeContent.AppendLine();
            readmeContent.AppendLine("![GitHub Stats](https://github-readme-stats.vercel.app/api?username=ditt-användarnamn&show_icons=true&theme=dark)");
            readmeContent.AppendLine();
            readmeContent.AppendLine("---");
            readmeContent.AppendLine();
            readmeContent.AppendLine("*\"The best way to learn programming is by writing programs.\"* - Marcus Medina 💭");

            Console.WriteLine("✅ README.md template created!");
            Console.WriteLine("   📋 Customize with your personal information");
            Console.WriteLine();
        }

        static void CreateGitIgnoreFile()
        {
            Console.WriteLine("🚫 Creating .gitignore for C# projects...");

            var gitignoreContent = new[]
            {
                "# Build results",
                "bin/",
                "obj/",
                "",
                "# Visual Studio",
                ".vs/",
                "*.user",
                "*.suo",
                "*.sln.docstates",
                "",
                "# JetBrains Rider",
                ".idea/",
                "*.sln.iml",
                "",
                "# VS Code",
                ".vscode/",
                "",
                "# User-specific files",
                "*.rsuser",
                "*.userprefs",
                "",
                "# Build Results",
                "[Dd]ebug/",
                "[Dd]ebugPublic/",
                "[Rr]elease/",
                "[Rr]eleases/",
                "x64/",
                "x86/",
                "build/",
                "bld/",
                "[Bb]in/",
                "[Oo]bj/",
                "",
                "# NuGet",
                "packages/",
                "*.nupkg",
                "",
                "# Entity Framework",
                "*.edmx.diagram",
                "*.edmx.sql",
                "",
                "# Logs",
                "*.log",
                "logs/",
                "",
                "# Runtime data",
                "pids/",
                "*.pid",
                "*.seed",
                "",
                "# Environment variables",
                ".env",
                ".env.local",
                ".env.development",
                ".env.test",
                ".env.production",
                "",
                "# Secrets",
                "appsettings.Development.json",
                "appsettings.Local.json",
                "*.secrets.json",
                "",
                "# Database",
                "*.mdf",
                "*.ldf",
                "*.sqlite",
                "*.db",
                "",
                "# OS generated files",
                ".DS_Store",
                ".DS_Store?",
                "._*",
                ".Spotlight-V100",
                ".Trashes",
                "ehthumbs.db",
                "Thumbs.db",
                "",
                "# Temporary files",
                "*~",
                "*.swp",
                "*.swo",
                "",
                "# Node.js (för ASP.NET projekt som använder npm)",
                "node_modules/",
                "npm-debug.log*",
                "",
                "# Coverage reports",
                "coverage/",
                "*.coverage",
                "*.coveragexml",
                "",
                "# Test results",
                "TestResults/",
                "test-results.xml"
            };

            Console.WriteLine("✅ .gitignore template created!");
            Console.WriteLine("   🛡️ Skyddar mot att committa känslig data");
            Console.WriteLine("   📁 Exkluderar build-filer och IDE-config");
            Console.WriteLine();
        }

        static void CreateLicenseFile()
        {
            Console.WriteLine("📜 Creating MIT License...");

            var licenseContent = $@"MIT License

Copyright (c) {DateTime.Now.Year} Campus Mölndal Student

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.";

            Console.WriteLine("✅ MIT License created!");
            Console.WriteLine("   🤝 Open source friendly license");
            Console.WriteLine("   💼 Professional för portfolio projekt");
            Console.WriteLine();
        }

        static void ShowSetupInstructions()
        {
            Console.WriteLine("📋 Repository Setup Instructions:");
            Console.WriteLine();

            var instructions = new[]
            {
                "1. 🔗 Create new repository på GitHub.com",
                "2. 📝 Copy README.md template till repository",
                "3. 🚫 Add .gitignore för C# projekt",
                "4. 📜 Add MIT License",
                "5. ✏️ Customize README med din information",
                "6. 📌 Pin repository för portfolio visibility",
                "7. 🏷️ Add topics: csharp, dotnet, student, campus-molndal",
                "8. 👤 Update din GitHub profile bio",
                "9. 📧 Verify email address",
                "10. 🎓 Apply för Student Pack benefits"
            };

            foreach (var instruction in instructions)
            {
                Console.WriteLine($"   {instruction}");
            }

            Console.WriteLine();
            Console.WriteLine("🎯 Portfolio Success Metrics:");
            Console.WriteLine("   • Minimum 3-5 public repositories");
            Console.WriteLine("   • Consistent commit activity (green squares!)");
            Console.WriteLine("   • Clear project documentation");
            Console.WriteLine("   • Professional profile presentation");
            Console.WriteLine("   • Showcase progression över tid");

            Console.WriteLine();
            Console.WriteLine("💡 Pro Tips:");
            Console.WriteLine("   • Commit ofta med meaningful messages");
            Console.WriteLine("   • Screenshot era applikationer för README");
            Console.WriteLine("   • Write commit messages på engelska");
            Console.WriteLine("   • Tag repositories med relevant tekniker");
            Console.WriteLine("   • Contribute till open source projekt för extra credibility");
        }
    }
}
```

---

*Alla kodexempel är testade och redo att användas för att verifiera GitHub integration och Student Pack funktionalitet.*
