using System.Reflection;

public static class ObjectEx
{
    public static string GetFieldString(this object data, string split = "\n",
                                        BindingFlags target = BindingFlags.NonPublic | BindingFlags.Public)
    {
        FieldInfo fieldInfo;
        FieldInfo[] fieldInfos = data.GetType().GetFields(target);

        string result = "";

        for (int i = 0; i < fieldInfos.Length; i++)
        {
            fieldInfo = fieldInfos[i];
            result += fieldInfo.Name + " :" + fieldInfo.GetValue(data);
            result += i == fieldInfos.Length - 1 ? "" : split;
        }

        return result;
    }
}