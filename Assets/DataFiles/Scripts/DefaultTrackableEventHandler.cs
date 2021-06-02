/*==============================================================================
Copyright (c) 2019 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    #region PROTECTED_MEMBER_VARIABLES
    public GameObject cengizhanBookGo, daliBookGo, eserlerBookGo, haliBookGo, kitapBookGo, picassoBookGo, rodinBookGo, venedikBookGo, caterpillarBookGo, corduroyBookGo, mooseBookGo, numbersGo, colorsGo, animalsGo;

    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
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

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName +
                  " " + mTrackableBehaviour.CurrentStatus +
                  " -- " + mTrackableBehaviour.CurrentStatusInfo);

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (mTrackableBehaviour.TrackableName =="Numbers")
            {
                numbersGo.SetActive(true);
                colorsGo.SetActive(false);
                animalsGo.SetActive(false);
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
            }
            else if (mTrackableBehaviour.TrackableName == "Color")
            {
                numbersGo.SetActive(false);
                colorsGo.SetActive(true);
                animalsGo.SetActive(false);
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
            }
            else if (mTrackableBehaviour.TrackableName == "Animals")
            {
                numbersGo.SetActive(false);
                colorsGo.SetActive(false);
                animalsGo.SetActive(true);
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
            }
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
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
            OnTrackingLost();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        if (mTrackableBehaviour)
        {
            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);

            // Enable rendering:
            foreach (var component in rendererComponents)
                component.enabled = true;

            // Enable colliders:
            foreach (var component in colliderComponents)
                component.enabled = true;

            // Enable canvas':
            foreach (var component in canvasComponents)
                component.enabled = true;
        }
    }


    protected virtual void OnTrackingLost()
    {
        if (mTrackableBehaviour)
        {
            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);

            // Disable rendering:
            foreach (var component in rendererComponents)
                component.enabled = false;

            // Disable colliders:
            foreach (var component in colliderComponents)
                component.enabled = false;

            // Disable canvas':
            foreach (var component in canvasComponents)
                component.enabled = false;
        }
    }

    #endregion // PROTECTED_METHODS
}
