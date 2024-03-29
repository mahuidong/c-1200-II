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

namespace Intersect
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
				base(global::Intersect.Properties.Settings.Default.db_TomeTwoConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<V_SaleInfo> V_SaleInfo
		{
			get
			{
				return this.GetTable<V_SaleInfo>();
			}
		}
		
		public System.Data.Linq.Table<V_SaleReturnInfo> V_SaleReturnInfo
		{
			get
			{
				return this.GetTable<V_SaleReturnInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.V_SaleInfo")]
	public partial class V_SaleInfo
	{
		
		private string _SaleBillCode;
		
		private string _SaleManCode;
		
		private string _SaleManName;
		
		private System.DateTime _SaleDate;
		
		private string _ClientCode;
		
		private string _ClientName;
		
		private string _WarehouseCode;
		
		private string _WarehouseName;
		
		private string _ProductCode;
		
		private string _ProductName;
		
		private int _Quantity;
		
		private double _Price;
		
		private double _Amount;
		
		public V_SaleInfo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleBillCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string SaleBillCode
		{
			get
			{
				return this._SaleBillCode;
			}
			set
			{
				if ((this._SaleBillCode != value))
				{
					this._SaleBillCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleManCode", DbType="VarChar(20)")]
		public string SaleManCode
		{
			get
			{
				return this._SaleManCode;
			}
			set
			{
				if ((this._SaleManCode != value))
				{
					this._SaleManCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleManName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string SaleManName
		{
			get
			{
				return this._SaleManName;
			}
			set
			{
				if ((this._SaleManName != value))
				{
					this._SaleManName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleDate", DbType="DateTime NOT NULL")]
		public System.DateTime SaleDate
		{
			get
			{
				return this._SaleDate;
			}
			set
			{
				if ((this._SaleDate != value))
				{
					this._SaleDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientCode", DbType="VarChar(20)")]
		public string ClientCode
		{
			get
			{
				return this._ClientCode;
			}
			set
			{
				if ((this._ClientCode != value))
				{
					this._ClientCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ClientName
		{
			get
			{
				return this._ClientName;
			}
			set
			{
				if ((this._ClientName != value))
				{
					this._ClientName = value;
				}
			}
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WarehouseName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string WarehouseName
		{
			get
			{
				return this._WarehouseName;
			}
			set
			{
				if ((this._WarehouseName != value))
				{
					this._WarehouseName = value;
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.V_SaleReturnInfo")]
	public partial class V_SaleReturnInfo
	{
		
		private string _SaleBillCode;
		
		private string _SaleManCode;
		
		private string _SaleManName;
		
		private System.DateTime _SaleDate;
		
		private string _ClientCode;
		
		private string _ClientName;
		
		private string _WarehouseCode;
		
		private string _WarehouseName;
		
		private string _ProductCode;
		
		private string _ProductName;
		
		private int _Quantity;
		
		private double _Price;
		
		private double _Amount;
		
		public V_SaleReturnInfo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleBillCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string SaleBillCode
		{
			get
			{
				return this._SaleBillCode;
			}
			set
			{
				if ((this._SaleBillCode != value))
				{
					this._SaleBillCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleManCode", DbType="VarChar(20)")]
		public string SaleManCode
		{
			get
			{
				return this._SaleManCode;
			}
			set
			{
				if ((this._SaleManCode != value))
				{
					this._SaleManCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleManName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string SaleManName
		{
			get
			{
				return this._SaleManName;
			}
			set
			{
				if ((this._SaleManName != value))
				{
					this._SaleManName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleDate", DbType="DateTime NOT NULL")]
		public System.DateTime SaleDate
		{
			get
			{
				return this._SaleDate;
			}
			set
			{
				if ((this._SaleDate != value))
				{
					this._SaleDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientCode", DbType="VarChar(20)")]
		public string ClientCode
		{
			get
			{
				return this._ClientCode;
			}
			set
			{
				if ((this._ClientCode != value))
				{
					this._ClientCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ClientName
		{
			get
			{
				return this._ClientName;
			}
			set
			{
				if ((this._ClientName != value))
				{
					this._ClientName = value;
				}
			}
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WarehouseName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string WarehouseName
		{
			get
			{
				return this._WarehouseName;
			}
			set
			{
				if ((this._WarehouseName != value))
				{
					this._WarehouseName = value;
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
	}
}
#pragma warning restore 1591
