﻿namespace ASM.ScreenMeterFaker.Configuration
{
    public class SMConfiguration
    {
        public bool readFromEnv { get; set; } = false;
        public string username { get; set; }
        public string password { get; set; }
        public string baseUrl { get; set; } = "https://www.screenmeter.com/api";
    }
}