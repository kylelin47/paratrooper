# paratrooper
## Motivation and Explanation
Our goal was to center our learning around a memorable experience. We wanted the experience to have unique sound
and a dynamic environment, so that it would be easily recognizable. We felt that sky diving satisfied these requirements. The visual
of falling through the clouds, and seeing the ground from so high that its features appear flat should evoke strong reaction and
imagination from the user. The sound of the wind rushing by quickly in free-fall contrasted with the relative calm of the parachute
flapping in the breeze should do the same. We decided we would teach about the basic knowledge required in order to safely sky dive.

We then decided to choose the location of the sky dive to be the [Great Blue Hole](https://en.wikipedia.org/wiki/Great_Blue_Hole).
From the start, we knew the location of the sky dive had to be a recognizable location, because sky diving into a generic environment
isn't as interesting. We decided on the Great Blue Hole in particular because of its size and how it's recognizable even from high
in the air.

At the end of the experience, we wanted our user to have a greater understanding of the steps taken in sky diving, along with some insight
into the mechanics of skydiving (for example, time spent in free fall, height to dive from, how sound changes when parachute deploys).

The user begins inside a small plane circling the Great Blue Hole.
A voice in the user's ear gives some introductory information, with sound effects meant to emulate the effect of a radio transmission, then
the door to the plane opens and the user jumps out of the plane. On the way down, the user is given instructions on how to safely complete
the sky dive.

### Learning Objective
After the VR experience, users will be able to demonstrate understanding of the key steps needed in order to sky dive.

### Increasing Sense of Presence
- Audio
    - All spatialized to seem to occur from proper location
    - Wind sounds that increase depending on velocity
    - Sounds of parachute opening, flapping in the wind, plane leaving
    - Instructions and learning information integrated into the world as a voice in an earpiece
- Visual
    - Avatar present
    - Volumetric clouds present at correct altitudes
    - Camera turns to match head position that a sky diver would have
    - Body rotates to positions that a sky diver would have
    - Graphics cover the entire range of experience
- Misc
    - Speeds and timings roughly scaled to reality
    - Single, easy to understand and follow story line with a strong central theme
    - Small beginning environment to acquaint users with looking around in VR before main experience begins

### Environment Design
- Care was taken to scale objects appropriately to each other
- Ambient sound effects are present and make sense to the situation
- Audio is spatialized
- Clouds are used as wayfinding aids
    - When looking up can help the user judge how far they have fallen
    - Helps orient the user when camera position changes
- Great Blue Hole is a landmark to help orient the user
- The parachute and the airplane have colors that contrast sharply with the background in order to stand out

## Education Results
## The Experience
Youtube Video:

Source code and executable:
## Technical Explanation
- Gravity was simulated using a RigidBody on the player
- Movement occurred by applying forces to the RigidBody
- The effect of a parachute was simulated by applying drag to the RigidBody
- Clouds are generated programatically
- Stereo overlays created by having a Canvas in the world space follow the camera
- Camera attached to the head of the avatar
- Avatar rotates to follow the camera
- Transitions (standing --> spread eagle --> parachuting) made using Unity Animator

## Non-Student Created Assets
### Audio
| Title | Author | Source |
| --- | --- | --- |
| Radio Static | None Listed | http://soundbible.com/149-Radio-Static.html |
| Sky Diving | Huggy\|3ear | https://www.freesound.org/people/Huggy13ear/packs/8657/ |
### Models
| Title | Author | Source |
| --- | --- | --- |
| CloudsToy | joycf | http://www.jocyf.com/utilsEnglih.html |
| Parachutes | 3D Everything | https://www.assetstore.unity3d.com/en/#!/content/40565 |
| Underwater world and effects | Konstantin Dvornik | http://kostiantyn-dvornik.blogspot.com/2013/05/unity-worlds-coolest-tutorial-about.html |
| Fishing Boat | Ozgur Saral | https://www.assetstore.unity3d.com/en/#!/content/23181 | 
| Cessna 172 Plane | 3dregenerator | http://tf3dm.com/3d-models/maya | 
| Pilot | AutoDesk Character Generator | https://charactergenerator.autodesk.com/account/MyAvatars.aspx | 
| Thumbs Up | Mixamo | https://www.mixamo.com/ |
## Team Members
- Kyle Lin
- Virada Long
- Tonny Xie
