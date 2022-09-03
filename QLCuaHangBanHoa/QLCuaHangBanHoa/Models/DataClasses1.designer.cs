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

namespace QLCuaHangBanHoa.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLCuaHangBanHoa")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCTHOADON(CTHOADON instance);
    partial void UpdateCTHOADON(CTHOADON instance);
    partial void DeleteCTHOADON(CTHOADON instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    partial void InsertHOADON(HOADON instance);
    partial void UpdateHOADON(HOADON instance);
    partial void DeleteHOADON(HOADON instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertLOAISP(LOAISP instance);
    partial void UpdateLOAISP(LOAISP instance);
    partial void DeleteLOAISP(LOAISP instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLCuaHangBanHoaConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CTHOADON> CTHOADONs
		{
			get
			{
				return this.GetTable<CTHOADON>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<HOADON> HOADONs
		{
			get
			{
				return this.GetTable<HOADON>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<LOAISP> LOAISPs
		{
			get
			{
				return this.GetTable<LOAISP>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTHOADON")]
	public partial class CTHOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maHD;
		
		private string _maSP;
		
		private System.Nullable<int> _soLuong;
		
		private System.Nullable<decimal> _donGia;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
		private EntityRef<HOADON> _HOADON;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaHDChanging(int value);
    partial void OnmaHDChanged();
    partial void OnmaSPChanging(string value);
    partial void OnmaSPChanged();
    partial void OnsoLuongChanging(System.Nullable<int> value);
    partial void OnsoLuongChanged();
    partial void OndonGiaChanging(System.Nullable<decimal> value);
    partial void OndonGiaChanged();
    #endregion
		
		public CTHOADON()
		{
			this._SANPHAM = default(EntityRef<SANPHAM>);
			this._HOADON = default(EntityRef<HOADON>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maHD", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int maHD
		{
			get
			{
				return this._maHD;
			}
			set
			{
				if ((this._maHD != value))
				{
					if (this._HOADON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaHDChanging(value);
					this.SendPropertyChanging();
					this._maHD = value;
					this.SendPropertyChanged("maHD");
					this.OnmaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maSP", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maSP
		{
			get
			{
				return this._maSP;
			}
			set
			{
				if ((this._maSP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaSPChanging(value);
					this.SendPropertyChanging();
					this._maSP = value;
					this.SendPropertyChanged("maSP");
					this.OnmaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soLuong", DbType="Int")]
		public System.Nullable<int> soLuong
		{
			get
			{
				return this._soLuong;
			}
			set
			{
				if ((this._soLuong != value))
				{
					this.OnsoLuongChanging(value);
					this.SendPropertyChanging();
					this._soLuong = value;
					this.SendPropertyChanged("soLuong");
					this.OnsoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_donGia", DbType="Money")]
		public System.Nullable<decimal> donGia
		{
			get
			{
				return this._donGia;
			}
			set
			{
				if ((this._donGia != value))
				{
					this.OndonGiaChanging(value);
					this.SendPropertyChanging();
					this._donGia = value;
					this.SendPropertyChanged("donGia");
					this.OndonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CTHOADON", Storage="_SANPHAM", ThisKey="maSP", OtherKey="maSP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.CTHOADONs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.CTHOADONs.Add(this);
						this._maSP = value.maSP;
					}
					else
					{
						this._maSP = default(string);
					}
					this.SendPropertyChanged("SANPHAM");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CTHOADON", Storage="_HOADON", ThisKey="maHD", OtherKey="maHD", IsForeignKey=true)]
		public HOADON HOADON
		{
			get
			{
				return this._HOADON.Entity;
			}
			set
			{
				HOADON previousValue = this._HOADON.Entity;
				if (((previousValue != value) 
							|| (this._HOADON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HOADON.Entity = null;
						previousValue.CTHOADONs.Remove(this);
					}
					this._HOADON.Entity = value;
					if ((value != null))
					{
						value.CTHOADONs.Add(this);
						this._maHD = value.maHD;
					}
					else
					{
						this._maHD = default(int);
					}
					this.SendPropertyChanged("HOADON");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maSP;
		
		private string _tenSP;
		
		private string _maLSP;
		
		private System.Nullable<int> _sLTon;
		
		private System.Nullable<decimal> _donGia;
		
		private string _hinhAnh;
		
		private string _moTa;
		
		private EntitySet<CTHOADON> _CTHOADONs;
		
		private EntityRef<LOAISP> _LOAISP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaSPChanging(string value);
    partial void OnmaSPChanged();
    partial void OntenSPChanging(string value);
    partial void OntenSPChanged();
    partial void OnmaLSPChanging(string value);
    partial void OnmaLSPChanged();
    partial void OnsLTonChanging(System.Nullable<int> value);
    partial void OnsLTonChanged();
    partial void OndonGiaChanging(System.Nullable<decimal> value);
    partial void OndonGiaChanged();
    partial void OnhinhAnhChanging(string value);
    partial void OnhinhAnhChanged();
    partial void OnmoTaChanging(string value);
    partial void OnmoTaChanged();
    #endregion
		
		public SANPHAM()
		{
			this._CTHOADONs = new EntitySet<CTHOADON>(new Action<CTHOADON>(this.attach_CTHOADONs), new Action<CTHOADON>(this.detach_CTHOADONs));
			this._LOAISP = default(EntityRef<LOAISP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maSP", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maSP
		{
			get
			{
				return this._maSP;
			}
			set
			{
				if ((this._maSP != value))
				{
					this.OnmaSPChanging(value);
					this.SendPropertyChanging();
					this._maSP = value;
					this.SendPropertyChanged("maSP");
					this.OnmaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenSP", DbType="NVarChar(100)")]
		public string tenSP
		{
			get
			{
				return this._tenSP;
			}
			set
			{
				if ((this._tenSP != value))
				{
					this.OntenSPChanging(value);
					this.SendPropertyChanging();
					this._tenSP = value;
					this.SendPropertyChanged("tenSP");
					this.OntenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maLSP", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string maLSP
		{
			get
			{
				return this._maLSP;
			}
			set
			{
				if ((this._maLSP != value))
				{
					if (this._LOAISP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaLSPChanging(value);
					this.SendPropertyChanging();
					this._maLSP = value;
					this.SendPropertyChanged("maLSP");
					this.OnmaLSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sLTon", DbType="Int")]
		public System.Nullable<int> sLTon
		{
			get
			{
				return this._sLTon;
			}
			set
			{
				if ((this._sLTon != value))
				{
					this.OnsLTonChanging(value);
					this.SendPropertyChanging();
					this._sLTon = value;
					this.SendPropertyChanged("sLTon");
					this.OnsLTonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_donGia", DbType="Money")]
		public System.Nullable<decimal> donGia
		{
			get
			{
				return this._donGia;
			}
			set
			{
				if ((this._donGia != value))
				{
					this.OndonGiaChanging(value);
					this.SendPropertyChanging();
					this._donGia = value;
					this.SendPropertyChanged("donGia");
					this.OndonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinhAnh", DbType="VarChar(50)")]
		public string hinhAnh
		{
			get
			{
				return this._hinhAnh;
			}
			set
			{
				if ((this._hinhAnh != value))
				{
					this.OnhinhAnhChanging(value);
					this.SendPropertyChanging();
					this._hinhAnh = value;
					this.SendPropertyChanged("hinhAnh");
					this.OnhinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_moTa", DbType="NVarChar(500)")]
		public string moTa
		{
			get
			{
				return this._moTa;
			}
			set
			{
				if ((this._moTa != value))
				{
					this.OnmoTaChanging(value);
					this.SendPropertyChanging();
					this._moTa = value;
					this.SendPropertyChanged("moTa");
					this.OnmoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CTHOADON", Storage="_CTHOADONs", ThisKey="maSP", OtherKey="maSP")]
		public EntitySet<CTHOADON> CTHOADONs
		{
			get
			{
				return this._CTHOADONs;
			}
			set
			{
				this._CTHOADONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISP_SANPHAM", Storage="_LOAISP", ThisKey="maLSP", OtherKey="maLSP", IsForeignKey=true)]
		public LOAISP LOAISP
		{
			get
			{
				return this._LOAISP.Entity;
			}
			set
			{
				LOAISP previousValue = this._LOAISP.Entity;
				if (((previousValue != value) 
							|| (this._LOAISP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAISP.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._LOAISP.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._maLSP = value.maLSP;
					}
					else
					{
						this._maLSP = default(string);
					}
					this.SendPropertyChanged("LOAISP");
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
		
		private void attach_CTHOADONs(CTHOADON entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_CTHOADONs(CTHOADON entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADON")]
	public partial class HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maHD;
		
		private string _userName;
		
		private System.Nullable<System.DateTime> _ngayDat;
		
		private System.Nullable<System.DateTime> _ngayGiao;
		
		private string _trangThai;
		
		private EntitySet<CTHOADON> _CTHOADONs;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaHDChanging(int value);
    partial void OnmaHDChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void OnngayDatChanging(System.Nullable<System.DateTime> value);
    partial void OnngayDatChanged();
    partial void OnngayGiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnngayGiaoChanged();
    partial void OntrangThaiChanging(string value);
    partial void OntrangThaiChanged();
    #endregion
		
		public HOADON()
		{
			this._CTHOADONs = new EntitySet<CTHOADON>(new Action<CTHOADON>(this.attach_CTHOADONs), new Action<CTHOADON>(this.detach_CTHOADONs));
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int maHD
		{
			get
			{
				return this._maHD;
			}
			set
			{
				if ((this._maHD != value))
				{
					this.OnmaHDChanging(value);
					this.SendPropertyChanging();
					this._maHD = value;
					this.SendPropertyChanged("maHD");
					this.OnmaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("userName");
					this.OnuserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDat", DbType="Date")]
		public System.Nullable<System.DateTime> ngayDat
		{
			get
			{
				return this._ngayDat;
			}
			set
			{
				if ((this._ngayDat != value))
				{
					this.OnngayDatChanging(value);
					this.SendPropertyChanging();
					this._ngayDat = value;
					this.SendPropertyChanged("ngayDat");
					this.OnngayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayGiao", DbType="Date")]
		public System.Nullable<System.DateTime> ngayGiao
		{
			get
			{
				return this._ngayGiao;
			}
			set
			{
				if ((this._ngayGiao != value))
				{
					this.OnngayGiaoChanging(value);
					this.SendPropertyChanging();
					this._ngayGiao = value;
					this.SendPropertyChanged("ngayGiao");
					this.OnngayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trangThai", DbType="NVarChar(100)")]
		public string trangThai
		{
			get
			{
				return this._trangThai;
			}
			set
			{
				if ((this._trangThai != value))
				{
					this.OntrangThaiChanging(value);
					this.SendPropertyChanging();
					this._trangThai = value;
					this.SendPropertyChanged("trangThai");
					this.OntrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CTHOADON", Storage="_CTHOADONs", ThisKey="maHD", OtherKey="maHD")]
		public EntitySet<CTHOADON> CTHOADONs
		{
			get
			{
				return this._CTHOADONs;
			}
			set
			{
				this._CTHOADONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_HOADON", Storage="_KHACHHANG", ThisKey="userName", OtherKey="userName", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._userName = value.userName;
					}
					else
					{
						this._userName = default(string);
					}
					this.SendPropertyChanged("KHACHHANG");
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
		
		private void attach_CTHOADONs(CTHOADON entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = this;
		}
		
		private void detach_CTHOADONs(CTHOADON entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _userName;
		
		private string _pass;
		
		private string _tenKH;
		
		private string _diaChi;
		
		private string _sDT;
		
		private string _email;
		
		private string _gioiTinh;
		
		private System.Nullable<System.DateTime> _ngaySinh;
		
		private EntitySet<HOADON> _HOADONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OntenKHChanging(string value);
    partial void OntenKHChanged();
    partial void OndiaChiChanging(string value);
    partial void OndiaChiChanged();
    partial void OnsDTChanging(string value);
    partial void OnsDTChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OngioiTinhChanging(string value);
    partial void OngioiTinhChanged();
    partial void OnngaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnngaySinhChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this.OnuserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("userName");
					this.OnuserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenKH", DbType="NVarChar(100)")]
		public string tenKH
		{
			get
			{
				return this._tenKH;
			}
			set
			{
				if ((this._tenKH != value))
				{
					this.OntenKHChanging(value);
					this.SendPropertyChanging();
					this._tenKH = value;
					this.SendPropertyChanged("tenKH");
					this.OntenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diaChi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string diaChi
		{
			get
			{
				return this._diaChi;
			}
			set
			{
				if ((this._diaChi != value))
				{
					this.OndiaChiChanging(value);
					this.SendPropertyChanging();
					this._diaChi = value;
					this.SendPropertyChanged("diaChi");
					this.OndiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sDT", DbType="VarChar(10)")]
		public string sDT
		{
			get
			{
				return this._sDT;
			}
			set
			{
				if ((this._sDT != value))
				{
					this.OnsDTChanging(value);
					this.SendPropertyChanging();
					this._sDT = value;
					this.SendPropertyChanged("sDT");
					this.OnsDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(100)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioiTinh", DbType="NVarChar(3)")]
		public string gioiTinh
		{
			get
			{
				return this._gioiTinh;
			}
			set
			{
				if ((this._gioiTinh != value))
				{
					this.OngioiTinhChanging(value);
					this.SendPropertyChanging();
					this._gioiTinh = value;
					this.SendPropertyChanged("gioiTinh");
					this.OngioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> ngaySinh
		{
			get
			{
				return this._ngaySinh;
			}
			set
			{
				if ((this._ngaySinh != value))
				{
					this.OnngaySinhChanging(value);
					this.SendPropertyChanging();
					this._ngaySinh = value;
					this.SendPropertyChanged("ngaySinh");
					this.OnngaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_HOADON", Storage="_HOADONs", ThisKey="userName", OtherKey="userName")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
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
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAISP")]
	public partial class LOAISP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maLSP;
		
		private string _tenLSP;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaLSPChanging(string value);
    partial void OnmaLSPChanged();
    partial void OntenLSPChanging(string value);
    partial void OntenLSPChanged();
    #endregion
		
		public LOAISP()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maLSP", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maLSP
		{
			get
			{
				return this._maLSP;
			}
			set
			{
				if ((this._maLSP != value))
				{
					this.OnmaLSPChanging(value);
					this.SendPropertyChanging();
					this._maLSP = value;
					this.SendPropertyChanged("maLSP");
					this.OnmaLSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenLSP", DbType="NVarChar(100)")]
		public string tenLSP
		{
			get
			{
				return this._tenLSP;
			}
			set
			{
				if ((this._tenLSP != value))
				{
					this.OntenLSPChanging(value);
					this.SendPropertyChanging();
					this._tenLSP = value;
					this.SendPropertyChanged("tenLSP");
					this.OntenLSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISP_SANPHAM", Storage="_SANPHAMs", ThisKey="maLSP", OtherKey="maLSP")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISP = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISP = null;
		}
	}
}
#pragma warning restore 1591