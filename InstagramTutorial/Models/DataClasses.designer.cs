﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstagramTutorial.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ınsta")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClassesDataContext() : 
				base(global::InstagramTutorial.Properties.Settings.Default.ınstaConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<CreateInsta> CreateInsta
		{
			get
			{
				return this.GetTable<CreateInsta>();
			}
		}
		
		public System.Data.Linq.Table<InstaUser> InstaUser
		{
			get
			{
				return this.GetTable<InstaUser>();
			}
		}
		
		public System.Data.Linq.Table<Sayfa1_> Sayfa1_
		{
			get
			{
				return this.GetTable<Sayfa1_>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CreateInsta")]
	public partial class CreateInsta
	{
		
		private int _UserId;
		
		private string _UserName;
		
		private string _UserPassword;
		
		private string _UserMail;
		
		private string _UserFirstname;
		
		public CreateInsta()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(MAX)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPassword", DbType="NVarChar(MAX)")]
		public string UserPassword
		{
			get
			{
				return this._UserPassword;
			}
			set
			{
				if ((this._UserPassword != value))
				{
					this._UserPassword = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserMail", DbType="NVarChar(MAX)")]
		public string UserMail
		{
			get
			{
				return this._UserMail;
			}
			set
			{
				if ((this._UserMail != value))
				{
					this._UserMail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserFirstname", DbType="NVarChar(MAX)")]
		public string UserFirstname
		{
			get
			{
				return this._UserFirstname;
			}
			set
			{
				if ((this._UserFirstname != value))
				{
					this._UserFirstname = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.InstaUser")]
	public partial class InstaUser
	{
		
		private int _UserId;
		
		private string _UserName;
		
		private string _UserPass;
		
		public InstaUser()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(MAX)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPass", DbType="NVarChar(MAX)")]
		public string UserPass
		{
			get
			{
				return this._UserPass;
			}
			set
			{
				if ((this._UserPass != value))
				{
					this._UserPass = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sayfa1$")]
	public partial class Sayfa1_
	{
		
		private string _UserName;
		
		private string _UserPass;
		
		public Sayfa1_()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(255)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPass", DbType="NVarChar(255)")]
		public string UserPass
		{
			get
			{
				return this._UserPass;
			}
			set
			{
				if ((this._UserPass != value))
				{
					this._UserPass = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
