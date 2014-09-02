﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExecuteQuery
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_TomeTwo")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public DataClassesDataContext() : 
				base(global::ExecuteQuery.Properties.Settings.Default.db_TomeTwoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<WarehouseInfo> WarehouseInfo
		{
			get
			{
				return this.GetTable<WarehouseInfo>();
			}
		}
		
		public System.Data.Linq.Table<V_StoreInfo> V_StoreInfo
		{
			get
			{
				return this.GetTable<V_StoreInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WarehouseInfo")]
	public partial class WarehouseInfo
	{
		
		private int _ID;
		
		private string _WareHouseCode;
		
		private string _HelpCode;
		
		private string _ShortName;
		
		private string _WareHouseName;
		
		private string _Location;
		
		private System.Nullable<double> _Area;
		
		private string _Memo;
		
		public WarehouseInfo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WareHouseCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string WareHouseCode
		{
			get
			{
				return this._WareHouseCode;
			}
			set
			{
				if ((this._WareHouseCode != value))
				{
					this._WareHouseCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HelpCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string HelpCode
		{
			get
			{
				return this._HelpCode;
			}
			set
			{
				if ((this._HelpCode != value))
				{
					this._HelpCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ShortName
		{
			get
			{
				return this._ShortName;
			}
			set
			{
				if ((this._ShortName != value))
				{
					this._ShortName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WareHouseName", DbType="VarChar(50)")]
		public string WareHouseName
		{
			get
			{
				return this._WareHouseName;
			}
			set
			{
				if ((this._WareHouseName != value))
				{
					this._WareHouseName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="VarChar(50)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this._Location = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="Float")]
		public System.Nullable<double> Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this._Area = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memo", DbType="VarChar(200)")]
		public string Memo
		{
			get
			{
				return this._Memo;
			}
			set
			{
				if ((this._Memo != value))
				{
					this._Memo = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.V_StoreInfo")]
	public partial class V_StoreInfo
	{
		
		private string _WarehouseCode;
		
		private string _WareHouseName;
		
		private string _ProductCode;
		
		private string _ProductName;
		
		private int _Quantity;
		
		private double _Price;
		
		private double _Amount;
		
		private string _Memo;
		
		private string _HelpCode;
		
		public V_StoreInfo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WarehouseCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string WarehouseCode
		{
			get
			{
				return this._WarehouseCode;
			}
			set
			{
				if ((this._WarehouseCode != value))
				{
					this._WarehouseCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WareHouseName", DbType="VarChar(50)")]
		public string WareHouseName
		{
			get
			{
				return this._WareHouseName;
			}
			set
			{
				if ((this._WareHouseName != value))
				{
					this._WareHouseName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ProductCode
		{
			get
			{
				return this._ProductCode;
			}
			set
			{
				if ((this._ProductCode != value))
				{
					this._ProductCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this._ProductName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this._Quantity = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Float NOT NULL")]
		public double Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this._Amount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memo", DbType="VarChar(100)")]
		public string Memo
		{
			get
			{
				return this._Memo;
			}
			set
			{
				if ((this._Memo != value))
				{
					this._Memo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HelpCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string HelpCode
		{
			get
			{
				return this._HelpCode;
			}
			set
			{
				if ((this._HelpCode != value))
				{
					this._HelpCode = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
