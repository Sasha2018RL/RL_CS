﻿using System;

namespace tasks
{
    public class Helper
    {
        private static int parseInt(string str)
        {
            return Convert.ToInt32(str);
        }

        public static int readInt(string prompt)
        {
            try
            {
                Console.Write(prompt+": "); 
                return parseInt(Console.ReadLine());
            }
            catch (Exception e)
            {
                return readInt(prompt);
            }
            
        }
    }
}