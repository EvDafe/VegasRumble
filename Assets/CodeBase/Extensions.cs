using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.ServicesScripts.Progress
{
    public static class Extensions
    {
        public static T FromJsonsireot<T>(this string yes) =>
            JsonConvert.DeserializeObject<T>(yes, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });

        public static string ToJsonagtjyl<T>(this T obj) =>
            JsonConvert.SerializeObject(obj, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });

        public static Vector3 RandomDirectionegtjmf(this Vector3 vector) =>
            new Vector3(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f)).normalized;

        public static Vector2 RandomDirectiondltope(this Vector2 vector) =>
            new Vector2(UnityEngine.Random.Range(-1, 1f), UnityEngine.Random.Range(1f, 1f)).normalized;


        public static void Shufflemtieot<T>(this IList<T> list)
        {
            System.Random rng = new System.Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static T Randomqewrfe<T>(this IList<T> list) =>
            list.ElementAt(UnityEngine.Random.Range(0, list.Count));

        public static List<int> GetRandomIndexesnfmyot<T>(this List<T> list ,int from, int to)
        {
            var random = new System.Random();
            HashSet<int> numbers = new HashSet<int>();
            while (numbers.Count < list.Count)
            {
                numbers.Add(random.Next(from, to));
            }
            return numbers.ToList();
        }

        public static T Randomshtyur<T>(this List<T> list) =>
            list[UnityEngine.Random.Range(0, list.Count)];

        public static Vector3 FindReflectedVectorBetweenwesdcv(this Vector3 from, Vector3 to)
        {
            if (from == null) throw new ArgumentException();
            if (to == null) throw new ArgumentException();
            return to - from;
        }
        public static Vector3 FindVectorBetweenmhktle(this Vector3 from, Vector3 to)
        {
            if (from == null) throw new ArgumentException();
            if (to == null) throw new ArgumentException();
            return from - to;
        }
        public static Vector3 FindClosestmdktle<T>(this Vector3 from, List<T> source) where T : Component
        {
            if (source.Count <= 0) throw new ArgumentException();
            if (from == null) throw new ArgumentException();

            T closest = source.First();

            foreach (var another in source)
            {
                if (Vector3.Distance(another.transform.position, from) <
                    Vector3.Distance(closest.transform.position, from))
                    closest = another;
            }
            return closest.transform.position;
        }
    }

}
