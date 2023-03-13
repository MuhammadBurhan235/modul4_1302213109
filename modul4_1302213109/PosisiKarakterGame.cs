using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302213109
{
    internal class PosisiKarakterGame
    {
        private State currentState;

        public PosisiKarakterGame()
        {
            currentState = new Berdiri();
        }

        public void SetState(State state)
        {
            currentState = state;
            currentState.DisplayState();
        }
    }

    interface State
    {
        void DisplayState();
    }

    class Berdiri : State
    {
        public void DisplayState()
        {
            Console.WriteLine("posisi standby");
        }
    }

    class Tengkurap : State
    {
        public void DisplayState()
        {
            Console.WriteLine("posisi istirahat");
        }
    }

    class Program_PKG
    {
        static void Main(string[] args)
        {
            PosisiKarakterGame posisi = new PosisiKarakterGame();

            // Mengubah state menjadi UnlockedState
            posisi.SetState(new Berdiri());

            // Mengubah state menjadi LockedState
            posisi.SetState(new Tengkurap());
        }
    }
}
