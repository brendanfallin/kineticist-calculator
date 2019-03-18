using ConsoleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KineticistDamageCalculator
{
    enum InfoTypes { Level, ConScore, BurnTaken, Element1, Element2, Element3 }
    enum Elements { Aether, Air, Earth, Fire, Void, Water, Wood }
    class Character
    {
        
        private List<int> CharacterInfo = new List<int>(6);

        //List will be { Name, Level, ConScore, BurnTaken, Element1, Element2, Element3 }
        public Character (string n, int l, int c, int b, int e1, int e2, int e3)
        {
            CharacterName = n;
            SetLevel(l);
            SetConScore(c);
            SetBurnTaken(b);
            CharacterInfo.Add(e1);
            CharacterInfo.Add(e2);
            CharacterInfo.Add(e3);
        }

        public string CharacterName { get; set; }

        public int GetLevel()
        {
            return CharacterInfo[(int) InfoTypes.Level];
        }

        public void SetLevel(int input)
        {
            if (input <= 0)
            {
                throw new InvalidLevelException("The level you entered was less than 1");
            }

            else if (input > 20)
            {
                throw new InvalidLevelException("The level you entered was greater than 20");
            }

            else
            {
                CharacterInfo[(int)InfoTypes.Level] = input;
            }
        }

        public int GetConScore()
        {
            return CharacterInfo[(int) InfoTypes.ConScore];
        }

        public void SetConScore(int input)
        {
            if (input < 0)
            {
                throw new InvalidConScoreException("You can't have a negative Constitution score");
            }

            else
            {
                CharacterInfo[(int)InfoTypes.ConScore] = input;
            }
        }

        public int GetBurnTaken()
        {
            return CharacterInfo[(int) InfoTypes.BurnTaken];
        }

        public void SetBurnTaken(int input)
        {
            if (input < 0)
            {
                throw new InvalidBurnTakenException("You can't take less than 0 burn");
            }

            else if (input > (int)InfoTypes.Level)
            {
                throw new InvalidBurnTakenException("You can't take more points of burn than you have hit dice");
            }

            else
            {
                CharacterInfo[(int)InfoTypes.BurnTaken] = input;
            }
        }
    }
}
