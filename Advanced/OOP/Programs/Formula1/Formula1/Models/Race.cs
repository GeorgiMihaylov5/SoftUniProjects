﻿using Formula1.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Race : IRace
    {
        private string raceName;
        private int numberOfLaps;

        public Race(string raceName, int numberOfLaps)
        {
            RaceName = raceName;
            NumberOfLaps = numberOfLaps;
            TookPlace = false;
            Pilots = new List<IPilot>();
        }

        public string RaceName
        {
            get => raceName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid race name: {value}.");
                }
                raceName = value;
            }
        }

        public int NumberOfLaps 
        { 
            get => numberOfLaps; 
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException($"Invalid lap numbers: {value}.");
                }
                numberOfLaps = value;
            }
        }

        public bool TookPlace { get; set; }

        public ICollection<IPilot> Pilots { get; }

        public void AddPilot(IPilot pilot)
        {
            Pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The {RaceName} race has:");
            sb.AppendLine($"Participants: {Pilots.Count}");
            sb.AppendLine($"Number of laps: {NumberOfLaps}");
            string tookPlace = TookPlace ? "Yes" : "No";
            sb.AppendLine($"Took place: {tookPlace}");

            return sb.ToString().TrimEnd();
        }
    }
}
