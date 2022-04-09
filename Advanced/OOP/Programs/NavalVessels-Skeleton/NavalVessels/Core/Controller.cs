using NavalVessels.Core.Contracts;
using NavalVessels.Models;
using NavalVessels.Models.Contracts;
using NavalVessels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Core
{
    public class Controller : IController
    {
        private readonly VesselRepository vesselRepository;
        private readonly List<ICaptain> captains;

        public Controller()
        {
            this.captains = new List<ICaptain>();
            this.vesselRepository = new VesselRepository();
        }

        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            var captain = captains.FirstOrDefault(x => x.FullName == selectedCaptainName);
            var vessel = vesselRepository.FindByName(selectedVesselName);

            if (captain == null)
            {
                return $"Captain {selectedCaptainName} could not be found.";
            }
            else if (vessel == null)
            {
                return $"Vessel {selectedVesselName} could not be found.";
            }
            else if (captain.Vessels.Contains(vessel))
            {
                return $"Vessel {selectedVesselName} is already occupied.";
            }
            vessel.Captain = captain;
            captain.AddVessel(vessel);
            var index = captains.IndexOf(captain);
            captains[index] = captain;          

            return $"Captain {selectedCaptainName} command vessel {selectedVesselName}.";
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            var attackingVessel = vesselRepository.FindByName(attackingVesselName);
            var defendingVessel = vesselRepository.FindByName(defendingVesselName);

            if (attackingVessel == null)
            {
                return $"Vessel {attackingVesselName} could not be found.";
            }
            else if (defendingVessel == null)
            {
                return $"Vessel {defendingVesselName} could not be found.";
            }
            else if (attackingVessel.ArmorThickness == 0)
            {
                return $"Unarmored vessel {attackingVesselName} cannot attack or be attacked.";
            }
            else if (defendingVessel.ArmorThickness == 0)
            {
                return $"Unarmored vessel {defendingVesselName} cannot attack or be attacked.";
            }
            attackingVessel.Attack(defendingVessel);
            attackingVessel.Captain.IncreaseCombatExperience();
            defendingVessel.Captain.IncreaseCombatExperience();

            return $"Vessel {defendingVesselName} was attacked by vessel {attackingVesselName} - current armor thickness: {defendingVessel.ArmorThickness}.";
        }

        public string CaptainReport(string captainFullName)
        {
            return captains.FirstOrDefault(x => x.FullName == captainFullName).Report();
        }

        public string HireCaptain(string fullName)
        {
            var captain = captains.FirstOrDefault(x => x.FullName == fullName);

            if (captain == null)
            {
                captains.Add(new Captain(fullName));
                return $"Captain {fullName} is hired.";
            }
            return $"Captain {fullName} is already hired.";
        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            var vessel = vesselRepository.Models.FirstOrDefault(x => x.Name == name);
            if (vessel != null)
            {
                return $"{vesselType} vessel {name} is already manufactured.";
            }
            else if (vesselType == nameof(Battleship))
            {
                vesselRepository.Add(new Battleship(name, mainWeaponCaliber, speed));
            }
            else if (vesselType == nameof(Submarine))
            {
                vesselRepository.Add(new Submarine(name, mainWeaponCaliber, speed));
            }
            else
            {
                return "Invalid vessel type.";
            }

            return $"{vesselType} {name} is manufactured with the main weapon caliber of {mainWeaponCaliber} inches and a maximum speed of {speed} knots.";
        }

        public string ServiceVessel(string vesselName)
        {
            var vessel = vesselRepository.FindByName(vesselName);
            if (vessel == null)
            {
                return $"Vessel {vesselName} could not be found.";
            }
            vessel.RepairVessel();
            return $"Vessel {vesselName} was repaired.";
        }

        public string ToggleSpecialMode(string vesselName)
        {
            if (vesselRepository.FindByName(vesselName) is Battleship battleship)
            {
                battleship.ToggleSonarMode();
                return $"Battleship {vesselName} toggled sonar mode.";
            }
            else if (vesselRepository.FindByName(vesselName) is Submarine submarine)
            {
                submarine.ToggleSubmergeMode();
                return $"Submarine {vesselName} toggled submerge mode.";
            }
            else 
            {
                return $"Vessel {vesselName} could not be found.";
            }
        }

        public string VesselReport(string vesselName)
        {
            return vesselRepository.FindByName(vesselName).ToString();
        }
    }
}
