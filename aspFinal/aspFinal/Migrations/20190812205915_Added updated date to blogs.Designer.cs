﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspFinal.DAL;

namespace aspFinal.Migrations
{
    [DbContext(typeof(AspFinalDbContext))]
    [Migration("20190812205915_Added updated date to blogs")]
    partial class Addedupdateddatetoblogs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("aspFinal.Models.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId");

                    b.Property<int>("CityId");

                    b.Property<DateTime>("CurrentDate");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.HasIndex("CityId");

                    b.ToTable("Advertisements");

                    b.HasData(
                        new { Id = 1, CarId = 1, CityId = 1, CurrentDate = new DateTime(2019, 8, 13, 0, 59, 15, 408, DateTimeKind.Local), UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) },
                        new { Id = 2, CarId = 2, CityId = 1, CurrentDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) },
                        new { Id = 3, CarId = 3, CityId = 2, CurrentDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) },
                        new { Id = 4, CarId = 4, CityId = 3, CurrentDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) },
                        new { Id = 5, CarId = 5, CityId = 4, CurrentDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) },
                        new { Id = 6, CarId = 6, CityId = 5, CurrentDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) },
                        new { Id = 7, CarId = 7, CityId = 6, CurrentDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) },
                        new { Id = 8, CarId = 8, CityId = 3, CurrentDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("aspFinal.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Lastname")
                        .HasMaxLength(100);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("aspFinal.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Image");

                    b.Property<string>("ShortContent")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new { Id = 1, Content = "The British firm’s racing arm has been investigating a full-time IndyCar programme since backing double Formula 1 world champion Fernando Alonso’s entry in the 2017 Indianapolis 500 in a Honda-powered Andretti Autosport car. The Spaniard nearly won that event, and returned this year for a one-off drive in a standalone McLaren-run car with Chevrolet engines, but failed to qualify for the event.Under the new partnership, the existing Schmidt Peterson team will be renamed Arrow McLaren Racing SP, and will switch from the Honda engines it has used this year to Chevrolet units.McLaren said that the “infrastructure of Arrow SPM [will] underpin the team’s operations, while McLaren adds technical expertise, commercial experience and marketing strength”.There is no word yet on drivers for next season. IndyCar race winner James Hinchcliffe and ex-Formula 1 racer Marcus Ericsson currently drive for the team. Alonso has previously expressed interest in an expanded IndyCar programme, although it is not known if he would be interested in a full-time campaign.Team co-founders Sam Schmidt and Ric Peterson will continue in their current roles, with McLaren sporting director Gil de Ferran leading the McLaren involvement. A dedicated group from McLaren Racing will work on the programme.De Ferran, who won back-to-back driver’s titles in the CART World Series in 2000 and 2001, said: ““IndyCar is a natural fit for McLaren, given our legacy and determination to succeed at the top levels of international motorsport. Our ambition, over time, is to consistently compete for wins and championships.”", CreateDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), Image = "1mclarenindy.jpg", ShortContent = "Formula 1 outfit links up with Arrow Schmidt Peterson Motorsport to run a pair of Chevrolet-powered cars in 2020", Title = "McLaren secures partnership for full-time IndyCar entry", UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) },
                        new { Id = 2, Content = "The Affalterbach firm is developing two four-wheel-drive versions of the GLB, in both 35 4Matic and 45 4Matic trim. The 35 version, which will feature the same 302bhp 2.0-litre mild hybrid petrol engine found in the A35 hot hatch, is set to be revealed at Frankfurt, with sales starting later this year.The Mercedes-AMG GLB has previously been spied undergoing development work in both variants. It is differentiated from standard versions by its reduced ride height, larger brake discs, multi-pot calipers and four tailpipes, as opposed to the twin-exit arrangement of the less powerful GLB 35 4Matic prototypes we’ve seen previously.The GLB 45, due on sale next year to rival the Audi RS Q3, is among a number of new Mercedes-AMG models set to run a newly developed four-cylinder engine based on Mercedes’ turbocharged 2.0-litre 'M260' unit.Also due to appear in the A45 4Matic, CLA 45, CLA 45 Shooting Brake and GLA 45, the new powerplant is claimed to develop 382bhp in standard guise and 416bhp in a higher state of tune.In the GLB 45, the new engine will be mated to an eight-speed dual-clutch automatic gearbox and a new four-wheel drive system developed in a partnership between AMG and Austrian engineering specialist Magna Powertrain. It uses electrohydraulic actuation instead of the electromechanical operation of the four-wheel drive system by transverse engine models built by AMG up to now.Among the developments incorporated on the new four-wheel drive system is a rear differential featuring two separate clutches. They allow it to apportion up to 100% of power to each of the individual rear wheels in a so-called drift mode that AMG sources have revealed to Autocar will feature on all upcoming 45-badged models.The GLB 45 is set to crown the upcoming GLB line-up when it goes on sale in 2020. It will be positioned above the GLB 35, which runs a milder 302bhp turbocharged 2.0-litre four-cylinder petrol engine and is set to form part of the initial GLB line-up that's planned to be launched in early June.The GLB is the eighth member of Mercedes’ compact car line-up. In standard guise, it offers the choice of either five or seven seats. ", CreateDate = new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local), Image = "img_4980.jpg", ShortContent = "High-performance four-wheel-drive version of new compact SUV set to go on sale in 2020", Title = "Hot Mercedes-AMG GLB SUV set for Frankfurt reveal", UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local) },
                        new { Id = 3, Content = "The latest version of the Korean firm’s compact SUV, which joins the existing petrol, diesel and fully electric models, will be offered in three trim levels, all of which will use the same 1.6-litre petrol-electric powertrain.That unit, taken from Kia’s larger Niro, makes 104bhp on its own and is mated to a 43bhp electric motor also powering the front wheels. Both are linked through a six-speed dual-clutch automatic gearbox and a small (1.56kWh) lithium ion battery that recharges through coasting and braking. Total system output is 139bhp, with a combined torque figure of 195lb ft. That’s sufficient for a 0-62mph time of 11.2sec on the smallest wheel size, and a maximum speed of just under 100mph.The hybrid is considerably more frugal on paper than the normal petrol equivalents, managing a claimed 72mpg (66mpg on 18in wheels) and CO2 emissions of 90g/km (99g/km on 18in wheels). For comparison, Hyundai claims the base 1.0 T-GDI petrol engine manages 54.3mpg combined. Entry-level Kona Hybrid SE models feature climate control, 16in wheels with a design bespoke to the hybrid version, special badges and unique white accents on the air vents and gear level. There is a 7in touchscreen with Apple CarPlay and Android Auto connectivity, rear parking sensors and camera and lane-keeping assist.The mid-level Kona Hybrid Premium starts at £24,295, and additions include 18in wheels, a 10.25in touchscreen, Krell sound system, keyless entry, privacy glass and wireless smartphone charging.The top Premium SE trim level is priced from £27,195 and includes the likes of LED front and rear lights, standard autonomous emergency braking, heated and ventilated leather seats and a head-up display.All three trim levels are available with different versions of Hyundai’s SmartSense safety packs as options.The £22,495 starting price for the Kona Hybrid compares to £17,305 for the petrol, and £27,250 for the electric version.", CreateDate = new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local), Image = "1734339_all-new_kona_hybrid_1.jpg", ShortContent = "Petrol-electric crossover will be capable of 75mpg, and available to buy in September", Title = "New Hyundai Kona Hybrid to start from £22,495", UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local) },
                        new { Id = 4, Content = "It’s the latest of a number of test mules seen in the last few days, including a new 3 Series-based B3 and the brand’s take on the new X7 SUV. While the former was expected, the two new models will take Alpina’s range of BMW-derived models to eight.As with the B3 and XB7, this 8 Series test car wears the tell-tale addenda of an Alpina model. These include bespoke bumper designs, the trademark multi-spoke wheel design and unique badging. It’s likely, although not yet confirmed, that the same treatment will be applied to the two-door coupé and cabriolet 8 Series models in due course.Likely to be called the B8, the new Alpina four-door will make use of the M850i’s twin-turbocharged 4.4-litre petrol V8 rather than the full-fat M8's version. However, it will be tuned to a power output of 600bhp, as is traditional. Using the identically powered B5 for comparison, that would translate to a 0-62mph time of well below four seconds and a top speed breaking the 200mph barrier (Alpina doesn’t use electronic speed limiters).We can also expect Alpina’s highly acclaimed chassis engineers to work their magic on the 8 Series, giving it a unique suspension tune that prioritises comfort just as much as handling. The interior, too, will receive upholstery upgrades as part of the usual makeover.No details of the B8's launch have been released yet, but given the M8 is due to go on sale in the next couple of months, we expect a debut in the first half of 2020 at the latest. ", CreateDate = new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local), Image = "img_6434.jpg", ShortContent = "Alpina’s flurry of new model launches looks set to continue, with prototypes of its version of the new BMW 8 Series Gran Coupé having emerged.", Title = "Alpina version of BMW 8 Series Gran Coupe seen testing", UpdatedDate = new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("aspFinal.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new { Id = 1, Name = "BMW" },
                        new { Id = 2, Name = "Mercedes" },
                        new { Id = 3, Name = "Toyota" },
                        new { Id = 4, Name = "Lada" }
                    );
                });

            modelBuilder.Entity("aspFinal.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<int>("FuelTypeId");

                    b.Property<string>("Image")
                        .HasMaxLength(200);

                    b.Property<bool>("IsVip");

                    b.Property<int>("MakeId");

                    b.Property<int>("ManufactureYear");

                    b.Property<int>("Millage");

                    b.Property<decimal>("Motor");

                    b.Property<decimal>("Price");

                    b.Property<int>("TransmissionId");

                    b.HasKey("Id");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("MakeId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Cars");

                    b.HasData(
                        new { Id = 1, Color = "Black", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", FuelTypeId = 1, Image = "car-1.jpg", IsVip = true, MakeId = 4, ManufactureYear = 2006, Millage = 0, Motor = 1.8m, Price = 12000m, TransmissionId = 1 },
                        new { Id = 2, Color = "White", Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", FuelTypeId = 1, Image = "car-2.jpg", IsVip = true, MakeId = 7, ManufactureYear = 2000, Millage = 146000, Motor = 2m, Price = 10000m, TransmissionId = 2 },
                        new { Id = 3, Color = "Black", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", FuelTypeId = 1, Image = "car-3.jpg", IsVip = true, MakeId = 9, ManufactureYear = 2009, Millage = 0, Motor = 1.8m, Price = 17000m, TransmissionId = 1 },
                        new { Id = 4, Color = "White", Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", FuelTypeId = 1, Image = "car-4.jpg", IsVip = true, MakeId = 6, ManufactureYear = 2003, Millage = 146000, Motor = 2m, Price = 14000m, TransmissionId = 2 },
                        new { Id = 5, Color = "Black", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", FuelTypeId = 1, Image = "car-5.jpg", IsVip = true, MakeId = 11, ManufactureYear = 1998, Millage = 250000, Motor = 1.8m, Price = 9000m, TransmissionId = 1 },
                        new { Id = 6, Color = "White", Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", FuelTypeId = 1, Image = "car-6.jpg", IsVip = true, MakeId = 2, ManufactureYear = 2019, Millage = 0, Motor = 2m, Price = 100000m, TransmissionId = 2 },
                        new { Id = 7, Color = "Black", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", FuelTypeId = 1, Image = "car-7.jpg", IsVip = true, MakeId = 7, ManufactureYear = 2004, Millage = 154456, Motor = 1.8m, Price = 17000m, TransmissionId = 1 },
                        new { Id = 8, Color = "White", Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", FuelTypeId = 1, Image = "car-1.jpg", IsVip = true, MakeId = 6, ManufactureYear = 2003, Millage = 146000, Motor = 2m, Price = 14000m, TransmissionId = 2 }
                    );
                });

            modelBuilder.Entity("aspFinal.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new { Id = 1, CountryId = 1, Name = "Baku" },
                        new { Id = 2, CountryId = 1, Name = "Sumgayit" },
                        new { Id = 3, CountryId = 1, Name = "Barda" },
                        new { Id = 4, CountryId = 2, Name = "Istanbul" },
                        new { Id = 5, CountryId = 2, Name = "Ankara" },
                        new { Id = 6, CountryId = 3, Name = "Moscow" }
                    );
                });

            modelBuilder.Entity("aspFinal.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new { Id = 1, Name = "Azerbaijan" },
                        new { Id = 2, Name = "Turkey" },
                        new { Id = 3, Name = "Russia" }
                    );
                });

            modelBuilder.Entity("aspFinal.Models.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");

                    b.HasData(
                        new { Id = 1, Type = "Benzin" },
                        new { Id = 2, Type = "Electric" },
                        new { Id = 3, Type = "Diesel" },
                        new { Id = 4, Type = "Hibrid" }
                    );
                });

            modelBuilder.Entity("aspFinal.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Makes");

                    b.HasData(
                        new { Id = 1, BrandId = 1, Name = "M3" },
                        new { Id = 2, BrandId = 1, Name = "M5" },
                        new { Id = 3, BrandId = 1, Name = "M7" },
                        new { Id = 4, BrandId = 3, Name = "Corolla" },
                        new { Id = 5, BrandId = 3, Name = "Camry" },
                        new { Id = 6, BrandId = 2, Name = "E220" },
                        new { Id = 7, BrandId = 2, Name = "C180" },
                        new { Id = 8, BrandId = 2, Name = "S600" },
                        new { Id = 9, BrandId = 2, Name = "A200" },
                        new { Id = 10, BrandId = 4, Name = "Priora" },
                        new { Id = 11, BrandId = 4, Name = "Granta" }
                    );
                });

            modelBuilder.Entity("aspFinal.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new { Id = 1, Image = "car-1_1.jpg" },
                        new { Id = 2, Image = "car-2_1.jpg" },
                        new { Id = 3, Image = "car-3_1.jpg" }
                    );
                });

            modelBuilder.Entity("aspFinal.Models.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Transmissions");

                    b.HasData(
                        new { Id = 1, Name = "Manual" },
                        new { Id = 2, Name = "Automatic" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("aspFinal.Models.Advertisement", b =>
                {
                    b.HasOne("aspFinal.Models.Car", "Car")
                        .WithOne("Advertisement")
                        .HasForeignKey("aspFinal.Models.Advertisement", "CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("aspFinal.Models.City", "City")
                        .WithMany("Advertisements")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("aspFinal.Models.Car", b =>
                {
                    b.HasOne("aspFinal.Models.FuelType", "FuelType")
                        .WithMany("Cars")
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("aspFinal.Models.Make", "Make")
                        .WithMany("Cars")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("aspFinal.Models.Transmission", "Transmission")
                        .WithMany("Cars")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("aspFinal.Models.City", b =>
                {
                    b.HasOne("aspFinal.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("aspFinal.Models.Make", b =>
                {
                    b.HasOne("aspFinal.Models.Brand", "Brand")
                        .WithMany("Makes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("aspFinal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("aspFinal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("aspFinal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("aspFinal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
