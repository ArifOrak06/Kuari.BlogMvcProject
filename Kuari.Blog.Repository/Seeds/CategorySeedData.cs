using Kuari.Blog.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Repository.Seeds
{
    internal class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category[]
            {
                new(){Id=1,Description="Yazılım Dünyasinda Kariyer Fırsatları",Name="Yazılım",Status=true},
                new(){Id=2,Description="Sinema ve Tiyatro Dünyasındaki Son Gelişmeler",Name="Sinema",Status=true},
                new(){Id=3,Description="Sağlıklı Hayat",Name="Sağlık",Status=true},
                new(){Id=4,Description="Ulusal ve Uluslararası Spor Müsabakaları",Name="Spor",Status=true},
                new(){Id=5,Description="Ulusal Siber Güvenliğin Önemi",Name="Siber Güvenlik",Status=true}
            });
        }
    }
}
