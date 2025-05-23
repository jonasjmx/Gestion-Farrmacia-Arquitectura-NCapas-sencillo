﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Farmacia")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertProducto(Producto instance);
    partial void UpdateProducto(Producto instance);
    partial void DeleteProducto(Producto instance);
    partial void InsertVenta_Detalle(Venta_Detalle instance);
    partial void UpdateVenta_Detalle(Venta_Detalle instance);
    partial void DeleteVenta_Detalle(Venta_Detalle instance);
    partial void InsertFactura(Factura instance);
    partial void UpdateFactura(Factura instance);
    partial void DeleteFactura(Factura instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Datos.Properties.Settings.Default.FarmaciaConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Cliente> Cliente
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Producto> Producto
		{
			get
			{
				return this.GetTable<Producto>();
			}
		}
		
		public System.Data.Linq.Table<Venta_Detalle> Venta_Detalle
		{
			get
			{
				return this.GetTable<Venta_Detalle>();
			}
		}
		
		public System.Data.Linq.Table<Factura> Factura
		{
			get
			{
				return this.GetTable<Factura>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private string _apellido;
		
		private string _cedula;
		
		private string _direccion;
		
		private string _telefono;
		
		private string _correo;
		
		private EntitySet<Factura> _Factura;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoChanging(string value);
    partial void OnapellidoChanged();
    partial void OncedulaChanging(string value);
    partial void OncedulaChanged();
    partial void OndireccionChanging(string value);
    partial void OndireccionChanged();
    partial void OntelefonoChanging(string value);
    partial void OntelefonoChanged();
    partial void OncorreoChanging(string value);
    partial void OncorreoChanged();
    #endregion
		
		public Cliente()
		{
			this._Factura = new EntitySet<Factura>(new Action<Factura>(this.attach_Factura), new Action<Factura>(this.detach_Factura));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(50)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido", DbType="NVarChar(50)")]
		public string apellido
		{
			get
			{
				return this._apellido;
			}
			set
			{
				if ((this._apellido != value))
				{
					this.OnapellidoChanging(value);
					this.SendPropertyChanging();
					this._apellido = value;
					this.SendPropertyChanged("apellido");
					this.OnapellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedula", DbType="NVarChar(10)")]
		public string cedula
		{
			get
			{
				return this._cedula;
			}
			set
			{
				if ((this._cedula != value))
				{
					this.OncedulaChanging(value);
					this.SendPropertyChanging();
					this._cedula = value;
					this.SendPropertyChanged("cedula");
					this.OncedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direccion", DbType="NVarChar(50)")]
		public string direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				if ((this._direccion != value))
				{
					this.OndireccionChanging(value);
					this.SendPropertyChanging();
					this._direccion = value;
					this.SendPropertyChanged("direccion");
					this.OndireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="NVarChar(10)")]
		public string telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo", DbType="NVarChar(50)")]
		public string correo
		{
			get
			{
				return this._correo;
			}
			set
			{
				if ((this._correo != value))
				{
					this.OncorreoChanging(value);
					this.SendPropertyChanging();
					this._correo = value;
					this.SendPropertyChanged("correo");
					this.OncorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Factura", Storage="_Factura", ThisKey="id", OtherKey="idCliente")]
		public EntitySet<Factura> Factura
		{
			get
			{
				return this._Factura;
			}
			set
			{
				this._Factura.Assign(value);
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
		
		private void attach_Factura(Factura entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = this;
		}
		
		private void detach_Factura(Factura entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Producto")]
	public partial class Producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombreComercial;
		
		private string _nombreGenerico;
		
		private string _presentacion;
		
		private System.Nullable<decimal> _precio;
		
		private System.Nullable<int> _stock;
		
		private EntitySet<Venta_Detalle> _Venta_Detalle;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreComercialChanging(string value);
    partial void OnnombreComercialChanged();
    partial void OnnombreGenericoChanging(string value);
    partial void OnnombreGenericoChanged();
    partial void OnpresentacionChanging(string value);
    partial void OnpresentacionChanged();
    partial void OnprecioChanging(System.Nullable<decimal> value);
    partial void OnprecioChanged();
    partial void OnstockChanging(System.Nullable<int> value);
    partial void OnstockChanged();
    #endregion
		
		public Producto()
		{
			this._Venta_Detalle = new EntitySet<Venta_Detalle>(new Action<Venta_Detalle>(this.attach_Venta_Detalle), new Action<Venta_Detalle>(this.detach_Venta_Detalle));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreComercial", DbType="NVarChar(50)")]
		public string nombreComercial
		{
			get
			{
				return this._nombreComercial;
			}
			set
			{
				if ((this._nombreComercial != value))
				{
					this.OnnombreComercialChanging(value);
					this.SendPropertyChanging();
					this._nombreComercial = value;
					this.SendPropertyChanged("nombreComercial");
					this.OnnombreComercialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreGenerico", DbType="NVarChar(50)")]
		public string nombreGenerico
		{
			get
			{
				return this._nombreGenerico;
			}
			set
			{
				if ((this._nombreGenerico != value))
				{
					this.OnnombreGenericoChanging(value);
					this.SendPropertyChanging();
					this._nombreGenerico = value;
					this.SendPropertyChanged("nombreGenerico");
					this.OnnombreGenericoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_presentacion", DbType="NVarChar(50)")]
		public string presentacion
		{
			get
			{
				return this._presentacion;
			}
			set
			{
				if ((this._presentacion != value))
				{
					this.OnpresentacionChanging(value);
					this.SendPropertyChanging();
					this._presentacion = value;
					this.SendPropertyChanged("presentacion");
					this.OnpresentacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this.OnprecioChanging(value);
					this.SendPropertyChanging();
					this._precio = value;
					this.SendPropertyChanged("precio");
					this.OnprecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stock", DbType="Int")]
		public System.Nullable<int> stock
		{
			get
			{
				return this._stock;
			}
			set
			{
				if ((this._stock != value))
				{
					this.OnstockChanging(value);
					this.SendPropertyChanging();
					this._stock = value;
					this.SendPropertyChanged("stock");
					this.OnstockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_Venta_Detalle", Storage="_Venta_Detalle", ThisKey="id", OtherKey="idProducto")]
		public EntitySet<Venta_Detalle> Venta_Detalle
		{
			get
			{
				return this._Venta_Detalle;
			}
			set
			{
				this._Venta_Detalle.Assign(value);
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
		
		private void attach_Venta_Detalle(Venta_Detalle entity)
		{
			this.SendPropertyChanging();
			entity.Producto = this;
		}
		
		private void detach_Venta_Detalle(Venta_Detalle entity)
		{
			this.SendPropertyChanging();
			entity.Producto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Venta_Detalle")]
	public partial class Venta_Detalle : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _idFactura;
		
		private System.Nullable<int> _idProducto;
		
		private System.Nullable<int> _cantidad;
		
		private System.Nullable<decimal> _subtotal;
		
		private EntityRef<Producto> _Producto;
		
		private EntityRef<Factura> _Factura;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnidFacturaChanging(System.Nullable<int> value);
    partial void OnidFacturaChanged();
    partial void OnidProductoChanging(System.Nullable<int> value);
    partial void OnidProductoChanged();
    partial void OncantidadChanging(System.Nullable<int> value);
    partial void OncantidadChanged();
    partial void OnsubtotalChanging(System.Nullable<decimal> value);
    partial void OnsubtotalChanged();
    #endregion
		
		public Venta_Detalle()
		{
			this._Producto = default(EntityRef<Producto>);
			this._Factura = default(EntityRef<Factura>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idFactura", DbType="Int")]
		public System.Nullable<int> idFactura
		{
			get
			{
				return this._idFactura;
			}
			set
			{
				if ((this._idFactura != value))
				{
					if (this._Factura.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidFacturaChanging(value);
					this.SendPropertyChanging();
					this._idFactura = value;
					this.SendPropertyChanged("idFactura");
					this.OnidFacturaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProducto", DbType="Int")]
		public System.Nullable<int> idProducto
		{
			get
			{
				return this._idProducto;
			}
			set
			{
				if ((this._idProducto != value))
				{
					if (this._Producto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidProductoChanging(value);
					this.SendPropertyChanging();
					this._idProducto = value;
					this.SendPropertyChanged("idProducto");
					this.OnidProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cantidad", DbType="Int")]
		public System.Nullable<int> cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				if ((this._cantidad != value))
				{
					this.OncantidadChanging(value);
					this.SendPropertyChanging();
					this._cantidad = value;
					this.SendPropertyChanged("cantidad");
					this.OncantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subtotal", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> subtotal
		{
			get
			{
				return this._subtotal;
			}
			set
			{
				if ((this._subtotal != value))
				{
					this.OnsubtotalChanging(value);
					this.SendPropertyChanging();
					this._subtotal = value;
					this.SendPropertyChanged("subtotal");
					this.OnsubtotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_Venta_Detalle", Storage="_Producto", ThisKey="idProducto", OtherKey="id", IsForeignKey=true)]
		public Producto Producto
		{
			get
			{
				return this._Producto.Entity;
			}
			set
			{
				Producto previousValue = this._Producto.Entity;
				if (((previousValue != value) 
							|| (this._Producto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producto.Entity = null;
						previousValue.Venta_Detalle.Remove(this);
					}
					this._Producto.Entity = value;
					if ((value != null))
					{
						value.Venta_Detalle.Add(this);
						this._idProducto = value.id;
					}
					else
					{
						this._idProducto = default(Nullable<int>);
					}
					this.SendPropertyChanged("Producto");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Factura_Venta_Detalle", Storage="_Factura", ThisKey="idFactura", OtherKey="id", IsForeignKey=true)]
		public Factura Factura
		{
			get
			{
				return this._Factura.Entity;
			}
			set
			{
				Factura previousValue = this._Factura.Entity;
				if (((previousValue != value) 
							|| (this._Factura.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Factura.Entity = null;
						previousValue.Venta_Detalle.Remove(this);
					}
					this._Factura.Entity = value;
					if ((value != null))
					{
						value.Venta_Detalle.Add(this);
						this._idFactura = value.id;
					}
					else
					{
						this._idFactura = default(Nullable<int>);
					}
					this.SendPropertyChanged("Factura");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Factura")]
	public partial class Factura : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _idCliente;
		
		private System.Nullable<System.DateTime> _fechaVenta;
		
		private System.Nullable<decimal> _iva;
		
		private System.Nullable<decimal> _subtotal;
		
		private System.Nullable<decimal> _Total;
		
		private EntitySet<Venta_Detalle> _Venta_Detalle;
		
		private EntityRef<Cliente> _Cliente;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnidClienteChanging(System.Nullable<int> value);
    partial void OnidClienteChanged();
    partial void OnfechaVentaChanging(System.Nullable<System.DateTime> value);
    partial void OnfechaVentaChanged();
    partial void OnivaChanging(System.Nullable<decimal> value);
    partial void OnivaChanged();
    partial void OnsubtotalChanging(System.Nullable<decimal> value);
    partial void OnsubtotalChanged();
    partial void OnTotalChanging(System.Nullable<decimal> value);
    partial void OnTotalChanged();
    #endregion
		
		public Factura()
		{
			this._Venta_Detalle = new EntitySet<Venta_Detalle>(new Action<Venta_Detalle>(this.attach_Venta_Detalle), new Action<Venta_Detalle>(this.detach_Venta_Detalle));
			this._Cliente = default(EntityRef<Cliente>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCliente", DbType="Int")]
		public System.Nullable<int> idCliente
		{
			get
			{
				return this._idCliente;
			}
			set
			{
				if ((this._idCliente != value))
				{
					if (this._Cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidClienteChanging(value);
					this.SendPropertyChanging();
					this._idCliente = value;
					this.SendPropertyChanged("idCliente");
					this.OnidClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaVenta", DbType="DateTime")]
		public System.Nullable<System.DateTime> fechaVenta
		{
			get
			{
				return this._fechaVenta;
			}
			set
			{
				if ((this._fechaVenta != value))
				{
					this.OnfechaVentaChanging(value);
					this.SendPropertyChanging();
					this._fechaVenta = value;
					this.SendPropertyChanged("fechaVenta");
					this.OnfechaVentaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iva", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> iva
		{
			get
			{
				return this._iva;
			}
			set
			{
				if ((this._iva != value))
				{
					this.OnivaChanging(value);
					this.SendPropertyChanging();
					this._iva = value;
					this.SendPropertyChanged("iva");
					this.OnivaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subtotal", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> subtotal
		{
			get
			{
				return this._subtotal;
			}
			set
			{
				if ((this._subtotal != value))
				{
					this.OnsubtotalChanging(value);
					this.SendPropertyChanging();
					this._subtotal = value;
					this.SendPropertyChanged("subtotal");
					this.OnsubtotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Factura_Venta_Detalle", Storage="_Venta_Detalle", ThisKey="id", OtherKey="idFactura")]
		public EntitySet<Venta_Detalle> Venta_Detalle
		{
			get
			{
				return this._Venta_Detalle;
			}
			set
			{
				this._Venta_Detalle.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Factura", Storage="_Cliente", ThisKey="idCliente", OtherKey="id", IsForeignKey=true)]
		public Cliente Cliente
		{
			get
			{
				return this._Cliente.Entity;
			}
			set
			{
				Cliente previousValue = this._Cliente.Entity;
				if (((previousValue != value) 
							|| (this._Cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cliente.Entity = null;
						previousValue.Factura.Remove(this);
					}
					this._Cliente.Entity = value;
					if ((value != null))
					{
						value.Factura.Add(this);
						this._idCliente = value.id;
					}
					else
					{
						this._idCliente = default(Nullable<int>);
					}
					this.SendPropertyChanged("Cliente");
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
		
		private void attach_Venta_Detalle(Venta_Detalle entity)
		{
			this.SendPropertyChanging();
			entity.Factura = this;
		}
		
		private void detach_Venta_Detalle(Venta_Detalle entity)
		{
			this.SendPropertyChanging();
			entity.Factura = null;
		}
	}
}
#pragma warning restore 1591
