using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameObjectEx
{
    #region Field

    private static int NameIdColor;

    #endregion Field

    #region Constructor

    static GameObjectEx()
    {
        GameObjectEx.NameIdColor = Shader.PropertyToID("_Color");
    }

    #endregion Constructor

    #region Extension

    public static void RemoveComponent<T>(this GameObject gameObject) where T : Component
    {
        GameObject.Destroy(gameObject.GetComponent<T>());
    }

    public static void RemoveAllComponent(this GameObject gameObject)
    {
        Component[] components = gameObject.GetComponents<Component>();

        for (int i = 0; i < components.Length; i++)
        {
            GameObject.Destroy(components[i]);
        }
    }

    public static void SetColor(this GameObject gameObject, Color color)
    {
        MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();

        Renderer renderer = gameObject.GetComponent<Renderer>();

        renderer.GetPropertyBlock(materialPropertyBlock);

        materialPropertyBlock.SetColor(GameObjectEx.NameIdColor, color);

        renderer.SetPropertyBlock(materialPropertyBlock);
    }

    public static T[] FindObjectsOfType<T>(bool includeInactive = true) where T : Object
    {
        const bool INCLUDE_INACTIVE = true;

        if (includeInactive)
        {
            List<T>      typeObjects = new List<T>();
            GameObject[] gameObjects = SceneManager.GetActiveScene().GetRootGameObjects();

            foreach (GameObject gameObject in gameObjects)
            {
                typeObjects.AddRange(gameObject.GetComponentsInChildren<T>(INCLUDE_INACTIVE));
            }

            return typeObjects.ToArray();
        }

        return GameObject.FindObjectsOfType<T>();
    }

    #endregion Extension
}