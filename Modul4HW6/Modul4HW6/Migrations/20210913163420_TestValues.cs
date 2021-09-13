using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW6.Migrations
{
    public partial class TestValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "DateOfBirth", "Email", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1969, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jay-Z@gmail.com", "https://www.instagram.com/Jay-Z/", "Jay-Z", "88005553535" },
                    { 2, new DateTime(1947, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "EltonJohn@gmail.com", "https://www.instagram.com/Elton_John/", "Elton John", "0509177329" },
                    { 3, new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eminem@gmail.com", "https://www.instagram.com/Eminem/", "Eminem", "0937299315" },
                    { 4, new DateTime(1958, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "MichaelJackson@gmail.com", "https://www.instagram.com/MichaelJackson/", "Michael Jackson", "17293711842" },
                    { 5, new DateTime(1986, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drake@gmail.com", "https://www.instagram.com/Drake/", "Drake", "32574523451" }
                });

            migrationBuilder.InsertData(
                table: "Ganres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Rap" },
                    { 2, "Pop music" },
                    { 3, "Jazz" },
                    { 4, "Rock" },
                    { 5, "Folk songs" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 1, 2.54, 1, new DateTime(2016, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "One Dance" },
                    { 2, 4.3799999999999999, 1, new DateTime(2009, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empire State Of Mind" },
                    { 3, 4.1500000000000004, 1, new DateTime(2010, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Young Forever" },
                    { 4, 5.4699999999999998, 1, new DateTime(2018, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvins Room" },
                    { 9, 4.1500000000000004, 1, new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venom" },
                    { 10, 4.1699999999999999, 1, new DateTime(2009, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mockingbird" },
                    { 5, 4.1900000000000004, 2, new DateTime(1987, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bad" },
                    { 6, 4.5300000000000002, 2, new DateTime(1982, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billie Jean" },
                    { 7, 2.54, 2, new DateTime(1989, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sacrifice" },
                    { 8, 6.46, 2, new DateTime(1971, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiny Dancer" },
                    { 11, 3.1600000000000001, 5, new DateTime(1971, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banks of the Ohio" }
                });

            migrationBuilder.InsertData(
                table: "ArtistsSongs",
                columns: new[] { "Id", "ArtistsId", "SongsId" },
                values: new object[,]
                {
                    { 1, 5, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 5, 4 },
                    { 9, 3, 9 },
                    { 10, 3, 10 },
                    { 5, 4, 5 },
                    { 6, 4, 6 },
                    { 7, 2, 7 },
                    { 8, 2, 8 },
                    { 11, null, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ArtistsSongs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ganres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ganres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ganres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ganres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ganres",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
