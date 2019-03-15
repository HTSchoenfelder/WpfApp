﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp.Services
{
    internal class Logger : ILogger
    {
        public void Log(string message)
        {
            MessageBox.Show(message);
        }
    }
}
