using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository;

namespace Repository;

public class AppDBContext : DbContext
{
    protected readonly IConfiguration configuration;

    public AppDBContext(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DiaryDBConnectionString"));
    }

    public DbSet<User> Users { get; set; }
    public DbSet<DiaryEntry> DiaryEntries { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Media> Medias { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    public DbSet<Thread> Threads { get; set; }
    public DbSet<ThreadPost> ThreadPosts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DiaryTag>().HasKey(dt => new {dt.DiaryId, dt.TagId});

        modelBuilder.Entity<DiaryEntry>()
            .HasOne(d => d.User)
            .WithMany(u => u.Diaries)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<DiaryTag>()
            .HasOne(dt => dt.DiaryEntry)
            .WithMany(d => d.DiaryTags)
            .HasForeignKey(dt => dt.DiaryId);

        modelBuilder.Entity<DiaryTag>()
            .HasOne(dt => dt.Tag)
            .WithMany(t => t.DiaryTags)
            .HasForeignKey(dt => dt.TagId);

        modelBuilder.Entity<Media>()
            .HasOne(m => m.DiaryEntry)
            .WithMany(d => d.MediaFiles)
            .HasForeignKey(m => m.DiaryId);

        modelBuilder.Entity<Reminder>()
            .HasOne(r => r.User)
            .WithMany(u => u.Reminders)
            .HasForeignKey(r => r.UserId);
        
        modelBuilder.Entity<ThreadPost>()
            .HasOne(tp => tp.Thread)
            .WithMany(t => t.Posts)
            .HasForeignKey(tp => tp.ThreadId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ThreadPost>()
            .HasOne(tp => tp.User)
            .WithMany(u => u.ThreadPosts)
            .HasForeignKey(tp => tp.UserId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}