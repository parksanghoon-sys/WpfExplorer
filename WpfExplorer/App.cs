using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Custom.Wpf;
using Custom.Wpf.Global.Controls;

namespace WpfExplorer
{
    internal class App : CustomApplication
    {
        protected override Window CreateShell()
        {
            return new Window();
        }
    }
}
