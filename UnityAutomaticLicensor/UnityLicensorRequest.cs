﻿namespace UnityAutomaticLicensor
{
    public class UnityLicensorRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string UnityExecutablePath { get; internal set; }
    }
}