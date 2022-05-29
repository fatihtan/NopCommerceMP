using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using Nop.Plugin.Widgets.Marketplace.Data.Domain;

namespace Nop.Plugin.Widgets.Marketplace.Data.Migrations
{
    [NopMigration("2022-05-30 01:59:00", "Nop.Plugin.Widgets.Marketplace schema", MigrationProcessType.Installation)]
    public class ProductVendorMappingMigration : AutoReversingMigration
    {
        private IMigrationManager _iMigrationManager;

        public ProductVendorMappingMigration(IMigrationManager iMigrationManager)
        {
            this._iMigrationManager = iMigrationManager;
        }
        public override void Up()
        {
            Create.TableFor<ProductVendorMapping>();
        }
    }
}
