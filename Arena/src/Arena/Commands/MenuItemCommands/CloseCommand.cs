﻿using System.Windows;
using Common.Utilities;

namespace Arena.Commands.MenuItemCommands
{
    class CloseCommand : CommandBase
    {
        public override void Execute(object parameter = null)
        {
            Application.Current.Shutdown();
        }
    }
}
