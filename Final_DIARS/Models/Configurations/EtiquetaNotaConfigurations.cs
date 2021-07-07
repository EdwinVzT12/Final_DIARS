using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_DIARS.Models;

namespace Final_DIARS.DB.Configuraciones
{
    public class EtiquetaNotaConfigurations : IEntityTypeConfiguration<EtiquetaNota>
    {
        public void Configure(EntityTypeBuilder<EtiquetaNota> builder)
        {
            builder.ToTable("EtiquetaNota");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Etiqueta).
                WithMany().
                HasForeignKey(o => o.IdEtiqueta);
        }
    }
}
