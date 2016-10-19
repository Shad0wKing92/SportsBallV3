using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AbilityMenu : MonoBehaviour {

    PlayerBackground PB;
    public GameObject abil1Tit, abil1des, abil2Tit, abil2des;
    bool menuActive;

	void Start () {
        PB = this.gameObject.GetComponentInParent<PlayerBackground>();
	}
	
    void Update()
    {
        if (PB.abilMenuOpen)
        {
            switch (PB.curChar)
            {
                case PlayerBackground.SelectableCharacters.Leslie:
                    abil1Tit.GetComponent<Text>().text = "Leslie Ability 1 Title";
                    abil1des.GetComponent<Text>().text = "Leslie Ability 1 Description";
                    abil2Tit.GetComponent<Text>().text = "Leslie Ability 2 Title";
                    abil2des.GetComponent<Text>().text = "Leslie Ability 2 Description";
                    break;
                case PlayerBackground.SelectableCharacters.Jona:
                    abil1Tit.GetComponent<Text>().text = "Jona Ability 1 Title";
                    abil1des.GetComponent<Text>().text = "Jona Ability 1 Description";
                    abil2Tit.GetComponent<Text>().text = "Jona Ability 2 Title";
                    abil2des.GetComponent<Text>().text = "Jona Ability 2 Description";
                    break;
                case PlayerBackground.SelectableCharacters.Ashita:
                    abil1Tit.GetComponent<Text>().text = "Ashita Ability 1 Title";
                    abil1des.GetComponent<Text>().text = "Ashita Ability 1 Description";
                    abil2Tit.GetComponent<Text>().text = "Ashita Ability 2 Title";
                    abil2des.GetComponent<Text>().text = "Ashita Ability 2 Description";
                    break;
                case PlayerBackground.SelectableCharacters.Catarine:
                    abil1Tit.GetComponent<Text>().text = "Catarine Ability 1 Title";
                    abil1des.GetComponent<Text>().text = "Catarine Ability 1 Description";
                    abil2Tit.GetComponent<Text>().text = "Catarine Ability 2 Title";
                    abil2des.GetComponent<Text>().text = "Catarine Ability 2 Description";
                    break;
                case PlayerBackground.SelectableCharacters.Ramsey:
                    abil1Tit.GetComponent<Text>().text = "Ramsey Ability 1 Title";
                    abil1des.GetComponent<Text>().text = "Ramsey Ability 1 Description";
                    abil2Tit.GetComponent<Text>().text = "Ramsey Ability 2 Title";
                    abil2des.GetComponent<Text>().text = "Ramsey Ability 2 Description";
                    break;
                case PlayerBackground.SelectableCharacters.Drogas:
                    abil1Tit.GetComponent<Text>().text = "Drogas Ability 1 Title";
                    abil1des.GetComponent<Text>().text = "Drogas Ability 1 Description";
                    abil2Tit.GetComponent<Text>().text = "Drogas Ability 2 Title";
                    abil2des.GetComponent<Text>().text = "Drogas Ability 2 Description";
                    break;
                case PlayerBackground.SelectableCharacters.Sylvia:
                    abil1Tit.GetComponent<Text>().text = "Sylvia Ability 1 Title";
                    abil1des.GetComponent<Text>().text = "Sylvia Ability 1 Description";
                    abil2Tit.GetComponent<Text>().text = "Sylvia Ability 2 Title";
                    abil2des.GetComponent<Text>().text = "Sylvia Ability 2 Description";
                    break;
                case PlayerBackground.SelectableCharacters.Bjin:
                    abil1Tit.GetComponent<Text>().text = "Bjin Ability 1 Title";
                    abil1des.GetComponent<Text>().text = "Bjin Ability 1 Description";
                    abil2Tit.GetComponent<Text>().text = "Bjin Ability 2 Title";
                    abil2des.GetComponent<Text>().text = "Bjin Ability 2 Description";
                    break;
                case PlayerBackground.SelectableCharacters.Xavier:
                    abil1Tit.GetComponent<Text>().text = "Xavier Ability 1 Title";
                    abil1des.GetComponent<Text>().text = "Xavier Ability 1 Description";
                    abil2Tit.GetComponent<Text>().text = "Xavier Ability 2 Title";
                    abil2des.GetComponent<Text>().text = "Xavier Ability 2 Description";
                    break;
                case PlayerBackground.SelectableCharacters.None:
                    break;
                default:
                    break;
            }
        }
    }
}
