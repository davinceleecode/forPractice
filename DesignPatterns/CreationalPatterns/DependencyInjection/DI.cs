using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.DesignPatterns.CreationalPatterns.DependencyInjection
{
    class DI
    {
        interface IGameControls
        {
            void PowerButton();
        }



        class Nintendo : IGameControls
        {
            public void PowerButton()
            {
                Console.WriteLine("Welcome to Nintendo...");
            }
        }

        class PlayStation : IGameControls
        {
            public void PowerButton()
            {
                Console.WriteLine("Welcome PlayStation...");
            }
        }


        class Xbox : IGameControls
        {
            public void PowerButton()
            {
                Console.WriteLine("Welcome Xbox...");
            }
        }


        class GameConsole
        {
            private readonly IGameControls _gameControls;

            public GameConsole(IGameControls gameControls)
            {
                this._gameControls = gameControls;
            }

            public void Start()
            {
                this._gameControls.PowerButton();
            }

        }




        class Implementation
        {
            public void PressStart()
            {
                IGameControls xbox = new Xbox();
                IGameControls ps = new PlayStation();
                IGameControls nintendo = new Nintendo();

                var gameconsole = new GameConsole(xbox);
                var g = new GameConsole(new Xbox());
                gameconsole.Start();
            }


        }


    }
}
