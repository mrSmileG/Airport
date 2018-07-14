using System;
using AutoMapper;
using DTOs;
using Models;

namespace BL
{
    internal class AutoMapperConfigurator
    {
        private static bool _isConfigured;

        public static void Configure()
        {
            if (!_isConfigured)
            {
                Mapper.Initialize(MapperConfig);
                _isConfigured = true;
            }
        }

        private static void MapperConfig(IMapperConfigurationExpression config)
        {
            AircrewConfigurator(config);
            DepartureConfigurator(config);
            FlightConfigurator(config);
            PilotConfigurator(config);
            PlaneConfigurator(config);
            PlaneTypeConfigurator(config);
            StewardConfigurator(config);
            TicketConfigurator(config);
        }

        private static void AircrewConfigurator(IProfileExpression config)
        {
            config.CreateMap<Aircrew, AircrewDto>();
            config.CreateMap<AircrewDto, Aircrew>();
        }

        private static void DepartureConfigurator(IProfileExpression config)
        {
            config.CreateMap<Departure, DepartureDto>();
            config.CreateMap<DepartureDto, Departure>();
        }

        private static void FlightConfigurator(IProfileExpression config)
        {
            config.CreateMap<Flight, FlightDto>();
            config.CreateMap<FlightDto, Flight>();
        }

        private static void PilotConfigurator(IProfileExpression config)
        {
            config.CreateMap<Pilot, PilotDto>();
            config.CreateMap<PilotDto, Pilot>();
        }

        private static void PlaneConfigurator(IProfileExpression config)
        {
            config.CreateMap<Plane, PlaneDto>();
            config.CreateMap<PlaneDto, Plane>();
        }

        private static void PlaneTypeConfigurator(IProfileExpression config)
        {
            config.CreateMap<PlaneType, PlaneTypeDto>();
            config.CreateMap<PlaneTypeDto, PlaneType>();
        }

        private static void StewardConfigurator(IProfileExpression config)
        {
            config.CreateMap<Steward, StewardDto>();
            config.CreateMap<StewardDto, Steward>();
        }

        private static void TicketConfigurator(IProfileExpression config)
        {
            config.CreateMap<Ticket, TicketDto>();
            config.CreateMap<TicketDto, Ticket>();
        }
    }
}
