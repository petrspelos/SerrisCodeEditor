﻿using Windows.ApplicationModel;

namespace SCEELibs
{

    [Windows.Foundation.Metadata.AllowForWeb]
    public static class SCEInfos
    {
        //SCE Version information
        public static string versionName { get => "Marne-la-Vallée (1.0)"; }
        public static string versionNumber { get => "2.0"; }
        public static bool preReleaseVersion { get => false; }

        //https://stackoverflow.com/questions/28635208/retrieve-the-current-app-version-from-package
        public static string getBuildVersion()
        {
            PackageVersion version = Package.Current.Id.Version;
            return string.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
        }


        /*History: 
         * Marne-la-Vallée ("2.0")
         * 
         * Marne-la-Vallée build ("1.6")
         * Val d'Europe build ("1.5")
         * Torcy build ("1.4")
         * Bry sur Marne build ("1.3")
         * Neuilly Plaisance build ("1.2")
         * Val de Fontenay build ("1.1")
         * Vincennes build ("1.0")
        */
    }

}
