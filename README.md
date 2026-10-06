# in-class-activities
## Devlogs
### W1
"Hello, World!"

In the Hierarchy, move the Camera off of the Cat GameObject, so that it’s no longer a
child of the Cat. What happens when you run the game now, and why?
- It no longer follows the cat as it moves, because it's not a child of the cat anymore and doesn't share the cat's transformations

itch page: https://auravum.itch.io/week-1-in-class-assignment

### W2
*Why are the r, g, and b variables floats instead of ints, bools, or strings?*
They're represented with decimals (floats) because the range is from 0 to 1, forcing you to use decimals to get any other number.

*Why is the _bounce variable an int instead of a float, bool, or string?*
because it increments, so only whole numbers are needed. You can't do half a bounce after all. You also are doing more than one bounce, so a boolean won't work, and unless you want a huge switch statement saying "if bounces == 1, bounces = 2; if bounces == 2, bounces = 3;...", it's just not a good option

*The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?*
I didn't get an error from Step 4, but I did get errors in several other places for not including the "f" at the end of assigning the r, g, b values.

### W3
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 