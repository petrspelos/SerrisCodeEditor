﻿using SCEELibs.Editor;
using SCEELibs.Modules;
using SCEELibs.Modules.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;

namespace SCEELibs
{

    [AllowForWeb]
    public sealed class SCEELibs
    {
        public SCEELibs(int id)
        {
            _currentID = id;

            _sheetManager = new SheetManager(id);
        }

        int _currentID = -1;
        public int currentID { get { return _currentID; } } 

        /* ===========
         * = MODULES =
         * ===========
         */
        Manager _modulesManager = new Manager();
        public Manager modulesManager { get { return _modulesManager; } }

        Addon _addon = new Addon();
        public Addon addon { get { return _addon; } }

        Theme _theme = new Theme();
        public Theme theme { get { return _theme; } }


        /* ==========
         * = EDITOR =
         * ==========
         */
        SheetManager _sheetManager;
        public SheetManager sheetManager { get { return _sheetManager; } }

        ConsoleManager _consoleManager = new ConsoleManager();
        public ConsoleManager consoleManager { get { return _consoleManager; } }
    }
}