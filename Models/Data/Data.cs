﻿using System.Collections.Generic;

namespace PersistAssist.Models
{
    public class Data
    {
        public static string banner =
            " ______                  __       __   _______             __       __   \n" +
            "|   __ .-----.----.-----|__.-----|  |_|   _   .-----.-----|__.-----|  |_ \n" +
            "|    __|  -__|   _|__ --|  |__ --|   _|       |__ --|__ --|  |__ --|   _|\n" +
            "|___|  |_____|__| |_____|__|_____|____|___|___|_____|_____|__|_____|____|\n";

        public static string version = "v0.1";
        public static bool displayBanner = false;
        public static bool logging = false;
        public static string namedpipe = "";

        public class Lists
        {
            public static readonly List<Persist> _persist = new List<Persist>();
            public static readonly List<Tradecraft> _tradecraft = new List<Tradecraft>();
            public static readonly List<Payload> _payloads = new List<Payload>();

            public static readonly List<Persist> _persistRegistry = new List<Persist>();
            public static readonly List<Persist> _persistMSBuild = new List<Persist>();
            public static readonly List<Persist> _persistAccountOps = new List<Persist>();
            public static readonly List<Persist> _persistMisc = new List<Persist>();
        }

        public class Enums
        {
            public enum PersistType
            {
                Registry,
                MSBuild,
                AccountOperations,
                Misc
            }

            public enum RegistryContext
            {
                HKLM,
                HKCU
            }
        }

    }
}
