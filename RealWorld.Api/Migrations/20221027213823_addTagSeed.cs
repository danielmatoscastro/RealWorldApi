using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealWorldApi.Migrations
{
    public partial class addTagSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "ad");

            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "assumenda");

            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "dignissimos");

            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "est");

            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "et");

            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "illum");

            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "iste");

            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "natus");

            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "quia");

            migrationBuilder.DeleteData(
                table: "TAGS",
                keyColumn: "Name",
                keyValue: "reiciendis");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "10000.CDwzHa+tbw8gAtkbIpGcvg==.KtEe4VNzAOezWwvgMHiu/kFcRwNtfR1xnXL00fv/oW8=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "10000.3JMyX0U84yjgJY+kpvcdfA==.14JjjNRCg1S/jrTsBkPWRdgKBl9sKHWJyKgrlLR3cQM=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "10000.GkBqVUYXAl9qXCFfcKkBpw==.Cz6FhYBLkPgznnm5hcizM7J5MU68761znrALa2nA0Xs=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "10000.P2a1ukFp/ihf+75ty2rLjg==.J8iD9XoJmpxNrNZTSFMDohvHvZqvEloALkKO1Eg9EcE=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "10000.iSp78b8YJg90dWTJTmTZXA==.3wPJkNM2GYWxdeTihfPDgxelucQv/fUW+ymroyVLcXc=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "10000.ZCcy/lH4JbGZxGafcQUx/A==.MZL8rvOXNoh8RnhykaLw6VjJH672x5W6S9SJoXPm1TI=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "10000.Mgjfyk85G1N4Od9cYFUgTQ==.ohdvNDaSKdV/dkzxx8BLhJm75nVKD01910SDLRZo/8Q=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "10000.48vC0b6cK9AGdubRooIvEQ==.N3xqewHehJzXH2iZsa8MCCvrGa6SQUqCKrEdt55RkvQ=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "10000.xzxHoIuS2BgtuSiMQCrPQw==.rmq5OnO5iH6x8T+dlUG29rZDPBHXVPmGiqzGlMYdWY0=");

            migrationBuilder.UpdateData(
                table: "USERS",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "10000.EMMMrJMxbQafGGNzEt2DpA==.ahUqel9uWPG8SkofViTf6ch4XxujML956fjN3Bn6DB4=");
        }
    }
}
