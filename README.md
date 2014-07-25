Augment-Randomiser
==================

A quick and dirty augment randomiser with a crude overlay ability for use with deus ex games. The randomiser will tell you what upgrades to get when (Don't worry - it will only tell you ones you can actually buy!). For use in fun runs for All missions% and perhaps other categories.

#How To Use
##The Basics
Head on over to the releases tab and find the latest version (Currently this is version 1.1). Follow the instructions in the release post to make sure you download the right things. All things going well, you can now start using the program.

The menu bar at the top gives you the options to set a seed for your randomiser run, it is advised you do this now (otherwise the software will use your system time). After setting your seed DO NOT HIT RESET. Reset is used to reset the augments given (I.e. when you first arrive on the boat for The Missing Link), IT DOES NOT RESET THE RNG.

The big gold button at the bottom states what augment the lords of RNG have bestowed upon you. The augment will state the praxis cost in the brackets afterwards. Hit this button when you have acquired this upgrade, and the RNGeesus will decide which augment to bless you with next.

The astute reader may have noticed a big list box full of gold augments. The augments in light gold are the augments you currently own (Jensen has some augments turned on by default!). The augments in dark gold are ones you could potentially draw at random. If you hit expand all (or double click some of the items in the list) you will see some augments marked in white - you can't roll these yet, but you may eventually. You can expand and collapse augments marked with a +/-.

Note: The recoil compensation augment depends on two previous augments, so it may still be white even if you own the augment directly above it.

##Hotkeys and Overlay
By default:
F9: Tells the program you have bought the upgrade, and rolls the next one.
F11: Tells the program to clear all owned augments (I.e. The Missing Link)
F12: Tells the program to toggle overlay mode

Overlay mode simply forces the window to be a topmost window, and reduces it to a simple bit of text stating your next augment and cost. To get the overlay to work ingame start the game with overlay mode toggled off, then toggle it when you get to the main menu. If you toggle too early or the overlay disappears, simply toggle it on and off.

#Modding
You can specify your own exciting aug trees by editing upgrades.txt and reading the rather trivial syntax guidelines.
You can edit the keybindings (and even bind keys to things which aren't bound by default) in keys.txt

