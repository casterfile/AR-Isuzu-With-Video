/*============================================================================== 
 * Copyright (c) 2012-2014 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/

using UnityEngine;
using System.Collections.Generic;
using Vuforia;

//[RequireComponent(typeof(AudioSource))]
/// <summary>
/// This class implements the IVirtualButtonEventHandler interface and
/// contains the logic to swap materials for the teapot model depending on what 
/// virtual button has been pressed.
/// </summary>
public class myVirtualButtonEventHandler : MonoBehaviour,
IVirtualButtonEventHandler
{
    #region PUBLIC_MEMBER_VARIABLES
    /// <summary>
    /// The materials that will be set for the teapot model
    /// </summary>
	public GameObject object1,object2,object3,object4,object5,object6;
	public Texture2D Color1,Color2,Color3,Color4,Color5,Color6,Price1,Price2,Price3,Price4,Price5,Price6; // drag the texture here
    #endregion // PUBLIC_MEMBER_VARIABLES



    #region PRIVATE_MEMBER_VARIABLES
	private int numObject,currentObject;
	private bool isPriceShow;


    #endregion // PRIVATE_MEMBER_VARIABLES



    #region UNITY_MONOBEHAVIOUR_METHODS

    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
		numObject = 1;
		currentObject = 1;
		isPriceShow = false;

    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS



    #region PUBLIC_METHODS
    
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("OnButtonPressed::" + vb.VirtualButtonName);


		switch (vb.VirtualButtonName)
        {
			case "Video":
				Debug.Log("This is working");
				Application.LoadLevel ("Scene2");
				if(currentObject == 1)
				{
					object1.SetActive(false);
					object2.SetActive(false);
					object3.SetActive(false);
					object4.SetActive(false);
					object5.SetActive(false);
					object6.SetActive(false);
					
					
				}
				
                break;

            case "Action":
				
				isPriceShow = true;
                break;

			case "Next":

				isPriceShow = false;
				if(numObject == 1) {
					currentObject = 1;
					object1.SetActive(true);
					object2.SetActive(false);
					object3.SetActive(false);
					object4.SetActive(false);
					object5.SetActive(false);
					object6.SetActive(false);
					numObject = 2;
				}
				else if(numObject == 2)
				{
					currentObject = 2;
					object1.SetActive(false);
					object2.SetActive(true);
					object3.SetActive(false);
					object4.SetActive(false);
					object5.SetActive(false);
					object6.SetActive(false);
					numObject = 3;
				}
				else if(numObject == 3)
				{
					currentObject = 3;
					object1.SetActive(false);
					object2.SetActive(false);
					object3.SetActive(true);
					object4.SetActive(false);
					object5.SetActive(false);
					object6.SetActive(false);
					numObject = 4;
				}
				else if(numObject == 4)
				{
					currentObject = 4;
					object1.SetActive(false);
					object2.SetActive(false);
					object3.SetActive(false);
					object4.SetActive(true);
					object5.SetActive(false);
					object6.SetActive(false);
					numObject = 5;
				}
				else if(numObject == 5)
				{
					currentObject = 5;
					object1.SetActive(false);
					object2.SetActive(false);
					object3.SetActive(false);
					object4.SetActive(false);
					object5.SetActive(true);
					object6.SetActive(false);
					numObject = 6;
				}
				else if(numObject == 6)
				{
					currentObject = 6;
					object1.SetActive(false);
					object2.SetActive(false);
					object3.SetActive(false);
					object4.SetActive(false);
					object5.SetActive(false);
					object6.SetActive(true);
					numObject = 1;
					
				}
				
				
                break;


        }

    }


	void OnGUI(){
		

		if (currentObject == 1) {
			GUI.DrawTexture(new Rect(600,600,414,128),Color1);
		}
		else if(currentObject == 2) {
			GUI.DrawTexture(new Rect(600,600,414,128),Color2);
		}
		else if(currentObject == 3) {
			GUI.DrawTexture(new Rect(600,600,414,128),Color3);
		}
		else if(currentObject == 4) {
			GUI.DrawTexture(new Rect(600,600,414,128),Color4);
		}
		else if(currentObject == 5) {
			GUI.DrawTexture(new Rect(600,600,414,128),Color5);
		}
		else if(currentObject == 6) {
			GUI.DrawTexture(new Rect(600,600,414,128),Color6);
		}
		
		
		if (currentObject == 1 && isPriceShow == true) {
			GUI.DrawTexture(new Rect(600,40,409,85),Price1);
		}
		else if(currentObject == 2 && isPriceShow == true) {
			GUI.DrawTexture(new Rect(600,40,409,85),Price2);
		}
		else if(currentObject == 3 && isPriceShow == true) {
			GUI.DrawTexture(new Rect(600,40,409,85),Price3);
		}
		else if(currentObject == 4 && isPriceShow == true) {
			GUI.DrawTexture(new Rect(600,40,409,85),Price4);
		}
		else if(currentObject == 5 && isPriceShow == true) {
			GUI.DrawTexture(new Rect(600,40,409,85),Price5);
		}
		else if(currentObject == 6 && isPriceShow == true) {
			GUI.DrawTexture(new Rect(600,40,409,85),Price6);
		}
	}





    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }
		

    #endregion // PUBLIC_METHODS
}
