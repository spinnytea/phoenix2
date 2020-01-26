# Organized Unity Project

[7 Ways to Keep Your Unity Project Organized](https://blog.theknightsofunity.com/7-ways-keep-unity-project-organized/)

## Directory Structure

This project is already setup with the suggested structure.

1. Do not store any asset files in the root directory. Use subdirectories whenever possible.
1. Do not create any additional directories in the root directory, unless you really need to.
1. Be consistent with naming. If you decide to use camel case for directory names and low letters for assets, stick to that convention.
1. Don’t try to move context-specific assets to the general directories. For instance, if there are materials generated from the model, don’t move them to Materials directory because later you won’t know where these come from.
1. Use 3rd-Party to store assets imported from the Asset Store. They usually have their own structure that shouldn’t be altered.
1. Use Sandbox directory for any experiments you’re not entirely sure about. While working on this kind of things, the last thing that you want to care about is a proper organization. Do what you want, then remove it or organize when you’re certain that you want to include it in your project. When you’re working on a project with other people, create your personal Sandbox subdirectory like: Sandbox/JohnyC.

## Scene Hierarchy Structure

Under `Assets > Scenes > Other` is a `Template` with the suggested structure.

1. All empty objects should be located at 0,0,0 with default rotation and scale.
1. When you’re instantiating an object in runtime, make sure to put it in _Dynamic – do not pollute the root of your hierarchy or you will find it difficult to navigate through it.
1. For empty objects that are only containers for scripts, use “@” as prefix – e.g. @Cheats

## Prefabs for Everything

Change the prefab, change them all!

## Version Control

At least use it for the scripts folder, if not the whole project.

## Editor Scripts

Basically, automate tasks you perfom often.

## Program Defensively

Basically, write good code. Don't expect anyone to use your file/script correctly.

## Implement In-Editor Cheats

This is about testing. Make some editor controls that help you setup your tests.

	Invincibility and Infinite Time let you not have to worry about those things while run into walls and test out the timing of a parry (or whatever else you need to tune).

```cs
class Cheats
{
	[MenuItem("My Game/Cheats/Unlock All Levels")]
	public static void UnlockAllLevels()
	{
		if (Application.isPlaying)
		{
			// unlock code here...
		} else {
			Debug.LogError("Not in play mode.");
		}
	}
}
```
