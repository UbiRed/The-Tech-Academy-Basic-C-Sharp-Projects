﻿using System;
using System.Collections.Generic;

namespace Casino
{
    public abstract class Game //base class - never instantiated, only inherited from
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        public abstract void Play(); //any inheriting class must implement this method
                                     
        public virtual void ListPlayers()   //virtual method in abstract class:
                                            // this method gets inherited, but can be overridden
        {
            foreach (Player player in Players) 
            {
                Console.WriteLine(player);
            }
        }
    }
}
