﻿// <auto-generated />
using System;
using Entity_DAL.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210520235055_updateTickets")]
    partial class updateTickets
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Entities.A_T_Managment", b =>
                {
                    b.Property<int>("agentId")
                        .HasColumnType("int");

                    b.Property<int>("ticketId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateAssign")
                        .HasColumnType("datetime2");

                    b.HasKey("agentId", "ticketId");

                    b.HasIndex("ticketId");

                    b.ToTable("A_T_Managments");
                });

            modelBuilder.Entity("Entities.Entities.DefaultPermissions", b =>
                {
                    b.Property<int>("permissionId")
                        .HasColumnType("int");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.HasKey("permissionId", "roleId");

                    b.HasIndex("roleId");

                    b.ToTable("DefaultPermissions");
                });

            modelBuilder.Entity("Entities.Entities.Permission", b =>
                {
                    b.Property<int>("permissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("permissionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("permissionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("permissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Entities.Entities.Product", b =>
                {
                    b.Property<string>("refId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("addedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateBuild")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateValidate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("factoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("refId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.Entities.ProductClient", b =>
                {
                    b.Property<int>("clientId")
                        .HasColumnType("int");

                    b.Property<string>("refId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("clientId", "refId");

                    b.HasIndex("refId");

                    b.ToTable("ProductClients");
                });

            modelBuilder.Entity("Entities.Entities.Role", b =>
                {
                    b.Property<int>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("roleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Entities.Entities.Ticket", b =>
                {
                    b.Property<int>("ticketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("relatedProductRefId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ticketDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ticketDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ticketPriority")
                        .HasColumnType("int");

                    b.Property<int>("ticketStatut")
                        .HasColumnType("int");

                    b.Property<string>("ticketTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ticketType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("ticketId");

                    b.HasIndex("relatedProductRefId");

                    b.HasIndex("userId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Entities.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAdresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("roleId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Entities.Entities.UserPermission", b =>
                {
                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("permisionId")
                        .HasColumnType("int");

                    b.HasKey("userId", "permisionId");

                    b.HasIndex("permisionId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("Entities.Entities.Agent", b =>
                {
                    b.HasBaseType("Entities.Entities.User");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Agent");
                });

            modelBuilder.Entity("Entities.Entities.Client", b =>
                {
                    b.HasBaseType("Entities.Entities.User");

                    b.Property<int>("priority")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Entities.Entities.A_T_Managment", b =>
                {
                    b.HasOne("Entities.Entities.Agent", "agent")
                        .WithMany("a_T_ManagmentsList")
                        .HasForeignKey("agentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entities.Ticket", "ticket")
                        .WithMany("listAT_Management")
                        .HasForeignKey("ticketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("agent");

                    b.Navigation("ticket");
                });

            modelBuilder.Entity("Entities.Entities.DefaultPermissions", b =>
                {
                    b.HasOne("Entities.Entities.Permission", "permission")
                        .WithMany("listDefaultPermissions")
                        .HasForeignKey("permissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entities.Role", "role")
                        .WithMany("listDefaultPermissions")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("permission");

                    b.Navigation("role");
                });

            modelBuilder.Entity("Entities.Entities.ProductClient", b =>
                {
                    b.HasOne("Entities.Entities.Client", "client")
                        .WithMany("myListProducts")
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entities.Product", "product")
                        .WithMany("ListProductClient")
                        .HasForeignKey("refId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");

                    b.Navigation("product");
                });

            modelBuilder.Entity("Entities.Entities.Ticket", b =>
                {
                    b.HasOne("Entities.Entities.Product", "relatedProduct")
                        .WithMany()
                        .HasForeignKey("relatedProductRefId");

                    b.HasOne("Entities.Entities.User", "creator_user")
                        .WithMany("listTickets")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("creator_user");

                    b.Navigation("relatedProduct");
                });

            modelBuilder.Entity("Entities.Entities.User", b =>
                {
                    b.HasOne("Entities.Entities.Role", "role")
                        .WithMany("listUser")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("Entities.Entities.UserPermission", b =>
                {
                    b.HasOne("Entities.Entities.Permission", "permision")
                        .WithMany("listUserPermissions")
                        .HasForeignKey("permisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entities.User", "user")
                        .WithMany("listUserPermissions")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("permision");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Entities.Entities.Permission", b =>
                {
                    b.Navigation("listDefaultPermissions");

                    b.Navigation("listUserPermissions");
                });

            modelBuilder.Entity("Entities.Entities.Product", b =>
                {
                    b.Navigation("ListProductClient");
                });

            modelBuilder.Entity("Entities.Entities.Role", b =>
                {
                    b.Navigation("listDefaultPermissions");

                    b.Navigation("listUser");
                });

            modelBuilder.Entity("Entities.Entities.Ticket", b =>
                {
                    b.Navigation("listAT_Management");
                });

            modelBuilder.Entity("Entities.Entities.User", b =>
                {
                    b.Navigation("listTickets");

                    b.Navigation("listUserPermissions");
                });

            modelBuilder.Entity("Entities.Entities.Agent", b =>
                {
                    b.Navigation("a_T_ManagmentsList");
                });

            modelBuilder.Entity("Entities.Entities.Client", b =>
                {
                    b.Navigation("myListProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
