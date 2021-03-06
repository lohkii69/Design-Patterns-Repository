﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimUDuck_Chapter_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();


            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}
