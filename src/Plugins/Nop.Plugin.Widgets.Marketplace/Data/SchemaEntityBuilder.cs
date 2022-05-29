using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator.Builders.Create.Table;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.Widgets.Marketplace.Data.Domain;

namespace Nop.Plugin.Widgets.Marketplace.Data
{
    public class SchemaEntityBuilder : NopEntityBuilder<ProductVendorMapping>
    {
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
        }
    }
}