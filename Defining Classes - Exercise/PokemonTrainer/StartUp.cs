using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string input;

            while((input = Console.ReadLine()) != "Tournament")
            {
                string[] info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealth = int.Parse(info[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if(trainers.Any(t => t.Name == trainerName))
                {
                    trainers.First(t => t.Name == trainerName).Pokemons.Add(pokemon);
                    continue;
                }

                Trainer trainer = new Trainer(trainerName);
                trainer.Pokemons.Add(pokemon);
                trainers.Add(trainer);
            }

            string element;

            while((element = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if(trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, trainers.OrderByDescending(t => t.Badges)));
        }
    }
}
