using UnityEditor;
using UnityEngine;

namespace CKit
{
    public static class AutoAddNameSpaceSwitch
    {
        private const string cacheKey = "AutoAddNameSpace";

        private const string toolbarPath = "CKit/AutoAddNameSpace/";

        //Set CheckMark
        [MenuItem(toolbarPath + "开启", true)]
        private static bool CheckQuickPlay()
        {
            bool auto = EditorPrefs.GetBool(cacheKey, true);
            Menu.SetChecked(toolbarPath + "开启", auto);
            Menu.SetChecked(toolbarPath + "关闭", !auto);
            return true;
        }

        [MenuItem(toolbarPath + "开启")]
        private static void SwitchToQuick()
        {
            SwitchToQuickPrefs(true);
        }

        [MenuItem(toolbarPath + "关闭")]
        private static void SwitchToNoQuick()
        {
            SwitchToQuickPrefs(false);
        }

        private static void SwitchToQuickPrefs(bool targetKeyword)
        {
            EditorPrefs.SetBool(cacheKey, targetKeyword);
        }

        public static bool GetIsAuto()
        {
            return EditorPrefs.GetBool(cacheKey, true);
        }
    }
}