
using Microsoft.EntityFrameworkCore;
using NorthwindApp.Entity;
using NorthwindApp.Models;

namespace NorthwindApp.Context;
public class NorthwindContext : DbContext
{
    public NorthwindContext(DbContextOptions<NorthwindContext> options): base(options)
    {

    }
    
    public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();
    public DbSet<CategoryTable> CategoryTables => Set<CategoryTable>();
    
    public DbSet<ProductEntity> Products => Set<ProductEntity>();
    public DbSet<SupplierEntity> Suppliers => Set<SupplierEntity>();
    public DbSet<CustomerEntity> Customers => Set<CustomerEntity>();
    public DbSet<EmployeeEntity> Employees => Set<EmployeeEntity>();
    public DbSet<ShipperEntity> Shippers => Set<ShipperEntity>();
    public DbSet<OrderEntity> Orders => Set<OrderEntity>();
    public DbSet<OrderDetailEntity> OrderDetails => Set<OrderDetailEntity>();
}