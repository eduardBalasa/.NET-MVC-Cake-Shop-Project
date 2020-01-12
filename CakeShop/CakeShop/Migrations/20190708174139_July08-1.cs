using Microsoft.EntityFrameworkCore.Migrations;

namespace CakeShop.Migrations
{
    public partial class July081 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Torturi Nunta" },
                    { 2, "Torturi Botez" },
                    { 3, "Candy Bar" },
                    { 4, "Deserturi" }
                });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "CategoryId", "Description", "ImageName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "In nuante pastelate, ghirlanda de trandafiri cu care am decorat acest tort de nunta ii confera o nota de eleganta si rafinament. Perlele si brosa sunt cateva din detaliile mici delicate si elegante.", "TortGhirlandaDeTrandafiri.jpg", "Ghirlanda de trandafiri", 500m },
                    { 2, 1, "Un tort de nunta pe care am ales sa il decoram cu o cascada de fluturi in degradee de mov, iar deasupra au fost asezati cei doi miri realizati manual.", "FluturiInDegradee.jpg", "Fluturi in Degradee", 700m },
                    { 3, 2, "Flavia Maria a avut parte de un tort de botez pe masura petrecerii. Decorat cu detalii in nuante de roz pastel si alb, o luna instelata si insertii aurite, tortul cu o compozitie usoara si fructata, a facut deliciul invitatilor aflati la petrecere.", "LunaRoz.jpg", "Luna Roz", 400m },
                    { 4, 2, "Tort de botez pentru baieti cu doua etaje, realizat in pasteluri bleu si argintii, asemenea celui din imagine. Alege compozitia preferata si lasa-i pe designerii nostri sa transforme tortul intr-o poveste magica!", "LunaAlbastra.jpg", "Luna Albastra", 450m },
                    { 5, 3, "Iata un desert ciocolatos si pufos ! Briosele au o aroma intensa de ciocolata si fi servite alaturi de o cafea.", "BrioseCuCiocolata.jpg", "Briose cu Ciocolata", 50m },
                    { 6, 3, "Produs de cofetărie de origine franceză, realizat din pudra de migdale, avand la mijloc o cremă deosebită.", "MacaronsChristmasTree.jpg", "Macarons Christmas Tree", 80m },
                    { 7, 4, "Prajituri delicioase preparate pe un blat alb pufos, bine insiropat, avand un strat de crema de ciocolata alba si lamaie. Sunt finisate cu fondant, in diverse culori.", "MiniAmandine.jpg", "Mini Amandine", 30m },
                    { 8, 4, "Mini eclere –  sunt preparate din aluat oparit si pufos, cu o cremă delicioasa de ciocolata, acoperite cu o crustă bogată de fondant.", "MiniEclere.jpg", "MiniEclere", 40m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
