﻿// <auto-generated />
using System;
using GymTracker.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GymTracker.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GymTracker.Domain.Entities.DefaultExercise", b =>
                {
                    b.Property<Guid>("DefaultExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("default_exercise_id");

                    b.Property<Guid>("DefaultWorkoutId")
                        .HasColumnType("uuid")
                        .HasColumnName("default_workout_id");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uuid")
                        .HasColumnName("exercise_id");

                    b.Property<string>("RepetitionsRange")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("repetitions_range");

                    b.Property<short>("SeriesAmount")
                        .HasColumnType("smallint")
                        .HasColumnName("series_amount");

                    b.HasKey("DefaultExerciseId");

                    b.HasIndex("DefaultWorkoutId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("default_exercises");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.DefaultWorkout", b =>
                {
                    b.Property<Guid>("DefaultWorkoutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("default_workout_id");

                    b.Property<string>("DefaultWorkoutName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("workout_name");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("DefaultWorkoutId");

                    b.HasIndex("DefaultWorkoutName")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("default_workouts");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.DiaryExercise", b =>
                {
                    b.Property<Guid>("DiaryExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("diary_exercise_id");

                    b.Property<Guid>("DefaultExerciseId")
                        .HasColumnType("uuid")
                        .HasColumnName("default_exercise_id");

                    b.Property<Guid>("DiaryWorkoutId")
                        .HasColumnType("uuid")
                        .HasColumnName("diary_workout_id");

                    b.HasKey("DiaryExerciseId");

                    b.HasIndex("DefaultExerciseId");

                    b.HasIndex("DiaryWorkoutId");

                    b.ToTable("diary_exercises");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.DiaryExerciseSerie", b =>
                {
                    b.Property<Guid>("DiaryExerciseSerieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("diary_exercise_serie_id");

                    b.Property<Guid>("DiaryExerciseId")
                        .HasColumnType("uuid")
                        .HasColumnName("diary_exercise_id");

                    b.Property<short>("Overload")
                        .HasColumnType("smallint")
                        .HasColumnName("overload");

                    b.Property<short>("Repetitions")
                        .HasColumnType("smallint")
                        .HasColumnName("repetitions");

                    b.Property<short>("SerieNumber")
                        .HasColumnType("smallint")
                        .HasColumnName("serie_number");

                    b.HasKey("DiaryExerciseSerieId");

                    b.HasIndex("DiaryExerciseId");

                    b.ToTable("diary_exercise_series");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.DiaryWorkout", b =>
                {
                    b.Property<Guid>("DiaryWorkoutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("diary_workout_id");

                    b.Property<Guid>("DefaultWorkoutId")
                        .HasColumnType("uuid")
                        .HasColumnName("default_workout_id");

                    b.Property<DateTime?>("WorkoutDate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("workout_date");

                    b.HasKey("DiaryWorkoutId");

                    b.HasIndex("DefaultWorkoutId");

                    b.ToTable("diary_workouts");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.Exercise", b =>
                {
                    b.Property<Guid>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("exercise_id");

                    b.Property<string>("ExerciseGif")
                        .HasColumnType("text")
                        .HasColumnName("exercise_gif");

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("exercise_name");

                    b.HasKey("ExerciseId");

                    b.HasIndex("ExerciseName")
                        .IsUnique();

                    b.ToTable("exercises");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.ExerciseMuscleGroup", b =>
                {
                    b.Property<Guid>("ExerciseMuscleGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("exercise_muscle_group_id");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uuid")
                        .HasColumnName("exercise_id");

                    b.Property<Guid>("MuscleGroupId")
                        .HasColumnType("uuid")
                        .HasColumnName("muscle_group_id");

                    b.HasKey("ExerciseMuscleGroupId");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("exercise_muscle_group");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.MuscleGroup", b =>
                {
                    b.Property<Guid>("MucleGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("muscle_group_id");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("group_name");

                    b.Property<string>("MuscleImage")
                        .HasColumnType("text")
                        .HasColumnName("muscle_image");

                    b.HasKey("MucleGroupId");

                    b.HasIndex("GroupName")
                        .IsUnique();

                    b.ToTable("muscle_groups");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.ProfileHistory", b =>
                {
                    b.Property<Guid>("ProfileHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("profile_history_id");

                    b.Property<float?>("AbdominalGirth")
                        .HasColumnType("decimal(4, 1)")
                        .HasColumnName("abdominal_girth");

                    b.Property<float?>("ArmGirth")
                        .HasColumnType("decimal(4, 1)")
                        .HasColumnName("arm_girth");

                    b.Property<float?>("BodyFat")
                        .HasColumnType("decimal(4, 3)")
                        .HasColumnName("body_fat");

                    b.Property<string>("EvolutionPhoto")
                        .HasColumnType("text")
                        .HasColumnName("evolution_photo");

                    b.Property<short>("Height")
                        .HasColumnType("smallint")
                        .HasColumnName("height");

                    b.Property<float?>("HipGirth")
                        .HasColumnType("decimal(4, 1)")
                        .HasColumnName("hip_girth");

                    b.Property<float?>("LegGirth")
                        .HasColumnType("decimal(4, 1)")
                        .HasColumnName("leg_girth");

                    b.Property<DateTime>("ProfileDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<float?>("ScapularGirth")
                        .HasColumnType("decimal(4, 1)")
                        .HasColumnName("scapular_girth");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<float>("Weight")
                        .HasColumnType("real")
                        .HasColumnName("weight");

                    b.HasKey("ProfileHistoryId");

                    b.HasIndex("UserId");

                    b.ToTable("profile_histories");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<short>("BirthYear")
                        .HasColumnType("smallint")
                        .HasColumnName("birth_year");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<char>("Gender")
                        .HasColumnType("char(1)")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("password_hash");

                    b.Property<string>("PasswordRecoverCode")
                        .HasColumnType("char(5)")
                        .HasColumnName("password_recover_code");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("password_salt");

                    b.Property<string>("ProfilePhoto")
                        .HasColumnType("text")
                        .HasColumnName("profile_photo");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.DefaultExercise", b =>
                {
                    b.HasOne("GymTracker.Domain.Entities.DefaultWorkout", "DefaultWorkout")
                        .WithMany()
                        .HasForeignKey("DefaultWorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTracker.Domain.Entities.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DefaultWorkout");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.DefaultWorkout", b =>
                {
                    b.HasOne("GymTracker.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.DiaryExercise", b =>
                {
                    b.HasOne("GymTracker.Domain.Entities.DefaultExercise", "DefaultExercise")
                        .WithMany()
                        .HasForeignKey("DefaultExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTracker.Domain.Entities.DiaryWorkout", "DiaryWorkout")
                        .WithMany()
                        .HasForeignKey("DiaryWorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DefaultExercise");

                    b.Navigation("DiaryWorkout");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.DiaryExerciseSerie", b =>
                {
                    b.HasOne("GymTracker.Domain.Entities.DefaultExercise", "DefaultExercise")
                        .WithMany()
                        .HasForeignKey("DiaryExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DefaultExercise");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.DiaryWorkout", b =>
                {
                    b.HasOne("GymTracker.Domain.Entities.DefaultWorkout", "DefaultWorkout")
                        .WithMany()
                        .HasForeignKey("DefaultWorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DefaultWorkout");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.ExerciseMuscleGroup", b =>
                {
                    b.HasOne("GymTracker.Domain.Entities.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTracker.Domain.Entities.MuscleGroup", "MuscleGroup")
                        .WithMany()
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("MuscleGroup");
                });

            modelBuilder.Entity("GymTracker.Domain.Entities.ProfileHistory", b =>
                {
                    b.HasOne("GymTracker.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
