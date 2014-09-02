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

namespace EntityRef
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
    partial void InsertDictionaryType(DictionaryType instance);
    partial void UpdateDictionaryType(DictionaryType instance);
    partial void DeleteDictionaryType(DictionaryType instance);
    partial void InsertDictionaryItem(DictionaryItem instance);
    partial void UpdateDictionaryItem(DictionaryItem instance);
    partial void DeleteDictionaryItem(DictionaryItem instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::EntityRef.Properties.Settings.Default.db_TomeTwoConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<DictionaryType> DictionaryType
		{
			get
			{
				return this.GetTable<DictionaryType>();
			}
		}
		
		public System.Data.Linq.Table<DictionaryItem> DictionaryItem
		{
			get
			{
				return this.GetTable<DictionaryItem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DictionaryType")]
	public partial class DictionaryType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DictTypeID;
		
		private string _DictTypeCode;
		
		private string _DictTypeName;
		
		private EntitySet<DictionaryItem> _DictionaryItem;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDictTypeIDChanging(int value);
    partial void OnDictTypeIDChanged();
    partial void OnDictTypeCodeChanging(string value);
    partial void OnDictTypeCodeChanged();
    partial void OnDictTypeNameChanging(string value);
    partial void OnDictTypeNameChanged();
    #endregion
		
		public DictionaryType()
		{
			this._DictionaryItem = new EntitySet<DictionaryItem>(new Action<DictionaryItem>(this.attach_DictionaryItem), new Action<DictionaryItem>(this.detach_DictionaryItem));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DictTypeID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DictTypeID
		{
			get
			{
				return this._DictTypeID;
			}
			set
			{
				if ((this._DictTypeID != value))
				{
					this.OnDictTypeIDChanging(value);
					this.SendPropertyChanging();
					this._DictTypeID = value;
					this.SendPropertyChanged("DictTypeID");
					this.OnDictTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DictTypeCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string DictTypeCode
		{
			get
			{
				return this._DictTypeCode;
			}
			set
			{
				if ((this._DictTypeCode != value))
				{
					this.OnDictTypeCodeChanging(value);
					this.SendPropertyChanging();
					this._DictTypeCode = value;
					this.SendPropertyChanged("DictTypeCode");
					this.OnDictTypeCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DictTypeName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DictTypeName
		{
			get
			{
				return this._DictTypeName;
			}
			set
			{
				if ((this._DictTypeName != value))
				{
					this.OnDictTypeNameChanging(value);
					this.SendPropertyChanging();
					this._DictTypeName = value;
					this.SendPropertyChanged("DictTypeName");
					this.OnDictTypeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DictionaryType_DictionaryItem", Storage="_DictionaryItem", ThisKey="DictTypeID", OtherKey="DictTypeID")]
		public EntitySet<DictionaryItem> DictionaryItem
		{
			get
			{
				return this._DictionaryItem;
			}
			set
			{
				this._DictionaryItem.Assign(value);
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
		
		private void attach_DictionaryItem(DictionaryItem entity)
		{
			this.SendPropertyChanging();
			entity.DictionaryType = this;
		}
		
		private void detach_DictionaryItem(DictionaryItem entity)
		{
			this.SendPropertyChanging();
			entity.DictionaryType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DictionaryItem")]
	public partial class DictionaryItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DictItemID;
		
		private int _DictTypeID;
		
		private string _DictItemCode;
		
		private string _DictItemName;
		
		private EntityRef<DictionaryType> _DictionaryType;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDictItemIDChanging(int value);
    partial void OnDictItemIDChanged();
    partial void OnDictTypeIDChanging(int value);
    partial void OnDictTypeIDChanged();
    partial void OnDictItemCodeChanging(string value);
    partial void OnDictItemCodeChanged();
    partial void OnDictItemNameChanging(string value);
    partial void OnDictItemNameChanged();
    #endregion
		
		public DictionaryItem()
		{
			this._DictionaryType = default(EntityRef<DictionaryType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DictItemID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DictItemID
		{
			get
			{
				return this._DictItemID;
			}
			set
			{
				if ((this._DictItemID != value))
				{
					this.OnDictItemIDChanging(value);
					this.SendPropertyChanging();
					this._DictItemID = value;
					this.SendPropertyChanged("DictItemID");
					this.OnDictItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DictTypeID", DbType="Int NOT NULL")]
		public int DictTypeID
		{
			get
			{
				return this._DictTypeID;
			}
			set
			{
				if ((this._DictTypeID != value))
				{
					if (this._DictionaryType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDictTypeIDChanging(value);
					this.SendPropertyChanging();
					this._DictTypeID = value;
					this.SendPropertyChanged("DictTypeID");
					this.OnDictTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DictItemCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string DictItemCode
		{
			get
			{
				return this._DictItemCode;
			}
			set
			{
				if ((this._DictItemCode != value))
				{
					this.OnDictItemCodeChanging(value);
					this.SendPropertyChanging();
					this._DictItemCode = value;
					this.SendPropertyChanged("DictItemCode");
					this.OnDictItemCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DictItemName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DictItemName
		{
			get
			{
				return this._DictItemName;
			}
			set
			{
				if ((this._DictItemName != value))
				{
					this.OnDictItemNameChanging(value);
					this.SendPropertyChanging();
					this._DictItemName = value;
					this.SendPropertyChanged("DictItemName");
					this.OnDictItemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DictionaryType_DictionaryItem", Storage="_DictionaryType", ThisKey="DictTypeID", OtherKey="DictTypeID", IsForeignKey=true)]
		public DictionaryType DictionaryType
		{
			get
			{
				return this._DictionaryType.Entity;
			}
			set
			{
				DictionaryType previousValue = this._DictionaryType.Entity;
				if (((previousValue != value) 
							|| (this._DictionaryType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DictionaryType.Entity = null;
						previousValue.DictionaryItem.Remove(this);
					}
					this._DictionaryType.Entity = value;
					if ((value != null))
					{
						value.DictionaryItem.Add(this);
						this._DictTypeID = value.DictTypeID;
					}
					else
					{
						this._DictTypeID = default(int);
					}
					this.SendPropertyChanged("DictionaryType");
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
