repeat="true"

while [ "$repeat" == true ]
do

    echo "Hello, What would you like to do today?"
    echo "enter 1 if you want to count from 3 to 7"
    echo "enter 2 if you want to multiply 2 numbers"
    echo "enter 3 if you want you want to add multiple numbers"
    echo "enter 4 if you want to exit"

    read ans

    if [ "$ans" == "1" ]
    then
    for i1 in 3 4 5 6 7
    do
        echo $i1
    done

    elif [ "$ans" == "2" ]
    then
        echo "Enter Number 1: "
        read num1
        echo "Enter Number 2: "

        read num2
        echo "The product is $(($num1 * $num2))"


    elif [ "$ans" == "3" ]
    then
    echo "How many numbers would you like to add?"
    read num
    sum=0

    for (( i2 = 1; i2 <= num;i2++ ));
    #for i in $(seq 1 $num)
    do
    echo "Enter the number $i2 : "
    read add
    sum=$(($sum + $add))
    done
    echo "The sum is: $sum"

    elif [ "$ans" == "4" ]
    then
    repeat="false"
    else
    echo not an acceptible number, try again
    fi

    echo "press something to continue"
    read confirm
    clear

done


