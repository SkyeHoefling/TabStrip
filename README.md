# TabStrip for Xamarin.Forms
Tab Strip control for Xamarin.Forms

## Setup

* Available on NuGet: Not yet released
* Install into your PCL and Client Projects

## Build

* [![Build status](https://ci.appveyor.com/api/projects/status/d0frm6gffguiclpy?svg=true)](https://ci.appveyor.com/project/ahoefling/tabstrip)
* CI NuGet Feed: [https://ci.appveyor.com/nuget/tabstrip](https://ci.appveyor.com/nuget/tabstrip)
    
### Platform Support
This will be filled out when we get closer to the first release

| Platform         | Supported | Version     |
|------------------|-----------|-------------|
| Xamarin.Android  | Yes       | API ?+      |
| Xamarin.iOS      | Yes       | iOS ?+      |
| Xamarin 10 UWP   | No        |             |
| macOS            | No        |             |
| linux            | No        |             |
| tvOS             | No        |             |
| watchOS          | No        |             |


* Project still in development no NuGet releases yet

## Usage

Initialize the renderers in your iOS and Android projects

```c#
Xamarin.Forms.Init();
TabStripRenderer.Init();
```

### XAML: ####

Add the namespace in the xmlns:

```xml
xmlns:plugin="clr-namespace:TabStrip.FormsPlugin.Abstractions;assembly=TabStrip.FormsPlugin.Abstractions"
```

Add the control:

```xml
<plugin:TabStripControl Position="{Binding CurrentPosition}" />
```

## Bindable Properties

| Property | Description                                                        | Default Value |
|----------|--------------------------------------------------------------------|---------------|
| Position | Gets or Sets current tab position of the tab strip.                | 0             |

## Release Notes

* Not released yet

## Roadmap

* [Minimal Viable Product (MVP)](https://github.com/ahoefling/TabStrip/wiki/Minimal-Viable-Product)
* Windows Support
* macOS Support
* linux Support
* Native Support

### Minimal Viable Product

* Implement basic cross-platform Tabstrip that supports Android and iOS via Xamarin.Forms

### Windows Support

* Implement Windows UWP support via Xamarin.Forms

### macOS Support

* Implement macOS support via Xamarin.Forms

### linux Support

* Implement linux support via Xamarin.Forms

### Native Support

* Implement Xamarin Navite support so it can be consumed in a Xamarin Native project instead of Xamarin.Forms. This will require a larger code re-write since it will be using Xamarin.Forms wrappers prior to this release

## Created By: [@Andrew_Hoefling](https://twitter.com/andrew_hoefling)

* Twitter: [@Andrew_Hoefling](https://twitter.com/andrew_hoefling)
* Blog: [andrewhoefling.com](http://www.andrewhoefling.com)

## History

* project started from this conversation: [https://github.com/alexrainman/CarouselView/issues/232#issuecomment-338496021](https://github.com/alexrainman/CarouselView/issues/232#issuecomment-338496021)

### Xamarin Dependencies

Thanks to other plugin creators to make this plugin possible

* [Carousel View](https://github.com/alexrainman/CarouselView)

### License

The MIT License (MIT) see License File