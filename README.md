# Lethal Company Chaos Mod
A WIP mod to introduce some *spice* to your game.

Send a warning to your party about a jester, and spawn another jester outside!

## Broad scope definition:
This mod is intended to function off of two (mostly) separate systems, known as "Triggers" and "Actions".
Each "Trigger" can have a chance to trigger an "Action", which can either be from the full list of actions, or a given subset that can only happen tied to a given Trigger.


* Triggers
    * Interations or actions that have chances to trigger the different Actions
    * Potential interactions that could be used as Triggers
        * send transmission
        * send chat
        * use airhorn
        * die
        * take damage
        * equip mask
        * give item to enemy
        * place item on corpse
        * etc
* Actions
    * Random actions/events with the goal of adding confusion
    * Locations could be either
        * random (utilizing the game's built-in spawning mechanics)
        * specified (happening at a location decided by either the trigger or type of action)
    * potential actions
        * trigger an explosion at a  location
        * spawn an enemy at a location
        * spawn scrap at a location
        * spawn weapons at a location
        * despawn an enemy
        * respawn a player
        * etc
