using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader
{
    public enum Scene
    {
        GameScene,
        Loading,
        MainMenu,
    }

    private static Action loaderCalllbackAction;

    public static void Load(Scene scene)
    {

        // Set up the callback action that will be triggered after the Loading scene is loaded
        loaderCalllbackAction = () =>
        {
            // Load target scene when Loading scene is loaded
            SceneManager.LoadScene(scene.ToString());
        };


        // Load loading scene
        SceneManager.LoadScene(Scene.Loading.ToString());

    }

    public static void LoaderCallback()
    {
        if(loaderCalllbackAction != null)
        {
            loaderCalllbackAction();
            loaderCalllbackAction = null;
        }
    }
}
