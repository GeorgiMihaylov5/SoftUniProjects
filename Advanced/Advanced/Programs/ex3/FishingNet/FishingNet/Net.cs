using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public Net(string material, int capacity)
        {
            this.Material = material;
            this.Capacity = capacity;
            this.Fish = new List<Fish>();
        }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public List<Fish> Fish { get; set; }

        public int Count => this.Fish.Count;

        public string AddFish(Fish fish)
        {
            if (this.Fish.Count == Capacity)
            {
                return "Fishing net is full.";
            }
            if (string.IsNullOrWhiteSpace(fish.FishType) || fish.Length <= 0 || fish.Weight <= 0)
            {
                return "Invalid fish.";
            }

            Fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }
        public bool ReleaseFish(double weight)
        {
            var fish = Fish.FirstOrDefault(x => x.Weight == weight);

            if (fish != null)
            {
                Fish.Remove(fish);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Fish GetFish(string fishType)
        {
            var fish = Fish.FirstOrDefault(x => x.FishType == fishType);
            return fish;
        }
        public Fish GetBiggestFish()
        {
            double longest = 0;
            Fish biggestFish = null;

            foreach (var item in Fish)
            {
                if (item.Length > longest)
                {
                    longest = item.Length;
                    biggestFish = item;
                }
            }
            return biggestFish;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

           sb.AppendLine($"Into the {this.Material}:");

            foreach (var item in Fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
