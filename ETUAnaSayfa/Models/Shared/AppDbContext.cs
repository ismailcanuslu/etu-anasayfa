using ETUAnaSayfa.Models.Home;
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

    }
}