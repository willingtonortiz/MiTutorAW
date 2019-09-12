using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MiTutor.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Availability",
                columns: table => new
                {
                    AvailabilityId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availability", x => x.AvailabilityId);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    UniversityId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.UniversityId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AvailabilityDay",
                columns: table => new
                {
                    AvailabilityDayId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Day = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    AvailabilityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailabilityDay", x => x.AvailabilityDayId);
                    table.ForeignKey(
                        name: "FK_AvailabilityDay_Availability_AvailabilityId",
                        column: x => x.AvailabilityId,
                        principalTable: "Availability",
                        principalColumn: "AvailabilityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Semester = table.Column<int>(nullable: false),
                    UniversityId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Points = table.Column<int>(nullable: true),
                    TutoringSessionTutoringId = table.Column<int>(nullable: true),
                    Tutor_Points = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AvailabilityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_User_PersonId",
                        column: x => x.PersonId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "University",
                        principalColumn: "UniversityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Availability_AvailabilityId",
                        column: x => x.AvailabilityId,
                        principalTable: "Availability",
                        principalColumn: "AvailabilityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    StudentPersonId = table.Column<int>(nullable: true),
                    TutorPersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subject_Person_StudentPersonId",
                        column: x => x.StudentPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subject_Person_TutorPersonId",
                        column: x => x.TutorPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tutoring",
                columns: table => new
                {
                    TutoringId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Place = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TutorPersonId = table.Column<int>(nullable: true),
                    TutoringSession_TutorPersonId = table.Column<int>(nullable: true),
                    TutoringOfferTutoringId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutoring", x => x.TutoringId);
                    table.ForeignKey(
                        name: "FK_Tutoring_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tutoring_Person_TutorPersonId",
                        column: x => x.TutorPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tutoring_Person_TutoringSession_TutorPersonId",
                        column: x => x.TutoringSession_TutorPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tutoring_Tutoring_TutoringOfferTutoringId",
                        column: x => x.TutoringOfferTutoringId,
                        principalTable: "Tutoring",
                        principalColumn: "TutoringId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    QualificationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AdresserPersonId = table.Column<int>(nullable: true),
                    AdresseePersonId = table.Column<int>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    StudentPersonId = table.Column<int>(nullable: true),
                    TutorPersonId = table.Column<int>(nullable: true),
                    TutoringSessionTutoringId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.QualificationId);
                    table.ForeignKey(
                        name: "FK_Qualification_Person_AdresseePersonId",
                        column: x => x.AdresseePersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Qualification_Person_AdresserPersonId",
                        column: x => x.AdresserPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Qualification_Person_StudentPersonId",
                        column: x => x.StudentPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Qualification_Person_TutorPersonId",
                        column: x => x.TutorPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Qualification_Tutoring_TutoringSessionTutoringId",
                        column: x => x.TutoringSessionTutoringId,
                        principalTable: "Tutoring",
                        principalColumn: "TutoringId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    TopicId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    SubjectId = table.Column<int>(nullable: true),
                    TutoringId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.TopicId);
                    table.ForeignKey(
                        name: "FK_Topic_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Topic_Tutoring_TutoringId",
                        column: x => x.TutoringId,
                        principalTable: "Tutoring",
                        principalColumn: "TutoringId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilityDay_AvailabilityId",
                table: "AvailabilityDay",
                column: "AvailabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_UniversityId",
                table: "Person",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TutoringSessionTutoringId",
                table: "Person",
                column: "TutoringSessionTutoringId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_AvailabilityId",
                table: "Person",
                column: "AvailabilityId");

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
                name: "IX_Subject_StudentPersonId",
                table: "Subject",
                column: "StudentPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_TutorPersonId",
                table: "Subject",
                column: "TutorPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_SubjectId",
                table: "Topic",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_TutoringId",
                table: "Topic",
                column: "TutoringId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutoring_SubjectId",
                table: "Tutoring",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutoring_TutorPersonId",
                table: "Tutoring",
                column: "TutorPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutoring_TutoringSession_TutorPersonId",
                table: "Tutoring",
                column: "TutoringSession_TutorPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutoring_TutoringOfferTutoringId",
                table: "Tutoring",
                column: "TutoringOfferTutoringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Tutoring_TutoringSessionTutoringId",
                table: "Person",
                column: "TutoringSessionTutoringId",
                principalTable: "Tutoring",
                principalColumn: "TutoringId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Availability_AvailabilityId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_PersonId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_University_UniversityId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Tutoring_TutoringSessionTutoringId",
                table: "Person");

            migrationBuilder.DropTable(
                name: "AvailabilityDay");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "Topic");

            migrationBuilder.DropTable(
                name: "Availability");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "University");

            migrationBuilder.DropTable(
                name: "Tutoring");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
