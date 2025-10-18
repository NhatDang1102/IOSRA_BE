using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository.Entities;


namespace Repository.Db;


public class IosraDbContext : DbContext
{
    public IosraDbContext(DbContextOptions<IosraDbContext> options) : base(options) { }


    public DbSet<Account> Accounts => Set<Account>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<AccountRole> AccountRoles => Set<AccountRole>();
    public DbSet<Admin> Admins => Set<Admin>();
    public DbSet<ContentMod> ContentMods => Set<ContentMod>();
    public DbSet<OperationMod> OperationMods => Set<OperationMod>();


    public DbSet<Reader> Readers => Set<Reader>();
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<AuthorRank> AuthorRanks => Set<AuthorRank>();
    public DbSet<Follow> Follows => Set<Follow>();
    public DbSet<FavoriteStory> FavoriteStories => Set<FavoriteStory>();


    public DbSet<DiaWallet> DiaWallets => Set<DiaWallet>();
    public DbSet<WalletPayment> WalletPayments => Set<WalletPayment>();
    public DbSet<DiaPayment> DiaPayments => Set<DiaPayment>();
    public DbSet<OpRequest> OpRequests => Set<OpRequest>();


    public DbSet<Story> Stories => Set<Story>();
    public DbSet<Chapter> Chapters => Set<Chapter>();
    public DbSet<ChapterComment> ChapterComments => Set<ChapterComment>();
    public DbSet<ChapterPurchaseLog> ChapterPurchaseLogs => Set<ChapterPurchaseLog>();
    public DbSet<Tag> Tags => Set<Tag>();
    public DbSet<StoryTag> StoryTags => Set<StoryTag>();


    public DbSet<Language> Languages => Set<Language>();
    public DbSet<ChapterLocalization> ChapterLocalizations => Set<ChapterLocalization>();
    public DbSet<Voice> Voices => Set<Voice>();
    public DbSet<ChapterVoice> ChapterVoices => Set<ChapterVoice>();


    public DbSet<ContentApprove> ContentApproves => Set<ContentApprove>();
    public DbSet<Report> Reports => Set<Report>();


    public DbSet<SubscriptionPlan> SubscriptionPlans => Set<SubscriptionPlan>();
    public DbSet<Subscription> Subscriptions => Set<Subscription>();


    protected override void OnModelCreating(ModelBuilder b)
    {
        // Global: set VARCHAR length for string IDs automatically
        foreach (var entity in b.Model.GetEntityTypes())
        {
            foreach (var prop in entity.GetProperties())
            {
                if (prop.ClrType == typeof(string) && prop.Name.EndsWith("Id"))
                {
                    prop.SetMaxLength(36);
                }
            }
        }


    }
}