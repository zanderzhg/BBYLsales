﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.239
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBYLsales
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sale")]
	public partial class mySaleDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertF_S_COLOR(F_S_COLOR instance);
    partial void UpdateF_S_COLOR(F_S_COLOR instance);
    partial void DeleteF_S_COLOR(F_S_COLOR instance);
    #endregion
		
		public mySaleDataContext() : 
				base(global::BBYLsales.Properties.Settings.Default.saleConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public mySaleDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public mySaleDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public mySaleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public mySaleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<F_S_COLOR> F_S_COLOR
		{
			get
			{
				return this.GetTable<F_S_COLOR>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.F_S_COLOR")]
	public partial class F_S_COLOR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _颜色;
		
		private int _颜色代码;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void On颜色Changing(string value);
    partial void On颜色Changed();
    partial void On颜色代码Changing(int value);
    partial void On颜色代码Changed();
    #endregion
		
		public F_S_COLOR()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_颜色", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string 颜色
		{
			get
			{
				return this._颜色;
			}
			set
			{
				if ((this._颜色 != value))
				{
					this.On颜色Changing(value);
					this.SendPropertyChanging();
					this._颜色 = value;
					this.SendPropertyChanged("颜色");
					this.On颜色Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_颜色代码", DbType="Int NOT NULL")]
		public int 颜色代码
		{
			get
			{
				return this._颜色代码;
			}
			set
			{
				if ((this._颜色代码 != value))
				{
					this.On颜色代码Changing(value);
					this.SendPropertyChanging();
					this._颜色代码 = value;
					this.SendPropertyChanged("颜色代码");
					this.On颜色代码Changed();
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
