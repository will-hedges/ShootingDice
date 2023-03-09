﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            Player player3 = new Player();
            player3.Name = "Wilma";

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            SmackTalkingPlayer smackTalker = new SmackTalkingPlayer(
                "I'm only 19 and I'm STILL better than you!"
            );
            smackTalker.Name = "Logan Gray";

            OneHigherPlayer oneHigher = new OneHigherPlayer();
            oneHigher.Name = "Slick Rick";

            HumanPlayer human = new HumanPlayer();
            human.Name = "Ima Robut";

            CreativeSmackTalkingPlayer creativeSmackTalker = new CreativeSmackTalkingPlayer();
            creativeSmackTalker.Name = "Chris Hanson";

            SoreLoserPlayer soreLoser = new SoreLoserPlayer();
            soreLoser.Name = "Kaci Wooldridge";

            UpperHalfPlayer upperHalf = new UpperHalfPlayer();
            upperHalf.Name = "Jack \"High Roller\" Roller";

            SoreLoserUpperHalfPlayer soreLoserUpperHalf = new SoreLoserUpperHalfPlayer();
            soreLoserUpperHalf.Name = "Will \"Peaches\" Hedges";

            List<Player> players = new List<Player>()
            {
                player1,
                player2,
                player3,
                large,
                smackTalker,
                oneHigher,
                human,
                creativeSmackTalker,
                soreLoser,
                upperHalf,
                soreLoserUpperHalf
            };

            try
            {
                PlayMany(players);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players
                .OrderBy(p => randomNumberGenerator.Next())
                .ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}
