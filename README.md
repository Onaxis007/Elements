## THE HYPAR SDK IS CURRENTLY IN BETA. DO NOT USE IT FOR PRODUCTION WORK.

# Hypar SDK
The Hypar SDK is a library for creating functions that execute on Hypar.

- `Hypar.Elements` provides abstractions for building elements like beams and slabs.
- `Hypar.Geometry` provides a minimal geometry library that supports points, lines, curves, and extrusions.

The Hypar SDK also reads and writes data using several open standards like [GeoJson](http://geojson.org/) and [glTF](https://www.khronos.org/gltf/).

## Getting Started
- The Hypar SDK is currently in beta. Contact beta@hypar.io to have an account created. Functions can be authored and executed locally. A login is only required when publishing your function to the world!
- Install [.net](https://www.microsoft.com/net/) - Hypar Elements is compatible with .net standard 2.1.
- Install the [Hypar CLI](https://github.com/hypar-io/sdk/edit/master/src/cli/README.md).
```
hypar new <function name>
cd <function name>
```
- Edit the `hypar.json` file to describe your function.
```
hypar publish
```
- Preview `.glb` models generated by Hypar locally using the [glTF Extension for Visual Studio Code](https://github.com/AnalyticalGraphicsInc/gltf-vscode), or [Don McCurdy's online glTF Viewer](https://gltf-viewer.donmccurdy.com/).

## Examples
The best examples are those provided in the [tests](https://github.com/hypar-io/elements/tree/master/test), where we demonstrate usage of almost every function in the library.

## Build
`dotnet build`

## Test
`dotnet test`

## Third Party Libraries

- [LibTessDotNet](https://github.com/speps/LibTessDotNet)  
- [Verb](https://github.com/pboyer/verb)