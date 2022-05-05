using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.PointEntity
{
    public class PointConfiguration : IEntityTypeConfiguration<Point>
    {
        public void Configure(EntityTypeBuilder<Point> builder)
        {
            builder
                .Property(p => p.Address)
                .HasMaxLength(100);
            builder
                .Property(p => p.Settlement)
                .HasMaxLength(100);
            builder
                .Property(p => p.Region)
                .HasMaxLength(100);
        }
    }
}
