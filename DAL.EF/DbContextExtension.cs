using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Models;

namespace DAL.EF
{
    public static class DbContextExtension
    {
        public static bool AllMigrationsApplied(this AppDbContext context)
        {
            var applied = context.GetService<IHistoryRepository>()
                .GetAppliedMigrations()
                .Select(m => m.MigrationId);

            var total = context.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);

            return !total.Except(applied).Any();
        }

        public static void EnsureSeeded(this AppDbContext context)
        {
            if (!context.Departures.Any())
            {
                context.Departures.AddRange(new List<Departure>
                {
                    new Departure
                    {
                        Flight = new Flight
                        {
                            ArrivalPlace = "Mexico",
                            ArrivalTime = new DateTime(2018, 07, 23, 8, 52, 0),
                            DeparturePlace = "Kiev",
                            DepartureTime = new DateTime(2018, 07, 22, 11, 35, 0),
                            Tickets = new List<Ticket>
                            {
                                new Ticket
                                {
                                    Price = 250
                                },
                                new Ticket
                                {
                                    Price = 250
                                },
                                new Ticket
                                {
                                    Price = 250
                                },
                                new Ticket
                                {
                                    Price = 190
                                }
                            }
                        },
                        Plane =  new Plane
                        {
                            Name = "Boing",
                            Lifetime = new TimeSpan(109800015162),
                            ReleaseDate = new DateTime(2000, 07, 26),
                            Type = new PlaneType
                            {
                                Model = "B-737",
                                Places = 148,
                                Carrying = 5
                            }
                        },
                        Aircrew = new Aircrew
                        {
                            Pilot = new Pilot
                            {
                                Birth = new DateTime(1979, 10, 30),
                                Name = "Tommy",
                                Surname = "Lloyd",
                                Experience = 12
                            },
                            Stewards = new List<Steward>
                            {
                                new Steward
                                {
                                    Birth = new DateTime(1986, 12, 24),
                                    Name = "Jhon",
                                    Surname = "Jadkins"
                                },
                                new Steward
                                {
                                    Birth = new DateTime(1987, 9, 17),
                                    Name = "Helen",
                                    Surname = "Mursini"
                                }
                            }
                        },
                        Date = new DateTime(2018, 08, 26)
                    },
                    new Departure
                    {
                        Flight = new Flight
                        {
                            ArrivalPlace = "USA",
                            ArrivalTime = new DateTime(2018, 07, 27, 6, 11, 0),
                            DeparturePlace = "Lviv",
                            DepartureTime = new DateTime(2018, 07, 26, 14, 17, 0),
                            Tickets = new List<Ticket>
                            {
                                new Ticket
                                {
                                    Price = 800
                                },
                                new Ticket
                                {
                                    Price = 950
                                }
                            }
                        },
                        Plane =  new Plane
                        {
                            Name = "Airnawt",
                            Lifetime = new TimeSpan(103500098115),
                            ReleaseDate = new DateTime(2006, 12, 10),
                            Type = new PlaneType
                            {
                                Model = "A-320",
                                Places = 90,
                                Carrying = 3
                            }
                        },
                        Aircrew = new Aircrew
                        {
                            Pilot = new Pilot
                            {
                                Birth = new DateTime(1977, 3, 12),
                                Name = "Charlie",
                                Surname = "Queens",
                                Experience = 14
                            },
                            Stewards = new List<Steward>
                            {
                                new Steward
                                {
                                    Birth = new DateTime(1984, 7, 4),
                                    Name = "Bridget",
                                    Surname = "Roberts"
                                }
                            }
                        },
                        Date = new DateTime(2018, 08, 28)
                    }
                });

                context.SaveChanges();
            }
        }
    }
}
