// Author: Cory Butler
// Created 08/28/17
// Copyright © 2018 by American Technical Publishers, Inc.

// Simulate Android button features in Unity.

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class AndroidFuctionality
{
    // Call with: if (Input.GetKeyDown(KeyCode.Escape))
    public static void BackButton(Button buttonOnClickToInvoke == null)
    {
        if (buttonOnClickToInvoke != null) 
            buttonOnClickToInvoke.onClick.Invoke();
        else
            MinimizeApp();
    }

    private static void MinimizeApp()
    {
        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        activity.Call<bool>("moveTaskToBack", true);
    }
}