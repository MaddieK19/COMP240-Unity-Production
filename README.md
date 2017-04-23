# COMP240-Unity-Production
## Maddie Kay and Thomas Easterbrook

# Asset Packages Used:
* [SteamVR Plugin](https://www.assetstore.unity3d.com/en/#!/content/32647)
* [SerialCommUnity](https://dwilches.github.io/SerialCommUnity/)
* [Falcon](https://www.assetstore.unity3d.com/en/#!/content/26962)
* [Low Poly Styled Trees](https://www.assetstore.unity3d.com/en/#!/content/43103)
* [Behaviour Machine](https://www.assetstore.unity3d.com/en/#!/content/20280)
* [Infinitia Mountains](https://www.assetstore.unity3d.com/en/#!/content/53984)
* [Realistic Terrain Collection LITE](https://www.assetstore.unity3d.com/en/#!/content/47726)



# Change Log
#### 30/01/2017:  
* Started migrating project over to Unity to make VR easier to implement  

#### 31/01/2017:  
* Altered Node, CompositeNode, DecoratorNode, SelectorNode, SequenceNode and LeafNode to work in Unity/C#
* Added Companion abstract class and falcon class
* Added Falcon assets

#### 06/02/2017:
* Added DeadBranch

#### 07/02/2017:
* Added code to DeadBranch
* Added leaf child
* Fixed error where LeafNode was not initialising correctly
* Added IdleBranch

#### 08/02/2017:
* Altered Behaviour tree to use Behaviour Machine Library to make it easier to manage
* Added pathfining to companion

#### 15/02/2017:
* Added a hunting branch

#### 18/02/2017:
* Fixed issue where GoToGameObject node could never succeed 
* Added injured subbranch to idle

#### 02/03/2017:
* Added more leaf nodes

#### 03/03/2017:
* Added SerialCommUnity package to help Unity work with the Arduino

#### 05/03/2017:
* Created a new branch for the Arduino haptics
* Merged and updated branches with each other
* Added SerialController to falcon

#### 14/03/2017:
* Added try catch so game does not crash when there's no Arduino plugged in

#### 26/03/2017:
* Created new branch for VR
* Added SteamVR plugin
* Switched camera to be SteamVR CameraRig

#### 28/03/2017:
* Merged PCG and Ai branches in Developement

#### 04/04/2017
* Randomly spawns mountains and trees
* Added Vive controller compatability to BT

