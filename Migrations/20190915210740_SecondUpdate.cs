using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MiTutor.Migrations
{
    public partial class SecondUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilityDay_Availability_AvailabilityId",
                table: "AvailabilityDay");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_PersonId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_University_UniversityId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Tutoring_TutoringSessionTutoringId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Availability_AvailabilityId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_Person_AdresseePersonId",
                table: "Qualification");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_Person_AdresserPersonId",
                table: "Qualification");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_Person_StudentPersonId",
                table: "Qualification");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_Person_TutorPersonId",
                table: "Qualification");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_Tutoring_TutoringSessionTutoringId",
                table: "Qualification");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Person_StudentPersonId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Person_TutorPersonId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Subject_SubjectId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Tutoring_TutoringId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutoring_Subject_SubjectId",
                table: "Tutoring");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutoring_Person_TutorPersonId",
                table: "Tutoring");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutoring_Person_TutoringSession_TutorPersonId",
                table: "Tutoring");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutoring_Tutoring_TutoringOfferTutoringId",
                table: "Tutoring");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_AdresseePersonId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_AdresserPersonId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_StudentPersonId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_TutorPersonId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_TutoringSessionTutoringId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Person_TutoringSessionTutoringId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_AvailabilityId",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutoring",
                table: "Tutoring");

            migrationBuilder.DropIndex(
                name: "IX_Tutoring_TutorPersonId",
                table: "Tutoring");

            migrationBuilder.DropIndex(
                name: "IX_Tutoring_TutoringSession_TutorPersonId",
                table: "Tutoring");

            migrationBuilder.DropColumn(
                name: "AdresseePersonId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "AdresserPersonId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "StudentPersonId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "TutorPersonId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "TutoringSessionTutoringId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TutoringSessionTutoringId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "AvailabilityId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Tutor_Points",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TutorPersonId",
                table: "Tutoring");

            migrationBuilder.DropColumn(
                name: "TutoringSession_TutorPersonId",
                table: "Tutoring");

            migrationBuilder.RenameTable(
                name: "Tutoring",
                newName: "TutoringOffer");

            migrationBuilder.RenameColumn(
                name: "TutoringId",
                table: "Topic",
                newName: "TutoringOfferTutoringId");

            migrationBuilder.RenameIndex(
                name: "IX_Topic_TutoringId",
                table: "Topic",
                newName: "IX_Topic_TutoringOfferTutoringId");

            migrationBuilder.RenameColumn(
                name: "TutorPersonId",
                table: "Subject",
                newName: "TutorId");

            migrationBuilder.RenameColumn(
                name: "StudentPersonId",
                table: "Subject",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_TutorPersonId",
                table: "Subject",
                newName: "IX_Subject_TutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_StudentPersonId",
                table: "Subject",
                newName: "IX_Subject_StudentId");

            migrationBuilder.RenameColumn(
                name: "TutoringOfferTutoringId",
                table: "TutoringOffer",
                newName: "TutorId1");

            migrationBuilder.RenameIndex(
                name: "IX_Tutoring_TutoringOfferTutoringId",
                table: "TutoringOffer",
                newName: "IX_TutoringOffer_TutorId1");

            migrationBuilder.RenameIndex(
                name: "IX_Tutoring_SubjectId",
                table: "TutoringOffer",
                newName: "IX_TutoringOffer_SubjectId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "User",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Topic",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdresseeId",
                table: "Qualification",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdresserId",
                table: "Qualification",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdresserRole",
                table: "Qualification",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TutoringSessionId",
                table: "Qualification",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UniversityId",
                table: "Person",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Person",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "AvailabilityId",
                table: "AvailabilityDay",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TutorId",
                table: "Availability",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TutorId",
                table: "TutoringOffer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TutoringOffer",
                table: "TutoringOffer",
                column: "TutoringId");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    TutoringSessionTutoringId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Person_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_TutoringOffer_TutoringSessionTutoringId",
                        column: x => x.TutoringSessionTutoringId,
                        principalTable: "TutoringOffer",
                        principalColumn: "TutoringId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    TutorId = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.TutorId);
                    table.ForeignKey(
                        name: "FK_Tutor_Person_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_AdresseeId",
                table: "Qualification",
                column: "AdresseeId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_AdresserId",
                table: "Qualification",
                column: "AdresserId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_TutoringSessionId",
                table: "Qualification",
                column: "TutoringSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Availability_TutorId",
                table: "Availability",
                column: "TutorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TutoringOffer_TutorId",
                table: "TutoringOffer",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_TutoringSessionTutoringId",
                table: "Student",
                column: "TutoringSessionTutoringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Availability_Tutor_TutorId",
                table: "Availability",
                column: "TutorId",
                principalTable: "Tutor",
                principalColumn: "TutorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilityDay_Availability_AvailabilityId",
                table: "AvailabilityDay",
                column: "AvailabilityId",
                principalTable: "Availability",
                principalColumn: "AvailabilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_University_UniversityId",
                table: "Person",
                column: "UniversityId",
                principalTable: "University",
                principalColumn: "UniversityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_Person_AdresseeId",
                table: "Qualification",
                column: "AdresseeId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_Person_AdresserId",
                table: "Qualification",
                column: "AdresserId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_TutoringOffer_TutoringSessionId",
                table: "Qualification",
                column: "TutoringSessionId",
                principalTable: "TutoringOffer",
                principalColumn: "TutoringId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Student_StudentId",
                table: "Subject",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Tutor_TutorId",
                table: "Subject",
                column: "TutorId",
                principalTable: "Tutor",
                principalColumn: "TutorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Subject_SubjectId",
                table: "Topic",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_TutoringOffer_TutoringOfferTutoringId",
                table: "Topic",
                column: "TutoringOfferTutoringId",
                principalTable: "TutoringOffer",
                principalColumn: "TutoringId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TutoringOffer_Subject_SubjectId",
                table: "TutoringOffer",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TutoringOffer_Tutor_TutorId",
                table: "TutoringOffer",
                column: "TutorId",
                principalTable: "Tutor",
                principalColumn: "TutorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TutoringOffer_Tutor_TutorId1",
                table: "TutoringOffer",
                column: "TutorId1",
                principalTable: "Tutor",
                principalColumn: "TutorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Person_UserId",
                table: "User",
                column: "UserId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Availability_Tutor_TutorId",
                table: "Availability");

            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilityDay_Availability_AvailabilityId",
                table: "AvailabilityDay");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_University_UniversityId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_Person_AdresseeId",
                table: "Qualification");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_Person_AdresserId",
                table: "Qualification");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_TutoringOffer_TutoringSessionId",
                table: "Qualification");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Student_StudentId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Tutor_TutorId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Subject_SubjectId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_TutoringOffer_TutoringOfferTutoringId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_TutoringOffer_Subject_SubjectId",
                table: "TutoringOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_TutoringOffer_Tutor_TutorId",
                table: "TutoringOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_TutoringOffer_Tutor_TutorId1",
                table: "TutoringOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Person_UserId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_AdresseeId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_AdresserId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_TutoringSessionId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Availability_TutorId",
                table: "Availability");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TutoringOffer",
                table: "TutoringOffer");

            migrationBuilder.DropIndex(
                name: "IX_TutoringOffer_TutorId",
                table: "TutoringOffer");

            migrationBuilder.DropColumn(
                name: "AdresseeId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "AdresserId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "AdresserRole",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "TutoringSessionId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Availability");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "TutoringOffer");

            migrationBuilder.RenameTable(
                name: "TutoringOffer",
                newName: "Tutoring");

            migrationBuilder.RenameColumn(
                name: "TutoringOfferTutoringId",
                table: "Topic",
                newName: "TutoringId");

            migrationBuilder.RenameIndex(
                name: "IX_Topic_TutoringOfferTutoringId",
                table: "Topic",
                newName: "IX_Topic_TutoringId");

            migrationBuilder.RenameColumn(
                name: "TutorId",
                table: "Subject",
                newName: "TutorPersonId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Subject",
                newName: "StudentPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_TutorId",
                table: "Subject",
                newName: "IX_Subject_TutorPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_StudentId",
                table: "Subject",
                newName: "IX_Subject_StudentPersonId");

            migrationBuilder.RenameColumn(
                name: "TutorId1",
                table: "Tutoring",
                newName: "TutoringOfferTutoringId");

            migrationBuilder.RenameIndex(
                name: "IX_TutoringOffer_TutorId1",
                table: "Tutoring",
                newName: "IX_Tutoring_TutoringOfferTutoringId");

            migrationBuilder.RenameIndex(
                name: "IX_TutoringOffer_SubjectId",
                table: "Tutoring",
                newName: "IX_Tutoring_SubjectId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "User",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Topic",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AdresseePersonId",
                table: "Qualification",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdresserPersonId",
                table: "Qualification",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentPersonId",
                table: "Qualification",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TutorPersonId",
                table: "Qualification",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TutoringSessionTutoringId",
                table: "Qualification",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UniversityId",
                table: "Person",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Person",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TutoringSessionTutoringId",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AvailabilityId",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tutor_Points",
                table: "Person",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AvailabilityId",
                table: "AvailabilityDay",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TutorPersonId",
                table: "Tutoring",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TutoringSession_TutorPersonId",
                table: "Tutoring",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutoring",
                table: "Tutoring",
                column: "TutoringId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_AdresseePersonId",
                table: "Qualification",
                column: "AdresseePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_AdresserPersonId",
                table: "Qualification",
                column: "AdresserPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_StudentPersonId",
                table: "Qualification",
                column: "StudentPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_TutorPersonId",
                table: "Qualification",
                column: "TutorPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_TutoringSessionTutoringId",
                table: "Qualification",
                column: "TutoringSessionTutoringId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TutoringSessionTutoringId",
                table: "Person",
                column: "TutoringSessionTutoringId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_AvailabilityId",
                table: "Person",
                column: "AvailabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutoring_TutorPersonId",
                table: "Tutoring",
                column: "TutorPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutoring_TutoringSession_TutorPersonId",
                table: "Tutoring",
                column: "TutoringSession_TutorPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilityDay_Availability_AvailabilityId",
                table: "AvailabilityDay",
                column: "AvailabilityId",
                principalTable: "Availability",
                principalColumn: "AvailabilityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_User_PersonId",
                table: "Person",
                column: "PersonId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_University_UniversityId",
                table: "Person",
                column: "UniversityId",
                principalTable: "University",
                principalColumn: "UniversityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Tutoring_TutoringSessionTutoringId",
                table: "Person",
                column: "TutoringSessionTutoringId",
                principalTable: "Tutoring",
                principalColumn: "TutoringId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Availability_AvailabilityId",
                table: "Person",
                column: "AvailabilityId",
                principalTable: "Availability",
                principalColumn: "AvailabilityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_Person_AdresseePersonId",
                table: "Qualification",
                column: "AdresseePersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_Person_AdresserPersonId",
                table: "Qualification",
                column: "AdresserPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_Person_StudentPersonId",
                table: "Qualification",
                column: "StudentPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_Person_TutorPersonId",
                table: "Qualification",
                column: "TutorPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_Tutoring_TutoringSessionTutoringId",
                table: "Qualification",
                column: "TutoringSessionTutoringId",
                principalTable: "Tutoring",
                principalColumn: "TutoringId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Person_StudentPersonId",
                table: "Subject",
                column: "StudentPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Person_TutorPersonId",
                table: "Subject",
                column: "TutorPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Subject_SubjectId",
                table: "Topic",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Tutoring_TutoringId",
                table: "Topic",
                column: "TutoringId",
                principalTable: "Tutoring",
                principalColumn: "TutoringId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutoring_Subject_SubjectId",
                table: "Tutoring",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutoring_Person_TutorPersonId",
                table: "Tutoring",
                column: "TutorPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutoring_Person_TutoringSession_TutorPersonId",
                table: "Tutoring",
                column: "TutoringSession_TutorPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutoring_Tutoring_TutoringOfferTutoringId",
                table: "Tutoring",
                column: "TutoringOfferTutoringId",
                principalTable: "Tutoring",
                principalColumn: "TutoringId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
