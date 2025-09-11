using DEMO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Config
{
    public class DeptConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {

            builder.HasKey(x => x.DeptId);

            //builder.Property(x => x.DeptId).UseIdentityColumn(10, 10)
            //                                                           .IsRequired(true)

            //                                 //.ValueGeneratedNever()
            //                                 .HasDefaultValueSql("new Guid()");

            builder.Property(x => x.DeptName).HasColumnType("varchar")
                                                                      .HasMaxLength(100)
                                                                      .HasColumnName("DeptIDD")
                                                                      .IsRequired(false)
                                                                      .HasDefaultValue("Hr");

            //builder.Property(x => x.DateOfCreation).HasAnnotation("Datatype", "Date");
            //builder.Property(x => x.DateOfCreation).HasDefaultValue("Get Date()");

            builder.Ignore(x => x.Serial);
        }

    }
}
