# This is to add more information to the file your code
# echo ThisIsAComment

echo ThisIsNotAComment

# variables
# They are a way for us to store information for our code to use at a later time
msg="Hello World" #a equal sing is a way for us to createvariables to store something
echo $msg # $ syntax is the way we can call on a variable

# control flow
# They are a way for us to tell the program what line of code we want to run
# or how many times we want to run that line of code

# IF statments
# Like the english word if, it will only run the line of code if a condition is true

ten=10
five=5
thirteen=13

# 10 > 5 then run these lines of code
echo "===First If==="
if [ "$ten" -ge "$five" ] #ge means greater than
then
echo "greater!"
echo "$ten > $five"
fi

# 5 > 10 the nrun thes lines of code
echo "===Second IF==="
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
echo "$five -ge $ten"
fi

#check if 5 or 10 is greater
echo "===THIRD IF==="
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
echo "$five > $ten"
elif [ "$ten" -ge "$five" ]
then
echo "greater!"
echo "$ten > $five"
fi

echo "==Fourth IF==="
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
echo "$five > $ten"
elif [ "$ten" -ge "$thirteen"]
then
echo "lesser!"
echo "$ten > $thirteen"
else
echo "Nothing Works!"
fi

# Loop statements
# It will run that line of code multiple times as long as the conditon you set up is true

# For loop
# Will repeat the amount of code x amount of times (you determine how many times you loop)
# Useful if you know how many times you want to repeat your code

echo "===FOr Loop==="
for num in 1 3 5 9001 poggers
do
echo "Repeating"
echo $num

done

echo " ===Second For loop==="
for num in {1..10}
do echo $num

done

# While loop
# Will repeat the code multiple times as long as the condition is true

echo "===WHile loop==="
while [ "$ten" -ge "$five" ]
do
echo "Greater!"
echo $five
five=$(($five+1)) #$((meathematical operation)) is the syntax needed
done

# Input and OUtput
# We can ask the input for user that is currently using the shell script for some
# sort of information we will use

echo "what is your name?" 
read name
echo "Hello $name, welcome to programming!"

# We will combine everything to create a menu-like interface of our termnal that
# will ask the user information and proces that information based on whatever they
# want

clear # This will clear our terminal
repeat="true"

while [ "$repeat" == true ]
do
echo "Welcome to shell script!"
echo "What do you want to do today"
echo "enter 1 if you want to add 2 numbers"
echo "enter 2 if you want to exit out of the program"
read ans

if [ "$ans" == "1" ]
then
echo "Give me 2 numbers"
read num1
read num2
echo "this is your number $(($num1+$num2))"
echo "press enter to continue"
read asdfjkl;
elif ["$ans" == "2" ]
then
echo "Goodbye!"
repeat=="false"
else
echo "Command not found"
fi

clear
done
