using UnityEngine;
using UnityEngine.UI;
using Rewired;
using System.Collections;

public class WeaponSelect : MonoBehaviour {

    public enum Weapons { sniper, pistol, smg, minigun, ball, stream, none}
    public Weapons curWeapon;
    public int playerNum;
    Player _player;
    public float bar1num, bar2num, bar3num, bar4num;
    int weaponNum = 1;
    public GameObject WeaponNameGameobject;
    //Text weaponName;
    public GameObject bar1, bar2, bar3, bar4, tip1, tip2, tip3, tip4;
    Image _bar1, _bar2, _bar3, _bar4;
    bool axisPressed = false;

	void Start () {
        _player = ReInput.players.GetPlayer(playerNum);
        _bar1 = bar1.GetComponentInChildren<Image>();
        _bar2 = bar2.GetComponentInChildren<Image>();
        _bar3 = bar3.GetComponentInChildren<Image>();
        _bar4 = bar4.GetComponentInChildren<Image>();
        //weaponName = WeaponNameGameobject.GetComponent<Text>();
        cycleWeapons();
        
    }

    void Update()
    {
        if (_player.GetAxisRaw("Horizontal") > 0 && !axisPressed)
        {
            weaponNum++;
            axisPressed = true;
            if (weaponNum == 7)
            {
                weaponNum = 1;
                
            }
            cycleWeapons();
        }
        if (_player.GetAxisRaw("Horizontal") < 0 && !axisPressed)
        {
            weaponNum--;
            axisPressed = true;
            if (weaponNum == 0)
            {
                weaponNum = 6;
            }
            cycleWeapons();
        }
        if (_player.GetAxisRaw("Horizontal") == 0 && axisPressed)
        {
            axisPressed = false;
        }
        
        _bar1.fillAmount = bar1num;
        _bar2.fillAmount = bar2num;
        _bar3.fillAmount = bar3num;
        _bar4.fillAmount = bar4num;
    }
	
    void cycleWeapons()
    {
        switch (weaponNum)
        {
            case 1:
                WeaponNameGameobject.GetComponent<Text>().text = "Sniper";
                adjustValues(0.8f, 0.7f, 0.6f, 0.5f, 67, 47, 27, 7);
                curWeapon = Weapons.sniper;
                break;
            case 2:
                WeaponNameGameobject.GetComponent<Text>().text = "Pistol";
                adjustValues(0.5f, 0.6f, 0.7f, 0.9f, 7, 27, 47, 87);
                curWeapon = Weapons.pistol;
                break;
            case 3:
                WeaponNameGameobject.GetComponent<Text>().text = "SMG";
                adjustValues(0.1f, 0.2f, 0.3f, 0.4f, -77, -57, -37, -17);
                curWeapon = Weapons.smg;
                break;
            case 4:
                WeaponNameGameobject.GetComponent<Text>().text = "MiniGun";
                adjustValues(0.05f, 0.15f, 0.25f, 0.35f, -87, -67, -47, -27);
                curWeapon = Weapons.minigun;
                break;
            case 5:
                WeaponNameGameobject.GetComponent<Text>().text = "Ball";
                adjustValues(0.45f, 0.55f, 0.65f, 0.75f, -7, 17, 37, 57);
                curWeapon = Weapons.ball;
                break;
            case 6:
                WeaponNameGameobject.GetComponent<Text>().text = "Stream";
                adjustValues(0.85f, 0.95f, 1f, 0.05f, 77, 97, 107, -87);
                curWeapon = Weapons.stream;
                break;
            default:
                break;
        }
    }

    void adjustValues(float b1, float b2, float b3, float b4, float t1, float t2, float t3, float t4)
    {
        bar1num = b1;
        bar2num = b2;
        bar3num = b3;
        bar4num = b4;
        tip1.GetComponent<RectTransform>().anchoredPosition = new Vector2(t1, tip1.GetComponent<RectTransform>().anchoredPosition.y);
        tip2.GetComponent<RectTransform>().anchoredPosition = new Vector2(t2, tip2.GetComponent<RectTransform>().anchoredPosition.y);
        tip3.GetComponent<RectTransform>().anchoredPosition = new Vector2(t3, tip3.GetComponent<RectTransform>().anchoredPosition.y);
        tip4.GetComponent<RectTransform>().anchoredPosition = new Vector2(t4, tip4.GetComponent<RectTransform>().anchoredPosition.y);
    }

    

    //notes
    //have left and right movement when menu is active control plus or minus to weaponNum
    //weaponNum will cycle into a switch statement that will control varibles for bars

}
