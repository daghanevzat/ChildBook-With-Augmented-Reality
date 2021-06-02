using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChildBook : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject cengizhanBookGo, daliBookGo, eserlerBookGo, haliBookGo, kitapBookGo, picassoBookGo, rodinBookGo, venedikBookGo, caterpillarBookGo, corduroyBookGo, mooseBookGo, numbersGo, colorsGo, animalsGo;

    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponents<VirtualButtonBehaviour> ();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }
        cengizhanBookGo.SetActive(false);
        daliBookGo.SetActive(false);
        eserlerBookGo.SetActive(false);
        haliBookGo.SetActive(false);
        kitapBookGo.SetActive(false);
        picassoBookGo.SetActive(false);
        rodinBookGo.SetActive(false);
        venedikBookGo.SetActive(false);
        caterpillarBookGo.SetActive(false);
        corduroyBookGo.SetActive(false);
        mooseBookGo.SetActive(false);
        numbersGo.SetActive(false);
        colorsGo.SetActive(false);
        animalsGo.SetActive(false);
    }
    
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "CengizhanBookVB")
        {
            Debug.Log("Cengizhan Book Button pressed.");
            cengizhanBookGo.SetActive(true);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(false);
            corduroyBookGo.SetActive(false);
            mooseBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "DaliButtonVB")
        {
            Debug.Log("Dali Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(true);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(false);
            corduroyBookGo.SetActive(false);
            mooseBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "EserlerButtonVB")
        {
            Debug.Log("Eserler Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(true);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "HaliButtonVB")
        {
            Debug.Log("Hali Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(true);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(false);
            corduroyBookGo.SetActive(false);
            mooseBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "KitapButtonVB")
        {
            Debug.Log("Kitap Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(true);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(false);
            corduroyBookGo.SetActive(false);
            mooseBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "PicassoButtonVB")
        {
            Debug.Log("Kitap Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(true);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(false);
            corduroyBookGo.SetActive(false);
            mooseBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "RodinButtonVB")
        {
            Debug.Log("Rodin Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(true);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(false);
            corduroyBookGo.SetActive(false);
            mooseBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "VenedikButtonVB")
        {
            Debug.Log("Venedik Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(true);
            caterpillarBookGo.SetActive(false);
            corduroyBookGo.SetActive(false);
            mooseBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "CaterpillarButtonVB")
        {
            Debug.Log("Caterpillar Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(true);
            corduroyBookGo.SetActive(false);
            mooseBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "CorduroyButtonVB")
        {
            Debug.Log("Corduroy Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(false);
            corduroyBookGo.SetActive(true);
            mooseBookGo.SetActive(false);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "MooseMuffinButtonVB")
        {
            Debug.Log("Moose Muffin Book Button pressed.");
            cengizhanBookGo.SetActive(false);
            daliBookGo.SetActive(false);
            eserlerBookGo.SetActive(false);
            haliBookGo.SetActive(false);
            kitapBookGo.SetActive(false);
            picassoBookGo.SetActive(false);
            rodinBookGo.SetActive(false);
            venedikBookGo.SetActive(false);
            caterpillarBookGo.SetActive(false);
            corduroyBookGo.SetActive(false);
            mooseBookGo.SetActive(true);
            numbersGo.SetActive(false);
            colorsGo.SetActive(false);
            animalsGo.SetActive(false);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supported");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button released.");
    }

}
