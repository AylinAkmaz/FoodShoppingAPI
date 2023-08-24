using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class RoleMap : BaseMap<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.Property(q => q.Name).HasMaxLength(20).IsRequired();
            builder.HasMany(q => q.FoodDetails).WithOne(q => q.Role).HasForeignKey(q => q.RoleID);

        }
    }
}
