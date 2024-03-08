using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_JuanHernandez
{
    internal class Player
    {
        // Fields
        string _name;
        string _number;

        // Constructor
        public Player(string name, string number) { Name = name; Number = number; }

        // Properties
        public string Name { get => _name; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new PlayerException("Enter a valid name");
                }
                _name = value;
            }
        }
        public string Number { get => _number; set
            {
                if (!int.TryParse(value, out int num) || num < 1 || num > 999)
                {
                    throw new PlayerException("Enter a valid number");
                }
                _number = value;
            }
        }
    }
}
