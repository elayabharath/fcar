### How to include the Oculus VR components

1. Go here: https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022
2. Sign in to Unity if needed. Click install, let it open the window. It should go Package Manager -> Oculus Integration
3. Download / Upgrade and Import.
4. It will open a window asking if you want to install everything. Say Yes. Wait for a long time
5. Now you can add OVR components to your objects.



----
## Notes:
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


---
### Failed experiments with distance grabbing.
Attempting to make the car grabble, but it's not working - likely because the car is too big. Added Distance Grabbable and Grabbable to the car. Grabber is added by default to both hands.. included distance grabbable to the left hand, but no luck

Well okay, now the left hand is grabbable while the right hand is distance grabbable.
The ball is grabbable, while the bottle is distance grabbable

Both hands can grab the bottle. The right hand randomly grabs the bottle at a distance. Unclear what exactly triggers it but it suddenly snaps to my hands. There is also a light glow around the bottle if I move my right hand, which does not happen if I move my left hand.

Left hand can grab the ball, but right hand seems to create some explosive force.

(also, made the car bigger, and moved the items to the edge of the car, and removed the obstacles for ease of use)

--
### Hand Tracking:
https://developer.oculus.com/design/hands-design-ui/
https://developer.oculus.com/documentation/unity/unity-handtracking/
https://skarredghost.com/2020/01/03/how-to-oculus-quest-hands-sdk-unity/

There doesnt seem to be a built-in way to grab using hand-tracking.
https://www.reddit.com/r/oculus/comments/eq2h21/hand_tracking_experiments_measuring_grab_force/

We can adapt the OVR Grabber to make it grab on pinch like so:
https://www.youtube.com/watch?v=UoSzhoZ18bE
