using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityEngine
{
    public class AssetManager
    {
        const string ResourcesPath = "Resources/";
        const string StreamingPath = "StreamingAssets/";

        static AssetManager _instance = new AssetManager();

        //Simple singleton
        static AssetManager() { }
        private AssetManager()
        {
            _loadedAssets = new Dictionary<string, UnityEngine.Object>();
        }

        public static List<KeyValuePair<string, UnityEngine.Object>> GetAllLoadedAssets()
        {
            var list = _instance._loadedAssets.ToList();
            return list;
        }

        public static bool HasLoaded(string assetPath)
        {
            return _instance._loadedAssets.ContainsKey(assetPath);
        }

        public static T Load<T>(string assetPath) where T : UnityEngine.Object
        {
            Debug.Log("Loading: " + assetPath);

            if (HasLoaded(assetPath))
            {
                Debug.Log("Aready loaded: " + assetPath);
                return (T)_instance._loadedAssets[assetPath];
            }

            if(typeof(T) == typeof(Shader))
            {
                //TODO: Shader.Find
                throw new NotImplementedException();
            }
            else if(assetPath.Length >= ResourcesPath.Length
                && assetPath.Substring(0, ResourcesPath.Length) == ResourcesPath)
            {
                var assetPathInsideResources = assetPath.Substring(ResourcesPath.Length, assetPath.Length - ResourcesPath.Length);
                
                //Ignore filetype when using Resoures.Load<T>()
                var file = assetPath.Split('/').Last();
                if(file.Contains("."))
                {
                    var fileType = '.' + file.Split('.').Last();
                    assetPathInsideResources = assetPathInsideResources.Substring(0, assetPathInsideResources.Length - fileType.Length);
                }
                
                
                Debug.Log("From resources: " + assetPathInsideResources);
                var asset = Resources.Load<T>(assetPathInsideResources);
                _instance._loadedAssets.Add(assetPath, asset);
                return asset;
            }
            else if (assetPath.Length >= StreamingPath.Length
                && assetPath.Substring(0, StreamingPath.Length) == StreamingPath)
            {
                //TODO: WWW
                throw new NotImplementedException();
            }
            else
            {
                throw new Exception("Unknown load method for path " + assetPath);
            }
        }

        public static void Clear()
        {
            _instance._loadedAssets.Clear();
        }

        public static void Unload(string assetPath, bool immediate = false)
        {
            if (!HasLoaded(assetPath))
                return;

            if (immediate)
            {
                UnityEngine.Object.DestroyImmediate(_instance._loadedAssets[assetPath]);
            }
            else
            {
                UnityEngine.Object.Destroy(_instance._loadedAssets[assetPath]);
            }

            _instance._loadedAssets.Remove(assetPath);
        }

        Dictionary<string, UnityEngine.Object> _loadedAssets;
    }
}