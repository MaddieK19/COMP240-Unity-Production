# COMP240-Unity-Production
##Maddie Kay and Thomas Easterbrook

https://teasterbrook17.github.io/COMP240-Unity-Production/

#Change Log
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

####08/02/2017:
* Altered Behaviour tree to use Behaviour Machine Library to make it easier to manage
* Added pathfining to companion

####15/02/2017:
* Added a hunting branch

####18/02/2017:
* Fixed issue where GoToGameObject node could never succeed 
* Added injured subbranch to idle

####02/03/2017:
* Added more leaf nodes

####03/03/2017:
* Added SerialCommUnity package to help Unity work with the Arduino

####05/03/2017:
* Created a new branch for the Arduino haptics
* Merged and updated branches with each other
* Added SerialController to falcon
