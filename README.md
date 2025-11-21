ITCG Bonus Assignment 

Shader one: Flat shader with specular highlights


Ambient shader uses the ambient light around multiplied by the color white to create bounce lighting

This is combined with the saturated result of the dot product of the main light and the normal vector in order to create lambert lighting with ambert diffuse


This is then combined with the reflection of the light, which is the dot product of the  reflection result of the normal vector and the view direction, and the view direction, creating specular highlights

I added the shader because the game uses pixel art instead of 3d art, so i created the flat shader element to make the game more closely resemble the look of the arcade games

The game was also stated to have a jump animation that was a saumersault, which i interpreted as a spherical shape, which is why its represented by a sphere in game.


Shader two: Rim lighting with flickering effect

First I get the saturated result of the dot product between the view direction and the normal vector

Then i subtract the result from 1 to create a rim effect

then i multiply the result b a value to change the rim's size, as well as multiplying by a color to make it more asthetically pleasing

I then generate a random value using the object's position and the time as a seed to generate a random number between 0 and 1, which creates randomized dots within the rim

I added the shader because old monitors tend to have this effect on the images being displayed, and I wanted to highlight that effect.

