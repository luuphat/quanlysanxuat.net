﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySanXuat.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLSX")]
	public partial class KhachHangDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    #endregion
		
		public KhachHangDataContext() : 
				base(global::QuanLySanXuat.Properties.Settings.Default.QLSXConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KhachHangDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KhachHangDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KhachHangDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KhachHangDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KhachHang_add")]
		public int KhachHang_add([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenKhachHang", DbType="NVarChar(200)")] string tenKhachHang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiaChi", DbType="NVarChar(200)")] string diaChi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DienThoai", DbType="NVarChar(20)")] string dienThoai, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fax", DbType="NVarChar(20)")] string fax, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Website", DbType="NVarChar(100)")] string website, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiTao", DbType="NVarChar(20)")] string nguoiTao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tenKhachHang, diaChi, dienThoai, fax, email, website, nguoiTao);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KhachHang_update")]
		public int KhachHang_update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhachHang", DbType="Int")] System.Nullable<int> maKhachHang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenKhachHang", DbType="NVarChar(200)")] string tenKhachHang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiaChi", DbType="NVarChar(200)")] string diaChi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DienThoai", DbType="NVarChar(20)")] string dienThoai, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fax", DbType="NVarChar(20)")] string fax, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Website", DbType="NVarChar(100)")] string website)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKhachHang, tenKhachHang, diaChi, dienThoai, fax, email, website);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KhachHang_delete")]
		public int KhachHang_delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhachHang", DbType="Int")] System.Nullable<int> maKhachHang)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKhachHang);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KhachHang_getList")]
		public ISingleResult<KhachHang> KhachHang_getList([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maKhachHang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KeySearch", DbType="NVarChar(200)")] string keySearch)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKhachHang, keySearch);
			return ((ISingleResult<KhachHang>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKhachHang;
		
		private string _TenKhachHang;
		
		private string _DiaChi;
		
		private string _DienThoai;
		
		private string _Fax;
		
		private string _Email;
		
		private string _Website;
		
		private string _NguoiTao;
		
		private System.DateTime _NgayTao;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachHangChanging(int value);
    partial void OnMaKhachHangChanged();
    partial void OnTenKhachHangChanging(string value);
    partial void OnTenKhachHangChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnFaxChanging(string value);
    partial void OnFaxChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnWebsiteChanging(string value);
    partial void OnWebsiteChanged();
    partial void OnNguoiTaoChanging(string value);
    partial void OnNguoiTaoChanged();
    partial void OnNgayTaoChanging(System.DateTime value);
    partial void OnNgayTaoChanged();
    #endregion
		
		public KhachHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhachHang", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string TenKhachHang
		{
			get
			{
				return this._TenKhachHang;
			}
			set
			{
				if ((this._TenKhachHang != value))
				{
					this.OnTenKhachHangChanging(value);
					this.SendPropertyChanging();
					this._TenKhachHang = value;
					this.SendPropertyChanged("TenKhachHang");
					this.OnTenKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(200)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="NVarChar(20)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="NVarChar(20)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Website", DbType="NVarChar(100)")]
		public string Website
		{
			get
			{
				return this._Website;
			}
			set
			{
				if ((this._Website != value))
				{
					this.OnWebsiteChanging(value);
					this.SendPropertyChanging();
					this._Website = value;
					this.SendPropertyChanged("Website");
					this.OnWebsiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiTao", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string NguoiTao
		{
			get
			{
				return this._NguoiTao;
			}
			set
			{
				if ((this._NguoiTao != value))
				{
					this.OnNguoiTaoChanging(value);
					this.SendPropertyChanging();
					this._NguoiTao = value;
					this.SendPropertyChanged("NguoiTao");
					this.OnNguoiTaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTao", DbType="DateTime NOT NULL")]
		public System.DateTime NgayTao
		{
			get
			{
				return this._NgayTao;
			}
			set
			{
				if ((this._NgayTao != value))
				{
					this.OnNgayTaoChanging(value);
					this.SendPropertyChanging();
					this._NgayTao = value;
					this.SendPropertyChanged("NgayTao");
					this.OnNgayTaoChanged();
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