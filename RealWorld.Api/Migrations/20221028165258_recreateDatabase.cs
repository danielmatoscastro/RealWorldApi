using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealWorldApi.Migrations
{
    public partial class recreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TAGS",
                columns: table => new
                {
                    Name = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAGS", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    PasswordHash = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Username = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Bio = table.Column<string>(type: "VARCHAR(500)", nullable: true),
                    Image = table.Column<string>(type: "VARCHAR(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ARTICLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slug = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(500)", nullable: false),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "DATETIMEOFFSET", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "DATETIMEOFFSET", nullable: false),
                    AuthorId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICLE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ARTICLE_USERS_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "USERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FOLLOWERS",
                columns: table => new
                {
                    Follow = table.Column<int>(type: "INT", nullable: false),
                    FollowedBy = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOLLOWERS", x => new { x.Follow, x.FollowedBy });
                    table.ForeignKey(
                        name: "FK_FOLLOWERS_USERS_Follow",
                        column: x => x.Follow,
                        principalTable: "USERS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FOLLOWERS_USERS_FollowedBy",
                        column: x => x.FollowedBy,
                        principalTable: "USERS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ARTICLES_TAGS",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "INT", nullable: false),
                    TagName = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICLES_TAGS", x => new { x.ArticleId, x.TagName });
                    table.ForeignKey(
                        name: "FK_ARTICLES_TAGS_ARTICLE_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "ARTICLE",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ARTICLES_TAGS_TAGS_TagName",
                        column: x => x.TagName,
                        principalTable: "TAGS",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "COMMENTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "VARCHAR(500)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "DATETIMEOFFSET", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "DATETIMEOFFSET", nullable: false),
                    AuthorId = table.Column<int>(type: "INT", nullable: false),
                    ArticleId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMMENTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COMMENTS_ARTICLE_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "ARTICLE",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_COMMENTS_USERS_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "USERS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FAVORITES",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "INT", nullable: false),
                    FavoritedBy = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAVORITES", x => new { x.ArticleId, x.FavoritedBy });
                    table.ForeignKey(
                        name: "FK_FAVORITES_ARTICLE_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "ARTICLE",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FAVORITES_USERS_FavoritedBy",
                        column: x => x.FavoritedBy,
                        principalTable: "USERS",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "TAGS",
                column: "Name",
                values: new object[]
                {
                    "ad",
                    "assumenda",
                    "dignissimos",
                    "est",
                    "et",
                    "illum",
                    "iste",
                    "natus",
                    "quia",
                    "reiciendis"
                });

            migrationBuilder.InsertData(
                table: "USERS",
                columns: new[] { "Id", "Bio", "Email", "Image", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { 1, "Illum assumenda iste quia natus et dignissimos reiciendis.\nNostrum totam harum totam voluptatibus.\nEos asperiores cum.", "Reagan.Stanton69@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/657.jpg", "10000.ZiJTadfBrqA1nuIToOMJLw==.gKRHw0IVosl1pweo/nfCCRP7sKnJnYHMC8UJtxMsOQg=", "Trace Pfeffer" },
                    { 2, "Vitae amet qui exercitationem doloribus facilis omnis.\nVel nisi a.\nPorro sed ad et autem suscipit blanditiis.", "Dallin_Jast48@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/243.jpg", "10000.8ahMOp9SfG+cnAuGEd3XNg==.Mdd5FuiDGtsu5kpJCklmQtM7zGnnQXGVGbcnx1pt328=", "Shad Shanahan" },
                    { 3, "Vero soluta fuga eius saepe eveniet dicta quo.\nFacilis dolorem eius repellat.\nEt quisquam consequatur aut qui porro.", "Susan_Dickens@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/406.jpg", "10000.65xW27T9h+dJEsxVZdS9pA==.MnL6NAaTvaOqvxQbmIFhGkTuBfg4TfmXeIQa0ywm07g=", "Marcos Koss" },
                    { 4, "Consequatur autem voluptas itaque exercitationem cupiditate nam sit quis.\nModi amet quasi fuga eligendi et molestiae modi non.\nUt cum explicabo.", "Benny.Monahan14@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/847.jpg", "10000.f/YEls5ktXG0EjWDvK3jxg==.M968h1FFeyEZmbbUfKEw9r8pUHy6P5ZLmVT8vlGFnhQ=", "Kevin Fahey" },
                    { 5, "Consequatur ea pariatur veritatis veniam nihil a.\nIure cupiditate minima molestias provident inventore minima dolores nulla laborum.\nQuod ea recusandae.", "Maximo_Morissette56@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/215.jpg", "10000.osHP59R/cYQ5eJcFWTNUfA==.S6/iNboW8NYEm460Wec6Kz98z+gxWk9eAIg0VAUcAWE=", "Christina Monahan" },
                    { 6, "Repellat similique veritatis voluptatem voluptas.\nFacilis sint ut beatae excepturi sequi vel.\nIn omnis tempore asperiores corporis et laudantium atque.", "Antonia44@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/563.jpg", "10000.7/Xc6w4B6zjOoU9EZip2Yw==.iC7vAacS433tqEt4bVde8Qp32gI5WRceSzQtZXnwlBo=", "Aisha Howell" },
                    { 7, "Sed repudiandae doloremque molestias sapiente asperiores sit et minima.\nOfficia est quia quam aut rerum aut aliquam magni eveniet.\nAut perspiciatis repellendus excepturi.", "Zachariah.Bartoletti19@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/620.jpg", "10000.9F0iTrfa/JgFTbZaSWNVWQ==.tnkZ2BMc1WnalmGEXkk0CTveouI/ks8+5UYHA2yzzXc=", "Krista Gibson" },
                    { 8, "Et repellendus dolores laborum natus.\nLaboriosam voluptatem aspernatur debitis quo saepe et aliquam.\nVoluptatum adipisci necessitatibus quos quidem.", "Frida_Frami0@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1229.jpg", "10000.ja0uiOXPHQLNrpnLelstBw==.vn4P2l8sfapAjKkH7oUuzu91ehplf77jF5FFUVmdxm4=", "Vidal Crona" },
                    { 9, "Sunt consectetur veritatis aut minus aut voluptas facilis sunt.\nQuo eos ducimus et.\nPraesentium laboriosam omnis molestiae est repellat est sunt fuga.", "Scarlett0@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/696.jpg", "10000.jShZFh6ZyCYapxC1Ki9vbQ==.xRWJyUldz9Dcmhvh1KmvUOEcUw32S8pux9yQqi0PS60=", "Margarett Hoeger" },
                    { 10, "Quia repellendus occaecati eum ut cupiditate neque harum omnis.\nMagnam et praesentium et laboriosam.\nVoluptatem distinctio quia sed.", "Oma43@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/149.jpg", "10000.vL+1WT5biI7rJy6/YihhOQ==.lF2oiVbPiFF40/niKXAbI2IbtKUak0bwOu39k1K1aXg=", "Rylee Maggio" }
                });

            migrationBuilder.InsertData(
                table: "ARTICLE",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "Description", "Slug", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 8, "Iste quia natus et dignissimos reiciendis ad nostrum totam. Totam voluptatibus doloremque eos asperiores cum ipsam illum. Doloribus aperiam cumque non recusandae est unde vitae amet. Exercitationem doloribus facilis omnis doloremque vel. A quas porro sed ad. Autem suscipit blanditiis ratione modi velit porro dolorum corrupti adipisci.\n\nId vero soluta fuga eius saepe eveniet dicta quo. Facilis dolorem eius repellat. Et quisquam consequatur aut qui porro. Et consectetur voluptatum ut. Tempore totam fugiat consequatur autem. Itaque exercitationem cupiditate nam sit quis qui modi amet.\n\nEligendi et molestiae modi non et ut. Explicabo voluptatem odit est tenetur quos ratione cum. Tempora et consequatur ea pariatur veritatis veniam.", new DateTimeOffset(new DateTime(2022, 8, 24, 11, 5, 12, 413, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, -3, 0, 0, 0)), "Doloribus iure cupiditate minima molestias provident inventore minima dolores nulla.", "aut-quod-ea-recusandae-magni-cumque-et", "Aut quod ea recusandae magni cumque et.", new DateTimeOffset(new DateTime(2022, 8, 24, 11, 5, 12, 413, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 2, 9, "Quia sit est magnam repellat similique veritatis. Voluptas similique facilis sint ut. Excepturi sequi vel. In omnis tempore asperiores corporis et laudantium atque. Quasi incidunt voluptatem ducimus.\n\nIure illum sed. Doloremque molestias sapiente asperiores sit et minima delectus officia est. Quam aut rerum aut aliquam. Eveniet dolor aut perspiciatis.\n\nAliquid doloribus aperiam eligendi quia adipisci dolores. Voluptatem enim et repellendus dolores laborum natus. Laboriosam voluptatem aspernatur debitis quo saepe et aliquam. Voluptatum adipisci necessitatibus quos quidem. Consequatur et asperiores laborum alias. Sapiente nesciunt est sunt consectetur veritatis aut minus aut voluptas.", new DateTimeOffset(new DateTime(2022, 8, 3, 15, 38, 55, 286, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, -3, 0, 0, 0)), "Et quo eos ducimus et et praesentium.", "omnis-molestiae-est-repellat-est", "Omnis molestiae est repellat est.", new DateTimeOffset(new DateTime(2022, 8, 3, 15, 38, 55, 286, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 3, 1, "Officiis ut eos alias iste tempore vel et quia repellendus. Eum ut cupiditate neque harum omnis ipsam. Et praesentium et laboriosam. Voluptatem distinctio quia sed. Est atque aut odio sed eos error.\n\nPerferendis similique praesentium asperiores quia quia veniam harum. Aliquam voluptatem perferendis dignissimos exercitationem voluptas qui provident hic. Rerum at eveniet totam. Ex omnis corporis quam reprehenderit nihil nam animi recusandae. Ullam soluta nisi totam et eius voluptates occaecati eos hic.\n\nVoluptas amet voluptatem et officia voluptates. Possimus temporibus sed aut laborum. Sunt illum et labore autem deserunt nam vitae. Asperiores nesciunt deleniti veritatis voluptatem maiores eaque.", new DateTimeOffset(new DateTime(2022, 4, 21, 21, 58, 9, 221, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, -3, 0, 0, 0)), "Sint sunt vero.", "fugit-nesciunt-omnis-fugiat", "Fugit nesciunt omnis fugiat.", new DateTimeOffset(new DateTime(2022, 4, 21, 21, 58, 9, 221, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 4, 8, "Quia dolor in qui. Tempora in quae minima atque ex est esse autem. Aut dolores cupiditate possimus.\n\nBlanditiis dicta qui ipsa omnis ut cumque impedit. Perspiciatis quo nihil et voluptate illum. Facere ut et qui doloribus ab unde. Delectus dignissimos et et.\n\nNemo repellat et blanditiis libero explicabo asperiores est. Aut cumque laboriosam. Earum occaecati sit excepturi eum autem occaecati eum nostrum.", new DateTimeOffset(new DateTime(2022, 10, 5, 22, 32, 45, 271, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, -3, 0, 0, 0)), "Qui ea sed nihil architecto suscipit sint omnis et.", "ut-quo-iste-qui-quod-quisquam-officia-veritatis-sit", "Ut quo iste qui quod quisquam officia veritatis sit.", new DateTimeOffset(new DateTime(2022, 10, 5, 22, 32, 45, 271, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 5, 1, "Ut est rerum dolor recusandae quae perspiciatis sed. Sit dolorem architecto est voluptatem. Similique et porro delectus molestiae nobis asperiores. Soluta fuga inventore rerum expedita recusandae voluptatem odit. Et architecto dolorem molestiae repellendus nostrum ea accusamus incidunt. Similique eius tempore.\n\nDeleniti neque voluptatem ducimus totam architecto a ut. Et sapiente sequi officiis. Necessitatibus animi itaque voluptates autem dolorem. Explicabo harum repellendus quia ipsam explicabo eligendi similique.\n\nAut qui suscipit neque quos voluptates. Rerum porro rerum odit molestiae sit qui eos non. Laboriosam sint et enim exercitationem ipsam. Iure provident ut.", new DateTimeOffset(new DateTime(2022, 2, 12, 0, 50, 23, 186, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, -3, 0, 0, 0)), "Reiciendis ut in illum.", "tenetur-aut-ut-et-qui-est", "Tenetur aut ut et qui est.", new DateTimeOffset(new DateTime(2022, 2, 12, 0, 50, 23, 186, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 6, 1, "Modi unde dolorem laborum sapiente amet repellendus et. Ab quibusdam ipsum quo eum. Est sapiente tempore placeat quos. Soluta nihil odit mollitia accusamus consequuntur doloribus tempora.\n\nSimilique ipsa quidem explicabo non eius sint ad earum. Aliquid repudiandae aliquid voluptatem magnam. Sit minima totam et. Ipsam omnis et. Voluptas veritatis perferendis sunt inventore quibusdam ea. Tempora incidunt magni architecto id minus.\n\nIn aut consequuntur. Assumenda ex dicta ut et earum. Possimus excepturi consequatur magnam ut quo omnis nobis. Ut sit aut error. Quas quia autem quia dolorem ducimus perspiciatis repudiandae iure et.", new DateTimeOffset(new DateTime(2022, 6, 20, 12, 35, 16, 495, DateTimeKind.Unspecified).AddTicks(6423), new TimeSpan(0, -3, 0, 0, 0)), "Ut assumenda corrupti aut libero laudantium sed sunt.", "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui", "Eveniet esse reiciendis eos commodi sit ab qui.", new DateTimeOffset(new DateTime(2022, 6, 20, 12, 35, 16, 495, DateTimeKind.Unspecified).AddTicks(6423), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 7, 2, "Natus iusto ut incidunt exercitationem tempora laudantium dolores neque voluptas. Consectetur quod et. Repellendus adipisci sit ut.\n\nVoluptatum corporis id impedit vel quaerat et ut dolores. Dolore in officia dicta aut quas quaerat. Dignissimos alias dolorum molestiae aut omnis modi labore. Consectetur qui at numquam. Dolores nesciunt dicta dolores nam occaecati deleniti delectus distinctio incidunt.\n\nDebitis autem sequi provident quasi. Itaque et autem porro qui. Dolores dolorem atque sunt sit laborum accusamus. Corporis laboriosam ut molestiae alias ut quo id. Voluptatum laboriosam reprehenderit quaerat.", new DateTimeOffset(new DateTime(2022, 6, 11, 1, 47, 21, 791, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, -3, 0, 0, 0)), "Et dicta quo sed fugit repudiandae quo fugit dolor perferendis.", "quidem-quo-eaque-voluptates-hic-ab-ea", "Quidem quo eaque voluptates hic ab ea.", new DateTimeOffset(new DateTime(2022, 6, 11, 1, 47, 21, 791, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 8, 1, "Necessitatibus est provident aut dignissimos velit ullam. Autem facere nostrum perferendis non. Atque corporis quos.\n\nDeserunt modi quia velit laudantium sit alias cumque. Non nostrum aperiam ut laudantium. Perspiciatis commodi sit sit tempore. Velit quibusdam ea voluptatem dolore fuga voluptates maiores. Facilis iste est exercitationem molestiae ipsam. Enim quasi assumenda dignissimos et aut temporibus vitae quisquam.\n\nSimilique molestias quia quia rem vitae perferendis. Molestiae porro voluptatem numquam. Sunt porro et aut id nihil earum aperiam.", new DateTimeOffset(new DateTime(2022, 1, 16, 8, 36, 50, 883, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, -3, 0, 0, 0)), "Ab fugit magnam tempora numquam in consequatur voluptatem perspiciatis.", "architecto-nisi-voluptatum-corporis", "Architecto nisi voluptatum corporis.", new DateTimeOffset(new DateTime(2022, 1, 16, 8, 36, 50, 883, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 9, 6, "Minima magnam necessitatibus quae neque at veritatis. Repellendus ratione voluptates ut exercitationem. Sint occaecati minus.\n\nModi at quibusdam. Quam in id sit quidem placeat et error ex. Eveniet distinctio repellendus nesciunt qui rerum quaerat consectetur.\n\nAliquam aspernatur aut magnam vitae iste. Quod incidunt sint eos cum deleniti rem totam est. Quo molestiae id perspiciatis qui iste optio. Ducimus minus commodi alias amet placeat. Reiciendis consequatur cupiditate. Molestiae ex recusandae beatae non.", new DateTimeOffset(new DateTime(2022, 6, 16, 12, 41, 24, 317, DateTimeKind.Unspecified).AddTicks(3448), new TimeSpan(0, -3, 0, 0, 0)), "Quo temporibus modi dolor enim.", "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut", "Vitae voluptas nihil voluptas ad necessitatibus tempore ut.", new DateTimeOffset(new DateTime(2022, 6, 16, 12, 41, 24, 317, DateTimeKind.Unspecified).AddTicks(3448), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 10, 3, "Dolorem blanditiis quod ipsa assumenda eum cumque fugit. Ratione modi quia ut ut tempore ipsa magnam porro et. Ut quam cum et. Voluptas ut nihil voluptatum pariatur dolor voluptatem et ullam. Voluptatum possimus nostrum quasi sapiente. Et commodi ut eos sed occaecati esse.\n\nQuam dolorem quis cum commodi voluptate dolor qui dolor. Natus repellat quidem aspernatur consequatur quasi. Animi explicabo velit quis a est rerum et. Illo dolores inventore maxime. At aut harum molestiae a dolor dolorem recusandae nulla.\n\nFugit et in cupiditate molestiae voluptatem ipsum temporibus esse sint. Ea natus laudantium quia nihil. Neque aliquid facilis. Iusto harum impedit saepe consequatur libero velit nostrum debitis. Dolore quas aliquid nulla sit perspiciatis consequuntur est.", new DateTimeOffset(new DateTime(2022, 9, 22, 4, 3, 39, 257, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, -3, 0, 0, 0)), "Enim voluptas necessitatibus provident cumque quasi delectus dolor ex et.", "dolores-ab-quia-soluta-repellat-eligendi-harum-nihil-deserunt", "Dolores ab quia soluta repellat eligendi harum nihil deserunt.", new DateTimeOffset(new DateTime(2022, 9, 22, 4, 3, 39, 257, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, -3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "COMMENTS",
                columns: new[] { "Id", "ArticleId", "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 8, 9, "Iste quia natus et dignissimos reiciendis ad nostrum totam.", new DateTimeOffset(new DateTime(2022, 1, 16, 23, 47, 52, 627, DateTimeKind.Unspecified).AddTicks(6022), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 1, 16, 23, 47, 52, 627, DateTimeKind.Unspecified).AddTicks(6022), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 2, 5, 10, "Eos asperiores cum.", new DateTimeOffset(new DateTime(2022, 2, 12, 8, 23, 23, 917, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 12, 8, 23, 23, 917, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 3, 9, 9, "Aperiam cumque non recusandae est unde vitae amet qui exercitationem.", new DateTimeOffset(new DateTime(2022, 6, 17, 12, 24, 54, 499, DateTimeKind.Unspecified).AddTicks(8606), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 17, 12, 24, 54, 499, DateTimeKind.Unspecified).AddTicks(8606), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 4, 7, 8, "Vel nisi a.", new DateTimeOffset(new DateTime(2022, 6, 11, 13, 54, 44, 955, DateTimeKind.Unspecified).AddTicks(5979), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 11, 13, 54, 44, 955, DateTimeKind.Unspecified).AddTicks(5979), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 5, 8, 2, "Et autem suscipit blanditiis ratione.", new DateTimeOffset(new DateTime(2022, 1, 16, 13, 55, 32, 477, DateTimeKind.Unspecified).AddTicks(2070), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 1, 16, 13, 55, 32, 477, DateTimeKind.Unspecified).AddTicks(2070), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 6, 5, 8, "Corrupti adipisci debitis dolorem id vero soluta.", new DateTimeOffset(new DateTime(2022, 2, 12, 15, 50, 11, 620, DateTimeKind.Unspecified).AddTicks(7865), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 12, 15, 50, 11, 620, DateTimeKind.Unspecified).AddTicks(7865), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 7, 3, 9, "Dicta quo ipsum facilis dolorem eius repellat deleniti et quisquam.", new DateTimeOffset(new DateTime(2022, 4, 22, 17, 23, 46, 788, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 22, 17, 23, 46, 788, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 8, 2, 8, "Consequuntur et consectetur voluptatum ut voluptas tempore totam.", new DateTimeOffset(new DateTime(2022, 8, 4, 11, 39, 9, 419, DateTimeKind.Unspecified).AddTicks(2751), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 4, 11, 39, 9, 419, DateTimeKind.Unspecified).AddTicks(2751), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 9, 9, 8, "Itaque exercitationem cupiditate nam sit quis qui modi amet.", new DateTimeOffset(new DateTime(2022, 6, 16, 14, 20, 4, 346, DateTimeKind.Unspecified).AddTicks(296), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 16, 14, 20, 4, 346, DateTimeKind.Unspecified).AddTicks(296), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 10, 7, 7, "Molestiae modi non et ut cum explicabo voluptatem.", new DateTimeOffset(new DateTime(2022, 6, 11, 4, 21, 24, 214, DateTimeKind.Unspecified).AddTicks(9554), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 11, 4, 21, 24, 214, DateTimeKind.Unspecified).AddTicks(9554), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 11, 7, 10, "Ratione cum similique tempora et consequatur.", new DateTimeOffset(new DateTime(2022, 6, 11, 10, 27, 6, 923, DateTimeKind.Unspecified).AddTicks(645), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 11, 10, 27, 6, 923, DateTimeKind.Unspecified).AddTicks(645), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 12, 9, 1, "Nihil a doloribus iure cupiditate.", new DateTimeOffset(new DateTime(2022, 6, 16, 19, 25, 4, 425, DateTimeKind.Unspecified).AddTicks(2527), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 16, 19, 25, 4, 425, DateTimeKind.Unspecified).AddTicks(2527), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 13, 6, 6, "Minima dolores nulla.", new DateTimeOffset(new DateTime(2022, 6, 21, 3, 18, 13, 335, DateTimeKind.Unspecified).AddTicks(3345), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 21, 3, 18, 13, 335, DateTimeKind.Unspecified).AddTicks(3345), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 14, 2, 8, "Recusandae magni cumque et eum nobis.", new DateTimeOffset(new DateTime(2022, 8, 4, 5, 19, 21, 37, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 4, 5, 19, 21, 37, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 15, 2, 2, "Magnam repellat similique veritatis voluptatem voluptas similique.", new DateTimeOffset(new DateTime(2022, 8, 4, 7, 9, 8, 832, DateTimeKind.Unspecified).AddTicks(8696), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 4, 7, 9, 8, 832, DateTimeKind.Unspecified).AddTicks(8696), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 16, 6, 10, "Excepturi sequi vel.", new DateTimeOffset(new DateTime(2022, 6, 21, 4, 0, 30, 336, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 21, 4, 0, 30, 336, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 17, 6, 6, "Asperiores corporis et laudantium atque numquam quasi incidunt.", new DateTimeOffset(new DateTime(2022, 6, 20, 16, 12, 28, 436, DateTimeKind.Unspecified).AddTicks(5496), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 20, 16, 12, 28, 436, DateTimeKind.Unspecified).AddTicks(5496), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 18, 5, 5, "Iure illum sed.", new DateTimeOffset(new DateTime(2022, 2, 12, 22, 46, 0, 754, DateTimeKind.Unspecified).AddTicks(9959), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 12, 22, 46, 0, 754, DateTimeKind.Unspecified).AddTicks(9959), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 19, 1, 6, "Asperiores sit et minima delectus officia est quia quam aut.", new DateTimeOffset(new DateTime(2022, 8, 25, 8, 21, 2, 777, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 25, 8, 21, 2, 777, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 20, 10, 3, "Eveniet dolor aut perspiciatis.", new DateTimeOffset(new DateTime(2022, 9, 22, 22, 54, 7, 166, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 22, 22, 54, 7, 166, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, -3, 0, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ARTICLE_AuthorId",
                table: "ARTICLE",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ARTICLE_Slug",
                table: "ARTICLE",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ARTICLES_TAGS_TagName",
                table: "ARTICLES_TAGS",
                column: "TagName");

            migrationBuilder.CreateIndex(
                name: "IX_COMMENTS_ArticleId",
                table: "COMMENTS",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_COMMENTS_AuthorId",
                table: "COMMENTS",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_FAVORITES_FavoritedBy",
                table: "FAVORITES",
                column: "FavoritedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FOLLOWERS_FollowedBy",
                table: "FOLLOWERS",
                column: "FollowedBy");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_Email",
                table: "USERS",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_USERS_Username",
                table: "USERS",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARTICLES_TAGS");

            migrationBuilder.DropTable(
                name: "COMMENTS");

            migrationBuilder.DropTable(
                name: "FAVORITES");

            migrationBuilder.DropTable(
                name: "FOLLOWERS");

            migrationBuilder.DropTable(
                name: "TAGS");

            migrationBuilder.DropTable(
                name: "ARTICLE");

            migrationBuilder.DropTable(
                name: "USERS");
        }
    }
}
