﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DrozdovEntities : DbContext
    {
        public DrozdovEntities()
            : base("name=DrozdovEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Ангар { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Вакцинация { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Вес { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Заказы { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Заказы_у_поставщиков { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Зарплата_сотрудника { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Зарплаты { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Клиенты { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Корма { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Коровы { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Лекарства { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> МедКнижка { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Объём_продаж { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Операция { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Породы { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Поставщики { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Продукция { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Склад { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Сотрудники { get; set; }
        public virtual DbSet<WpfApp1.Model.DrozdovEntities> Уход_за_животными { get; set; }
    }
}
