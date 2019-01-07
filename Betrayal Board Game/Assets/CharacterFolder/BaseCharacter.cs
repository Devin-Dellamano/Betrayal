using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour
{
	// general stats
    public string characterName = "";
	public int age = 0;
	public string height = "";
	public int weight = 0;
	public string[] hobbies;
	public string birthday = "";

	// game stats
    public int speed = 0;
    public int might = 0;
    public int sanity = 0;
    public int knowledge = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    virtual protected int ModifySpeed(int damage)
    {
		int speedCalc = speed;
		speedCalc += damage;

        return speedCalc;
    }

	virtual protected int ModifyMight(int damage)
	{
		int mightCalc = might;
		mightCalc += damage;

		return mightCalc;
	}

	virtual protected int ModifySanity(int damage)
	{
		int sanityCalc = sanity;
		sanityCalc += damage;

		return sanityCalc;
	}

	virtual protected int ModifyKnowledge(int damage)
	{
		int sanityKnowledge = knowledge;
		sanityKnowledge += damage;

		return sanityKnowledge;
	}
}
