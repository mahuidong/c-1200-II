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

namespace FindDataByLINQ
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
	public partial class linqtosqlDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public linqtosqlDataContextDataContext() : 
				base(global::FindDataByLINQ.Properties.Settings.Default.db_TomeTwoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tb_User> tb_User
		{
			get
			{
				return this.GetTable<tb_User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_User")]
	public partial class tb_User
	{
		
		private int _ID;
		
		private string _User_Name;
		
		private string _User_Sex;
		
		private string _User_Age;
		
		private string _User_Marriage;
		
		private string _User_Duty;
		
		private System.Nullable<int> _User_Pay;
		
		private string _User_Phone;
		
		private string _User_Address;
		
		public tb_User()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Name", DbType="VarChar(50)")]
		public string User_Name
		{
			get
			{
				return this._User_Name;
			}
			set
			{
				if ((this._User_Name != value))
				{
					this._User_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Sex", DbType="VarChar(50)")]
		public string User_Sex
		{
			get
			{
				return this._User_Sex;
			}
			set
			{
				if ((this._User_Sex != value))
				{
					this._User_Sex = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Age", DbType="VarChar(50)")]
		public string User_Age
		{
			get
			{
				return this._User_Age;
			}
			set
			{
				if ((this._User_Age != value))
				{
					this._User_Age = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Marriage", DbType="VarChar(50)")]
		public string User_Marriage
		{
			get
			{
				return this._User_Marriage;
			}
			set
			{
				if ((this._User_Marriage != value))
				{
					this._User_Marriage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Duty", DbType="VarChar(50)")]
		public string User_Duty
		{
			get
			{
				return this._User_Duty;
			}
			set
			{
				if ((this._User_Duty != value))
				{
					this._User_Duty = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Pay", DbType="Int")]
		public System.Nullable<int> User_Pay
		{
			get
			{
				return this._User_Pay;
			}
			set
			{
				if ((this._User_Pay != value))
				{
					this._User_Pay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Phone", DbType="VarChar(50)")]
		public string User_Phone
		{
			get
			{
				return this._User_Phone;
			}
			set
			{
				if ((this._User_Phone != value))
				{
					this._User_Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Address", DbType="VarChar(50)")]
		public string User_Address
		{
			get
			{
				return this._User_Address;
			}
			set
			{
				if ((this._User_Address != value))
				{
					this._User_Address = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
