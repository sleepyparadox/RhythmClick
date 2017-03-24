using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityEngine
{
    public static class uSquidUnityUtility
    {
        public static IEnumerable<Transform> GetChildren(this Transform parent)
        {
            for (int i = 0; i < parent.childCount; i++)
            {
                yield return parent.GetChild(i);
            }
        }

        public static IEnumerable<GameObject> GetChildren(this GameObject parent)
        {
            for (int i = 0; i < parent.transform.childCount; i++)
            {
                yield return parent.transform.GetChild(i).gameObject;
            }
        }

        public static void PerformRecursive(this Transform parent, Action<Transform> operation)
        {
            operation(parent);
            for (int i = 0; i < parent.childCount; i++)
            {
                PerformRecursive(parent.GetChild(i), operation);
            }
        }

        public static void PerformRecursive(this GameObject parent, Action<GameObject> operation)
        {
            operation(parent);
            for (int i = 0; i < parent.transform.childCount; i++)
            {
                PerformRecursive(parent.transform.GetChild(i).gameObject, operation);
            }
        }

        public static void PerformAscending(this Transform parent, Action<Transform> operation)
        {
            operation(parent);
            if (parent.transform.parent != null)
            {
                PerformAscending(parent.transform.parent, operation);
            }
        }

        public static void PerformAscending(this GameObject parent, Action<GameObject> operation)
        {
            operation(parent);
            if(parent.transform.parent != null)
            {
                PerformAscending(parent.transform.parent.gameObject, operation);
            }
        }

        public static UnityObject GetUnityObject(this GameObject gameObject)
        {
            if (gameObject == null)
                return null;
            var unityObjectBehaviour = gameObject.GetComponent<UnityObjectBehaviour>();
            if (unityObjectBehaviour == null)
                return null;
            return unityObjectBehaviour.UnityObject;
        }

        public static T FindChildAt<T>(this GameObject parent, string childPath) where T : Component
        {
            return parent.FindChildAt(childPath).GetComponent<T>();
        }

        public static T FindChildAt<T>(this Transform parent, string childPath) where T : Component
        {
            return parent.FindChild(childPath).GetComponent<T>();
        }

        public static GameObject FindChildAt(this GameObject parent, string childPath)
        {
            return parent.transform.FindChild(childPath).gameObject;
        }

        public static Transform FindChildAt(this Transform parent, string childPath)
        {
            if (childPath.Contains('/'))
            {
                Transform child = null;
                var children = childPath.Split('/');
                foreach (var childName in children)
                {
                    child = FindChildUsingName(parent, childName);

                    if(child == null)
                    {
                        //Not found
                        break;
                    }
                    else
                    {
                        parent = child;
                    }
                }
                return child;
            }
            else
            {
                return FindChildUsingName(parent, childPath);
            }
           
        }

        static Transform FindChildUsingName(Transform parent, string childName)
        {
            for (int i = 0; i < parent.childCount; i++)
            {
                var child = parent.GetChild(i);
                if (child.gameObject.name == childName)
                    return child;
            }

            Debug.LogWarning(string.Format("Couldn't find child \"{0}\" of parent \"{1}\"", childName, parent.name));
            return null;
        }

        public static bool IsWhiteSpaceOrEmpty(this string src)
        {
            return !src.Any(c => c != ' ' && c != '\n' && c != '\r' && c != '\t');
        }
    }
}
