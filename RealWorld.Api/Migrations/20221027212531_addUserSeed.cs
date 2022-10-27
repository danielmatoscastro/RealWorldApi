using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealWorldApi.Migrations
{
    public partial class addUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "USERS",
                columns: new[] { "Id", "Bio", "Email", "Image", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { 1, "Illum assumenda iste quia natus et dignissimos reiciendis.\nNostrum totam harum totam voluptatibus.\nEos asperiores cum.", "Reagan.Stanton69@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/657.jpg", "10000.CDwzHa+tbw8gAtkbIpGcvg==.KtEe4VNzAOezWwvgMHiu/kFcRwNtfR1xnXL00fv/oW8=", "Trace Pfeffer" },
                    { 2, "Vitae amet qui exercitationem doloribus facilis omnis.\nVel nisi a.\nPorro sed ad et autem suscipit blanditiis.", "Dallin_Jast48@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/243.jpg", "10000.3JMyX0U84yjgJY+kpvcdfA==.14JjjNRCg1S/jrTsBkPWRdgKBl9sKHWJyKgrlLR3cQM=", "Shad Shanahan" },
                    { 3, "Vero soluta fuga eius saepe eveniet dicta quo.\nFacilis dolorem eius repellat.\nEt quisquam consequatur aut qui porro.", "Susan_Dickens@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/406.jpg", "10000.GkBqVUYXAl9qXCFfcKkBpw==.Cz6FhYBLkPgznnm5hcizM7J5MU68761znrALa2nA0Xs=", "Marcos Koss" },
                    { 4, "Consequatur autem voluptas itaque exercitationem cupiditate nam sit quis.\nModi amet quasi fuga eligendi et molestiae modi non.\nUt cum explicabo.", "Benny.Monahan14@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/847.jpg", "10000.P2a1ukFp/ihf+75ty2rLjg==.J8iD9XoJmpxNrNZTSFMDohvHvZqvEloALkKO1Eg9EcE=", "Kevin Fahey" },
                    { 5, "Consequatur ea pariatur veritatis veniam nihil a.\nIure cupiditate minima molestias provident inventore minima dolores nulla laborum.\nQuod ea recusandae.", "Maximo_Morissette56@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/215.jpg", "10000.iSp78b8YJg90dWTJTmTZXA==.3wPJkNM2GYWxdeTihfPDgxelucQv/fUW+ymroyVLcXc=", "Christina Monahan" },
                    { 6, "Repellat similique veritatis voluptatem voluptas.\nFacilis sint ut beatae excepturi sequi vel.\nIn omnis tempore asperiores corporis et laudantium atque.", "Antonia44@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/563.jpg", "10000.ZCcy/lH4JbGZxGafcQUx/A==.MZL8rvOXNoh8RnhykaLw6VjJH672x5W6S9SJoXPm1TI=", "Aisha Howell" },
                    { 7, "Sed repudiandae doloremque molestias sapiente asperiores sit et minima.\nOfficia est quia quam aut rerum aut aliquam magni eveniet.\nAut perspiciatis repellendus excepturi.", "Zachariah.Bartoletti19@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/620.jpg", "10000.Mgjfyk85G1N4Od9cYFUgTQ==.ohdvNDaSKdV/dkzxx8BLhJm75nVKD01910SDLRZo/8Q=", "Krista Gibson" },
                    { 8, "Et repellendus dolores laborum natus.\nLaboriosam voluptatem aspernatur debitis quo saepe et aliquam.\nVoluptatum adipisci necessitatibus quos quidem.", "Frida_Frami0@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1229.jpg", "10000.48vC0b6cK9AGdubRooIvEQ==.N3xqewHehJzXH2iZsa8MCCvrGa6SQUqCKrEdt55RkvQ=", "Vidal Crona" },
                    { 9, "Sunt consectetur veritatis aut minus aut voluptas facilis sunt.\nQuo eos ducimus et.\nPraesentium laboriosam omnis molestiae est repellat est sunt fuga.", "Scarlett0@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/696.jpg", "10000.xzxHoIuS2BgtuSiMQCrPQw==.rmq5OnO5iH6x8T+dlUG29rZDPBHXVPmGiqzGlMYdWY0=", "Margarett Hoeger" },
                    { 10, "Quia repellendus occaecati eum ut cupiditate neque harum omnis.\nMagnam et praesentium et laboriosam.\nVoluptatem distinctio quia sed.", "Oma43@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/149.jpg", "10000.EMMMrJMxbQafGGNzEt2DpA==.ahUqel9uWPG8SkofViTf6ch4XxujML956fjN3Bn6DB4=", "Rylee Maggio" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
