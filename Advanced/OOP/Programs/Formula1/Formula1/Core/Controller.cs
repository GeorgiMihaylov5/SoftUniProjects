using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Repositories;
using System;
using System.Linq;
using System.Text;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private readonly PilotRepository pilotRepository;
        private readonly RaceRepository raceRepository;
        private readonly FormulaOneCarRepository carRepository;

        public Controller()
        {
            pilotRepository = new PilotRepository();
            raceRepository = new RaceRepository();
            carRepository = new FormulaOneCarRepository();
        }
        public string AddCarToPilot(string pilotName, string carModel)
        {
            var pilot = pilotRepository.FindByName(pilotName);
            var car = carRepository.FindByName(carModel);

            if (pilot == null || pilot.Car != null)
            {
                throw new InvalidOperationException($"Pilot {pilotName} does not exist or has a car.");
            }
            else if (car == null)
            {
                throw new NullReferenceException($"Car {carModel} does not exist.");
            }
            carRepository.Remove(car);
            pilot.AddCar(car);

            return $"Pilot {pilotName} will drive a {car.GetType().Name} {car.Model} car.";
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            var race = raceRepository.FindByName(raceName);
            var pilot = pilotRepository.FindByName(pilotFullName);

            if (race == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }
            else if (pilot == null || pilot.CanRace == false || race.Pilots.Contains(pilot))
            {
                throw new InvalidOperationException($"Can not add pilot {pilotFullName} to the race.");
            }

            race.AddPilot(pilot);

            return  $"Pilot {pilotFullName} is added to the {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            var car = carRepository.FindByName(model);
            if (car == null)
            {
                if (type == nameof(Ferrari))
                {
                    carRepository.Add(new Ferrari(model, horsepower, engineDisplacement));
                }
                else if (type == nameof(Williams))
                {
                    carRepository.Add(new Williams(model, horsepower, engineDisplacement));
                }
                else
                {
                    throw new InvalidOperationException($"Formula one car type {type} is not valid.");
                }
                return $"Car {type}, model {model} is created.";
            }
            else
            {
                throw new InvalidOperationException($"Formula one car {model} is already created.");
            }
        }

        public string CreatePilot(string fullName)
        {
            var pilot = pilotRepository.FindByName(fullName);
            if (pilot == null)
            {
                pilotRepository.Add(new Pilot(fullName));
                return $"Pilot {fullName} is created.";
            }
            else
            {
                throw new InvalidOperationException($"Pilot {fullName} is already created.");
            }
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            var race = raceRepository.FindByName(raceName);
            if (race == null)
            {
                raceRepository.Add(new Race(raceName, numberOfLaps));
                return $"Race {raceName} is created.";
            }
            else
            {
                throw new InvalidOperationException($"Race {raceName} is already created.");
            }
        }

        public string PilotReport()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var pilot in pilotRepository.Models.OrderByDescending(x => x.NumberOfWins))
            {
                sb.AppendLine(pilot.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string RaceReport()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var race in raceRepository.Models.OrderBy(x => x.NumberOfLaps))
            {
                if (race.TookPlace)
                {
                    sb.AppendLine(race.RaceInfo());
                }
            }
            return sb.ToString().TrimEnd();
        }

        public string StartRace(string raceName)
        {
            var race = raceRepository.FindByName(raceName);

            if (race == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }
            else if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than three participants.");
            }
            else if (race.TookPlace)
            {
                throw new InvalidOperationException($"Can not execute race {raceName}.");
            }

            var winPilots = race.Pilots.OrderByDescending(x => x.Car.RaceScoreCalculator(race.NumberOfLaps)).Take(3).ToList();

            race.TookPlace = true;

            winPilots[0].WinRace();
            
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Pilot {winPilots[0].FullName} wins the {raceName} race.");
            sb.AppendLine($"Pilot {winPilots[1].FullName} is second in the {raceName} race.");
            sb.AppendLine($"Pilot {winPilots[2].FullName} is third in the {raceName} race.");
        
            return sb.ToString().TrimEnd();
        }
    }
}
