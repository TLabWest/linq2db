// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.ClickHouse.MySql
{
	[Table("GrandChild")]
	public class GrandChild
	{
		[Column("ParentID"    )] public int ParentId     { get; set; } // Int32
		[Column("ChildID"     )] public int ChildId      { get; set; } // Int32
		[Column("GrandChildID")] public int GrandChildId { get; set; } // Int32
	}
}
