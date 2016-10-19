using UnityEngine;
using Rewired;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;

public class CursorMovement : MonoBehaviour {

    Vector3 p1padDirection, p2padDirection, p3padDirection, p4padDirection;
    public GameObject myEventSystem;
    public float speed = 0.09f;
    
    public float SpeedTemp; //don't know if I'll need this.
    public Vector2 p1Joystick, p2Joystick, p3Joystick, p4Joystick;
    Player p1, p2, p3, p4;
    public Sprite nul, p1h, p2h, p3h, p4h;
    GameObject p1bkg, p2bkg, p3bkg, p4bkg;
    PlayerBackground PB;
    //public GameObject TextObject;
    //public GameObject p1bkg, p2bkg, p3pkg, p4bgk;
    //GameObject p1Hover, p2Hover, p3Hover, p4Hover, p1Selected, p2Selected, p3Selected, p4Selected;

    void Start () {
        myEventSystem = GameObject.Find("EventSystem");
        p1 = ReInput.players.GetPlayer(0);
        p2 = ReInput.players.GetPlayer(1);
        p3 = ReInput.players.GetPlayer(2);
        p4 = ReInput.players.GetPlayer(3);
        p1bkg = GameObject.Find("P1Background");
        p2bkg = GameObject.Find("P2Background");
        p3bkg = GameObject.Find("P3Background");
        p4bkg = GameObject.Find("P4Background");
    }

	void Update () {
        SpeedTemp = speed; //do I need this?
        //p1 movement
        if (this.gameObject.name == "p1Cursor")
        {
            p1padDirection.z = p1.GetAxis("Horizontal");
            p1padDirection.x = p1.GetAxis("Vertical");
            p1Joystick = new Vector2(p1padDirection.z, p1padDirection.x);
            this.transform.position += new Vector3(p1padDirection.z * speed, p1padDirection.x * speed, 0);
        }
        //p2 movement
        if (this.gameObject.name == "p2Cursor")
        {
            p2padDirection.z = p2.GetAxis("Horizontal");
            p2padDirection.x = p2.GetAxis("Vertical");
            p2Joystick = new Vector2(p2padDirection.z, p2padDirection.x);
            this.transform.position += new Vector3(p2padDirection.z * speed, p2padDirection.x * speed, 0);
        }
        //p3 movement
        if (this.gameObject.name == "p3Cursor")
        {
            p3padDirection.z = p3.GetAxis("Horizontal");
            p3padDirection.x = p3.GetAxis("Vertical");
            p3Joystick = new Vector2(p3padDirection.z, p3padDirection.x);
            this.transform.position += new Vector3(p3padDirection.z * speed, p3padDirection.x * speed, 0);
        }
        //p4 movement
        if (this.gameObject.name == "p4Cursor")
        {
            p4padDirection.z = p4.GetAxis("Horizontal");
            p4padDirection.x = p4.GetAxis("Vertical");
            p4Joystick = new Vector2(p4padDirection.z, p4padDirection.x);
            this.transform.position += new Vector3(p4padDirection.z * speed, p4padDirection.x * speed, 0);
        }
    }

    void FixedUpdate()
    {
        Vector3 _viewPos = Camera.main.WorldToViewportPoint(this.transform.position);
        _viewPos.x = Mathf.Clamp01(_viewPos.x);
        _viewPos.y = Mathf.Clamp01(_viewPos.y);
        this.transform.position = Camera.main.ViewportToWorldPoint(_viewPos);
    }

    public void FindTB(GameObject pnBkg)
    {
        pnBkg.transform.GetChild(0).gameObject.SetActive(true);
        //TextObject = pnBkg;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "CharacterIcon")
        {
            switch (this.gameObject.name)
            {
                case "p1Cursor":
                    col.gameObject.GetComponent<Image>().sprite = p1h;
                    PB = p1bkg.GetComponent<PlayerBackground>();
                    PB.switchChar(col);
                    //Hover(col);
                    break;
                case "p2Cursor":
                    col.gameObject.GetComponent<Image>().sprite = p2h;
                    PB = p2bkg.GetComponent<PlayerBackground>();
                    PB.switchChar(col);
                    //Hover(col);
                    break;
                case "p3Cursor":
                    col.gameObject.GetComponent<Image>().sprite = p3h;
                    PB = p3bkg.GetComponent<PlayerBackground>();
                    PB.switchChar(col);
                    //Hover(col);
                    break;
                case "p4Cursor":
                    col.gameObject.GetComponent<Image>().sprite = p4h;
                    PB = p4bkg.GetComponent<PlayerBackground>();
                    PB.switchChar(col);
                    //Hover(col);
                    break;
            }
            #region
            //switch (col.name)
            //{
            //    case "CenterDiamond":
            //        TextObject.GetComponent<Text>().text = "Mercy";
            //        break;
            //    case "NorthDiamond":
            //        TextObject.GetComponent<Text>().text = "Torb";
            //        break;
            //    case "NorthEastDiamond":
            //        TextObject.GetComponent<Text>().text = "Widow";
            //        break;
            //    case "EastDiamond":
            //        TextObject.GetComponent<Text>().text = "McCree";
            //        break;
            //    case "SouthEastDiamond":
            //        TextObject.GetComponent<Text>().text = "Tracer";
            //        break;
            //    case "SouthDiamond":
            //        TextObject.GetComponent<Text>().text = "Mei";
            //        break;
            //    case "SouthWestDiamond":
            //        TextObject.GetComponent<Text>().text = "D.Va";
            //        break;
            //    case "WestDiamond":
            //        TextObject.GetComponent<Text>().text = "Hanjo";
            //        break;
            //    case "NorthWestDiamond":
            //        TextObject.GetComponent<Text>().text = "Genji";
            //        break;
            //    default:
            //        break;
            //}
            #endregion
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {
        col.gameObject.GetComponent<Image>().sprite = nul;
    }
}
