// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using System.Data.SqlTypes;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SqlServerNorthwind
{
	[Table("Current Product List", IsView = true)]
	public class CurrentProductList
	{
		[Column("ProductID"  , DataType = DataType.Int32   , DbType = "int"         , IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public SqlInt32  ProductId   { get; set; } // int
		[Column("ProductName", DataType = DataType.NVarChar, DbType = "nvarchar(40)", Length     = 40                                            )] public SqlString ProductName { get; set; } // nvarchar(40)
	}
}