using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Ludvig_Baummann_Olsson
{
	
    class Animal
    {
		public Animal(string inName,double inWeight,int inAge)
		{
			name = inName;
			weight = inWeight;
			age = inAge;
		}

		private string name;
		private double weight;
		private int age;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}
		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public virtual string Stats()
		{
			var result = new StringBuilder();

			result.AppendLine(
				$"Name: {name}\n" +
				$"Weight: {weight}\n" +
				$"Age: {age}");

			return result.ToString();
		}

	}

	class Horse : Animal
	{
		public Horse(string inName,double inWeight,int inAge, bool inTrott):base(inName,inWeight,inAge)
		{
			IsTrotting = inTrott;
		}

		public bool IsTrotting { get; set; }

		public override string Stats()
		{
			var result = new StringBuilder();

			result.AppendLine(
				$"Name: {Name}\n" +
				$"Weight: {Weight}\n" +
				$"Age: {Age}\n" +
				$"Is trotting: {IsTrotting}");

			return result.ToString();
		}

	}

	class Dog : Animal
	{
		public Dog(string inName, double inWeight, int inAge,bool inHunger) : base(inName, inWeight, inAge)
		{
			IsHungry = inHunger;
		}

		public bool IsHungry { get; set; }

		public string Bark() { return "WOOF WOOF, BARK BARK"; }

		public override string Stats()
		{
			var result = new StringBuilder();

			result.AppendLine(
				$"Name: {Name}\n" +
				$"Weight: {Weight}\n" +
				$"Age: {Age}\n" +
				$"Is hungry: {IsHungry}");

			return result.ToString();
		}

	}

	class Hedgehog : Animal
	{
		public Hedgehog(string inName, double inWeight, int inAge,int inSpikes) : base(inName, inWeight, inAge)
		{
			NumberOfSpikes = inSpikes;
		}

		public int NumberOfSpikes { get; set; }

		public override string Stats()
		{
			var result = new StringBuilder();

			result.AppendLine(
				$"Name: {Name}\n" +
				$"Weight: {Weight}\n" +
				$"Age: {Age}\n" +
				$"Spikes: {NumberOfSpikes}");

			return result.ToString();
		}

	}

	class Worm : Animal
	{
		public Worm(string inName, double inWeight, int inAge, bool inDig) : base(inName, inWeight, inAge)
		{
			CanDig = inDig;
		}

		public bool CanDig { get; set; }

		public override string Stats()
		{
			var result = new StringBuilder();

			result.AppendLine(
				$"Name: {Name}\n" +
				$"Weight: {Weight}\n" +
				$"Age: {Age}\n" +
				$"Can dig: {CanDig}");

			return result.ToString();
		}

	}

	
	class Bird : Animal
	{
		
		public Bird(string inName, double inWeight, int inAge) : base(inName, inWeight, inAge)
		{
		}
		public virtual void Fly()
		{

		}
	}

	class  Pelican : Bird
	{
		public Pelican(string inName, double inWeight, int inAge,int inEatenFish) : base(inName, inWeight, inAge)
		{
			FishEaten = inEatenFish;
		}

		public int FishEaten { get; set; }

		public override string Stats()
		{
			var result = new StringBuilder();

			result.AppendLine(
				$"Name: {Name}\n" +
				$"Weight: {Weight}\n" +
				$"Age: {Age}\n" +
				$"Fish eaten: {FishEaten}");

			return result.ToString();
		}

	}
	class Flamingo : Bird
	{
		public Flamingo(string inName, double inWeight, int inAge, double inLegLength) : base(inName, inWeight, inAge)
		{
			LegLenght = inLegLength;
		}
		public double LegLenght { get; set; }

		public override string Stats()
		{
			var result = new StringBuilder();

			result.AppendLine(
				$"Name: {Name}\n" +
				$"Weight: {Weight}\n" +
				$"Age: {Age}\n" +
				$"Leg Lenght: {LegLenght}");

			return result.ToString();
		}
	}
	class Swan : Bird
	{
		public Swan(string inName, double inWeight, int inAge,double inDistFlown) : base(inName, inWeight, inAge)
		{
			DistanceFlown = inDistFlown;
		}
		public double DistanceFlown { get; set; }

		public override string Stats()
		{
			var result = new StringBuilder();

			result.AppendLine(
				$"Name: {Name}\n" +
				$"Weight: {Weight}\n" +
				$"Age: {Age}\n" +
				$"Distance flown: {DistanceFlown}");

			return result.ToString();
		}
	}


}
