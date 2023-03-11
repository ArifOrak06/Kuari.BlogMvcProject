using Kuari.Blog.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Kuari.Blog.Repository.Configurations
{
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<About> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        
        }
    }
}
