using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealWorldApi.Migrations
{
    public partial class CreateDatabase : Migration
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
                    Bio = table.Column<string>(type: "VARCHAR(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ARTICLE",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_ARTICLE", x => x.Slug);
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
                    ArticleSlug = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    TagName = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICLES_TAGS", x => new { x.ArticleSlug, x.TagName });
                    table.ForeignKey(
                        name: "FK_ARTICLES_TAGS_ARTICLE_ArticleSlug",
                        column: x => x.ArticleSlug,
                        principalTable: "ARTICLE",
                        principalColumn: "Slug");
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
                    ArticleSlug = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMMENTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COMMENTS_ARTICLE_ArticleSlug",
                        column: x => x.ArticleSlug,
                        principalTable: "ARTICLE",
                        principalColumn: "Slug");
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
                    ArticleSlug = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    FavoritedBy = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAVORITES", x => new { x.ArticleSlug, x.FavoritedBy });
                    table.ForeignKey(
                        name: "FK_FAVORITES_ARTICLE_ArticleSlug",
                        column: x => x.ArticleSlug,
                        principalTable: "ARTICLE",
                        principalColumn: "Slug");
                    table.ForeignKey(
                        name: "FK_FAVORITES_USERS_FavoritedBy",
                        column: x => x.FavoritedBy,
                        principalTable: "USERS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ARTICLE_AuthorId",
                table: "ARTICLE",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ARTICLES_TAGS_TagName",
                table: "ARTICLES_TAGS",
                column: "TagName");

            migrationBuilder.CreateIndex(
                name: "IX_COMMENTS_ArticleSlug",
                table: "COMMENTS",
                column: "ArticleSlug");

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
