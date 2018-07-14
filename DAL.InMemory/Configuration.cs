using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Models;

namespace DAL.InMemory
{
    internal static class Configuration
    {

        public static void Seed(AppContext context)
        {
            context.Stewards = new List<Steward>
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
                },
                new Steward
                {
                    Birth = new DateTime(1984, 7, 4),
                    Name = "Bridget",
                    Surname = "Roberts"
                }
            };

            context.Pilots = new List<Pilot>
            {
                new Pilot
                {
                    Birth = new DateTime(1979, 10, 30),
                    Name = "Tommy",
                    Surname = "Lloyd",
                    Experience = 12
                },
                new Pilot
                {
                    Birth = new DateTime(1977, 3, 12),
                    Name = "Charlie",
                    Surname = "Queens",
                    Experience = 14
                },
                new Pilot
                {
                    Birth = new DateTime(1980, 6, 14),
                    Name = "Dani",
                    Surname = "Bilissi",
                    Experience = 7
                }
            };

            context.Aircrews = new List<Aircrew>
            {
                new Aircrew
                {
                    Pilot = context.Pilots.First(),
                    Stewards = context.Stewards.Take(2)
                },
                new Aircrew
                {
                    Pilot = context.Pilots.ElementAt(1),
                    Stewards = context.Stewards.Take(3)
                },
                new Aircrew
                {
                    Pilot = context.Pilots.ElementAt(2),
                    Stewards = context.Stewards.Take(1)
                }
            };

            context.Tickets = new List<Ticket>
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
                },
                new Ticket
                {
                    Price = 800
                },
                new Ticket
                {
                    Price = 950
                }
            };

            context.Flights = new List<Flight>
            {
               new Flight
                {
                    ArrivalPlace = "Mexico",
                    ArrivalTime = new DateTime(2018, 07, 23, 8, 52, 0),
                    DeparturePlace = "Kiev",
                    DepartureTime = new DateTime(2018, 07, 22, 11, 35, 0),
                    Tickets = context.Tickets.Where(t => t.Price < 300)
                },
                new Flight
                {
                    ArrivalPlace = "USA",
                    ArrivalTime = new DateTime(2018, 07, 27, 6, 11, 0),
                    DeparturePlace = "Lviv",
                    DepartureTime = new DateTime(2018, 07, 26, 14, 17, 0),
                    Tickets = context.Tickets.Where(t => t.Price > 700)
                }
            };

            context.PlaneTypes = new List<PlaneType>
            {
                new PlaneType
                {
                    Model = "B-737",
                    Places = 148,
                    Carrying = 5
                },
                new PlaneType
                {
                    Model = "A-320",
                    Places = 90,
                    Carrying = 3
                }
            };

            context.Planes = new List<Plane>
            {
                new Plane
                {
                    Name = "Boing",
                    Lifetime = new TimeSpan(10000,0, 0, 0),
                    ReleaseDate = new DateTime(2000, 07, 26, 0, 0, 0),
                    Type = context.PlaneTypes.FirstOrDefault(t => t.Model == "B-737")
                },
                new Plane
                {
                    Name = "Airnawt",
                    Lifetime = new TimeSpan(8000,0, 0, 0),
                    ReleaseDate = new DateTime(2006, 12, 10, 0, 0, 0),
                    Type = context.PlaneTypes.FirstOrDefault(t => t.Model == "A-320")
                }
            };

            context.Departures = new List<Departure>
            {
                new Departure
                {
                    FlightId = context.Flights.First(f => f.ArrivalPlace == "Mexico").Id,
                    Plane = context.Planes.FirstOrDefault(p => p.Name == "Boing"),
                    Aircrew = context.Aircrews.ElementAt(0),
                    Date = new DateTime(2018, 08, 26, 0, 0, 0)
                },
                new Departure
                {
                    FlightId = context.Flights.First(f => f.ArrivalPlace == "USA").Id,
                    Plane = context.Planes.FirstOrDefault(p => p.Name == "Airnawt"),
                    Aircrew = context.Aircrews.ElementAt(1),
                    Date = new DateTime(2018, 08, 28, 0, 0, 0)
                }
            };
        }
    }
}
