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

namespace EditDataByLINQ
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
	public partial class linqtosqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Inserttb_User(tb_User instance);
    partial void Updatetb_User(tb_User instance);
    partial void Deletetb_User(tb_User instance);
    #endregion
		
		public linqtosqlDataContext() : 
				base(global::EditDataByLINQ.Properties.Settings.Default.db_TomeTwoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
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
	public partial class tb_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _User_Name;
		
		private string _User_Sex;
		
		private string _User_Age;
		
		private string _User_Marriage;
		
		private string _User_Duty;
		
		private System.Nullable<int> _User_Pay;
		
		private string _User_Phone;
		
		private string _User_Address;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUser_NameChanging(string value);
    partial void OnUser_NameChanged();
    partial void OnUser_SexChanging(string value);
    partial void OnUser_SexChanged();
    partial void OnUser_AgeChanging(string value);
    partial void OnUser_AgeChanged();
    partial void OnUser_MarriageChanging(string value);
    partial void OnUser_MarriageChanged();
    partial void OnUser_DutyChanging(string value);
    partial void OnUser_DutyChanged();
    partial void OnUser_PayChanging(System.Nullable<int> value);
    partial void OnUser_PayChanged();
    partial void OnUser_PhoneChanging(string value);
    partial void OnUser_PhoneChanged();
    partial void OnUser_AddressChanging(string value);
    partial void OnUser_AddressChanged();
    #endregion
		
		public tb_User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
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
					this.OnUser_NameChanging(value);
					this.SendPropertyChanging();
					this._User_Name = value;
					this.SendPropertyChanged("User_Name");
					this.OnUser_NameChanged();
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
					this.OnUser_SexChanging(value);
					this.SendPropertyChanging();
					this._User_Sex = value;
					this.SendPropertyChanged("User_Sex");
					this.OnUser_SexChanged();
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
					this.OnUser_AgeChanging(value);
					this.SendPropertyChanging();
					this._User_Age = value;
					this.SendPropertyChanged("User_Age");
					this.OnUser_AgeChanged();
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
					this.OnUser_MarriageChanging(value);
					this.SendPropertyChanging();
					this._User_Marriage = value;
					this.SendPropertyChanged("User_Marriage");
					this.OnUser_MarriageChanged();
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
					this.OnUser_DutyChanging(value);
					this.SendPropertyChanging();
					this._User_Duty = value;
					this.SendPropertyChanged("User_Duty");
					this.OnUser_DutyChanged();
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
					this.OnUser_PayChanging(value);
					this.SendPropertyChanging();
					this._User_Pay = value;
					this.SendPropertyChanged("User_Pay");
					this.OnUser_PayChanged();
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
					this.OnUser_PhoneChanging(value);
					this.SendPropertyChanging();
					this._User_Phone = value;
					this.SendPropertyChanged("User_Phone");
					this.OnUser_PhoneChanged();
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
					this.OnUser_AddressChanging(value);
					this.SendPropertyChanging();
					this._User_Address = value;
					this.SendPropertyChanged("User_Address");
					this.OnUser_AddressChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
