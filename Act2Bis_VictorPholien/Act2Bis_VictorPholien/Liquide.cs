using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    public class Liquide
    {
        private string _nom="";
        private string _type="";

		public Liquide(string nom, string type) 
		{
			_nom = nom;
			_type = type;
		}

		public string Nom
		{
			get 
			{
				return _nom; 
			}
			set 
			{ 
				_nom = value; 
			}
		}

		public string Type
		{
			get
			{
				return _type;
			}
			set 
			{ 
				_type = value; 
			}
		}
	}
}
