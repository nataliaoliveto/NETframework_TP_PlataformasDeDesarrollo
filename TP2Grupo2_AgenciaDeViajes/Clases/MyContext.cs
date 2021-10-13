﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EasyEncryption;

namespace TP2Grupo2_AgenciaDeViajes.Clases
{
    class MyContext : DbContext
    {
        // El nombre de la base es: Grupo2_TP4
        // Declaración de Entidades.
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Alojamiento> alojamientos { get; set; }
        public DbSet<Hotel> hoteles { get; set; }
        public DbSet<Cabania> cabanias { get; set; }
        public DbSet<Reserva> reservas { get; set; }
        public MyContext() { }

        // Levanta el ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Resources.ConnectionString);
        }

        // Sobrecarga del modelo. Crea la base de datos desde el código.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Usuarios.
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .HasKey(u => u.id);

            modelBuilder.Entity<Usuario>(
                usr =>
                {
                    usr.Property(u => u.DNI).HasColumnType("int");
                    usr.Property(u => u.DNI).IsRequired(true);
                    usr.Property(u => u.nombre).HasColumnType("varchar(50)");
                    usr.Property(u => u.nombre).IsRequired(true);
                    usr.Property(u => u.mail).HasColumnType("varchar(100)");
                    usr.Property(u => u.mail).IsRequired(true);
                    usr.Property(u => u.password).HasColumnType("varchar(500)");
                    usr.Property(u => u.password).IsRequired(true);
                    usr.Property(u => u.esADMIN).HasColumnType("bit");
                    usr.Property(u => u.bloqueado).HasColumnType("bit");
                });

            //  Alojamientos.            
            modelBuilder.Entity<Alojamiento>()
                .ToTable("Alojamiento")
                .HasKey(a => a.id);

            modelBuilder.Entity<Alojamiento>(
                aloj =>
                {
                    aloj.Property(a => a.aCodigo).HasColumnType("int");
                    aloj.Property(a => a.aCodigo).IsRequired(true);
                    aloj.Property(a => a.aCiudad).HasColumnType("varchar(100)");
                    aloj.Property(a => a.aCiudad).IsRequired(true);
                    aloj.Property(a => a.aBarrio).HasColumnType("varchar(100)");
                    aloj.Property(a => a.aBarrio).IsRequired(true);
                    aloj.Property(a => a.aEstrellas).HasColumnType("int");
                    aloj.Property(a => a.aEstrellas).IsRequired(true);
                    aloj.Property(a => a.aCantPersonas).HasColumnType("int");
                    aloj.Property(a => a.aCantPersonas).IsRequired(true);
                    aloj.Property(a => a.aTV).HasColumnType("bit");
                }
            );

            // Especificación de Discriminator con los valores que puede tomar.
            modelBuilder.Entity<Alojamiento>()
                .HasDiscriminator<string>("Tipo")
                    .HasValue<Hotel>("Hotel")
                    .HasValue<Cabania>("Cabania");

            // Definición de Entidad padre.
            modelBuilder.Entity<Hotel>().HasBaseType<Alojamiento>();
            modelBuilder.Entity<Cabania>().HasBaseType<Alojamiento>();

            // Reservas.
            modelBuilder.Entity<Reserva>()
                .ToTable("Reserva")
                .HasKey(r => r.id);

            modelBuilder.Entity<Reserva>(
                res =>
                {
                    res.Property(r => r.fDesde).HasColumnType("datetime");
                    res.Property(r => r.fDesde).IsRequired(true);
                    res.Property(r => r.fHasta).HasColumnType("datetime");
                    res.Property(r => r.fHasta).IsRequired(true);
                    res.Property(r => r.propiedadId).HasColumnType("int");
                    res.Property(r => r.propiedadId).IsRequired(true);
                    res.Property(r => r.personaId).HasColumnType("int");
                    res.Property(r => r.personaId).IsRequired(true);
                    res.Property(r => r.precio).HasColumnType("decimal(16,2)");
                    res.Property(r => r.precio).IsRequired(true);
                    res.Property(r => r.cantPersonas).HasColumnType("int");
                    res.Property(r => r.cantPersonas).IsRequired(true);
                });
            
            modelBuilder.Ignore<Agencia>();
            modelBuilder.Ignore<AgenciaManager>();

            #region RegionDataSeed
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    id = 1,
                    DNI = 11111111,
                    nombre = "admin",
                    mail = "admin@admin.com",
                    password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918",
                    esADMIN = true,
                    bloqueado = false
                },
                new Usuario
                {
                    id = 2,
                    DNI = 12121212,
                    nombre = "Luis",
                    mail = "luisjose@hotmail.com",
                    password = "9250e222c4c71f0c58d4c54b50a880a312e9f9fed55d5c3aa0b0e860ded99165",
                    esADMIN = false,
                    bloqueado = false
                },
                new Usuario
                {
                    id = 3,
                    DNI = 13131313,
                    nombre = "Pedro",
                    mail = "pedropablo@hotmail.com",
                    password = "9250e222c4c71f0c58d4c54b50a880a312e9f9fed55d5c3aa0b0e860ded99165",
                    esADMIN = false,
                    bloqueado = false
                },
                new Usuario
                {
                    id = 4,
                    DNI = 14141414,
                    nombre = "Leo",
                    mail = "leoparedes@hotmail.com",
                    password = "9250e222c4c71f0c58d4c54b50a880a312e9f9fed55d5c3aa0b0e860ded99165",
                    esADMIN = false,
                    bloqueado = false
                },
                new Usuario
                {
                    id = 5,
                    DNI = 22222222,
                    nombre = "Juan",
                    mail = "juanperez@hotmail.com",
                    password = "9250e222c4c71f0c58d4c54b50a880a312e9f9fed55d5c3aa0b0e860ded99165",
                    esADMIN = false,
                    bloqueado = false
                },
                new Usuario
                {
                    id = 6,
                    DNI = 33333333,
                    nombre = "Batman",
                    mail = "juancarlosbatman@hotmail.com",
                    password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918",
                    esADMIN = true,
                    bloqueado = false
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    id = 1,
                    aCodigo = 1,
                    aCiudad = "CABA",
                    aBarrio = "Palermo",
                    aEstrellas = 4,
                    aCantPersonas = 300,
                    aTV = true,
                    hPrecioxPersona = 150
                },
                new Hotel
                {
                    id = 2,
                    aCodigo = 2,
                    aCiudad = "CABA",
                    aBarrio = "Palermo",
                    aEstrellas = 5,
                    aCantPersonas = 200,
                    aTV = true,
                    hPrecioxPersona = 200
                },
                new Hotel
                {
                    id = 3,
                    aCodigo = 3,
                    aCiudad = "CABA",
                    aBarrio = "Belgrano",
                    aEstrellas = 4,
                    aCantPersonas = 200,
                    aTV = true,
                    hPrecioxPersona = 150
                },
                new Hotel
                {
                    id = 4,
                    aCodigo = 4,
                    aCiudad = "CABA",
                    aBarrio = "Retiro",
                    aEstrellas = 3,
                    aCantPersonas = 400,
                    aTV = true,
                    hPrecioxPersona = 100
                },
                new Hotel
                {
                    id = 5,
                    aCodigo = 5,
                    aCiudad = "CABA",
                    aBarrio = "San Nicolas",
                    aEstrellas = 3,
                    aCantPersonas = 350,
                    aTV = true,
                    hPrecioxPersona = 90
                }
            );

            modelBuilder.Entity<Cabania>().HasData(
                new Cabania
                {
                    id = 6,
                    aCodigo = 6,
                    aCiudad = "Cordoba",
                    aBarrio = "La Falda",
                    aEstrellas = 3,
                    aCantPersonas = 5,
                    aTV = true,
                    cPrecioxDia = 50,
                    cHabitaciones = 2,
                    cbanios = 1
                },
                new Cabania
                {
                    id = 7,
                    aCodigo = 7,
                    aCiudad = "Cordoba",
                    aBarrio = "La Falda",
                    aEstrellas = 3,
                    aCantPersonas = 10,
                    aTV = true,
                    cPrecioxDia = 50,
                    cHabitaciones = 4,
                    cbanios = 1
                },
                new Cabania
                {
                    id = 8,
                    aCodigo = 8,
                    aCiudad = "Cordoba",
                    aBarrio = "Mina Clavero",
                    aEstrellas = 2,
                    aCantPersonas = 6,
                    aTV = false,
                    cPrecioxDia = 30,
                    cHabitaciones = 4,
                    cbanios = 2
                },
                new Cabania
                {
                    id = 9,
                    aCodigo = 9,
                    aCiudad = "Cordoba",
                    aBarrio = "Mina Clavero",
                    aEstrellas = 2,
                    aCantPersonas = 8,
                    aTV = true,
                    cPrecioxDia = 35,
                    cHabitaciones = 3,
                    cbanios = 2
                },
                new Cabania
                {
                    id = 10,
                    aCodigo = 10,
                    aCiudad = "Cordoba",
                    aBarrio = "Nono",
                    aEstrellas = 2,
                    aCantPersonas = 4,
                    aTV = false,
                    cPrecioxDia = 55,
                    cHabitaciones = 1,
                    cbanios = 1,
                }
            );

            modelBuilder.Entity<Reserva>().HasData(
                new Reserva
                {
                    id = 1,
                    fDesde = Convert.ToDateTime("2021-12-09 00:00:00.000"),
                    fHasta = Convert.ToDateTime("2021-12-15 00:00:00.000"),
                    precio = 4200,
                    cantPersonas = 3,
                    propiedadId = 2,
                    personaId = 5
                },
                new Reserva
                {
                    id = 2,
                    fDesde = Convert.ToDateTime("2021-11-25 00:00:00.000"),
                    fHasta = Convert.ToDateTime("2021-11-30 00:00:00.000"),
                    precio = 2160,
                    cantPersonas = 4,
                    propiedadId = 5,
                    personaId = 2
                },
                new Reserva
                {
                    id = 3,
                    fDesde = Convert.ToDateTime("2021-10-25 00:00:00.000"),
                    fHasta = Convert.ToDateTime("2021-10-30 00:00:00.000"),
                    precio = 300,
                    cantPersonas = 2,
                    propiedadId = 6,
                    personaId = 3
                },
                new Reserva
                {
                    id = 4,
                    fDesde = Convert.ToDateTime("2021-10-20 00:00:00.000"),
                    fHasta = Convert.ToDateTime("2021-10-30 00:00:00.000"),
                    precio = 4950,
                    cantPersonas = 5,
                    propiedadId = 5, 
                    personaId = 4
                },
                new Reserva
                {
                    id = 5,
                    fDesde = Convert.ToDateTime("2021-10-20 00:00:00.000"),
                    fHasta = Convert.ToDateTime("2021-10-30 00:00:00.000"),
                    precio = 4400,
                    cantPersonas = 2,
                    propiedadId = 2,
                    personaId = 5
                },
                new Reserva
                {
                    id = 6,
                    fDesde = Convert.ToDateTime("2021-12-20 00:00:00.000"),
                    fHasta = Convert.ToDateTime("2021-12-30 00:00:00.000"),
                    precio = 6600,
                    cantPersonas = 3,
                    propiedadId = 2,
                    personaId = 2
                },
                new Reserva
                {
                    id = 7,
                    fDesde = Convert.ToDateTime("2021-09-02 00:00:00.000"),
                    fHasta = Convert.ToDateTime("2021-10-02 00:00:00.000"),
                    precio = 930,
                    cantPersonas = 3,
                    propiedadId = 8,
                    personaId = 4
                }
            );
            #endregion
        }
    }
}
