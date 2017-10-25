using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppCinemaProva.Configution
{
    public class EntityConvention:Convention
    {
        public EntityConvention()
        {
            Properties().Where(c => c.Name == c.ReflectedType + "Id").Configure(c => c.IsKey());

            Properties().Where(c => c.Name == "DataCadastro").Configure(c => c.HasColumnType("dateTime2"));

            Properties<string>().Configure(c => c.HasMaxLength(150));
        }
    }
}