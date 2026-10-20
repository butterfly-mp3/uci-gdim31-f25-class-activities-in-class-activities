# in-class-activities
## Devlogs
### W1
"Hello, World!"

1. In the Hierarchy, move the Camera off of the Cat GameObject, so that it’s no longer a
child of the Cat. What happens when you run the game now, and why?
    It no longer follows the cat as it moves, because it's not a child of the cat anymore and doesn't share the cat's transformations

itch page: https://auravum.itch.io/week-1-in-class-assignment

### W2
1. *Why are the r, g, and b variables floats instead of ints, bools, or strings?*
    They're represented with decimals (floats) because the range is from 0 to 1, forcing you to use decimals to get any other number.

2. *Why is the _bounce variable an int instead of a float, bool, or string?*
    because it increments, so only whole numbers are needed. You can't do half a bounce after all. You also are doing more than one bounce, so a boolean won't work, and unless you want a huge switch statement saying "if bounces == 1, bounces = 2; if bounces == 2, bounces = 3;...", it's just not a good option

3. *The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?*
    I didn't get an error from Step 4, but I did get errors in several other places for not including the "f" at the end of assigning the r, g, b values.

### W3
Table #5

*Imagine we need to design a method to perform the following function. What would you make the parameters (input) and return type (output) of this method?*

1. You’re building a visual novel, and you’re writing a method named GetResponse that gives you a character’s text response to a player’s dialogue choice. The relevant data for the dialogue choice are the player’s current friendship level with the character and a flag that tells you whether or not the player knows the character’s secret.
    Parameters: player dialogue choice, friendship level, knows secret
    Return type: (string)response dialogue

2. You’re building a horror game, and you’re writing a method named SetLightDimness that makes the room’s lights brighter or darker based on the player’s current sanity level. The player’s sanity level is a number that goes from 0% - 100%. The method changes the light itself, so it doesn’t need any output.
    Parameters: sanity

3. You’re building a rhythm game, and you’re writing a method named DidPlayerHitBeat that tells you whether or not the player accurately hit a beat based on the time that they pressed a key.
    Parameters: current beat, note beat
    return: (boolean) hit beat?

*With your table mates, come up with a metaphor to explain the relationship between classes and Components with a metaphor. Also describe how methods and member variables factor into that metaphor.  Remember that classes are templates that can become Components; member variables are traits of each class; and methods are things the class can do.*
    Components are a dish. Classes are the recipe for that dish, with the member variables being the ingredients list and the methods being the actual instructions to use those ingredients.

*Why do you think the balls get extremely bright, especially in the Scene, if they bounce too many times?*
    Since the brightness is just multiplied every time it bounces, each bounce mutiplies the brightness without ever changing it back, making more bounces brighter than the last.

### W4
1. What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?
    I added RigidBodies to both the cat and the ball, because the cat had a parameter for the rigidbody in it's script component, and the ball was fairly obvious it needed to have physics to actual move at all. The goal I added a trigger because I didn't want anything to actually be stopped from moving through it, and just know when it's inside it, which is exactly what the trigger option does.
2. IF your game did not work perfectly the first time you tested it, talk about what you had to fix.
    Of course it worked perfectly...
    There was a point where I forget to put .text at the end of _pointsText... Eventually I figured out what I was missing but for a second I was going insane.


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 