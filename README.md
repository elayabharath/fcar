### How to include the Oculus VR components

1. Go here: https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022
2. Sign in to Unity if needed. Click install, let it open the window. It should go Package Manager -> Oculus Integration
3. Download / Upgrade and Import.
4. It will open a window asking if you want to install everything. Say Yes. Wait for a long time
5. Now you can add OVR components to your objects.



----
Notes:
Unclear what FollowPlayer is supposed to do. Even if it's disabled / commented out the ground follows me wherever I look.

OVRInput used for capturing input from the oculus controllers
https://developer.oculus.com/documentation/unity/unity-ovrinput/

It needs to be used with OVRManager as outlined here:
https://developer.oculus.com/documentation/unity/unity-utilities-overview/

Pointers on how to build Input controllers
https://developer.oculus.com/design/bp-userinput/

How to use OVRCameraRig
https://www.youtube.com/watch?v=9_P5yFqwTGU

Unit Serializes variables inside classes and makes them available as Options in the UI
https://docs.unity3d.com/ScriptReference/SerializeField.html
