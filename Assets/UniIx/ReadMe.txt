UniIx - Interactive Extensions for Unity
===

[Interactive Extensions (Ix)](https://github.com/Reactive-Extensions/Rx.NET) is a library which extends LINQ to Objects to provide many of the operators available in Rx but targeted for IEnumerable.



Installation
---

Use [UniIx.unitypackage](./UniIx.unitypackage) to install.  



How To Update UniIx
---

1. Copy .cs files from [Interactive Extensions](https://github.com/Reactive-Extensions/Rx.NET/tree/master/Ix.NET/Source/System.Interactive).
2. Paste to Assets/UniIx directory.
3. Convert `nameof(xxx)` to `"xxx"` in .cs files.
3. Comment `Do<TSource>(this IEnumerable<TSource> source, IObserver<TSource> observer)` method in `Do.cs`.



License
---
This library is under the MIT License.

Some code is borrowed from [Rx.NET](https://rx.codeplex.com/) and [mono/mcs](https://github.com/mono/mono).
