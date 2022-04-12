using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPattern.State
{
    public interface State
    {
        void ExecuteCommand(Player player);
    }
    public class HealthyState : State
    {
        public void ExecuteCommand(Player player)
        {
            Console.WriteLine("The player is in Healthy State.");
        }
    }
    public class HurtState : State
    {
        public void ExecuteCommand(Player player)
        {
            Console.WriteLine("The player is wounded. Please search health points");
        }
    }
    public class DeadState : State
    {
        public void ExecuteCommand(Player player)
        {
            Console.WriteLine("The player is dead. Game Over.");
        }
    }
    public class Player
    {
        State currentState;

        public Player()
        {
            this.currentState = new HealthyState();
        }

        public void Bullethit(int bullets)
        {
            Console.WriteLine("Bullets hits to the player: " + bullets);
            if (bullets < 5)
                this.currentState = new HealthyState();
            if (bullets >= 5 && bullets < 10)
                this.currentState = new HurtState();
            if (bullets >= 10)
                this.currentState = new DeadState();

            currentState.ExecuteCommand(this);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Player player = new Player();
                player.Bullethit(3);
                player.Bullethit(9);
                player.Bullethit(12);

                Console.ReadLine();
            }
        }
    }
}
