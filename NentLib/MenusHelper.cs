using System;
using LeagueSharp;
using LeagueSharp.Common;
using LeagueSharp.Data;
using SharpDX;

namespace NentLib
{
    public static class MenuHelper
    {
        public static void CreateItem(this Menu m, string displayName, string uniqueID)
        {
            try
            {
                m.AddItem(new MenuItem(uniqueID, displayName).SetValue(true));
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Error creating the checkbox with the uniqueID = ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(uniqueID);
                Console.ResetColor();
            }
        }
    }
}

