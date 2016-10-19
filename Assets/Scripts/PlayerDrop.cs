using UnityEngine;
using Rewired;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class PlayerDrop : MonoBehaviour {

    bool p1Drop, p2Drop, p3Drop, p4Drop = false;

    public EventSystem myEventSystem;

    public GameObject Cursor;
    enum buttonSchemes { Xbox_Zhidong, Sony, Wii, Nyko, GameCube, none}
    buttonSchemes curScheme;
    CursorMovement CM;
    PlayerBackground PB;
    GodScript God;
    GameObject p1Cursor, p2Cursor, p3Cursor, p4Cursor;
    Player p1, p2, p3, p4;
    public GameObject p1Background, p2Background, p3Background, p4Background, p1Logo, p2Logo, p3Logo, p4Logo;
    public Material[] CursorMats;

    //string p1curButt, p2curButt, p3curButt, p4curButt;
    bool p1CharSelected, p2CharSelected, p3CharSelected, p4CharSelected;


    void Start()
    {
        p1 = ReInput.players.GetPlayer(0);
        p2 = ReInput.players.GetPlayer(1);
        p3 = ReInput.players.GetPlayer(2);
        p4 = ReInput.players.GetPlayer(3);
        CM = Cursor.GetComponent<CursorMovement>();
        God = GameObject.Find("God").GetComponent<GodScript>();
    }

	void Update ()
    {
        //player select
        if (p1.GetButtonDown("Select") && p1Drop && !p1CharSelected)
        {
            PB = p1Background.GetComponent<PlayerBackground>();
            PB.selectChar();
            p1CharSelected = true;
            p1Cursor.SetActive(false);
        }
        if (p2.GetButtonDown("Select") && p2Drop && !p2CharSelected)
        {
            PB = p2Background.GetComponent<PlayerBackground>();
            PB.selectChar();
            p2CharSelected = true;
            p2Cursor.SetActive(false);
        }
        if (p3.GetButtonDown("Select") && p3Drop && !p3CharSelected)
        {
            PB = p3Background.GetComponent<PlayerBackground>();
            PB.selectChar();
            p3CharSelected = true;
            p3Cursor.SetActive(false);
        }
        if (p4.GetButtonDown("Select") && p4Drop && !p4CharSelected)
        {
            PB = p4Background.GetComponent<PlayerBackground>();
            PB.selectChar();
            p4CharSelected = true;
            p4Cursor.SetActive(false);
        }
        //player selection cancel
        if (p1.GetButtonDown("Cancel") && p1Drop && p1CharSelected)
        {
            p1CharSelected = false;
            //PB = p1Background.GetComponent<PlayerBackground>();
            //PB.CancelSelection();
            p1Cursor.SetActive(true);
        }
        if (p2.GetButtonDown("Cancel") && p2Drop && p2CharSelected)
        {
            p2CharSelected = false;
            //PB = p2Background.GetComponent<PlayerBackground>();
            //PB.CancelSelection();
            p2Cursor.SetActive(true);
        }
        if (p3.GetButtonDown("Cancel") && p3Drop && p3CharSelected)
        {
            p3CharSelected = false;
            //PB = p3Background.GetComponent<PlayerBackground>();
            //PB.CancelSelection();
            p3Cursor.SetActive(true);
        }
        if (p4.GetButtonDown("Cancel") && p4Drop && p4CharSelected)
        {
            p4CharSelected = false;
            p4Cursor.SetActive(true);
        }
        //player drop
        if (p1.GetButtonDown("Select") && !p1Drop)
        {
            Spawn(1, p1Background);
        }
        if (p2.GetButtonDown("Select") && !p2Drop)
        {
            Spawn(2, p2Background);
        }
        if (p3.GetButtonDown("Select") && !p3Drop)
        {
            Spawn(3, p3Background);
        }
        if (p4.GetButtonDown("Select") && !p4Drop)
        {
            Spawn(4, p4Background);
        }
        #region
        //if (p1.GetAxis("Horizontal") >= -1 || p1.GetAxis("Vertical") >= -1 )
        //{
        //    if (!p1CharSelected)
        //    {
        //      p1curButt = (myEventSystem.GetComponent<EventSystem>().currentSelectedGameObject).ToString();
        //      CharHover();
        //    }
        //}
        #endregion
        

        //if (p1CharSelected && p1.GetButtonDown("Cancel"))
        //{
        //    CharacterDeselected();
        //}
    }

    void Spawn(int pnumDrop, GameObject pnumBackgroundObj)
    {
        switch (pnumDrop)
        {
            case 1:
                p1Drop = true;
                p1Cursor = Instantiate(Cursor, new Vector3(0, 0, 20), this.transform.rotation) as GameObject;
                p1Cursor.name = "p1Cursor";
                p1Logo.SetActive(false);
                //p1Cursor.gameObject.GetComponentInChildren<GameObject>().GetComponentInChildren<MeshRenderer>().material = CursorMats[0];
                Transform tempGO1 = p1Cursor.GetComponentInChildren<Transform>();
                tempGO1.GetComponentInChildren<MeshRenderer>().material = CursorMats[0];
                break;
            case 2:
                p2Drop = true;
                p2Cursor = Instantiate(Cursor, new Vector3(0, 0, 20), this.transform.rotation) as GameObject;
                p2Cursor.name = "p2Cursor";
                p2Logo.SetActive(false);
                Transform tempGO2 = p2Cursor.GetComponentInChildren<Transform>();
                tempGO2.GetComponentInChildren<MeshRenderer>().material = CursorMats[1];
                break;
            case 3:
                p3Drop = true;
                p3Cursor = Instantiate(Cursor, new Vector3(0, 0, 20), this.transform.rotation) as GameObject;
                p3Cursor.name = "p3Cursor";
                p3Logo.SetActive(false);
                Transform tempGO3 = p3Cursor.GetComponentInChildren<Transform>();
                tempGO3.GetComponentInChildren<MeshRenderer>().material = CursorMats[2];
                break;
            case 4:
                p4Drop = true;
                p4Cursor = Instantiate(Cursor, new Vector3(0, 0, 20), this.transform.rotation) as GameObject;
                p4Cursor.name = "p4Cursor";
                p4Logo.SetActive(false);
                Transform tempGO4 = p4Cursor.GetComponentInChildren<Transform>();
                tempGO4.GetComponentInChildren<MeshRenderer>().material = CursorMats[3];
                break;
        }
        CM.FindTB(pnumBackgroundObj);
        God.PlayerAdd();
        //pnumBackgroundObj.SetActive(true);

    }

    void RemovePlayer()
    {

    }
    #region
    //public void CharHover()
    //{
    //    switch (p1curButt)
    //    {
    //        case "CenterDiamond":
    //            p1Background.GetComponent<Text>().text = "Mercy";
    //            if (p1.GetButtonDown("Select"))
    //            {
    //                CharacterSelected(1);
    //            }
    //            break;
    //        case "NorthDiamond":
    //            p1Background.GetComponent<Text>().text = "Torb";
    //            if (p1.GetButtonDown("Select"))
    //            {
    //                CharacterSelected(2);
    //            }
    //            break;
    //        case "NorthEastDiamond":
    //            p1Background.GetComponent<Text>().text = "Widow";
    //            if (p1.GetButtonDown("Select"))
    //            {
    //                CharacterSelected(3);
    //            }
    //            break;
    //        case "EastDiamond":
    //            p1Background.GetComponent<Text>().text = "McCree";
    //            if (p1.GetButtonDown("Select"))
    //            {
    //                CharacterSelected(4);
    //            }
    //            break;
    //        case "SouthEastDiamond":
    //            p1Background.GetComponent<Text>().text = "Tracer";
    //            if (p1.GetButtonDown("Select"))
    //            {
    //                CharacterSelected(5);
    //            }
    //            break;
    //        case "SouthDiamond":
    //            p1Background.GetComponent<Text>().text = "Mei";
    //            if (p1.GetButtonDown("Select"))
    //            {
    //                CharacterSelected(6);
    //            }
    //            break;
    //        case "SouthWestDiamond":
    //            p1Background.GetComponent<Text>().text = "D.va";
    //            if (p1.GetButtonDown("Select"))
    //            {
    //                CharacterSelected(7);
    //            }
    //            break;
    //        case "WestDiamond":
    //            p1Background.GetComponent<Text>().text = "Hanjo";
    //            if (p1.GetButtonDown("Select"))
    //            {
    //                CharacterSelected(8);
    //            }
    //            break;
    //        case "NorthWestDiamond":
    //            p1Background.GetComponent<Text>().text = "Genji";
    //            if (p1.GetButtonDown("Select"))
    //            {
    //                CharacterSelected(9);
    //            }
    //            break;
    //    }
    //}


    //void CharacterSelected(int charNum)
    //{
    //    p1Cursor.SetActive(false);
    //    switch (charNum)
    //    {
    //        case 1:
    //            //set player as character
    //            p1Background.GetComponent<Text>().text = ("Mercy selected");
    //            p1CharSelected = true;
    //            break;
    //        case 2:
    //            p1Background.GetComponent<Text>().text = ("Torb selected");
    //            p1CharSelected = true;
    //            break;
    //        case 3:
    //            p1Background.GetComponent<Text>().text = ("Widow selected");
    //            p1CharSelected = true;
    //            break;
    //        case 4:
    //            p1Background.GetComponent<Text>().text = ("McCree selected");
    //            p1CharSelected = true;
    //            break;
    //        case 5:
    //            p1Background.GetComponent<Text>().text = ("Tracer selected");
    //            p1CharSelected = true;
    //            break;
    //        case 6:
    //            p1Background.GetComponent<Text>().text = ("Mei selected");
    //            p1CharSelected = true;
    //            break;
    //        case 7:
    //            p1Background.GetComponent<Text>().text = ("D.va selected");
    //            p1CharSelected = true;
    //            break;
    //        case 8:
    //            p1Background.GetComponent<Text>().text = ("Hanjo selected");
    //            p1CharSelected = true;
    //            break;
    //        case 9:
    //            p1Background.GetComponent<Text>().text = ("Genji selected");
    //            p1CharSelected = true;
    //            break;
    //        default:
    //            break;
    //    }
    //}
    

    //public void CharacterDeselected()
    //{
    //    p1CharSelected = false;
    //    p1Cursor.SetActive(true);
    //}
    #endregion
}
