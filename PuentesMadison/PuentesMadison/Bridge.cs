using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuentesMadison
{
    internal class Bridge
    {
        private string _structure;
        private int _residue;

        public Bridge() { }

        public string Structure 
        { 
            get => _structure; 
            set => _structure = ValidateBridge(value); 
        }

        public void ProveBridge()
        {
            if (_structure.Length % 2 == 1)
            {
                _residue = 1;
            }
            else
            {
                _residue = 0;
            }

            for (int i = 1, j = _structure.Length - 2; i < (_structure.Length + _residue) / 2; i++, j--)
            {
                ValidateSymmetry(_structure[i], _structure[j]);
                ValidatePlatforms(CountPlatforms(_structure[i], _structure[i - 1], _structure[i + 1]), i, j);
            }
        }

        private string ValidateBridge(string value)
        {
            if (value[0] != '*' || value[value.Length - 1] != '*')
            {
                throw new ArgumentException("The bridge is not valid.");
            }

            for (int i = 1; i < value.Length - 1; i++)
            {
                if (value[i] != '=' && value[i] != '+')
                {
                    throw new ArgumentException("The bridge is not valid.");
                }
            }

            return value;
        }
        
        private void ValidateSymmetry(char value, char value2)
        {
            if (value != value2)
            {
                throw new ArgumentException("The bridge is not valid.");
            }
        } 

        private void ValidatePlatforms(bool value, int i, int j)
        {
            if (value == true && i != j)
            {
                throw new ArgumentException("The bridge is not valid.");
            }
        }

        private bool CountPlatforms(char value, char value2, char value3)
        {
            if (value == '=')
            {
                if (value == value2)
                {
                    if (value == value3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
