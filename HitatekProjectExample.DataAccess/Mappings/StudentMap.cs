using HitatekProjectExample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitatekProjectExample.DataAccess.Mappings
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.Property(s => s.Adi).HasMaxLength(50);
            builder.Property(s => s.Adi).IsRequired();

            builder.Property(s => s.Soyadi).HasMaxLength(50);
            builder.Property(s => s.Soyadi).IsRequired();

            builder.Property(s => s.NotOrtalamasi).IsRequired();

            builder.ToTable("Students");

            builder.HasData(new Student
            {
                Id = 1,
                Adi = "Ahmet",
                Soyadi = "C#",
                NotOrtalamasi = 50
            },
            new Student
            {
                Id = 2,
                Adi = "Mehmet",
                Soyadi = "Java",
                NotOrtalamasi = 80
            },
            new Student
            {
                Id = 3,
                Adi = "Fatma",
                Soyadi = "Pyhton",
                NotOrtalamasi = 45
            },
            new Student
            {
                Id = 4,
                Adi = "Ayşe",
                Soyadi = "JavaScript",
                NotOrtalamasi = 100
            });
        }
    }
}
