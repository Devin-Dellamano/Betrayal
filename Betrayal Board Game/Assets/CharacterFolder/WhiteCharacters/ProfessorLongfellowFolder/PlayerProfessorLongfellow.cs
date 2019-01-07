using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProfessorLongfellow : BaseCharacter
{
	enum SpeedStat
	{
		Skull = 0,
		NumOne = 2,
		NumTwo = 2,
		NumThree = 4,
		StartingSpeed = 4,
		NumFive = 5,
		NumSix = 5,
		NumSeven = 6,
		NumEight = 6
	};
	enum MightStat
	{
		Skull = 0,
		NumOne = 1,
		NumTwo = 2,
		StartingMight = 3,
		NumFour = 4,
		NumFive = 5,
		NumSix = 5,
		NumSeven = 6,
		NumEight = 6
	};
	enum SanityStat
	{
		Skull = 0,
		NumOne = 1,
		NumTwo = 3,
		StartingSanity = 3,
		NumFour = 4,
		NumFive = 5,
		NumSix = 5,
		NumSeven = 6,
		NumEight = 7
	};
	enum KnowledgeStat
	{
		Skull = 0,
		NumOne = 4,
		NumTwo = 5,
		NumThree = 5,
		NumFour = 5,
		StartingKnowledge = 5,
		NumSix = 6,
		NumSeven = 7,
		NumEight = 8
	};

	public PlayerProfessorLongfellow()
	{
		color = "white";
		characterName = "Professor Longfellow";
		age = 57;
		height = "5\'11\"";
		weight = 153;
		hobbies = new string[3];
		hobbies[0] = "Gaelic Music";
		hobbies[1] = "Drama";
		hobbies[2] = "Fine Wines";
		birthday = "July 27";

		speed = (int)SpeedStat.StartingSpeed;
		might = (int)MightStat.StartingMight;
		sanity = (int)SanityStat.StartingSanity;
		knowledge = (int)KnowledgeStat.StartingKnowledge;
	}

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	// calls the parent function first
	// then determine the speed stat for the character
	override protected int ModifySpeed(int damage)
	{
		int speedCalc = base.ModifySpeed(damage);

		if (speedCalc <= 0)
			speed = (int)SpeedStat.Skull;
		else if (speedCalc == 1)
			speed = (int)SpeedStat.NumOne;
		else if (speedCalc == 2)
			speed = (int)SpeedStat.NumTwo;
		else if (speedCalc == 3)
			speed = (int)SpeedStat.NumThree;
		else if (speedCalc == 4)
			speed = (int)SpeedStat.StartingSpeed;
		else if (speedCalc == 5)
			speed = (int)SpeedStat.NumFive;
		else if (speedCalc == 6)
			speed = (int)SpeedStat.NumSix;
		else if (speedCalc == 7)
			speed = (int)SpeedStat.NumSeven;
		else if (speedCalc >= 8)
			speed = (int)SpeedStat.NumEight;

		return speed;
	}

	// calls the parent function first
	// then determine the might stat for the character
	override protected int ModifyMight(int damage)
	{
		int mightCalc = base.ModifyMight(damage);

		if (mightCalc <= 0)
			might = (int)MightStat.Skull;
		else if (mightCalc == 1)
			might = (int)MightStat.NumOne;
		else if (mightCalc == 2)
			might = (int)MightStat.NumTwo;
		else if (mightCalc == 3)
			might = (int)MightStat.StartingMight;
		else if (mightCalc == 4)
			might = (int)MightStat.NumFour;
		else if (mightCalc == 5)
			might = (int)MightStat.NumFive;
		else if (mightCalc == 6)
			might = (int)MightStat.NumSix;
		else if (mightCalc == 7)
			might = (int)MightStat.NumSeven;
		else if (mightCalc >= 8)
			might = (int)MightStat.NumEight;

		return might;
	}

	// calls the parent function first
	// then determine the sanity stat for the character
	override protected int ModifySanity(int damage)
	{
		int sanityCalc = base.ModifySanity(damage);

		if (sanityCalc <= 0)
			sanity = (int)SanityStat.Skull;
		else if (sanityCalc == 1)
			sanity = (int)SanityStat.NumOne;
		else if (sanityCalc == 2)
			sanity = (int)SanityStat.NumTwo;
		else if (sanityCalc == 3)
			sanity = (int)SanityStat.StartingSanity;
		else if (sanityCalc == 4)
			sanity = (int)SanityStat.NumFour;
		else if (sanityCalc == 5)
			sanity = (int)SanityStat.NumFive;
		else if (sanityCalc == 6)
			sanity = (int)SanityStat.NumSix;
		else if (sanityCalc == 7)
			sanity = (int)SanityStat.NumSeven;
		else if (sanityCalc >= 8)
			sanity = (int)SanityStat.NumEight;

		return sanity;
	}

	// calls the parent function first
	// then determine the knowledge stat for the character
	override protected int ModifyKnowledge(int damage)
	{
		int knowledgeCalc = base.ModifyKnowledge(damage);

		if (knowledgeCalc <= 0)
			knowledge = (int)KnowledgeStat.Skull;
		else if (knowledgeCalc == 1)
			knowledge = (int)KnowledgeStat.NumOne;
		else if (knowledgeCalc == 2)
			knowledge = (int)KnowledgeStat.NumTwo;
		else if (knowledgeCalc == 3)
			knowledge = (int)KnowledgeStat.NumThree;
		else if (knowledgeCalc == 4)
			knowledge = (int)KnowledgeStat.NumFour;
		else if (knowledgeCalc == 5)
			knowledge = (int)KnowledgeStat.StartingKnowledge;
		else if (knowledgeCalc == 6)
			knowledge = (int)KnowledgeStat.NumSix;
		else if (knowledgeCalc == 7)
			knowledge = (int)KnowledgeStat.NumSeven;
		else if (knowledgeCalc >= 8)
			knowledge = (int)KnowledgeStat.NumEight;

		return knowledge;
	}
}
