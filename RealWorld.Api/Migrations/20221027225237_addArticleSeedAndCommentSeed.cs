using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealWorldApi.Migrations
{
    public partial class addArticleSeedAndCommentSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ARTICLE",
                columns: new[] { "Slug", "AuthorId", "Body", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { "architecto-nisi-voluptatum-corporis.", 1, "Necessitatibus est provident aut dignissimos velit ullam. Autem facere nostrum perferendis non. Atque corporis quos.\n\nDeserunt modi quia velit laudantium sit alias cumque. Non nostrum aperiam ut laudantium. Perspiciatis commodi sit sit tempore. Velit quibusdam ea voluptatem dolore fuga voluptates maiores. Facilis iste est exercitationem molestiae ipsam. Enim quasi assumenda dignissimos et aut temporibus vitae quisquam.\n\nSimilique molestias quia quia rem vitae perferendis. Molestiae porro voluptatem numquam. Sunt porro et aut id nihil earum aperiam.", new DateTimeOffset(new DateTime(2022, 1, 16, 8, 36, 50, 883, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, -3, 0, 0, 0)), "Ab fugit magnam tempora numquam in consequatur voluptatem perspiciatis.", "Architecto nisi voluptatum corporis.", new DateTimeOffset(new DateTime(2022, 1, 16, 8, 36, 50, 883, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "aut-quod-ea-recusandae-magni-cumque-et.", 8, "Iste quia natus et dignissimos reiciendis ad nostrum totam. Totam voluptatibus doloremque eos asperiores cum ipsam illum. Doloribus aperiam cumque non recusandae est unde vitae amet. Exercitationem doloribus facilis omnis doloremque vel. A quas porro sed ad. Autem suscipit blanditiis ratione modi velit porro dolorum corrupti adipisci.\n\nId vero soluta fuga eius saepe eveniet dicta quo. Facilis dolorem eius repellat. Et quisquam consequatur aut qui porro. Et consectetur voluptatum ut. Tempore totam fugiat consequatur autem. Itaque exercitationem cupiditate nam sit quis qui modi amet.\n\nEligendi et molestiae modi non et ut. Explicabo voluptatem odit est tenetur quos ratione cum. Tempora et consequatur ea pariatur veritatis veniam.", new DateTimeOffset(new DateTime(2022, 8, 24, 11, 5, 12, 413, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, -3, 0, 0, 0)), "Doloribus iure cupiditate minima molestias provident inventore minima dolores nulla.", "Aut quod ea recusandae magni cumque et.", new DateTimeOffset(new DateTime(2022, 8, 24, 11, 5, 12, 413, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "dolores-ab-quia-soluta-repellat-eligendi-harum-nihil-deserunt.", 3, "Dolorem blanditiis quod ipsa assumenda eum cumque fugit. Ratione modi quia ut ut tempore ipsa magnam porro et. Ut quam cum et. Voluptas ut nihil voluptatum pariatur dolor voluptatem et ullam. Voluptatum possimus nostrum quasi sapiente. Et commodi ut eos sed occaecati esse.\n\nQuam dolorem quis cum commodi voluptate dolor qui dolor. Natus repellat quidem aspernatur consequatur quasi. Animi explicabo velit quis a est rerum et. Illo dolores inventore maxime. At aut harum molestiae a dolor dolorem recusandae nulla.\n\nFugit et in cupiditate molestiae voluptatem ipsum temporibus esse sint. Ea natus laudantium quia nihil. Neque aliquid facilis. Iusto harum impedit saepe consequatur libero velit nostrum debitis. Dolore quas aliquid nulla sit perspiciatis consequuntur est.", new DateTimeOffset(new DateTime(2022, 9, 22, 4, 3, 39, 257, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, -3, 0, 0, 0)), "Enim voluptas necessitatibus provident cumque quasi delectus dolor ex et.", "Dolores ab quia soluta repellat eligendi harum nihil deserunt.", new DateTimeOffset(new DateTime(2022, 9, 22, 4, 3, 39, 257, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui.", 1, "Modi unde dolorem laborum sapiente amet repellendus et. Ab quibusdam ipsum quo eum. Est sapiente tempore placeat quos. Soluta nihil odit mollitia accusamus consequuntur doloribus tempora.\n\nSimilique ipsa quidem explicabo non eius sint ad earum. Aliquid repudiandae aliquid voluptatem magnam. Sit minima totam et. Ipsam omnis et. Voluptas veritatis perferendis sunt inventore quibusdam ea. Tempora incidunt magni architecto id minus.\n\nIn aut consequuntur. Assumenda ex dicta ut et earum. Possimus excepturi consequatur magnam ut quo omnis nobis. Ut sit aut error. Quas quia autem quia dolorem ducimus perspiciatis repudiandae iure et.", new DateTimeOffset(new DateTime(2022, 6, 20, 12, 35, 16, 495, DateTimeKind.Unspecified).AddTicks(6423), new TimeSpan(0, -3, 0, 0, 0)), "Ut assumenda corrupti aut libero laudantium sed sunt.", "Eveniet esse reiciendis eos commodi sit ab qui.", new DateTimeOffset(new DateTime(2022, 6, 20, 12, 35, 16, 495, DateTimeKind.Unspecified).AddTicks(6423), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "fugit-nesciunt-omnis-fugiat.", 1, "Officiis ut eos alias iste tempore vel et quia repellendus. Eum ut cupiditate neque harum omnis ipsam. Et praesentium et laboriosam. Voluptatem distinctio quia sed. Est atque aut odio sed eos error.\n\nPerferendis similique praesentium asperiores quia quia veniam harum. Aliquam voluptatem perferendis dignissimos exercitationem voluptas qui provident hic. Rerum at eveniet totam. Ex omnis corporis quam reprehenderit nihil nam animi recusandae. Ullam soluta nisi totam et eius voluptates occaecati eos hic.\n\nVoluptas amet voluptatem et officia voluptates. Possimus temporibus sed aut laborum. Sunt illum et labore autem deserunt nam vitae. Asperiores nesciunt deleniti veritatis voluptatem maiores eaque.", new DateTimeOffset(new DateTime(2022, 4, 21, 21, 58, 9, 221, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, -3, 0, 0, 0)), "Sint sunt vero.", "Fugit nesciunt omnis fugiat.", new DateTimeOffset(new DateTime(2022, 4, 21, 21, 58, 9, 221, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "omnis-molestiae-est-repellat-est.", 9, "Quia sit est magnam repellat similique veritatis. Voluptas similique facilis sint ut. Excepturi sequi vel. In omnis tempore asperiores corporis et laudantium atque. Quasi incidunt voluptatem ducimus.\n\nIure illum sed. Doloremque molestias sapiente asperiores sit et minima delectus officia est. Quam aut rerum aut aliquam. Eveniet dolor aut perspiciatis.\n\nAliquid doloribus aperiam eligendi quia adipisci dolores. Voluptatem enim et repellendus dolores laborum natus. Laboriosam voluptatem aspernatur debitis quo saepe et aliquam. Voluptatum adipisci necessitatibus quos quidem. Consequatur et asperiores laborum alias. Sapiente nesciunt est sunt consectetur veritatis aut minus aut voluptas.", new DateTimeOffset(new DateTime(2022, 8, 3, 15, 38, 55, 286, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, -3, 0, 0, 0)), "Et quo eos ducimus et et praesentium.", "Omnis molestiae est repellat est.", new DateTimeOffset(new DateTime(2022, 8, 3, 15, 38, 55, 286, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "quidem-quo-eaque-voluptates-hic-ab-ea.", 2, "Natus iusto ut incidunt exercitationem tempora laudantium dolores neque voluptas. Consectetur quod et. Repellendus adipisci sit ut.\n\nVoluptatum corporis id impedit vel quaerat et ut dolores. Dolore in officia dicta aut quas quaerat. Dignissimos alias dolorum molestiae aut omnis modi labore. Consectetur qui at numquam. Dolores nesciunt dicta dolores nam occaecati deleniti delectus distinctio incidunt.\n\nDebitis autem sequi provident quasi. Itaque et autem porro qui. Dolores dolorem atque sunt sit laborum accusamus. Corporis laboriosam ut molestiae alias ut quo id. Voluptatum laboriosam reprehenderit quaerat.", new DateTimeOffset(new DateTime(2022, 6, 11, 1, 47, 21, 791, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, -3, 0, 0, 0)), "Et dicta quo sed fugit repudiandae quo fugit dolor perferendis.", "Quidem quo eaque voluptates hic ab ea.", new DateTimeOffset(new DateTime(2022, 6, 11, 1, 47, 21, 791, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "tenetur-aut-ut-et-qui-est.", 1, "Ut est rerum dolor recusandae quae perspiciatis sed. Sit dolorem architecto est voluptatem. Similique et porro delectus molestiae nobis asperiores. Soluta fuga inventore rerum expedita recusandae voluptatem odit. Et architecto dolorem molestiae repellendus nostrum ea accusamus incidunt. Similique eius tempore.\n\nDeleniti neque voluptatem ducimus totam architecto a ut. Et sapiente sequi officiis. Necessitatibus animi itaque voluptates autem dolorem. Explicabo harum repellendus quia ipsam explicabo eligendi similique.\n\nAut qui suscipit neque quos voluptates. Rerum porro rerum odit molestiae sit qui eos non. Laboriosam sint et enim exercitationem ipsam. Iure provident ut.", new DateTimeOffset(new DateTime(2022, 2, 12, 0, 50, 23, 186, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, -3, 0, 0, 0)), "Reiciendis ut in illum.", "Tenetur aut ut et qui est.", new DateTimeOffset(new DateTime(2022, 2, 12, 0, 50, 23, 186, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "ut-quo-iste-qui-quod-quisquam-officia-veritatis-sit.", 8, "Quia dolor in qui. Tempora in quae minima atque ex est esse autem. Aut dolores cupiditate possimus.\n\nBlanditiis dicta qui ipsa omnis ut cumque impedit. Perspiciatis quo nihil et voluptate illum. Facere ut et qui doloribus ab unde. Delectus dignissimos et et.\n\nNemo repellat et blanditiis libero explicabo asperiores est. Aut cumque laboriosam. Earum occaecati sit excepturi eum autem occaecati eum nostrum.", new DateTimeOffset(new DateTime(2022, 10, 5, 22, 32, 45, 271, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, -3, 0, 0, 0)), "Qui ea sed nihil architecto suscipit sint omnis et.", "Ut quo iste qui quod quisquam officia veritatis sit.", new DateTimeOffset(new DateTime(2022, 10, 5, 22, 32, 45, 271, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut.", 6, "Minima magnam necessitatibus quae neque at veritatis. Repellendus ratione voluptates ut exercitationem. Sint occaecati minus.\n\nModi at quibusdam. Quam in id sit quidem placeat et error ex. Eveniet distinctio repellendus nesciunt qui rerum quaerat consectetur.\n\nAliquam aspernatur aut magnam vitae iste. Quod incidunt sint eos cum deleniti rem totam est. Quo molestiae id perspiciatis qui iste optio. Ducimus minus commodi alias amet placeat. Reiciendis consequatur cupiditate. Molestiae ex recusandae beatae non.", new DateTimeOffset(new DateTime(2022, 6, 16, 12, 41, 24, 317, DateTimeKind.Unspecified).AddTicks(3448), new TimeSpan(0, -3, 0, 0, 0)), "Quo temporibus modi dolor enim.", "Vitae voluptas nihil voluptas ad necessitatibus tempore ut.", new DateTimeOffset(new DateTime(2022, 6, 16, 12, 41, 24, 317, DateTimeKind.Unspecified).AddTicks(3448), new TimeSpan(0, -3, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "10000.2Dmv2hgt89rykUew4z1PDg==.CdXd1UdbTpKMmXTFsvsOPu91Y7niJ3Od/uNUX8PXMgA=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "10000.tW2q/LNVtGd1ogOaAe7ouQ==.dIhsqhmRx7qQiBJJSyCFWSxPTMlZYiamNAjnu0H4G8M=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "10000./4pdzwt5Wf5dZjHM2aYzOA==.iLp1IxJn/8MIMjMTXZZ364+A21v9Lg8/uMGxTr+JYaU=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "10000.1Hl4FdG9LsA7o/uUUB7w2w==.+EVRO9tIfxEZ61weyiZ6hW7qRBq3S/Si63eCK0qWwC0=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "10000.N5r8yohC9ouwap2eGzibBw==.tA9IgOpY8ZYx4c4+M6lrUrnGAuTgPYhYA/0i5zo25FE=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "10000.x5sBRSBHT0fvZMp7gvrbuw==./PtUuNbfxqJgJRXRI48DkqWE+6rDa8BiusdYFdUhmqQ=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "10000.ocjGVbds2A1SDhjKZ6tGzw==.HJK1aRgA6vGqx3OHHRIYm1CdLPwJjFbqmhq0Z8dTUFQ=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "10000.5lENaaPsvSpsgjdAzpnKCg==.8NC76iLIf/ves2hpLlj0sVG6JmuJC2PpPmJUiFx9Joc=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "10000.scgmlHcPiw2kq5XRLAy4+Q==.bp3vUkzvBecyRDwNxGBJ81Tqmb8eO/4TFaXjc2WOssU=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "10000.W5AX+scHuPrxnxqZQZGfmw==.DY3C/PKtXXKCFym2Sy3zdqyHqT4C4J9wAem9D3I1kac=");

            migrationBuilder.InsertData(
                table: "COMMENTS",
                columns: new[] { "Id", "ArticleSlug", "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "architecto-nisi-voluptatum-corporis.", 9, "Iste quia natus et dignissimos reiciendis ad nostrum totam.", new DateTimeOffset(new DateTime(2022, 1, 16, 23, 47, 52, 627, DateTimeKind.Unspecified).AddTicks(6022), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 1, 16, 23, 47, 52, 627, DateTimeKind.Unspecified).AddTicks(6022), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 2, "tenetur-aut-ut-et-qui-est.", 10, "Eos asperiores cum.", new DateTimeOffset(new DateTime(2022, 2, 12, 8, 23, 23, 917, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 12, 8, 23, 23, 917, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 3, "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut.", 9, "Aperiam cumque non recusandae est unde vitae amet qui exercitationem.", new DateTimeOffset(new DateTime(2022, 6, 17, 12, 24, 54, 499, DateTimeKind.Unspecified).AddTicks(8606), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 17, 12, 24, 54, 499, DateTimeKind.Unspecified).AddTicks(8606), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 4, "quidem-quo-eaque-voluptates-hic-ab-ea.", 8, "Vel nisi a.", new DateTimeOffset(new DateTime(2022, 6, 11, 13, 54, 44, 955, DateTimeKind.Unspecified).AddTicks(5979), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 11, 13, 54, 44, 955, DateTimeKind.Unspecified).AddTicks(5979), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 5, "architecto-nisi-voluptatum-corporis.", 2, "Et autem suscipit blanditiis ratione.", new DateTimeOffset(new DateTime(2022, 1, 16, 13, 55, 32, 477, DateTimeKind.Unspecified).AddTicks(2070), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 1, 16, 13, 55, 32, 477, DateTimeKind.Unspecified).AddTicks(2070), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 6, "tenetur-aut-ut-et-qui-est.", 8, "Corrupti adipisci debitis dolorem id vero soluta.", new DateTimeOffset(new DateTime(2022, 2, 12, 15, 50, 11, 620, DateTimeKind.Unspecified).AddTicks(7865), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 12, 15, 50, 11, 620, DateTimeKind.Unspecified).AddTicks(7865), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 7, "fugit-nesciunt-omnis-fugiat.", 9, "Dicta quo ipsum facilis dolorem eius repellat deleniti et quisquam.", new DateTimeOffset(new DateTime(2022, 4, 22, 17, 23, 46, 788, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 22, 17, 23, 46, 788, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 8, "omnis-molestiae-est-repellat-est.", 8, "Consequuntur et consectetur voluptatum ut voluptas tempore totam.", new DateTimeOffset(new DateTime(2022, 8, 4, 11, 39, 9, 419, DateTimeKind.Unspecified).AddTicks(2751), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 4, 11, 39, 9, 419, DateTimeKind.Unspecified).AddTicks(2751), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 9, "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut.", 8, "Itaque exercitationem cupiditate nam sit quis qui modi amet.", new DateTimeOffset(new DateTime(2022, 6, 16, 14, 20, 4, 346, DateTimeKind.Unspecified).AddTicks(296), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 16, 14, 20, 4, 346, DateTimeKind.Unspecified).AddTicks(296), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 10, "quidem-quo-eaque-voluptates-hic-ab-ea.", 7, "Molestiae modi non et ut cum explicabo voluptatem.", new DateTimeOffset(new DateTime(2022, 6, 11, 4, 21, 24, 214, DateTimeKind.Unspecified).AddTicks(9554), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 11, 4, 21, 24, 214, DateTimeKind.Unspecified).AddTicks(9554), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 11, "quidem-quo-eaque-voluptates-hic-ab-ea.", 10, "Ratione cum similique tempora et consequatur.", new DateTimeOffset(new DateTime(2022, 6, 11, 10, 27, 6, 923, DateTimeKind.Unspecified).AddTicks(645), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 11, 10, 27, 6, 923, DateTimeKind.Unspecified).AddTicks(645), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 12, "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut.", 1, "Nihil a doloribus iure cupiditate.", new DateTimeOffset(new DateTime(2022, 6, 16, 19, 25, 4, 425, DateTimeKind.Unspecified).AddTicks(2527), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 16, 19, 25, 4, 425, DateTimeKind.Unspecified).AddTicks(2527), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 13, "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui.", 6, "Minima dolores nulla.", new DateTimeOffset(new DateTime(2022, 6, 21, 3, 18, 13, 335, DateTimeKind.Unspecified).AddTicks(3345), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 21, 3, 18, 13, 335, DateTimeKind.Unspecified).AddTicks(3345), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 14, "omnis-molestiae-est-repellat-est.", 8, "Recusandae magni cumque et eum nobis.", new DateTimeOffset(new DateTime(2022, 8, 4, 5, 19, 21, 37, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 4, 5, 19, 21, 37, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 15, "omnis-molestiae-est-repellat-est.", 2, "Magnam repellat similique veritatis voluptatem voluptas similique.", new DateTimeOffset(new DateTime(2022, 8, 4, 7, 9, 8, 832, DateTimeKind.Unspecified).AddTicks(8696), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 4, 7, 9, 8, 832, DateTimeKind.Unspecified).AddTicks(8696), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 16, "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui.", 10, "Excepturi sequi vel.", new DateTimeOffset(new DateTime(2022, 6, 21, 4, 0, 30, 336, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 21, 4, 0, 30, 336, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 17, "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui.", 6, "Asperiores corporis et laudantium atque numquam quasi incidunt.", new DateTimeOffset(new DateTime(2022, 6, 20, 16, 12, 28, 436, DateTimeKind.Unspecified).AddTicks(5496), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 20, 16, 12, 28, 436, DateTimeKind.Unspecified).AddTicks(5496), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 18, "tenetur-aut-ut-et-qui-est.", 5, "Iure illum sed.", new DateTimeOffset(new DateTime(2022, 2, 12, 22, 46, 0, 754, DateTimeKind.Unspecified).AddTicks(9959), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 12, 22, 46, 0, 754, DateTimeKind.Unspecified).AddTicks(9959), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 19, "aut-quod-ea-recusandae-magni-cumque-et.", 6, "Asperiores sit et minima delectus officia est quia quam aut.", new DateTimeOffset(new DateTime(2022, 8, 25, 8, 21, 2, 777, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 25, 8, 21, 2, 777, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 20, "dolores-ab-quia-soluta-repellat-eligendi-harum-nihil-deserunt.", 3, "Eveniet dolor aut perspiciatis.", new DateTimeOffset(new DateTime(2022, 9, 22, 22, 54, 7, 166, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 22, 22, 54, 7, 166, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, -3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "ut-quo-iste-qui-quod-quisquam-officia-veritatis-sit.");

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "architecto-nisi-voluptatum-corporis.");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "aut-quod-ea-recusandae-magni-cumque-et.");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "dolores-ab-quia-soluta-repellat-eligendi-harum-nihil-deserunt.");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui.");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "fugit-nesciunt-omnis-fugiat.");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "omnis-molestiae-est-repellat-est.");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "quidem-quo-eaque-voluptates-hic-ab-ea.");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "tenetur-aut-ut-et-qui-est.");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut.");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "10000.kyzLAFcvW4NZRW/aD1XQmA==.A0HkLh1f2Cj7gsLw1BVuylvgXXTuJthwnGDAnd7/Xh0=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "10000.dR8AYSEzXCWh3AImE5M4oA==.05tRvRM8TgnNyGvWPpctPR9FVQRL3kLLV/yiy5+XAoM=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "10000.2NeL+r/Tk45Hn8JxACCBZQ==.zxhyEIgrb0PJafhJY8QD7AFduGUHmKYtsM6zskic0ic=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "10000.M5pG+QmkxFBjrKTHTVbufg==./B2Hac0H5kZLXhamXfwd1wl2/2Uqq3pui6cXVDD+pmw=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "10000.LnHOXVnfESvSER7aaMeyZg==.qb0fLj5xeD6U371ihtHVwg9UH3E6s4/kCeQRA7cdL70=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "10000.DwNDFnhTyMwCr9inIpw+9A==.GvozCb/XOivN+pDuhs7gNeVFkqlPWkgLbNYWNYYNzEw=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "10000.nI6jTcePHOxnEduxlKY7JQ==.t0DaVsVc8f+dRlrjRNeNeZz8aVmJ5SrUdLhq9ONRRk0=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "10000.wXOVJ9rxwW4ReGZmrFNx0Q==.CXE+wAmrnDVyMyyW2aIlg8i+d1sbISnZ/yUovhgkDBg=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "10000.Aq54hQzmEKQSg1sZ9puOOQ==.S5AH6pwF3ne+QAN7roP5cRvW+T+vY8ARpfpwTMAhxNQ=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "10000.Nxk3P5QEwse5SkDfOEGpew==.Rt+HfKNk9USCuKpI5FOYIVN81PuFrr1dsrSb1CO8hQQ=");
        }
    }
}
