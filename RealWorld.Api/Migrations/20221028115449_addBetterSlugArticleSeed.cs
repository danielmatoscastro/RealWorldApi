using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealWorldApi.Migrations
{
    public partial class addBetterSlugArticleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "ut-quo-iste-qui-quod-quisquam-officia-veritatis-sit.");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut.");

            migrationBuilder.InsertData(
                table: "ARTICLE",
                columns: new[] { "Slug", "AuthorId", "Body", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { "architecto-nisi-voluptatum-corporis", 1, "Necessitatibus est provident aut dignissimos velit ullam. Autem facere nostrum perferendis non. Atque corporis quos.\n\nDeserunt modi quia velit laudantium sit alias cumque. Non nostrum aperiam ut laudantium. Perspiciatis commodi sit sit tempore. Velit quibusdam ea voluptatem dolore fuga voluptates maiores. Facilis iste est exercitationem molestiae ipsam. Enim quasi assumenda dignissimos et aut temporibus vitae quisquam.\n\nSimilique molestias quia quia rem vitae perferendis. Molestiae porro voluptatem numquam. Sunt porro et aut id nihil earum aperiam.", new DateTimeOffset(new DateTime(2022, 1, 16, 8, 36, 50, 883, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, -3, 0, 0, 0)), "Ab fugit magnam tempora numquam in consequatur voluptatem perspiciatis.", "Architecto nisi voluptatum corporis.", new DateTimeOffset(new DateTime(2022, 1, 16, 8, 36, 50, 883, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "aut-quod-ea-recusandae-magni-cumque-et", 8, "Iste quia natus et dignissimos reiciendis ad nostrum totam. Totam voluptatibus doloremque eos asperiores cum ipsam illum. Doloribus aperiam cumque non recusandae est unde vitae amet. Exercitationem doloribus facilis omnis doloremque vel. A quas porro sed ad. Autem suscipit blanditiis ratione modi velit porro dolorum corrupti adipisci.\n\nId vero soluta fuga eius saepe eveniet dicta quo. Facilis dolorem eius repellat. Et quisquam consequatur aut qui porro. Et consectetur voluptatum ut. Tempore totam fugiat consequatur autem. Itaque exercitationem cupiditate nam sit quis qui modi amet.\n\nEligendi et molestiae modi non et ut. Explicabo voluptatem odit est tenetur quos ratione cum. Tempora et consequatur ea pariatur veritatis veniam.", new DateTimeOffset(new DateTime(2022, 8, 24, 11, 5, 12, 413, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, -3, 0, 0, 0)), "Doloribus iure cupiditate minima molestias provident inventore minima dolores nulla.", "Aut quod ea recusandae magni cumque et.", new DateTimeOffset(new DateTime(2022, 8, 24, 11, 5, 12, 413, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "dolores-ab-quia-soluta-repellat-eligendi-harum-nihil-deserunt", 3, "Dolorem blanditiis quod ipsa assumenda eum cumque fugit. Ratione modi quia ut ut tempore ipsa magnam porro et. Ut quam cum et. Voluptas ut nihil voluptatum pariatur dolor voluptatem et ullam. Voluptatum possimus nostrum quasi sapiente. Et commodi ut eos sed occaecati esse.\n\nQuam dolorem quis cum commodi voluptate dolor qui dolor. Natus repellat quidem aspernatur consequatur quasi. Animi explicabo velit quis a est rerum et. Illo dolores inventore maxime. At aut harum molestiae a dolor dolorem recusandae nulla.\n\nFugit et in cupiditate molestiae voluptatem ipsum temporibus esse sint. Ea natus laudantium quia nihil. Neque aliquid facilis. Iusto harum impedit saepe consequatur libero velit nostrum debitis. Dolore quas aliquid nulla sit perspiciatis consequuntur est.", new DateTimeOffset(new DateTime(2022, 9, 22, 4, 3, 39, 257, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, -3, 0, 0, 0)), "Enim voluptas necessitatibus provident cumque quasi delectus dolor ex et.", "Dolores ab quia soluta repellat eligendi harum nihil deserunt.", new DateTimeOffset(new DateTime(2022, 9, 22, 4, 3, 39, 257, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui", 1, "Modi unde dolorem laborum sapiente amet repellendus et. Ab quibusdam ipsum quo eum. Est sapiente tempore placeat quos. Soluta nihil odit mollitia accusamus consequuntur doloribus tempora.\n\nSimilique ipsa quidem explicabo non eius sint ad earum. Aliquid repudiandae aliquid voluptatem magnam. Sit minima totam et. Ipsam omnis et. Voluptas veritatis perferendis sunt inventore quibusdam ea. Tempora incidunt magni architecto id minus.\n\nIn aut consequuntur. Assumenda ex dicta ut et earum. Possimus excepturi consequatur magnam ut quo omnis nobis. Ut sit aut error. Quas quia autem quia dolorem ducimus perspiciatis repudiandae iure et.", new DateTimeOffset(new DateTime(2022, 6, 20, 12, 35, 16, 495, DateTimeKind.Unspecified).AddTicks(6423), new TimeSpan(0, -3, 0, 0, 0)), "Ut assumenda corrupti aut libero laudantium sed sunt.", "Eveniet esse reiciendis eos commodi sit ab qui.", new DateTimeOffset(new DateTime(2022, 6, 20, 12, 35, 16, 495, DateTimeKind.Unspecified).AddTicks(6423), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "fugit-nesciunt-omnis-fugiat", 1, "Officiis ut eos alias iste tempore vel et quia repellendus. Eum ut cupiditate neque harum omnis ipsam. Et praesentium et laboriosam. Voluptatem distinctio quia sed. Est atque aut odio sed eos error.\n\nPerferendis similique praesentium asperiores quia quia veniam harum. Aliquam voluptatem perferendis dignissimos exercitationem voluptas qui provident hic. Rerum at eveniet totam. Ex omnis corporis quam reprehenderit nihil nam animi recusandae. Ullam soluta nisi totam et eius voluptates occaecati eos hic.\n\nVoluptas amet voluptatem et officia voluptates. Possimus temporibus sed aut laborum. Sunt illum et labore autem deserunt nam vitae. Asperiores nesciunt deleniti veritatis voluptatem maiores eaque.", new DateTimeOffset(new DateTime(2022, 4, 21, 21, 58, 9, 221, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, -3, 0, 0, 0)), "Sint sunt vero.", "Fugit nesciunt omnis fugiat.", new DateTimeOffset(new DateTime(2022, 4, 21, 21, 58, 9, 221, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "omnis-molestiae-est-repellat-est", 9, "Quia sit est magnam repellat similique veritatis. Voluptas similique facilis sint ut. Excepturi sequi vel. In omnis tempore asperiores corporis et laudantium atque. Quasi incidunt voluptatem ducimus.\n\nIure illum sed. Doloremque molestias sapiente asperiores sit et minima delectus officia est. Quam aut rerum aut aliquam. Eveniet dolor aut perspiciatis.\n\nAliquid doloribus aperiam eligendi quia adipisci dolores. Voluptatem enim et repellendus dolores laborum natus. Laboriosam voluptatem aspernatur debitis quo saepe et aliquam. Voluptatum adipisci necessitatibus quos quidem. Consequatur et asperiores laborum alias. Sapiente nesciunt est sunt consectetur veritatis aut minus aut voluptas.", new DateTimeOffset(new DateTime(2022, 8, 3, 15, 38, 55, 286, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, -3, 0, 0, 0)), "Et quo eos ducimus et et praesentium.", "Omnis molestiae est repellat est.", new DateTimeOffset(new DateTime(2022, 8, 3, 15, 38, 55, 286, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "quidem-quo-eaque-voluptates-hic-ab-ea", 2, "Natus iusto ut incidunt exercitationem tempora laudantium dolores neque voluptas. Consectetur quod et. Repellendus adipisci sit ut.\n\nVoluptatum corporis id impedit vel quaerat et ut dolores. Dolore in officia dicta aut quas quaerat. Dignissimos alias dolorum molestiae aut omnis modi labore. Consectetur qui at numquam. Dolores nesciunt dicta dolores nam occaecati deleniti delectus distinctio incidunt.\n\nDebitis autem sequi provident quasi. Itaque et autem porro qui. Dolores dolorem atque sunt sit laborum accusamus. Corporis laboriosam ut molestiae alias ut quo id. Voluptatum laboriosam reprehenderit quaerat.", new DateTimeOffset(new DateTime(2022, 6, 11, 1, 47, 21, 791, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, -3, 0, 0, 0)), "Et dicta quo sed fugit repudiandae quo fugit dolor perferendis.", "Quidem quo eaque voluptates hic ab ea.", new DateTimeOffset(new DateTime(2022, 6, 11, 1, 47, 21, 791, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "tenetur-aut-ut-et-qui-est", 1, "Ut est rerum dolor recusandae quae perspiciatis sed. Sit dolorem architecto est voluptatem. Similique et porro delectus molestiae nobis asperiores. Soluta fuga inventore rerum expedita recusandae voluptatem odit. Et architecto dolorem molestiae repellendus nostrum ea accusamus incidunt. Similique eius tempore.\n\nDeleniti neque voluptatem ducimus totam architecto a ut. Et sapiente sequi officiis. Necessitatibus animi itaque voluptates autem dolorem. Explicabo harum repellendus quia ipsam explicabo eligendi similique.\n\nAut qui suscipit neque quos voluptates. Rerum porro rerum odit molestiae sit qui eos non. Laboriosam sint et enim exercitationem ipsam. Iure provident ut.", new DateTimeOffset(new DateTime(2022, 2, 12, 0, 50, 23, 186, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, -3, 0, 0, 0)), "Reiciendis ut in illum.", "Tenetur aut ut et qui est.", new DateTimeOffset(new DateTime(2022, 2, 12, 0, 50, 23, 186, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "ut-quo-iste-qui-quod-quisquam-officia-veritatis-sit", 8, "Quia dolor in qui. Tempora in quae minima atque ex est esse autem. Aut dolores cupiditate possimus.\n\nBlanditiis dicta qui ipsa omnis ut cumque impedit. Perspiciatis quo nihil et voluptate illum. Facere ut et qui doloribus ab unde. Delectus dignissimos et et.\n\nNemo repellat et blanditiis libero explicabo asperiores est. Aut cumque laboriosam. Earum occaecati sit excepturi eum autem occaecati eum nostrum.", new DateTimeOffset(new DateTime(2022, 10, 5, 22, 32, 45, 271, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, -3, 0, 0, 0)), "Qui ea sed nihil architecto suscipit sint omnis et.", "Ut quo iste qui quod quisquam officia veritatis sit.", new DateTimeOffset(new DateTime(2022, 10, 5, 22, 32, 45, 271, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, -3, 0, 0, 0)) },
                    { "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut", 6, "Minima magnam necessitatibus quae neque at veritatis. Repellendus ratione voluptates ut exercitationem. Sint occaecati minus.\n\nModi at quibusdam. Quam in id sit quidem placeat et error ex. Eveniet distinctio repellendus nesciunt qui rerum quaerat consectetur.\n\nAliquam aspernatur aut magnam vitae iste. Quod incidunt sint eos cum deleniti rem totam est. Quo molestiae id perspiciatis qui iste optio. Ducimus minus commodi alias amet placeat. Reiciendis consequatur cupiditate. Molestiae ex recusandae beatae non.", new DateTimeOffset(new DateTime(2022, 6, 16, 12, 41, 24, 317, DateTimeKind.Unspecified).AddTicks(3448), new TimeSpan(0, -3, 0, 0, 0)), "Quo temporibus modi dolor enim.", "Vitae voluptas nihil voluptas ad necessitatibus tempore ut.", new DateTimeOffset(new DateTime(2022, 6, 16, 12, 41, 24, 317, DateTimeKind.Unspecified).AddTicks(3448), new TimeSpan(0, -3, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "10000.lJlvQiLEr9zRsTYwomkUQA==.LcRsSsOilykIZXUrCDr3yago6ZdRWAffxdQ6dKZe4Mw=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "10000.TQ2qFu1bsHSgXSTURoo+Gw==.iB0So0vra969rQhnN/hx+7613zus4C5kPbLt57eaYOo=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "10000.hlYD/Zb03QGc1r7jzvVNmA==.7YVMtsSqDk2m2OFvHbeWqMeC4M6wxN6hcIel07uM4qc=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "10000.YMlmEdpYO31SN8nWnLnl1g==.L0pE7oNMOC13NiDj9iCqsYhDWyfSWwPmdAJKTDAKMjA=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "10000.d/orWzw2DBRa1A0+0FmLZA==.mGBv+2rbfni1N7D69EJe80abpNC9n/PXD4zDLsytoP4=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "10000.RPWsH3/B1sB4C4Ood9MQoQ==.ukR68nAIjQ7xV+/GH/tkCgZBLpromo8xu9GjdUvaukc=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "10000.kjYfEGQFRlHxjNf551K/Rg==.lmI8TAbQD1LnipUvpQiVPOiqXcN9FFHnwtrtxcvfn7E=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "10000.spQH1D22SPsKuz78RggP9Q==.OugYlJqr/eQYVjfx0PXAAoseR4OnkMdrAT9/prp2s48=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "10000.wtvDH3y0D0BTzFUmgIE+2g==./XHVj0xVTavVTc3Ba/qNPVEciHIPxkHQ+6CjEPlPf+g=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "10000.vh+fREFC9b2slL1WwYDZxQ==.UXg9CvypwA540U4sGfZLFV0vV5/yfki8f20MPoBTJqw=");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArticleSlug",
                value: "architecto-nisi-voluptatum-corporis");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArticleSlug",
                value: "tenetur-aut-ut-et-qui-est");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArticleSlug",
                value: "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArticleSlug",
                value: "quidem-quo-eaque-voluptates-hic-ab-ea");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArticleSlug",
                value: "architecto-nisi-voluptatum-corporis");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArticleSlug",
                value: "tenetur-aut-ut-et-qui-est");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 7,
                column: "ArticleSlug",
                value: "fugit-nesciunt-omnis-fugiat");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 8,
                column: "ArticleSlug",
                value: "omnis-molestiae-est-repellat-est");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 9,
                column: "ArticleSlug",
                value: "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 10,
                column: "ArticleSlug",
                value: "quidem-quo-eaque-voluptates-hic-ab-ea");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 11,
                column: "ArticleSlug",
                value: "quidem-quo-eaque-voluptates-hic-ab-ea");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 12,
                column: "ArticleSlug",
                value: "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 13,
                column: "ArticleSlug",
                value: "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 14,
                column: "ArticleSlug",
                value: "omnis-molestiae-est-repellat-est");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 15,
                column: "ArticleSlug",
                value: "omnis-molestiae-est-repellat-est");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 16,
                column: "ArticleSlug",
                value: "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 17,
                column: "ArticleSlug",
                value: "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 18,
                column: "ArticleSlug",
                value: "tenetur-aut-ut-et-qui-est");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 19,
                column: "ArticleSlug",
                value: "aut-quod-ea-recusandae-magni-cumque-et");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 20,
                column: "ArticleSlug",
                value: "dolores-ab-quia-soluta-repellat-eligendi-harum-nihil-deserunt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "architecto-nisi-voluptatum-corporis");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "aut-quod-ea-recusandae-magni-cumque-et");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "dolores-ab-quia-soluta-repellat-eligendi-harum-nihil-deserunt");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "fugit-nesciunt-omnis-fugiat");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "omnis-molestiae-est-repellat-est");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "quidem-quo-eaque-voluptates-hic-ab-ea");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "tenetur-aut-ut-et-qui-est");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "ut-quo-iste-qui-quod-quisquam-officia-veritatis-sit");

            migrationBuilder.DeleteData(
                table: "ARTICLE",
                keyColumn: "Slug",
                keyValue: "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut");

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

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArticleSlug",
                value: "architecto-nisi-voluptatum-corporis.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArticleSlug",
                value: "tenetur-aut-ut-et-qui-est.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArticleSlug",
                value: "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArticleSlug",
                value: "quidem-quo-eaque-voluptates-hic-ab-ea.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArticleSlug",
                value: "architecto-nisi-voluptatum-corporis.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArticleSlug",
                value: "tenetur-aut-ut-et-qui-est.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 7,
                column: "ArticleSlug",
                value: "fugit-nesciunt-omnis-fugiat.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 8,
                column: "ArticleSlug",
                value: "omnis-molestiae-est-repellat-est.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 9,
                column: "ArticleSlug",
                value: "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 10,
                column: "ArticleSlug",
                value: "quidem-quo-eaque-voluptates-hic-ab-ea.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 11,
                column: "ArticleSlug",
                value: "quidem-quo-eaque-voluptates-hic-ab-ea.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 12,
                column: "ArticleSlug",
                value: "vitae-voluptas-nihil-voluptas-ad-necessitatibus-tempore-ut.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 13,
                column: "ArticleSlug",
                value: "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 14,
                column: "ArticleSlug",
                value: "omnis-molestiae-est-repellat-est.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 15,
                column: "ArticleSlug",
                value: "omnis-molestiae-est-repellat-est.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 16,
                column: "ArticleSlug",
                value: "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 17,
                column: "ArticleSlug",
                value: "eveniet-esse-reiciendis-eos-commodi-sit-ab-qui.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 18,
                column: "ArticleSlug",
                value: "tenetur-aut-ut-et-qui-est.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 19,
                column: "ArticleSlug",
                value: "aut-quod-ea-recusandae-magni-cumque-et.");

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "Id",
                keyValue: 20,
                column: "ArticleSlug",
                value: "dolores-ab-quia-soluta-repellat-eligendi-harum-nihil-deserunt.");
        }
    }
}
