using ETUAnaSayfa.Models.Home;
using ETUAnaSayfa.Models.Shared.UnitTemplate;
using Microsoft.EntityFrameworkCore;

namespace ETUAnaSayfa.Models.Shared;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Events> Events { get; set; }
    public DbSet<News> News { get; set; }
    
    public DbSet<NewsImages> NewsImages { get; set; }
    
    public DbSet<Announcements> Announcements { get; set; }
    
    public DbSet<Videos> Videos { get; set; }
    
    public DbSet<Contact> Contacts { get; set; }
    
    public DbSet<ContactForm> ContactForms { get; set; }
    
    /*
     * UNİT TEMPLATES
     */
    
    public DbSet<UnitMainPage> UnitMainPage { get; set; }
    public DbSet<UnitAnnouncements> UnitAnnouncements { get; set; }
    public DbSet<UnitPublications> UnitPublications { get; set; }
    public DbSet<UnitQuickAccess> UnitQuickAccess { get; set; }
    public DbSet<UnitMenus> UnitMenus { get; set; }
    public DbSet<UnitSubMenus> UnitSubMenus { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Events>(entity =>
        {
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.Date)
                .IsRequired();
            entity.Property(e => e.IsPinned)
                .IsRequired();
            entity.Property(e => e.IsVisible)
                .IsRequired();
            entity.Property(e => e.ImgPath)
                .IsRequired();
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(160);
            entity.Property(e => e.Text)
                .IsRequired()
                .HasMaxLength(3550);
            entity.Property(e => e.Date)
                .IsRequired();
            entity.Property(e => e.IsVisible)
                .IsRequired();
            entity.Property(e => e.IsPinned)
                .IsRequired();
            entity.Property(e => e.CoverImgPath)
                .IsRequired()
                .HasMaxLength(300);
            
        });
        
        modelBuilder.Entity<NewsImages>(entity =>
        {
            entity.Property(e => e.ImagePath)
                .IsRequired()
                .HasMaxLength(300);
        });

        modelBuilder.Entity<Announcements>(entity =>
        {
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Text)
                .IsRequired()
                .HasMaxLength(1200);
            entity.Property(e => e.Date)
                .IsRequired();
            entity.Property(e => e.IsVisible)
                .IsRequired();
            entity.Property(e => e.IsPinned)
                .IsRequired();
        });
        
        modelBuilder.Entity<Videos>(entity =>
        {
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.VideoId)
                .IsRequired();
            entity.Property(e => e.ReleaseDate)
                .IsRequired();
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.KepEmail)
                .IsRequired()
                .HasMaxLength(120);
        });

        modelBuilder.Entity<ContactForm>(entity =>
        {
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.Message)
                .IsRequired()
                .HasMaxLength(2000);
            entity.Property(e => e.IsRead)
                .IsRequired();
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.Choices)
                .IsRequired();
        });
        
        /*
         * UNİTS TEMPLATE
         */

        modelBuilder.Entity<UnitMainPage>(entity =>
        {
            
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Subpath)
                .IsRequired()
                .HasMaxLength(180);
            entity.HasIndex(x => x.Subpath)
                .IsUnique();
        });

        modelBuilder.Entity<UnitQuickAccess>(entity =>
        {
            
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(40);
            entity.Property(e => e.ActionURI)
                .IsRequired()
                .HasMaxLength(700);
        });

        modelBuilder.Entity<UnitAnnouncements>(entity =>
        {
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Text)
                .IsRequired()
                .HasMaxLength(1200);
            entity.Property(e => e.Date)
                .IsRequired();
            entity.Property(e => e.IsVisible)
                .IsRequired();
            entity.Property(e => e.IsPinned)
                .IsRequired();
            
            entity.Ignore(e => e.IsRedirect);
        });
        
        modelBuilder.Entity<UnitPublications>(entity =>
        {
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Text)
                .IsRequired()
                .HasMaxLength(1200);
            entity.Property(e => e.Date)
                .IsRequired();
            entity.Property(e => e.IsVisible)
                .IsRequired();
            entity.Property(e => e.IsPinned)
                .IsRequired();
            
            entity.Ignore(e => e.IsRedirect);
        });

        modelBuilder.Entity<UnitMenus>(entity =>
        {
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.IconPath)
                .IsRequired()
                .HasMaxLength(120);
            
            entity.HasMany(menu => menu.SubMenus)
                .WithOne(subMenu => subMenu.UnitMenus)
                .HasForeignKey(subMenu => subMenu.UnitMenusId)
                .OnDelete(DeleteBehavior.Cascade);
            
           
        });

        modelBuilder.Entity<UnitSubMenus>(entity =>
        {
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.Text)
                .HasMaxLength(3550);
            entity.Property(e => e.Link)
                .HasMaxLength(700);
            entity.Property(e => e.Text)
                .HasMaxLength(3550);
            entity.Property(e => e.Url)
                .HasMaxLength(700);
            
            entity.Ignore(e => e.IsRedirect);

        });


    }
}