using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class Superhero
    {

		//Precondition: Name, Birthcity, Superpower 1, Birthyear, and Superpower 2 must be passed as parameters
		//Postcondition: Superhero object created with corresponding data populated
		public Superhero(string name, string birthcity, string superpower1, int birthyear, string superpower2)
		{
			SuperheroName = name;
			BirthCity = birthcity;
			FirstSuperpower = superpower1;
			BirthYear = birthyear;
			SecondSuperpower = superpower2;
		}

		private int _year; //private int to hold Birthyear; accessed through BirthYear
		public const int DEFAULT_YEAR = 1999; //public const int to hold the default birthyear

		private bool earthStatus = true; //boolean to hold superhero's on Earth status; default is true (on earth)

		public string SuperheroName //String for superhero name
		{
			get; set;
		}

		public string BirthCity //String for superhero birth city
		{
			get; set;
		}

		public string FirstSuperpower //String for superhero's first superpower
		{
			get; set;
		}

		public int BirthYear //int for superhero's birth year
		{
			//Precondition: BirthYear property accessed from Superhero object
			//Postcondition: _year returned to calling statement
			get
			{
				return _year;
			}

			//Precondition: BirthYear property is set to a valid integer
			//Postcondition: _year set to inputted value if positive, or set to DEFAULT_YEAR if negative
			set
			{
				if (value >= 0) //If inputted year is positive, set the year to the inputted value
				{
					_year = value;
				}
				else
				{
					_year = DEFAULT_YEAR; //If inputted year is negative, set the Birthyear to the default year value
				}
			}
		}

		public string SecondSuperpower //String for superhero's second superpower
		{
			get; set;
		}

		public char Initial //Read Only Char property for superhero's first initial
		{
			//Precondition: SuperheroName property is set to a valid string
			//Postcondition: First letter from SuperheroName returned to calling statement
			get
			{
				return SuperheroName[0];
			}
		}

		//Precondition: Superhero object instantiated, called directly from object
		//Postcondition: Superhero's earthStatus set to true
		public void OnPlanetEarth()
		{
			earthStatus = true;
		}

		//Precondition: Superhero object instantiated, called directly from object
		//Postcondition: Superhero's earthStatus set to false
		public void OffPlanetEarth()
		{
			earthStatus = false;
		}

		//Precondition: Superhero object instantiated, called directly from object
		//Postcondition: Superhero's earthStatus is returned to calling statement
		public bool IsOnPlanetEarth()
		{
			return earthStatus;
		}

		//Precondition: Superhero object instantiated, called directly from object
		//Postcondition: Returns string with all necessary Superhero info with formatting
		override public string ToString()
		{
			return $"Name: {SuperheroName}{Environment.NewLine}Birth City: {BirthCity}{Environment.NewLine}First Superpower: {FirstSuperpower}{Environment.NewLine}Birth Year: {BirthYear}{Environment.NewLine}Second Superpower: {SecondSuperpower}{Environment.NewLine}On Planet Earth: {IsOnPlanetEarth()}";
		}
	}
}
