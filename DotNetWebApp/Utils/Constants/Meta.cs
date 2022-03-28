using System;
using System.Collections.ObjectModel;

namespace DotNetWebApp.Utils.Constants;

public static class Meta
{
    public static ReadOnlyDictionary<int, string> List { get; } = new ReadOnlyDictionary<int, string>(
        new Dictionary<int, string> {
                { 1, "hoge"},
                { 2, "fuga"},
                { 3, "piyo"},
        }
    );

    public static bool ContainsKey(int key) => List.ContainsKey(key);
}

