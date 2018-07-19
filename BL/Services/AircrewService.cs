using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTOs;
using Models;
using BL.Helpers;
using Models.Remote;
using System.IO;

namespace BL.Services
{
    public sealed class AircrewService : BaseService<AircrewDto, Aircrew>, IServiceRemote
    {
        public AircrewService(IRepositoryUnit repositoryUnit)
        {
            _repository = repositoryUnit.AircrewRepository;
        }

        public async Task SynchronizeRemoteData(int count)
        {
            const string url = "http://5b128555d50a5c0014ef1204.mockapi.io/crew";

            var crews = (await RemoteDataGrabHelper
                .GrabRemoteEndpoint<Crew>(url, count))
                .ToList();

            await Task.WhenAll(
                PostRemoteCrewsToDbAsync(crews),
                WriteToCsvAsync(crews));
        }

        private async Task PostRemoteCrewsToDbAsync(IEnumerable<Crew> crews)
        {
            foreach (var crew in crews)
            {
                var stewards = crew.Stewardess.Select(steward => new StewardDto
                    {
                        Birth = steward.BirthDate,
                        Name = steward.FirstName,
                        Surname = steward.LastName
                    })
                    .ToList();

                var pilot = crew.Pilot.FirstOrDefault();

                await CreateAsync(new AircrewDto
                {
                    Pilot = new PilotDto
                    {
                        Name = pilot.FirstName,
                        Surname = pilot.LastName,
                        Birth = pilot.BirthDate,
                        Experience = pilot.Exp
                    },
                   Stewards = stewards
                });
            }
        }

        private static async Task WriteToCsvAsync(IEnumerable<Crew> crews)
        {
            var currentDate = DateTime.Now;

            try
            {
                using (var writer = new StreamWriter($"log_{currentDate.ToString($"yyyyMMdd_HHmmss")}.csv"))
                {
                    foreach (var crew in crews)
                    {
                        await writer.WriteAsync(crew.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
