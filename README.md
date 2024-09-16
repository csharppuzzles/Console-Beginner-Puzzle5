# C# Console Beginners Puzzle 5

## Switches

### View the YouTube Video: 


## Puzzles
In Program.cs, I have commented out some starting code for these puzzles. <br />
Write your code in these sections and uncomment them. <br />
I have provided some examples of similar functions to what each puzzle is asking for. Learn to read the code and modify it. <br />

At the very bottom, I have listed the functions. Comment and uncomment them, to run them one at a time.

```
// Run the puzzles

    exampleA()
    // puzzleA()

    exampleB()
    // puzzleB()

    exampleC()
    // puzzleC()
```

### A - Workout of the day
Write a program that provides a fitness exercise for the user to do, depending on what day of the week it is. <br />
Ask the user for the weekday. <br />
    "What day is it?: " <br />
Use a SWITCH statement to print out an exercise. The exercise should be different for each day. <br />
Make the console text a different COLOR for each day. NOT background color, make the text letter color different. <br />
    "Monday: 20 Sit ups"            (red text) <br />
    "Tuesday: 15 jumping jacks"     (blue text) <br />
    "Wednesday: 20 press ups"       (green text) <br />
    "Thursday: 10 burpees"          (yellow text) <br />
    ...
Colorama documentation - https://pypi.org/project/colorama/ <br />
Colorama github - https://github.com/tartley/colorama     (just for documentation, you do not need to install) <br />
Remember to convert the user's input to lowercase before comparison. <br />
Have a "default case" should the user not enter a weekday. <br />


### B - Color me in
Re-write the above example program to use a SWITCH statement <br />
Use the unicode colors Cyan, Yellow and Magenta instead of red, blue and green. <br />
You might get confused with how to add "or" into the switch statement. Clue, it isn't "or". <br />
You should not need the null check for the switch as the default case should catch it. <br />


### C - Maths Switch
Write a program using a switch statement, that allows the user to enter 2 numbers and choose the operator + - * / <br />
So the user could enter "2" then "*" then "7" in 3 separate input prompts. <br />
They will get the answer "2 * 7 = 14" <br />


# Good Luck!
