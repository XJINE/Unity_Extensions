using UnityEngine;

public static class InputEx
{
    #region Method

    public static bool GetKeysDown(params KeyCode[] keys)
    {
        int keyLength = keys.Length - 1;

        for (int i = 0; i < keyLength; i++)
        {
            if (!Input.GetKey(keys[i]))
            {
                return false;
            }
        }

        return Input.GetKeyDown(keys[keyLength]);
    }

    #endregion Method
}