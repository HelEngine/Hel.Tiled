
<!-- PROJECT SHIELDS -->
<!--
-->
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=HelEngine_Hel.Tiled&metric=alert_status)](https://sonarcloud.io/dashboard?id=HelEngine_Hel.Tiled)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=HelEngine_Hel.Tiled&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=HelEngine_Hel.Tiled)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=HelEngine_Hel.Tiled&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=HelEngine_Hel.Tiled)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=HelEngine_Hel.Tiled&metric=sqale_index)](https://sonarcloud.io/dashboard?id=HelEngine_Hel.Tiled)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=HelEngine_Hel.Tiled&metric=ncloc)](https://sonarcloud.io/dashboard?id=HelEngine_Hel.Tiled)



<!-- PROJECT LOGO -->
<br />
<p align="center">

  <h3 align="center">Hel Tiled</h3>

  <p align="center">
    Wrapper for utilizing Tiled maps in C#. Created for the Hel Engine.
    <br />
    <a href="https://helengine.github.io/Hel.Docsify/#/"><strong>Explore the docs »</strong></a>
    <br />
    <a href="https://helengine.github.io/Hel.Tiled/">API Reference</a>
    .
    <a href="https://www.mapeditor.org/">Tiled</a>
    ·
    <a href="https://github.com/HelEngine/Hel.Tiled/issues">Report Bug</a>
    ·
    <a href="https://github.com/HelEngine/Hel.Tiled/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
* [Getting Started](#getting-started)
  * [Installation](#installation)
* [Usage](#usage)
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)



<!-- ABOUT THE PROJECT -->
## About The Project

Hel.Tiled is a completely decoupled Tiled map loader. Although Hel.Tiled is used in Hel.Engine, you can use it
with any framework you want. 

Hel.Tiled is not currently stable.

Highest tested TILED version: [1.4.2](https://github.com/bjorn/tiled/releases/tag/v1.4.2)

**Hel.Tiled currently only supports JSON files**

<!-- GETTING STARTED -->
## Getting Started

Hel.Tiled is available on the [NuGet package manager](https://www.nuget.org/packages/Hel.Tiled/) 

### Installation

Add [Hel.Tiled](https://www.nuget.org/packages/Hel.Tiled/) to your project, or build is locally.


## Usage

[Full release documentation](https://helengine.github.io/Hel.Tiled/)

Usage depends on if this library is being used on its own or through Hel.Engine.

### Hel.Engine usage
Using **Hel.Tiled** in **Hel.Engine** is very simple.

```c#
// Call the static tilemap loader in Hel.Engine and pass the path to your json file
// stored in Content.
var tilemap = TiledLoader.TilemapLoader("myFile.json");
```
You can now use the tilemap object. This will also load the proper textures.

#### Hel.Tiled usage

```c#
// Call the tilemap loader
var tilemap = TiledFactory.LoadTilemap(@"path/to/file.json");
```

This will load the tilemap and its tilesets. Tileset textures will **NOT** be loaded however. 

<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/HelEngine/Hel.Tiled/issues) for a list of proposed features (and known issues).


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Lorenzo Torelli - [@twitter_handle](https://twitter.com/twitter_handle) - lorenzo@tortonmind.com

