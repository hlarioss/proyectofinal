﻿using analisis.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace analisis.Datos.Mapping.Usuarios
{
    class personaMap : IEntityTypeConfiguration<persona>
    {
        public void Configure(EntityTypeBuilder<persona> builder)
        {
            builder.ToTable("persona")
               .HasKey(c => c.idpersona);
            builder.Property(c => c.tipo_persona)
                .HasMaxLength(200);
            builder.Property(c => c.nombre)
                .HasMaxLength(200);
            builder.Property(c => c.tipo_documento)
                  .HasMaxLength(200);
            builder.Property(c => c.num_documento);
            builder.Property(c => c.direccion)
                .HasMaxLength(256);
            builder.Property(c => c.telefono)
                .HasMaxLength(256);
            builder.Property(c => c.email)
                .HasMaxLength(256);

        }
    }
}
