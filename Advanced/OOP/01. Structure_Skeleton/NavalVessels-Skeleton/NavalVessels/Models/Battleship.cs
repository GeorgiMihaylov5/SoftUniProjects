using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Battleship : Vessel, IBattleship
    {
        public Battleship(string name, double mainWeaponCaliber, 
            double speed)
            : base( name, mainWeaponCaliber,  speed, 300)
        {
            this.SonarMode = false;
        }
        public bool SonarMode { get; private set; }

        public void ToggleSonarMode()
        {
            if (!this.SonarMode)
            {
                this.MainWeaponCaliber += 40;
                this.Speed -= 5;
                this.SonarMode = true;
            }
            else
            {
                this.MainWeaponCaliber -= 40;
                this.Speed += 5;
                this.SonarMode = false;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            string m = this.SonarMode ? "ON" : "OFF";
            sb.AppendLine($" *Sonar mode: {m}");

            return sb.ToString().TrimEnd();
        }
    }
}
