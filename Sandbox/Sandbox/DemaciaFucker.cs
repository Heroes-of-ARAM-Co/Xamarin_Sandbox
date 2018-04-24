using System.Text;
using System;
using System.Linq;

namespace Core
{
    public static class DemaciaFucker
    {
        public static string[] DemaciaCommands = { "For Demacia!","Kiss My Demacia", "Demacia!!!" };
        public static string ToBattle()
        {
            Random randomNumber = new Random();
            var randomShout = randomNumber.Next(0, DemaciaCommands.Count());
            return DemaciaCommands[randomShout];

        }
    }
}
