Kaleidoscope
============

This program was inspired by an Android app called "Magic Kaleido" by the oddly-named "Doodle Joy Studio". While it seems like it's designed for kids, especially when you look at their other apps, I've found it surprisingly addictive, and I'm 20 at the time of writing this. (They've since come out with a better version, called "Magic Brush Box", that lets you set the color and brush type manually, and is still free.) Anyway, I was experimenting with C# and .NET, as I had been wanting to learn it for a while. I ended up creating this program, which is very similar.

## How to Use

This program is mostly pretty self-explanatory, but there's a few things that need explanation. First of all, if you're wondering why the color palette is so weird, it's because it's randomly generated each time you run the application. Two colors that are guaranteed to appear, however, are black and white. Some time soon I'll probably add some more preset colors. (And not just so I won't be accused of [hypocrisy](http://flarn2006.blogspot.com/2012/07/fixing-color-palette-in-windows-7s.html).

As you probably already figured out (unless you're reading this before you try the program) you can draw by dragging in the white area in the center of the window. It will automatically draw more lines in a symmetrical manner, and you can make some neat designs with this. On the right, you can control the number of "reflections" it makes, as well as the pen width. If you uncheck "doubled", you can draw lines going purely clockwise or purely counterclockwise, without another line appearing going the opposite direction.

If you resize the window, you may notice that new lines you draw no longer radiate from the center of the window. This is intentional. Originally I had it automatically reposition the center point, but this would get troublesome if I wanted to resize the window in the middle of a drawing, as then it wouldn't be symmetrical anymore. So now you can manually change the center point by right-clicking. By default this won't appear to do anything until you draw, but you can toggle the center point to be shown from the View menu. The center point won't appear when you save your drawing or copy it to the clipboard, so don't worry about that.

## License

This program is licensed under the MIT License. Basically, do whatever you want with it, as long as you give me credit and don't take credit for any of my work.
