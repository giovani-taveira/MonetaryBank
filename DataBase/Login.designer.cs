﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MonetaryBank")]
	public partial class LoginDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public LoginDataContext() : 
				base(global::DataBase.Properties.Settings.Default.MonetaryBankConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LoginDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LoginTable> LoginTable
		{
			get
			{
				return this.GetTable<LoginTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoginTable")]
	public partial class LoginTable
	{
		
		private string _CPF;
		
		private string _Senha;
		
		public LoginTable()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPF", DbType="VarChar(14)")]
		public string CPF
		{
			get
			{
				return this._CPF;
			}
			set
			{
				if ((this._CPF != value))
				{
					this._CPF = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Senha", DbType="VarChar(50)")]
		public string Senha
		{
			get
			{
				return this._Senha;
			}
			set
			{
				if ((this._Senha != value))
				{
					this._Senha = value;
				}
			}
		}
	}
}
#pragma warning restore 1591