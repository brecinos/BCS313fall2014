﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaroCoffeShop
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FaroCoffeeShop")]
	public partial class DataClassesFaroDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBill(Bill instance);
    partial void UpdateBill(Bill instance);
    partial void DeleteBill(Bill instance);
    partial void InsertClient(Client instance);
    partial void UpdateClient(Client instance);
    partial void DeleteClient(Client instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertPayment(Payment instance);
    partial void UpdatePayment(Payment instance);
    partial void DeletePayment(Payment instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertOrderx(Orderx instance);
    partial void UpdateOrderx(Orderx instance);
    partial void DeleteOrderx(Orderx instance);
    partial void InsertOrderDetail(OrderDetail instance);
    partial void UpdateOrderDetail(OrderDetail instance);
    partial void DeleteOrderDetail(OrderDetail instance);
    partial void InsertInternetSession(InternetSession instance);
    partial void UpdateInternetSession(InternetSession instance);
    partial void DeleteInternetSession(InternetSession instance);
    #endregion
		
		public DataClassesFaroDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["FaroCoffeeShopConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFaroDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFaroDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFaroDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFaroDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Bill> Bills
		{
			get
			{
				return this.GetTable<Bill>();
			}
		}
		
		public System.Data.Linq.Table<Client> Clients
		{
			get
			{
				return this.GetTable<Client>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Payment> Payments
		{
			get
			{
				return this.GetTable<Payment>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Orderx> Orderxes
		{
			get
			{
				return this.GetTable<Orderx>();
			}
		}
		
		public System.Data.Linq.Table<OrderDetail> OrderDetails
		{
			get
			{
				return this.GetTable<OrderDetail>();
			}
		}
		
		public System.Data.Linq.Table<InternetSession> InternetSessions
		{
			get
			{
				return this.GetTable<InternetSession>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bill")]
	public partial class Bill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BillId;
		
		private System.Nullable<decimal> _Amount;
		
		private System.Nullable<int> _InternetSessionId;
		
		private EntityRef<InternetSession> _InternetSession;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBillIdChanging(int value);
    partial void OnBillIdChanged();
    partial void OnAmountChanging(System.Nullable<decimal> value);
    partial void OnAmountChanged();
    partial void OnInternetSessionIdChanging(System.Nullable<int> value);
    partial void OnInternetSessionIdChanged();
    #endregion
		
		public Bill()
		{
			this._InternetSession = default(EntityRef<InternetSession>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BillId
		{
			get
			{
				return this._BillId;
			}
			set
			{
				if ((this._BillId != value))
				{
					this.OnBillIdChanging(value);
					this.SendPropertyChanging();
					this._BillId = value;
					this.SendPropertyChanged("BillId");
					this.OnBillIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InternetSessionId", DbType="Int")]
		public System.Nullable<int> InternetSessionId
		{
			get
			{
				return this._InternetSessionId;
			}
			set
			{
				if ((this._InternetSessionId != value))
				{
					if (this._InternetSession.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnInternetSessionIdChanging(value);
					this.SendPropertyChanging();
					this._InternetSessionId = value;
					this.SendPropertyChanged("InternetSessionId");
					this.OnInternetSessionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="InternetSession_Bill", Storage="_InternetSession", ThisKey="InternetSessionId", OtherKey="InternetSession1", IsForeignKey=true)]
		public InternetSession InternetSession
		{
			get
			{
				return this._InternetSession.Entity;
			}
			set
			{
				InternetSession previousValue = this._InternetSession.Entity;
				if (((previousValue != value) 
							|| (this._InternetSession.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._InternetSession.Entity = null;
						previousValue.Bills.Remove(this);
					}
					this._InternetSession.Entity = value;
					if ((value != null))
					{
						value.Bills.Add(this);
						this._InternetSessionId = value.InternetSession1;
					}
					else
					{
						this._InternetSessionId = default(Nullable<int>);
					}
					this.SendPropertyChanged("InternetSession");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client")]
	public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Idclient;
		
		private string _name;
		
		private string _email;
		
		private System.Nullable<int> _paymentId;
		
		private EntitySet<Orderx> _Orderxes;
		
		private EntityRef<Payment> _Payment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdclientChanging(int value);
    partial void OnIdclientChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpaymentIdChanging(System.Nullable<int> value);
    partial void OnpaymentIdChanged();
    #endregion
		
		public Client()
		{
			this._Orderxes = new EntitySet<Orderx>(new Action<Orderx>(this.attach_Orderxes), new Action<Orderx>(this.detach_Orderxes));
			this._Payment = default(EntityRef<Payment>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idclient", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Idclient
		{
			get
			{
				return this._Idclient;
			}
			set
			{
				if ((this._Idclient != value))
				{
					this.OnIdclientChanging(value);
					this.SendPropertyChanging();
					this._Idclient = value;
					this.SendPropertyChanged("Idclient");
					this.OnIdclientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paymentId", DbType="Int")]
		public System.Nullable<int> paymentId
		{
			get
			{
				return this._paymentId;
			}
			set
			{
				if ((this._paymentId != value))
				{
					if (this._Payment.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpaymentIdChanging(value);
					this.SendPropertyChanging();
					this._paymentId = value;
					this.SendPropertyChanged("paymentId");
					this.OnpaymentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Orderx", Storage="_Orderxes", ThisKey="Idclient", OtherKey="ClientId")]
		public EntitySet<Orderx> Orderxes
		{
			get
			{
				return this._Orderxes;
			}
			set
			{
				this._Orderxes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Payment_Client", Storage="_Payment", ThisKey="paymentId", OtherKey="PaymentId", IsForeignKey=true)]
		public Payment Payment
		{
			get
			{
				return this._Payment.Entity;
			}
			set
			{
				Payment previousValue = this._Payment.Entity;
				if (((previousValue != value) 
							|| (this._Payment.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Payment.Entity = null;
						previousValue.Clients.Remove(this);
					}
					this._Payment.Entity = value;
					if ((value != null))
					{
						value.Clients.Add(this);
						this._paymentId = value.PaymentId;
					}
					else
					{
						this._paymentId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Payment");
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
		
		private void attach_Orderxes(Orderx entity)
		{
			this.SendPropertyChanging();
			entity.Client = this;
		}
		
		private void detach_Orderxes(Orderx entity)
		{
			this.SendPropertyChanging();
			entity.Client = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdEmployee;
		
		private string _Name;
		
		private EntitySet<Orderx> _Orderxes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdEmployeeChanging(int value);
    partial void OnIdEmployeeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Employee()
		{
			this._Orderxes = new EntitySet<Orderx>(new Action<Orderx>(this.attach_Orderxes), new Action<Orderx>(this.detach_Orderxes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmployee", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdEmployee
		{
			get
			{
				return this._IdEmployee;
			}
			set
			{
				if ((this._IdEmployee != value))
				{
					this.OnIdEmployeeChanging(value);
					this.SendPropertyChanging();
					this._IdEmployee = value;
					this.SendPropertyChanged("IdEmployee");
					this.OnIdEmployeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Orderx", Storage="_Orderxes", ThisKey="IdEmployee", OtherKey="EmployeeId")]
		public EntitySet<Orderx> Orderxes
		{
			get
			{
				return this._Orderxes;
			}
			set
			{
				this._Orderxes.Assign(value);
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
		
		private void attach_Orderxes(Orderx entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_Orderxes(Orderx entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Payment")]
	public partial class Payment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PaymentId;
		
		private string _paymentMethod;
		
		private EntitySet<Client> _Clients;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPaymentIdChanging(int value);
    partial void OnPaymentIdChanged();
    partial void OnpaymentMethodChanging(string value);
    partial void OnpaymentMethodChanged();
    #endregion
		
		public Payment()
		{
			this._Clients = new EntitySet<Client>(new Action<Client>(this.attach_Clients), new Action<Client>(this.detach_Clients));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PaymentId
		{
			get
			{
				return this._PaymentId;
			}
			set
			{
				if ((this._PaymentId != value))
				{
					this.OnPaymentIdChanging(value);
					this.SendPropertyChanging();
					this._PaymentId = value;
					this.SendPropertyChanged("PaymentId");
					this.OnPaymentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paymentMethod", DbType="VarChar(50)")]
		public string paymentMethod
		{
			get
			{
				return this._paymentMethod;
			}
			set
			{
				if ((this._paymentMethod != value))
				{
					this.OnpaymentMethodChanging(value);
					this.SendPropertyChanging();
					this._paymentMethod = value;
					this.SendPropertyChanged("paymentMethod");
					this.OnpaymentMethodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Payment_Client", Storage="_Clients", ThisKey="PaymentId", OtherKey="paymentId")]
		public EntitySet<Client> Clients
		{
			get
			{
				return this._Clients;
			}
			set
			{
				this._Clients.Assign(value);
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
		
		private void attach_Clients(Client entity)
		{
			this.SendPropertyChanging();
			entity.Payment = this;
		}
		
		private void detach_Clients(Client entity)
		{
			this.SendPropertyChanging();
			entity.Payment = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductId;
		
		private string _name;
		
		private string _description;
		
		private System.Nullable<int> _price;
		
		private System.Nullable<int> _inventory;
		
		private EntitySet<OrderDetail> _OrderDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnpriceChanging(System.Nullable<int> value);
    partial void OnpriceChanged();
    partial void OninventoryChanging(System.Nullable<int> value);
    partial void OninventoryChanged();
    #endregion
		
		public Product()
		{
			this._OrderDetails = new EntitySet<OrderDetail>(new Action<OrderDetail>(this.attach_OrderDetails), new Action<OrderDetail>(this.detach_OrderDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(50)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int")]
		public System.Nullable<int> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventory", DbType="Int")]
		public System.Nullable<int> inventory
		{
			get
			{
				return this._inventory;
			}
			set
			{
				if ((this._inventory != value))
				{
					this.OninventoryChanging(value);
					this.SendPropertyChanging();
					this._inventory = value;
					this.SendPropertyChanged("inventory");
					this.OninventoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderDetail", Storage="_OrderDetails", ThisKey="ProductId", OtherKey="ProductId")]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return this._OrderDetails;
			}
			set
			{
				this._OrderDetails.Assign(value);
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
		
		private void attach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orderx")]
	public partial class Orderx : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderId;
		
		private System.Nullable<int> _ClientId;
		
		private System.Nullable<int> _EmployeeId;
		
		private string _Date;
		
		private EntitySet<OrderDetail> _OrderDetails;
		
		private EntityRef<Client> _Client;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnClientIdChanging(System.Nullable<int> value);
    partial void OnClientIdChanged();
    partial void OnEmployeeIdChanging(System.Nullable<int> value);
    partial void OnEmployeeIdChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    #endregion
		
		public Orderx()
		{
			this._OrderDetails = new EntitySet<OrderDetail>(new Action<OrderDetail>(this.attach_OrderDetails), new Action<OrderDetail>(this.detach_OrderDetails));
			this._Client = default(EntityRef<Client>);
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientId", DbType="Int")]
		public System.Nullable<int> ClientId
		{
			get
			{
				return this._ClientId;
			}
			set
			{
				if ((this._ClientId != value))
				{
					if (this._Client.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClientIdChanging(value);
					this.SendPropertyChanging();
					this._ClientId = value;
					this.SendPropertyChanged("ClientId");
					this.OnClientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int")]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="VarChar(20)")]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Orderx_OrderDetail", Storage="_OrderDetails", ThisKey="OrderId", OtherKey="OrderId")]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return this._OrderDetails;
			}
			set
			{
				this._OrderDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Orderx", Storage="_Client", ThisKey="ClientId", OtherKey="Idclient", IsForeignKey=true)]
		public Client Client
		{
			get
			{
				return this._Client.Entity;
			}
			set
			{
				Client previousValue = this._Client.Entity;
				if (((previousValue != value) 
							|| (this._Client.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Client.Entity = null;
						previousValue.Orderxes.Remove(this);
					}
					this._Client.Entity = value;
					if ((value != null))
					{
						value.Orderxes.Add(this);
						this._ClientId = value.Idclient;
					}
					else
					{
						this._ClientId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Client");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Orderx", Storage="_Employee", ThisKey="EmployeeId", OtherKey="IdEmployee", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.Orderxes.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.Orderxes.Add(this);
						this._EmployeeId = value.IdEmployee;
					}
					else
					{
						this._EmployeeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Employee");
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
		
		private void attach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Orderx = this;
		}
		
		private void detach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Orderx = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderDetail")]
	public partial class OrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderDetailId;
		
		private int _OrderId;
		
		private System.Nullable<int> _ProductId;
		
		private System.Nullable<decimal> _Subtotal;
		
		private System.Nullable<decimal> _Total;
		
		private EntityRef<Orderx> _Orderx;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderDetailIdChanging(int value);
    partial void OnOrderDetailIdChanged();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnProductIdChanging(System.Nullable<int> value);
    partial void OnProductIdChanged();
    partial void OnSubtotalChanging(System.Nullable<decimal> value);
    partial void OnSubtotalChanged();
    partial void OnTotalChanging(System.Nullable<decimal> value);
    partial void OnTotalChanged();
    #endregion
		
		public OrderDetail()
		{
			this._Orderx = default(EntityRef<Orderx>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDetailId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderDetailId
		{
			get
			{
				return this._OrderDetailId;
			}
			set
			{
				if ((this._OrderDetailId != value))
				{
					this.OnOrderDetailIdChanging(value);
					this.SendPropertyChanging();
					this._OrderDetailId = value;
					this.SendPropertyChanged("OrderDetailId");
					this.OnOrderDetailIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._Orderx.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int")]
		public System.Nullable<int> ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subtotal", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Subtotal
		{
			get
			{
				return this._Subtotal;
			}
			set
			{
				if ((this._Subtotal != value))
				{
					this.OnSubtotalChanging(value);
					this.SendPropertyChanging();
					this._Subtotal = value;
					this.SendPropertyChanged("Subtotal");
					this.OnSubtotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Decimal(10,2)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Orderx_OrderDetail", Storage="_Orderx", ThisKey="OrderId", OtherKey="OrderId", IsForeignKey=true)]
		public Orderx Orderx
		{
			get
			{
				return this._Orderx.Entity;
			}
			set
			{
				Orderx previousValue = this._Orderx.Entity;
				if (((previousValue != value) 
							|| (this._Orderx.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Orderx.Entity = null;
						previousValue.OrderDetails.Remove(this);
					}
					this._Orderx.Entity = value;
					if ((value != null))
					{
						value.OrderDetails.Add(this);
						this._OrderId = value.OrderId;
					}
					else
					{
						this._OrderId = default(int);
					}
					this.SendPropertyChanged("Orderx");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderDetail", Storage="_Product", ThisKey="ProductId", OtherKey="ProductId", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.OrderDetails.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.OrderDetails.Add(this);
						this._ProductId = value.ProductId;
					}
					else
					{
						this._ProductId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.InternetSession")]
	public partial class InternetSession : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _InternetSession1;
		
		private string _UserName;
		
		private string _system_password;
		
		private System.Nullable<int> _Time;
		
		private EntitySet<Bill> _Bills;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInternetSession1Changing(int value);
    partial void OnInternetSession1Changed();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void Onsystem_passwordChanging(string value);
    partial void Onsystem_passwordChanged();
    partial void OnTimeChanging(System.Nullable<int> value);
    partial void OnTimeChanged();
    #endregion
		
		public InternetSession()
		{
			this._Bills = new EntitySet<Bill>(new Action<Bill>(this.attach_Bills), new Action<Bill>(this.detach_Bills));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="InternetSession", Storage="_InternetSession1", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int InternetSession1
		{
			get
			{
				return this._InternetSession1;
			}
			set
			{
				if ((this._InternetSession1 != value))
				{
					this.OnInternetSession1Changing(value);
					this.SendPropertyChanging();
					this._InternetSession1 = value;
					this.SendPropertyChanged("InternetSession1");
					this.OnInternetSession1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
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
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_system_password", DbType="VarChar(50)")]
		public string system_password
		{
			get
			{
				return this._system_password;
			}
			set
			{
				if ((this._system_password != value))
				{
					this.Onsystem_passwordChanging(value);
					this.SendPropertyChanging();
					this._system_password = value;
					this.SendPropertyChanged("system_password");
					this.Onsystem_passwordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="Int")]
		public System.Nullable<int> Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="InternetSession_Bill", Storage="_Bills", ThisKey="InternetSession1", OtherKey="InternetSessionId")]
		public EntitySet<Bill> Bills
		{
			get
			{
				return this._Bills;
			}
			set
			{
				this._Bills.Assign(value);
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
		
		private void attach_Bills(Bill entity)
		{
			this.SendPropertyChanging();
			entity.InternetSession = this;
		}
		
		private void detach_Bills(Bill entity)
		{
			this.SendPropertyChanging();
			entity.InternetSession = null;
		}
	}
}
#pragma warning restore 1591
