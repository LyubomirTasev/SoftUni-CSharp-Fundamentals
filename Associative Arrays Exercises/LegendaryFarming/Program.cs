using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterial = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterial = new Dictionary<string, int>();

            keyMaterial["motes"] = 0;
            keyMaterial["fragments"] = 0;
            keyMaterial["shards"] = 0;

            bool hasToBreak = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterial[material] += quantity;

                        if (keyMaterial[material] >= 250)
                        {
                            keyMaterial[material] -= 250;

                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }

                            hasToBreak = true;
                            break;
                        }
                        else
                        {
                            if (!junkMaterial.ContainsKey(material))
                            {
                                junkMaterial.Add(material, 0);
                            }
                            junkMaterial[material] += quantity;
                        }
                    }
                }

                if (hasToBreak)
                {
                    break;
                }
            }

            Dictionary<string, int> filteredKeyMaterial = keyMaterial
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp in filteredKeyMaterial)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }

            foreach (var kvp in junkMaterial.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }
        }
    }
}
