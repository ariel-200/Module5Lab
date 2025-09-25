using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5
{
    internal class Player
    {
        // Create variables for the class attributes
        private string name;
        private int score;
        private int livesLeft;

        // three contructors

        // First constructor creates a Player object without setting the values
        public Player()
        {

        } // end 1st constructor

        // Second Constructor
        public Player(string name)
        {
            // set the value fo the attribute
            this.name = name;
        } // end second constructor

        // Third constructor
        public Player(string name, int startingLives)
        {
            // set the name and lives attributes
            this.name = name;
            livesLeft = startingLives;
        } // end third constructor

        // Methods - taks or actions that our object can perform

        // This method returns the score
        public int GetScore()
        {
            return score;
        } // end GetScore Method

        // This method increments the points
        public void AddPoints(int totalPoints)
        {
            // Increment the score
            score += totalPoints;
        } // end AddPoints Method

        //This method kills off the player
        public void Kill()
        {
            // Make sure they can't have negative lives
            if (livesLeft > 0)
            {
                livesLeft--;
            } // end if statement
        } // end Kill Method

        // This method return the lives left
        public int GetLivesLeft()
        {
            return livesLeft;
        } // end GetLivesLeft Method

    } // end class
} // end namespace