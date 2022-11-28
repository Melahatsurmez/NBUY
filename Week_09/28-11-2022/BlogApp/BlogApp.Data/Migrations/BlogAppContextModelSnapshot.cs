﻿// <auto-generated />
using System;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogApp.Data.Migrations
{
    [DbContext(typeof(BlogAppContext))]
    partial class BlogAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogApp.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(6191),
                            Date = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(6188),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(6193),
                            Note = "C# 11.0 Yenilikleri",
                            SeoAuthor = "Deniz Gezen",
                            SeoDescription = "C# 11.0 Yenilikleri",
                            SeoTags = "C#,C# 11.0, DotNet 6, DotNet 7, DotNet Core",
                            Thumbnail = "deafult.jpg",
                            Title = "C# 11.0 Yenilikleri",
                            UserId = 1,
                            ViewsCount = 116
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(6204),
                            Date = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(6201),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(6206),
                            Note = "Modern JavaScript",
                            SeoAuthor = "Deniz Gezen",
                            SeoDescription = "Modern JavaScript",
                            SeoTags = "ECMA Script 6,map,filter,reduce, arrow function",
                            Thumbnail = "deafult.jpg",
                            Title = "Modern JavaScript",
                            UserId = 1,
                            ViewsCount = 193
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır.",
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(6214),
                            Date = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(6212),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(6216),
                            Note = "React Component Yapısı",
                            SeoAuthor = "Yusuf Onan",
                            SeoDescription = "React Component Yapısı",
                            SeoTags = "React, React Js, Component,state, Class Component, function component",
                            Thumbnail = "deafult.jpg",
                            Title = "React Component Yapısı",
                            UserId = 2,
                            ViewsCount = 225
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(9305),
                            Description = "C# programlama dili ile ilgili makaleler.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(9306),
                            Name = "C#",
                            Note = "C# Blog kategorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(9313),
                            Description = "JavaScript dili ile ilgili makaleler.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(9315),
                            Name = "JavaScript",
                            Note = "JavaScript Blog kategorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(9320),
                            Description = "React Js ile ilgili makaleler.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 961, DateTimeKind.Local).AddTicks(9322),
                            Name = "React Js",
                            Note = "React Js Blog kategorisi"
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(4022),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(4025),
                            Note = "C# 11.0 Yenilikleri ile ilgili Yorum",
                            Text = "1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir."
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(4031),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(4033),
                            Note = "Mordern JavaScript ile ilgili Yorum",
                            Text = "1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir."
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(4038),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(4039),
                            Note = "React Js Componentler ile ilgili Yorum",
                            Text = "1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir."
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(9708),
                            Description = "Admin rolü tüm haklara sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(9709),
                            Name = "Admin",
                            Note = "Bu, admin rolüdür."
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(9717),
                            Description = "User rolü, kısıtlı haklara sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 962, DateTimeKind.Local).AddTicks(9719),
                            Name = "User",
                            Note = "Bu, user rolüdür."
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifiedByName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 963, DateTimeKind.Local).AddTicks(8509),
                            Description = "İlk admin kullanıcısı",
                            Email = "denizgezen@gmail.com",
                            FirstName = "Deniz",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Gezen",
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 963, DateTimeKind.Local).AddTicks(8511),
                            Note = " Admin Kullanıcısı.",
                            PasswordHash = new byte[] { 50, 48, 48, 56, 50, 48, 101, 51, 50, 50, 55, 56, 49, 53, 101, 100, 49, 55, 53, 54, 97, 54, 98, 53, 51, 49, 101, 55, 101, 48, 100, 50 },
                            Picture = "https://www.teknozum.com/wp-content/uploads/2019/12/whatsapp-profil-foto%C4%9Fraflar%C4%B1-17-1024x1024.jpg",
                            RoleId = 1,
                            UserName = "denizgezen"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 55, 16, 963, DateTimeKind.Local).AddTicks(8546),
                            Description = "İlk user kullanıcısı",
                            Email = "yusufonan@gmail.com",
                            FirstName = "Yusuf",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Onan",
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 55, 16, 963, DateTimeKind.Local).AddTicks(8548),
                            Note = " User Kullanıcısı.",
                            PasswordHash = new byte[] { 52, 54, 102, 57, 52, 99, 56, 100, 101, 49, 52, 102, 98, 51, 54, 54, 56, 48, 56, 53, 48, 55, 54, 56, 102, 102, 49, 98, 55, 102, 50, 97 },
                            Picture = "https://tasarimfikir.com/wp-content/uploads/profil-fotografi-tasarimi-min.jpg",
                            RoleId = 2,
                            UserName = "yusuonan"
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Article", b =>
                {
                    b.HasOne("BlogApp.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogApp.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("BlogApp.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.User", b =>
                {
                    b.HasOne("BlogApp.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
